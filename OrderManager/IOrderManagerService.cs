﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OrderManager.ProductManagerService;

namespace OrderManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderManagerService
    {
        [OperationContract]
        void CreateOrder(Product[] products);

        [OperationContract]
        Product[] GetNextOrder();
    }
}