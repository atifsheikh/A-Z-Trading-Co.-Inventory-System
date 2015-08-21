using Starcounter;

namespace ThePrimeBaby.Database
{
    [Database]
    public class Vendor 
    {
        public string ObId { get { return DbHelper.GetObjectID(this); } }
        public string NAME;
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT;
        public decimal OPENNING_BALANCE;
        public decimal BALANCE_LIMIT;
    }
}
