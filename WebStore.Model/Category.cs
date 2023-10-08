using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Category
    {
        public string CategoryName { get; set; }
        public Product Product { get; set; }
    }
}