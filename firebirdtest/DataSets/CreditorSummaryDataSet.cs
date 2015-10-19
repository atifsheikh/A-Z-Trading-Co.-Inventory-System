using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagement.DataSets
{
    public class CreditSummary
    {
        //public Shipment Shipment { get; set; }
        public List<Vendor> vendor { get; set; }
        internal List<Vendor> GetCreditorList()
        {
            return vendor;
        }
    }
}
