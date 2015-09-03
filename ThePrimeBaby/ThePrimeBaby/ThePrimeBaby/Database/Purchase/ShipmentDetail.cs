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
        public int PRICE;
        public decimal SUBTOTAL;


        internal static bool AddConsignmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
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
