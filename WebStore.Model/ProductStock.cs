using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class ProductStock
    {
        public IList<Product> Product { get; set; }
        public int Quantity { get; set; }
    }
}