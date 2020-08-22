using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RetailWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        static MySqlConnection getConnection()
        {

            string myConnectionString = "Database=ssa46;DataSource = mysql.mcscw3.le.ac.uk; User Id = ssa46; Password =ot5Oe4oh";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            return connection;
        }
        
        //Add commodity by giving type number and feature number
        public string getComponentByFeatureType(int id, string features)
        {
            Commodity c = new Commodity();

            try
            {

                MySqlConnection connection = getConnection();
                connection.Open();

                MySqlCommand mycm = new MySqlCommand("Select type_name from types where type_no in (Select type_no from feature where feature_no=?feature_no_para AND type_no=?type_no_para)", connection);
                mycm.Parameters.AddWithValue("?feature_no_para", features);
                mycm.Parameters.AddWithValue("?type_no_para", id);

                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {


                        c.Name = msdr.GetString("type_name");



                    }
                }

                msdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return c.Name;
        }

       
        //Add new feature by type number , feature number and feature name
        public bool AddNewFeature(int typenum, string featurnum, string featurename)

        {
            bool query = true;
            try
            {

                MySqlConnection connection = getConnection();
                connection.Open();
                MySqlCommand mycm = new MySqlCommand("insert into feature(type_no,feature_no,feature_name) values (?type_no_para,?feature_no_para,?feature_name_para)", connection);
                mycm.Prepare();
                //     mycm.CommandText = string.Format("insert into feature(type_no,feature_no,feature_name) values (?type_no_para,?feature_no_para,?feature_name_para)");

                mycm.Parameters.AddWithValue("?type_no_para", typenum);
                mycm.Parameters.AddWithValue("?feature_no_para", featurnum);
                mycm.Parameters.AddWithValue("?feature_name_para", featurename);

                mycm.ExecuteNonQuery();

                connection.Close();


                return query;
            }
            catch
            {
                query = false;
                return query;
            }
        }



       
        public string AddCommodity(int number, string name)
        {
            string s = "Record added successfully";


            try
            {


                MySqlConnection connection = getConnection();
                connection.Open();
                MySqlCommand mycm = new MySqlCommand("insert into types(type_no,type_name) values (?type_no_para,?type_name_para)", connection);
                mycm.Prepare();
                mycm.Parameters.AddWithValue("?type_no_para", number);
                mycm.Parameters.AddWithValue("?type_name_para", name);


                mycm.ExecuteNonQuery();

                connection.Close();


                return s;
            }
            catch (Exception e)
            {
                s = "Failed";
                Console.WriteLine(e);
                return s;
            }
        }

        //List all laptops
        public List<Laptop> getAllLaptops()
        {

            List<Laptop> laptops = new List<Laptop>();
            try
            {

                MySqlConnection connection = getConnection();
                connection.Open();

                MySqlCommand mycm = new MySqlCommand("select * from commodities", connection);

                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Laptop lap = new Laptop();
                        String lap_info;


                        lap.Id = msdr.GetInt32("type_no");




                        if (lap.Id == 100001)
                        {

                            lap_info = msdr.GetString("information");
                            string[] words = lap_info.Split(' ');

                            foreach (string word in words)
                            {
                                Console.WriteLine("Feature is " + word);

                                Console.WriteLine(word.Substring(0, 3));

                                if (word.Substring(0, 3).Equals("c01"))
                                {
                                    lap.Name = word;
                                    Console.WriteLine(word);
                                    Console.WriteLine(lap.Name);

                                }
                                else if (word.Substring(0, 3).Equals("c05"))
                                {
                                    lap.Brand = word;
                                    Console.WriteLine(lap.Brand);
                                }

                                else if (word.Substring(0, 3).Equals("c03"))
                                {
                                    lap.cPU = word;
                                    Console.WriteLine(lap.cPU);
                                }
                                else
                                {
                                    continue;
                                }

                            }


                        }

                        else
                        {
                            continue;
                        }


                        laptops.Add(lap);

                    }
                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return laptops.ToList();

        }




        /* List of commodities to restock taking min count from database*/
        public List<string> show_RestockItems()
        {
            int min_count = 10;
            List<string> restock = new List<string>();
            List<string> ids = new List<string>();
            List<int> stock_count = new List<int>();
            try
            {
                MySqlConnection sqlcon = getConnection();
                sqlcon.Open();
                MySqlCommand sqlda = new MySqlCommand("select * from commodities", sqlcon);

                MySqlDataReader msdr = sqlda.ExecuteReader();
                if (msdr.HasRows)
                {
                    while (msdr.Read())
                    {

                        int typeid;
                        string type_info;
                        typeid = msdr.GetInt32("type_no");
                        int count_stock = 0;
                        type_info = msdr.GetString("information");
                        string[] words = type_info.Split(' ');
                        Console.WriteLine(type_info);
                        Console.WriteLine(words);
                        foreach (string word in words)
                        {
                            if (word.Substring(0, 3).Equals("c01"))
                            {
                                ids.Add(word);


                            }
                            if (word.Substring(0, 3).Equals("c07"))

                            {
                                word.Substring(3);
                                count_stock = Int32.Parse(word.Substring(3));
                               stock_count.Add(count_stock);
                            }

                        }

                        if (count_stock == 0)
                        {
                            stock_count.Add(0);
                        }
                    }

                }

                msdr.Close();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
           
            for (int i = 0; i < stock_count.Count; i++)
            {
               
              
                if (stock_count[i] < min_count)
                {
                    
                    restock.Add(ids[i]);
                }
            }
            return restock;

        }

    }
}