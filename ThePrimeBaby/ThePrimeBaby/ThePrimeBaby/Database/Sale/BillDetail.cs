using Starcounter;
using System;
using ThePrimeBaby.Database.Base;

namespace ThePrimeBaby.Database
{
    public class BillDetail : Concept
    {
        public int QTY;
        public Item Item;
        public Bill Bill;
        public int PCS_CTN;
        public decimal T_QUANTITY;
        public decimal SUBTOTAL;
        public Customer Customer;

        internal static bool AddSale(decimal UnitPrice, int QTY, int BILL_ID, decimal SUBTOTAL, string ITEM_CODE, string ITEM_NAME, int PCS_CTN, int QUANT, int CUSTOMER_ID)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        internal static bool DeleteBillDetails(string BillNumber)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
