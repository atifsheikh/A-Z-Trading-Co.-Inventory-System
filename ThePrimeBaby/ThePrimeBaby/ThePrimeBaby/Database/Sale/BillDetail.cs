using Starcounter;

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

    }
}
