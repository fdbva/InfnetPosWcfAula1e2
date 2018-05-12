using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.OrderManagerService;
using StoreApp.ProductManagerService;
using Product = StoreApp.OrderManagerService.Product;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtem produtos do WCF
            ProductManagerServiceClient clientProducts = null;
            OrderManagerServiceClient clientOrders = null;

            try
            {
                clientProducts = new ProductManagerServiceClient();
                clientProducts.Open();
                var stayInMenu = true;

                do
                {
                    Console.WriteLine("Enter L to list all products, B to buy one of each, anything else to exit");
                    var enteredInput = Console.ReadLine()?.ToUpperInvariant();

                    switch (enteredInput)
                    {
                        case "L":
                            PrintAllProducts(clientProducts.GetAllAvailableProducts());
                            break;
                        case "B":
                            clientOrders = BuyOneOfEachProduct(clientProducts.GetAllAvailableProducts());
                            break;
                        default:
                            stayInMenu = false;
                            break;
                    }
                } while (stayInMenu);


                Console.ReadLine();
            }
            finally
            {
                clientProducts?.Close();
                clientOrders?.Close();
            }
        }

        private static OrderManagerServiceClient BuyOneOfEachProduct(ProductManagerService.Product[] products)
        {
//Simula uma compra
            Console.WriteLine("==== BUY ONE OF EACH PRODUCTS ====");
            var clientOrders = new OrderManagerServiceClient();
            clientOrders.Open();
            clientOrders.CreateOrder(products.Select(product => new Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = 1
            }).ToArray());

            Console.WriteLine("==== END BUY ONE OF EACH PRODUCTS ====");
            return clientOrders;
        }

        private static void PrintAllProducts(ProductManagerService.Product[] products)
        {
            Console.WriteLine("==== PRINTING ALL PRODUCTS ====");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} - {product.Quantity}");
            }

            Console.WriteLine("==== END PRINTING ALL PRODUCTS ====");
        }
    }
}