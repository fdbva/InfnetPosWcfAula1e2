using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackApp.OrderManagerService;

namespace PackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtem produtos do WCF
            OrderManagerServiceClient client = null;

            try
            {
                client = new OrderManagerServiceClient();
                client.Open();

                var stayInMenu = true;

                do
                {
                    Console.WriteLine("Enter Y to read next order or anything else to cancel");
                    var enteredInput = Console.ReadLine()?.ToUpperInvariant();
                    switch (enteredInput)
                    {
                        case "Y":
                            var order = client.GetNextOrder();
                            if (order != null)
                                foreach (var product in order)
                                {
                                    Console.WriteLine($"{product.Name} - R${product.Price} - Qty:{product.Quantity}");
                                }
                            break;
                        default:
                            stayInMenu = false;
                            break;
                    }
                } while (stayInMenu);
            }
            finally
            {
                client?.Close();
            }
        }
    }
}
