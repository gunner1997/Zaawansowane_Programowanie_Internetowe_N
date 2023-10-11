using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Order
    {
        public Customer Customer { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public long TrackingNumber { get; set; }
        public IList<OrderProduct> Products { get; set;}
    }
}