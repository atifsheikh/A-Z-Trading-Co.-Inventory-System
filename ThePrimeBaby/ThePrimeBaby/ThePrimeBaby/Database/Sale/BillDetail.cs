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
        internal static bool AddBillDetail(Item Item, Bill Bill, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            try
            {
                Db.Transact(() =>
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.BillDetail b").First) + 1;
                    billDetail.Item = Item;
                    billDetail.Bill = Bill;
                    billDetail.T_QUANTITY = T_QUANTITY;
                    billDetail.QTY_PER_BOX = QTY_PER_BOX;
                    billDetail.MODEL = MODEL.Trim();
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
        //internal static bool AddSale(decimal UnitPrice, int QTY, Bill BILL_ID, decimal SUBTOTAL, Item item, int PCS_CTN, int QUANT, Customer CUSTOMER_ID)
        //{
        //    try
        //    {
        //        Db.Transact(() =>
        //        {
        //            BillDetail billDetail = new BillDetail();
        //            billDetail.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.BillDetail b").First) + 1;
        //            billDetail.Bill = BILL_ID;
        //            billDetail.Item = item;
        //            billDetail.QTY_PER_BOX = QTY;
        //            billDetail.PCS_CTN = PCS_CTN;
        //            billDetail.T_QUANTITY =QUANT;
        //            billDetail.PRICE = UnitPrice;
        //            billDetail.SUBTOTAL = SUBTOTAL;
        //            billDetail.Customer = CUSTOMER_ID;
        //        });                
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //internal static bool DeleteBillDetails(string BillID)
        //{
        //    try
        //    {
        //        Db.Transact(() =>
        //        {
        //            Db.SlowSQL("DELETE FROM BillDetail WHERE Bill.ID = ?", BillID);
        //        });
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
