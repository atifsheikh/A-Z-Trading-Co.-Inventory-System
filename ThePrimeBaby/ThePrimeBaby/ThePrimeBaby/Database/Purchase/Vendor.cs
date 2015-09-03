using Starcounter;
using System;

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

        internal static bool AddVendor(string Name, string address, string phone, string email)
        {
            try
            {
                Db.Transact(() =>
                {
                    Vendor vendor = new Vendor();
                    vendor.NAME = Name;
                    vendor.ADDRESS = address;
                    vendor.PHONE = phone;
                    vendor.EMAIL = email;
                    vendor.OPENNING_BALANCE = 0;
                    vendor.BALANCE_LIMIT = 0;
                });
                return true;
            }
            catch (Exception ex)
            { return false; }

        }
    }
}
