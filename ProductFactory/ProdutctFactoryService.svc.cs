using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProductFactory.Model;

namespace ProductFactory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductFactoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductFactoryService.svc or ProductFactoryService.svc.cs at the Solution Explorer and start debugging.
    public class ProductFactoryService : IProductFactoryService
    {
        public Product CreateProduct(string name, string description, decimal price, int quantity)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                Price = price,
                Quantity = quantity
            };
        }
    }
}
