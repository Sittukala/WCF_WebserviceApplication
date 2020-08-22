using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object for Laptop 
            Laptop l = new Laptop();

           //set laptop information
            l.setLaptopInformation(101, "lap2", "Notebook2", 40000, "HP", 23, 10, "Intel");

            //get laptop information
            Console.WriteLine("Laptop 1 is added is " +l.getLaptopInformation());
            Console.WriteLine();
            Laptop l1 = new Laptop();
            l1.setLaptopInformation(102, "lap3", "Notebook3", 50000, "Lenovo", 22, 20, "LenovoCpu" + "\n");
            //getting as object using toString method
            Console.WriteLine("Laptop 2 is added is " + l1 + "\n");


            Wine w1 = new Wine();
            w1.setWineInformation(101,"wine1","A",2000,"Matoi",23,100,"230degree");
            Console.WriteLine("Wine 1 is added is " + w1.getWineInformation() + "\n");

            //Modify objects according to neccesity is done by setter method for same id or object created
            w1.setWineInformation(101, "wine111", "B", 2000, "Matoi", 23, 1, "230degree");

            Console.WriteLine("Wine 1 is updated as " + w1.getWineInformation() +"\n");

            //creating simple commodity object

            Commodity c = new Commodity();
            c.setBasicInformation(1,"general_commodity","Clothes",600,"Levis",12,100);
            Console.WriteLine("commodity 1 is added is " + c.getBasicInformation() + "\n");
          

            //Restock method
            l1.restock();
        
            Console.WriteLine(l1.sell());

            Console.WriteLine("To check the commodity with reduced stock size after sale: \n" + l1);

            w1.restock();
            Console.WriteLine(w1.sell());
            Console.WriteLine("To check the commodity with reduced stock size after sale: \n" + w1);

            Console.ReadLine();
        }
      
    }
}
