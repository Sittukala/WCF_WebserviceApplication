using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RetailWebService
{
  
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
       
        
         List<Laptop> getAllLaptops();
        [OperationContract]
        string AddCommodity(int number, string name);

        [OperationContract]
        bool AddNewFeature(int typenum, string featurnum, string featurename);
        [OperationContract]
        string getComponentByFeatureType(int id,string features);

        [OperationContract]
        List<string> show_RestockItems();

    }


}




[DataContract]
public class CompositeType
{
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}

    [DataContract]


public class Commodity
    {
    protected int id;
    protected string typeRef;
    protected string name;
    protected string type;
    protected int price;
    protected string brand;
    protected int size;
    protected int stock;

    [DataMember]
    public int Id { get => id; set => id = value; }
    [DataMember]
    public string TypeRef { get => typeRef; set => typeRef = value; }
    [DataMember]
    public string Name { get => name; set => name = value; }
    [DataMember]
    public string Type { get => type; set => type = value; }
    [DataMember]
    public int Price { get => price; set => price = value; }
    [DataMember]
    public string Brand { get => brand; set => brand = value; }
    [DataMember]
    public int Size { get => size; set => size = value; }
    [DataMember]
    public int Stock { get => stock; set => stock = value; }

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

    public String getBasicInformation()
        {
            return "ID:" + id + "\tName:" + name + "\tType" + type + "\tPrice" + price + "\tBrand" + brand + "\tSize" + size + "\tStock" + stock;
        }

    public override string ToString()
        {
            return "ID:" + id + "\tName:" + name + "\tType" + type + "\tPrice" + price + "\tBrand" + brand + "\tSize" + size + "\tStock" + stock;
        }
    }
[DataContract]


public class Laptop : Commodity
    {
       [DataMember]
        protected string CPU;

        public string cPU { get => CPU; set => CPU = value; }

   
        public void setLaptopInformation(int id, string name, string type, int price, string brand, int size, int stock, string CPU)
        {
        
            base.setBasicInformation(id, name, type, price, brand, size, stock);
            this.CPU = CPU;
        }

        public String getLaptopInformation()
        {

            return base.getBasicInformation() + " " + CPU;
        }
        public override string ToString()
        {
            return base.ToString() + " " + CPU.ToString();
        }

    public class Wine : Commodity
    {
        protected string alcohol_content;

        [DataMember]
        public string Alcohol_content { get => alcohol_content; set => alcohol_content = value; }


        public void setWineInformation(int id, string name, string type, int price, string brand, int size, int stock, string alcohol_content)
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



