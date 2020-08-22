using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailWebService_Host
{
    class Program
    {
        
        static void Main(string[] args)
        {

            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
         
            string option = "yes";
            while (option =="yes") {
            string main_menu = " Enter your choice range from 1-3" + "\n" + "1. Search for commodity by its feature and type number" + "\n" + "2. Enter new commodity" + "\n" +"3. List all laptops";
             Console.WriteLine(main_menu);
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice) {
                    
                    case 1:
                        // Search for commodity by type number and feature number
                        Console.WriteLine("List of all commodities 1. 100001 - Laptop" +"\n" + "2. 100005 - wine" + "\n" + " 3. 100010 -Clothes" + "\n" +  " 4. 100015 - Beer " + "\n" +" 5. 100020 - Wine ");
                        Console.WriteLine("Enter type number of commodity to search");
                        int commodity_num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter any one of the feature name in brackets to search according to the type number you entered in commodity list to search before :" +
                            "1. 100001 - Laptop (c01/c02/c03/etc) " +
                            "2. 100005 - Wine (c01/c02/c03//etc)");
                        String commodity_name = Console.ReadLine();
                        Console.WriteLine(client.getComponentByFeatureType(commodity_num, commodity_name));
                        Console.WriteLine("Wishing to continue with search. Press 1 to continue and 2 to Quit");
                        int ch_1 = Int32.Parse(Console.ReadLine());
                        if (ch_1 == 1)
                            goto case 1;
                        else
                            break;
                    case 2:

                        //Add new commodity
                        Console.WriteLine("Enter a new commodity");
                        Console.WriteLine("List of all commodities 1. 100001 - Laptop" + "\n" + "2. 100005 - wine" + "\n" + " 3. 100010 -Clothes" + "\n" + " 4. 100015 - Beer " + "\n" + " 5. 100020 - Wine ");
                        Console.WriteLine("Enter similar kind of type number of commodity to maintain the structure of the table");
                        int commoditynumber = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new commodity name");
                        string commodityname = Console.ReadLine();
                       string res= client.AddCommodity(commoditynumber,commodityname);
                        if (res.Equals(true))
                        {
                            Console.WriteLine("Commodity added successfully");
                        }
                        Console.WriteLine("Wishing to continue with search. Press 1 to continue and 2 to Quit");
                        int ch_2 = Int32.Parse(Console.ReadLine());
                        if (ch_2 == 1)
                            goto case 2;
                        else
                            break;
                       

                    case 3:

                        //List of laptops

                        Console.WriteLine("Showing the list of all laptops");
                     foreach(ServiceReference2.Laptop l in client.getAllLaptops())
                        {
                            Console.WriteLine("Commodity Id" +l.Id);
                            Console.WriteLine("Laptop name" +l.Name); 
                            Console.WriteLine();
                        }
                        int ch_3 = Int32.Parse(Console.ReadLine());
                        if (ch_3 == 1)
                            goto case 2;
                        else
                            break;

                    default:

                        Console.WriteLine("Your option doesnt exit");
                        Console.WriteLine(main_menu);
                        break;

                }
                Console.WriteLine(" Press 'yes' to return to Main menu and continue again and 'no' to quit application");
                option=Console.ReadLine();
            }

            //Add new feature

            Console.WriteLine("Add a new feature to the commodity");
            Console.WriteLine("Existing type numbers 1. 100001 - Laptop 2. 100005 - wine 3. 100010 -Clothes  4. 100015 - Beer  5. 100020 - Wine ");
            Console.WriteLine("Enter a feature number: (Feature starts with 'c0number' where replace number accordingly like c010 or c011,etc)");

            Console.WriteLine("Enter similar kind of type number and faeture number to maintain the structure of the table");
            Console.WriteLine("Enter type number");
            int Type_number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter new feature number");
            string Feature_number = Console.ReadLine();
            Console.WriteLine("Enter new faeture name");
            string Feature_name =Console.ReadLine();
           
            bool result=client.AddNewFeature(Type_number,Feature_number,Feature_name);
            if (result==true)
            {
                Console.WriteLine("Feature added successfully");
            }
          
            // Restock list of items
            Console.WriteLine("Showing all the list of commodities that needs re-stocking");
            Console.WriteLine("The commoditeswhose restock value null or less than min-count of 10 from the database are considered for re-stocking");
            foreach (var i in client.show_RestockItems())
            {
                Console.WriteLine("Restock item is " +i);

            }
            Console.ReadLine();
          
        }
    }
}
