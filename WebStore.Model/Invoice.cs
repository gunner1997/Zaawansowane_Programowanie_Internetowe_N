using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model
{
    public class Invoice
    {
        public string NIP { get; set; }
        public string? REGON { get; set; }      // can be null
        public IList<Order> Order { get; set; }
        public DateTime DateOfInvoice { get; set; }
    }
}