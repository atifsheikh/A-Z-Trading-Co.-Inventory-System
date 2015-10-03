using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firebirdtest.Classes
{
    public class Customer
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public int AMOUNT { get; set; }
        public int OPENING_BALANCE { get; set; }
        public int BALANCE_LIMIT { get; set; }
    }

    public class Bill
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DATED { get; set; }
        public int AMOUNT { get; set; }
        public string REMARKS { get; set; }
        public int CUSTOMER_BALANCE { get; set; }
        public int TOTAL_CTN { get; set; }
    }

    public class BillDetail
    {
        public string NAME { get; set; }
        public string MODEL { get; set; }
        public int T_QUANTITY { get; set; }
        public int PRICE { get; set; }
        public int SUBTOTAL { get; set; }
    }
    public class Invoice
    {
        public Customer Customer { get; set; }
        public Bill Bill { get; set; }

        public List<BillDetail> BillDetail { get; set; }
        internal List<BillDetail> GetBillDetail()
        {
            return BillDetail;
        }
    }
}