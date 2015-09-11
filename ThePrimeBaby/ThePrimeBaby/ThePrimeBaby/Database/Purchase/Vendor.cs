using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Vendor : Concept
    {
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT;
        public decimal OPENING_BALANCE;
        public decimal BALANCE_LIMIT;

        internal static bool AddVendor(string Name, string address, string phone, string email, decimal balance_limit, decimal opening_balance)
        {
            try
            {
                Db.Transact(() =>
                {
                    ThePrimeBaby.Database.Vendor vendor = new Vendor();
                    vendor.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Vendor b").First) + 1;
                    vendor.NAME = Name;
                    vendor.ADDRESS = address;
                    vendor.PHONE = phone;
                    vendor.EMAIL = email;
                    vendor.OPENING_BALANCE = opening_balance;
                    vendor.BALANCE_LIMIT = balance_limit;
                });
                return true;
            }
            catch (Exception ex)
            { return false; }

        }

        internal static bool ModifyVendor(string Find, string Replace)
        {
            try
            {
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.Name = ?", Find).First;
                Db.Transact(() =>
                {
                    vendor.NAME = Replace;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyVendor(int FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            try
            {
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    vendor.NAME = ReplaceName;
                    vendor.ADDRESS = ReplaceAddress;
                    vendor.PHONE = ReplacePhone;
                    vendor.EMAIL = ReplaceEmail;
                    vendor.AMOUNT = CalculatedAmount;
                    vendor.OPENING_BALANCE = ReplaceOpening_balance;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyVendor(int VendorID, decimal NewBalance)
        {
            try
            {
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(VendorID)).First;
                Db.Transact(() =>
                {
                    vendor.AMOUNT = NewBalance;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool DeleteVendor(string Name)
        {
            try
            {
                Db.Transact(() =>
                {
                    Db.SlowSQL("DELETE FROM Vendor WHERE Name = ?", Name);
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
