using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagement.DataSets
{
    public class DebitSummary
    {
        //public Bill Bill { get; set; }
        public List<Customer> customer { get; set; }
        internal List<Customer> GetDebitorList()
        {
            return customer;
        }
    }
}
