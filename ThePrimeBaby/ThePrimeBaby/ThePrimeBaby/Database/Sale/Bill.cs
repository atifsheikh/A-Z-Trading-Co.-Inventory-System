using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Bill : Concept
    {
        public Customer CUSTOMER;
        public DateTime DATED;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;
    }
}
