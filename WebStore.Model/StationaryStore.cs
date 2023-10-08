using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class StationaryStore
    {
        public string StoreName { get; set; }
        public Address StoreAddress { get; set; }   
        public StationaryStoreEmployee StationaryEmployee { get; set; } 
    }
}