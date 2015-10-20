using Starcounter;
using System;
using ThePrimeBaby.Database.Base;

namespace ThePrimeBaby.Database
{
    public class BillDetail : Concept
    {
        public Bill Bill;
        public Item Item;
        public int T_QUANTITY;
        public int QTY_PER_BOX;
        public string MODEL;
        public int CTN;
        public decimal PRICE;
        public decimal SUBTOTAL;
        internal static bool AddBillDetail(Item Item, Bill Bill, int T_QUANTITY, int QTY_PER_BOX, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            try
            {
                Db.Transact(() =>
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.BillDetail b").First) + 1;
                    billDetail.Item = Item;
                    billDetail.NAME = Item.CODE;
                    billDetail.MODEL = Item.MODEL;
                    billDetail.Bill = Bill;
                    billDetail.T_QUANTITY = T_QUANTITY;
                    billDetail.QTY_PER_BOX = QTY_PER_BOX;
                    billDetail.CTN = CTN;
                    billDetail.PRICE = PRICE;
                    billDetail.SUBTOTAL = SUBTOTAL;
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
