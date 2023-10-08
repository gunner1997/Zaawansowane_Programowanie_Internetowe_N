using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class OrderProductModel
    {
        IList<Product> Products {get; set;}
        IList<Order> Orders {get; set;}
    }
}