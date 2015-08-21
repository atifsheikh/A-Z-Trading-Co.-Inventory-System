using Starcounter;

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
    }
}
