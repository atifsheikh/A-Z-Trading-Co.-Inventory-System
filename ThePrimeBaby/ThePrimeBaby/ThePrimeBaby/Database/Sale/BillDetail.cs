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
        public decimal UNITPRICE;
        public Customer Customer;

        internal static bool AddSale(decimal UnitPrice, int QTY, Bill BILL_ID, decimal SUBTOTAL, Item item, int PCS_CTN, int QUANT, Customer CUSTOMER_ID)
        {
            try
            {
                Db.Transact(() =>
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.BillDetail b").First) + 1;
                    billDetail.Bill = BILL_ID;
                    billDetail.Item = item;
                    billDetail.QTY = QTY;
                    billDetail.PCS_CTN = PCS_CTN;
                    billDetail.T_QUANTITY =QUANT;
                    billDetail.UNITPRICE = UnitPrice;
                    billDetail.SUBTOTAL = SUBTOTAL;
                    billDetail.Customer = CUSTOMER_ID;
                });                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool DeleteBillDetails(string BillID)
        {
            try
            {
                Db.Transact(() =>
                {
                    Db.SlowSQL("DELETE FROM BillDetail WHERE Bill.ID = ?", BillID);
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
