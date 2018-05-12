using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OrderManager.Exceptions;
using OrderManager.ProductManagerService;

namespace OrderManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderManagerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderManagerService.svc or OrderManagerService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class OrderManagerService : IOrderManagerService
    {
        private static readonly Queue<List<Product>> Orders = new Queue<List<Product>>();

        public void CreateOrder(Product[] products)
        {
            //Obtem produtos do WCF
            ProductManagerServiceClient client = null;

            try
            {
                client = new ProductManagerServiceClient();
                client.Open();

                var successProducts = new List<Product>();
                var productsInStock = client.GetAllAvailableProducts().ToDictionary(x => x.Id);
                foreach (var product in products)
                {
                    if (!productsInStock
                        .TryGetValue(product.Id, out var productInStock))
                    {
                        throw new OrderStockException($"Product {product.Name} not found!");
                    }

                    if (productInStock.Quantity < product.Quantity)
                        throw new OrderStockException($"{product.Name} is out of Stock");
                    productInStock.Quantity = productInStock.Quantity - product.Quantity;
                    successProducts.Add(product);
                }

                foreach (var product in productsInStock.Values)
                {
                    client.UpdateProduct(product);
                }

                Orders.Enqueue(successProducts);
            }
            finally
            {
                client?.Close();
            }
        }

        public Product[] GetNextOrder()
        {
            return Orders.Count <= 0 ? null : Orders.Dequeue().ToArray();
        }
    }
}