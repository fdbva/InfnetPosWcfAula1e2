using System;
using System.Runtime.Serialization;

namespace OrderManager.Exceptions
{
    [Serializable]
    internal class OrderStockException : Exception
    {
        public OrderStockException()
        {
        }

        public OrderStockException(string message) : base(message)
        {
        }

        public OrderStockException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}