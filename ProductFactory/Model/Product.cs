using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactory.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price
        {
            get => Price;
            set
            {
                if (value == 0) throw new ArgumentException("Preço precisa ser maior que zero");
                Price = value;
            }
        }

        public int Quantity { get; set; }
    }
}