﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreApp.ProductManagerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ProductFactory.Model")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public decimal Price {
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
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductManagerService.IProductManagerService")]
    public interface IProductManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/AddProduct", ReplyAction="http://tempuri.org/IProductManagerService/AddProductResponse")]
        void AddProduct(string name, string description, decimal price, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/AddProduct", ReplyAction="http://tempuri.org/IProductManagerService/AddProductResponse")]
        System.Threading.Tasks.Task AddProductAsync(string name, string description, decimal price, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/GetAllProducts", ReplyAction="http://tempuri.org/IProductManagerService/GetAllProductsResponse")]
        StoreApp.ProductManagerService.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/GetAllProducts", ReplyAction="http://tempuri.org/IProductManagerService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<StoreApp.ProductManagerService.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/GetAllAvailableProducts", ReplyAction="http://tempuri.org/IProductManagerService/GetAllAvailableProductsResponse")]
        StoreApp.ProductManagerService.Product[] GetAllAvailableProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/GetAllAvailableProducts", ReplyAction="http://tempuri.org/IProductManagerService/GetAllAvailableProductsResponse")]
        System.Threading.Tasks.Task<StoreApp.ProductManagerService.Product[]> GetAllAvailableProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/UpdateProduct", ReplyAction="http://tempuri.org/IProductManagerService/UpdateProductResponse")]
        void UpdateProduct(StoreApp.ProductManagerService.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManagerService/UpdateProduct", ReplyAction="http://tempuri.org/IProductManagerService/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(StoreApp.ProductManagerService.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductManagerServiceChannel : StoreApp.ProductManagerService.IProductManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductManagerServiceClient : System.ServiceModel.ClientBase<StoreApp.ProductManagerService.IProductManagerService>, StoreApp.ProductManagerService.IProductManagerService {
        
        public ProductManagerServiceClient() {
        }
        
        public ProductManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddProduct(string name, string description, decimal price, int quantity) {
            base.Channel.AddProduct(name, description, price, quantity);
        }
        
        public System.Threading.Tasks.Task AddProductAsync(string name, string description, decimal price, int quantity) {
            return base.Channel.AddProductAsync(name, description, price, quantity);
        }
        
        public StoreApp.ProductManagerService.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<StoreApp.ProductManagerService.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public StoreApp.ProductManagerService.Product[] GetAllAvailableProducts() {
            return base.Channel.GetAllAvailableProducts();
        }
        
        public System.Threading.Tasks.Task<StoreApp.ProductManagerService.Product[]> GetAllAvailableProductsAsync() {
            return base.Channel.GetAllAvailableProductsAsync();
        }
        
        public void UpdateProduct(StoreApp.ProductManagerService.Product product) {
            base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(StoreApp.ProductManagerService.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
    }
}