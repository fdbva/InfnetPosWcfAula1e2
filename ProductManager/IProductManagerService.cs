using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProductManager.ProductFactoryService;

namespace ProductManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductManagerService
    {
        [OperationContract]
        void AddProduct(string name, string description, decimal price, int quantity);

        [OperationContract]
        Product[] GetAllProducts();

        [OperationContract]
        Product[] GetAllAvailableProducts();

        [OperationContract]
        void UpdateProduct(Product product);
    }
}
