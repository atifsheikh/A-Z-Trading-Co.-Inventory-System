using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class CustomerVoucher : Concept
    {
        public Customer Customer;
        public DateTime DATED;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;
    }
}
