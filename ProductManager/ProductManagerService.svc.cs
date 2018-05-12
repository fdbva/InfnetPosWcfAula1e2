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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductManagerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductManagerService.svc or ProductManagerService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ProductManagerService : IProductManagerService
    {
        private static readonly List<Product> Products = new List<Product>();

        public void AddProduct(string name, string description, decimal price, int quantity)
        {
            var client = new ProductFactoryServiceClient();
            client.Open();
            var product = client.CreateProduct(name, description, price, quantity);
            client.Close();
            Products.Add(product);
        }

        public Product[] GetAllProducts()
        {
            return Products.ToArray();
        }

        public Product[] GetAllAvailableProducts()
        {
            return Products.Where(x => x.Quantity > 0).ToArray();
        }

        public void UpdateProduct(Product product)
        {
            var savedProduct = Products.FirstOrDefault(x => x.Id == product.Id);
            if (savedProduct == null)
                throw new ArgumentException("Product not found");

            savedProduct.Name = product.Name;
            savedProduct.Description = product.Description;
            savedProduct.Price = product.Price;
            savedProduct.Quantity = product.Quantity;
        }
    }
}
