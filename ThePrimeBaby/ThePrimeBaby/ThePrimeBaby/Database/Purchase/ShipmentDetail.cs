using Starcounter;
using System;
using ThePrimeBaby.Database.Base;

namespace ThePrimeBaby.Database
{
    public class ShipmentDetail: Concept
    {
        public Shipment Shipment;
        public Item Item;
        public int T_QUANTITY;
        public int QTY_PER_BOX;
        public string MODEL;
        public int CTN;
        public decimal PRICE;
        public decimal SUBTOTAL;


        internal static bool AddConsignmentDetail(Item Item, Shipment Shipment, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            try
            {
                Db.Transact(()=>
                {
                    ShipmentDetail shipmentDetail = new ShipmentDetail();
                    shipmentDetail.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.ShipmentDetail b").First) + 1;
                    shipmentDetail.Item = Item;
                    shipmentDetail.Shipment = Shipment;
                    shipmentDetail.T_QUANTITY = T_QUANTITY;
                    shipmentDetail.QTY_PER_BOX = QTY_PER_BOX;
                    shipmentDetail.MODEL = MODEL;
                    shipmentDetail.CTN = CTN;
                    shipmentDetail.PRICE = PRICE;
                    shipmentDetail.SUBTOTAL = SUBTOTAL;
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
