﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetailWebService_Host.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Laptop", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Laptop : RetailWebService_Host.ServiceReference1.Commodity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPUField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((object.ReferenceEquals(this.CPUField, value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Commodity", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RetailWebService_Host.ServiceReference1.Laptop))]
    public partial class Commodity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeRefField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeRef {
            get {
                return this.TypeRefField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeRefField, value) != true)) {
                    this.TypeRefField = value;
                    this.RaisePropertyChanged("TypeRef");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        RetailWebService_Host.ServiceReference1.CompositeType GetDataUsingDataContract(RetailWebService_Host.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<RetailWebService_Host.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(RetailWebService_Host.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllLaptops", ReplyAction="http://tempuri.org/IService1/getAllLaptopsResponse")]
        RetailWebService_Host.ServiceReference1.Laptop[] getAllLaptops();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllLaptops", ReplyAction="http://tempuri.org/IService1/getAllLaptopsResponse")]
        System.Threading.Tasks.Task<RetailWebService_Host.ServiceReference1.Laptop[]> getAllLaptopsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCommodity", ReplyAction="http://tempuri.org/IService1/AddCommodityResponse")]
        string AddCommodity(int number, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCommodity", ReplyAction="http://tempuri.org/IService1/AddCommodityResponse")]
        System.Threading.Tasks.Task<string> AddCommodityAsync(int number, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewFeature", ReplyAction="http://tempuri.org/IService1/AddNewFeatureResponse")]
        bool AddNewFeature(int typenum, string featurnum, string featurename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewFeature", ReplyAction="http://tempuri.org/IService1/AddNewFeatureResponse")]
        System.Threading.Tasks.Task<bool> AddNewFeatureAsync(int typenum, string featurnum, string featurename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getComponentByFeatureType", ReplyAction="http://tempuri.org/IService1/getComponentByFeatureTypeResponse")]
        string getComponentByFeatureType(int id, string features);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getComponentByFeatureType", ReplyAction="http://tempuri.org/IService1/getComponentByFeatureTypeResponse")]
        System.Threading.Tasks.Task<string> getComponentByFeatureTypeAsync(int id, string features);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/show_RestockItems", ReplyAction="http://tempuri.org/IService1/show_RestockItemsResponse")]
        string[] show_RestockItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/show_RestockItems", ReplyAction="http://tempuri.org/IService1/show_RestockItemsResponse")]
        System.Threading.Tasks.Task<string[]> show_RestockItemsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RetailWebService_Host.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RetailWebService_Host.ServiceReference1.IService1>, RetailWebService_Host.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public RetailWebService_Host.ServiceReference1.CompositeType GetDataUsingDataContract(RetailWebService_Host.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<RetailWebService_Host.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(RetailWebService_Host.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public RetailWebService_Host.ServiceReference1.Laptop[] getAllLaptops() {
            return base.Channel.getAllLaptops();
        }
        
        public System.Threading.Tasks.Task<RetailWebService_Host.ServiceReference1.Laptop[]> getAllLaptopsAsync() {
            return base.Channel.getAllLaptopsAsync();
        }
        
        public string AddCommodity(int number, string name) {
            return base.Channel.AddCommodity(number, name);
        }
        
        public System.Threading.Tasks.Task<string> AddCommodityAsync(int number, string name) {
            return base.Channel.AddCommodityAsync(number, name);
        }
        
        public bool AddNewFeature(int typenum, string featurnum, string featurename) {
            return base.Channel.AddNewFeature(typenum, featurnum, featurename);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewFeatureAsync(int typenum, string featurnum, string featurename) {
            return base.Channel.AddNewFeatureAsync(typenum, featurnum, featurename);
        }
        
        public string getComponentByFeatureType(int id, string features) {
            return base.Channel.getComponentByFeatureType(id, features);
        }
        
        public System.Threading.Tasks.Task<string> getComponentByFeatureTypeAsync(int id, string features) {
            return base.Channel.getComponentByFeatureTypeAsync(id, features);
        }
        
        public string[] show_RestockItems() {
            return base.Channel.show_RestockItems();
        }
        
        public System.Threading.Tasks.Task<string[]> show_RestockItemsAsync() {
            return base.Channel.show_RestockItemsAsync();
        }
    }
}