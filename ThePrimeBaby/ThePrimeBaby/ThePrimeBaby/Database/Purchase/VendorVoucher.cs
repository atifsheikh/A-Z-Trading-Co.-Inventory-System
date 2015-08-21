using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class VendorVoucher : Concept
    {
        public Vendor Vendor;
        public DateTime DATED;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;
    }
}
