using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactory.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price needs to be bigger than zero");
                _price = value;
            }
        }

        public int Quantity { get; set; }
    }
}