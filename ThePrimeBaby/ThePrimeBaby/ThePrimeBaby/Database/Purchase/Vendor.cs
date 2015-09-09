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
        public decimal OPENNING_BALANCE;
        public decimal BALANCE_LIMIT;

        internal static bool AddVendor(string Name, string address, string phone, string email, decimal openning_balance, decimal balance_limit)
        {
            try
            {
                Db.Transact(() =>
                {
                    ThePrimeBaby.Database.Vendor vendor = new Vendor();
                    vendor.NAME = Name;
                    vendor.ADDRESS = address;
                    vendor.PHONE = phone;
                    vendor.EMAIL = email;
                    vendor.OPENNING_BALANCE = openning_balance;
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
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM Vendor c WHERE c.Name = ?", Find).First;
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
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM Vendor c WHERE c.ID = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    vendor.NAME = ReplaceName;
                    vendor.ADDRESS = ReplaceAddress;
                    vendor.PHONE = ReplacePhone;
                    vendor.EMAIL = ReplaceEmail;
                    vendor.AMOUNT = CalculatedAmount;
                    vendor.OPENNING_BALANCE = ReplaceOpening_balance;
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
                ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM Vendor c WHERE c.ID = ?", Convert.ToInt32(VendorID)).First;
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
