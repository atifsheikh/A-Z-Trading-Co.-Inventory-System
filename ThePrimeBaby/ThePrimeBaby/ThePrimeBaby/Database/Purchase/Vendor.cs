using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Vendor : Concept
    {
        public string BUSINESS_NAME;
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT{ 
            get 
            {
                QueryResultRows<Database.Shipment> AllShipments = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE Vendor = ?",this);
                decimal ShipmentCalc = 0.0m;
                foreach (Database.Shipment OneShipment in AllShipments)
                {
                    ShipmentCalc += OneShipment.AMOUNT;
                }
                QueryResultRows<Database.VendorVoucher> AllVendorVouchers = Db.SQL<Database.VendorVoucher>("SELECT s FROM ThePrimeBaby.Database.VendorVoucher s WHERE Vendor = ?", this);
                decimal VoucherCalc = 0.0m;
                foreach (Database.VendorVoucher OneVendorVoucher in AllVendorVouchers)
                {
                    VoucherCalc += OneVendorVoucher.AMOUNT;
                }
                return ((ShipmentCalc + this.OPENING_BALANCE)-VoucherCalc);
            }
        }
        public decimal TotalAmount { 
            get 
            {
                QueryResultRows<Database.Shipment> AllShipments = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE Vendor = ?",this);
                decimal Calc = 0.0m;
                foreach (Database.Shipment OneShipment in AllShipments)
                {
                    Calc += OneShipment.AMOUNT;
                }
                return (Calc + this.OPENING_BALANCE);
            }
        }
        public decimal OPENING_BALANCE;
        public decimal BALANCE_LIMIT;
        internal static string PreviousBalance(Database.Vendor vendor, DateTime dateTime)
        {
            QueryResultRows<Database.Shipment> AllShipments = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE Vendor = ? AND DATED < ?", vendor, dateTime);
            decimal ShipmentCalc = 0.0m;
            foreach (Database.Shipment OneShipment in AllShipments)
            {
                ShipmentCalc += OneShipment.AMOUNT;
            }
            QueryResultRows<Database.VendorVoucher> AllVendorVouchers = Db.SQL<Database.VendorVoucher>("SELECT s FROM ThePrimeBaby.Database.VendorVoucher s WHERE Vendor = ? AND DATED < ?", vendor, dateTime);
            decimal VendorCalc = 0.0m;
            foreach (Database.VendorVoucher OneVendorVoucher in AllVendorVouchers)
            {
                VendorCalc += OneVendorVoucher.AMOUNT;
            }
            return ((ShipmentCalc + vendor.OPENING_BALANCE) - VendorCalc).ToString();

        }

        internal static bool AddVendor(string Name, string address, string phone, string email, decimal balance_limit, decimal opening_balance, string BusinessName)
        {
            try
            {
                Db.Transact(() =>
                {
                    ThePrimeBaby.Database.Vendor vendor = new Vendor();
                    vendor.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Vendor b").First) + 1;
                    vendor.NAME = Name.Trim();
                    vendor.ADDRESS = address.Trim();
                    vendor.PHONE = phone.Trim();
                    vendor.EMAIL = email.Trim();
                    vendor.OPENING_BALANCE = opening_balance;
                    vendor.BALANCE_LIMIT = balance_limit;
                    vendor.BUSINESS_NAME = BusinessName;
                });
                return true;
            }
            catch (Exception ex)
            { return false; }

        }

        internal static bool ModifyVendor(string Find, string Replace, ThePrimeBaby.Database.Vendor vendor)
        {
            try
            {
                Db.Transact(() =>
                {
                    vendor.NAME = Replace.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyVendor(int FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, ThePrimeBaby.Database.Vendor vendor, string BusinessName)
        {
            try
            {
                //ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    vendor.NAME = ReplaceName.Trim();
                    vendor.ADDRESS = ReplaceAddress.Trim();
                    vendor.PHONE = ReplacePhone.Trim();
                    vendor.EMAIL = ReplaceEmail.Trim();
                    vendor.OPENING_BALANCE = ReplaceOpening_balance;
                    vendor.BUSINESS_NAME = BusinessName;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //internal static bool ModifyVendor(int VendorID, decimal NewBalance, ThePrimeBaby.Database.Vendor vendor)
        //{
        //    try
        //    {
        //        //ThePrimeBaby.Database.Vendor vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(VendorID)).First;
        //        Db.Transact(() =>
        //        {
        //            vendor.AMOUNT = NewBalance;
        //        });
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        internal static bool DeleteVendor(string Name)
        {
            try
            {
                Db.Transact(() =>
                {
                    Db.SlowSQL("DELETE FROM Vendor WHERE Name = ?", Name.Trim());
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
