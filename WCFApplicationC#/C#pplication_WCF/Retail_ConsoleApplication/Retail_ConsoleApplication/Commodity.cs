using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_ConsoleApplication
{
    public class Commodity
    {
        protected int id;
      //  protected string typeRef;
        protected string name;
        protected string type;
        protected int price;
        protected string brand;
        protected int size;
        protected int stock;
        int min_count = 10;
        public int Id { get => id; set => id = value; }
    //    public string TypeRef { get => typeRef; set => typeRef = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Size { get => size; set => size = value; }
        public int Stock { get => stock; set => stock = value; }


        //update method
        public void setBasicInformation(int id, string name, string type, int price, string brand, int size, int stock)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
            this.brand = brand;
            this.size = size;
            this.stock = stock;

        }

        //getter method
        public string getBasicInformation()
        {
            return "ID:" + id + "\tName:" + name + "\tType" + type + "\tPrice" + price + "\tBrand" + brand + "\tSize" + size + "\tStock" + stock;
        }

        public override string ToString()
        {
            return "ID:" + id + "\tName:" + name + "\tType" + type + "\tPrice" + price + "\tBrand" + brand + "\tSize" + size + "\tStock" + stock;
        }

        public bool restock()
        {
            bool restock_item = false;
          
            if (stock < min_count)
            {
                restock_item = true;
                Console.WriteLine(" Need restocking");

            }
            else
            {
                Console.WriteLine(" Item present in stock");
            }

            return restock_item;
        }
        public string sell()
        {
         
            string sell_commodity;
            if (restock() == false)
            {
             
             
                stock = stock - 1;
                sell_commodity= "Commodity eligible for sale";
            }
            else
            {
                sell_commodity="Commodity not for sale since no stock. Restock the commodity and sell";
            }
           
            return sell_commodity;
        }
     
}
        public class Laptop : Commodity
        {
            protected string cpu;

        public string CPU { get => cpu; set => cpu = value; }



        public void setLaptopInformation(int id, string name, string type, int price, string brand, int size, int stock, string CPU)
            {
              
                base.setBasicInformation(id, name, type, price, brand, size, stock);
                this.CPU = CPU;
            }

        public string getLaptopInformation()
            {

                return base.getBasicInformation() + " " + CPU.ToString();
            }
        public override string ToString()
            {
                return base.ToString() + " " + CPU.ToString();
            }
        }
        public class Wine : Commodity
        {
            protected string alcohol_content;

            public string Alcohol_content { get => alcohol_content; set => alcohol_content = value; }


            public void setWineInformation(int id, string name, string type, int price, string brand, int size, int stock,string alcohol_content)
            {
                base.setBasicInformation(id, name, type, price, brand, size, stock);

                this.Alcohol_content = alcohol_content;
            }

        public string getWineInformation()
            {
                return base.getBasicInformation() + "" + Alcohol_content.ToString();
            }
            public override string ToString()
            {
                return base.ToString() + " " + Alcohol_content.ToString();
            }
        }
    
}


