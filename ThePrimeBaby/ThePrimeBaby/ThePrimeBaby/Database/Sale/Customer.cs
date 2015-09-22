using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Customer : Concept
    {
        public string BUSINESS_NAME;
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT
        {
            get
            {
                QueryResultRows<Database.Shipment> AllShipments = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE Vendor = ?", this);
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
                return ((ShipmentCalc + this.OPENING_BALANCE) - VoucherCalc);
            }
        }
        public decimal TotalAmount
        {
            get
            {
                QueryResultRows<Database.Shipment> AllShipments = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE Vendor = ?", this);
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

        internal static bool AddCustomer(string Name, string address, string phone, string email, int balance_limit, int opening_balance, string BusinessName)
        {
            try
            {
                Db.Transact(() =>
                {
                    Customer customer = new Customer();
                    customer.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Customer b").First + 1); 
                    customer.NAME = Name.Trim();
                    customer.ADDRESS = address.Trim();
                    customer.PHONE = phone.Trim();
                    customer.EMAIL = email.Trim();
                    customer.BALANCE_LIMIT = balance_limit;
                    customer.OPENING_BALANCE = opening_balance;
                    customer.BUSINESS_NAME = BusinessName;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(string Find, string Replace, Database.Customer customer)
        {
            try
            {
                //Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Name = ?", Find).First;
                Db.Transact(() => {
                    customer.NAME = Replace.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(int FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, Database.Customer customer, string ReplaceBusiness_name)
        {
            try
            {
                //Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    customer.NAME = ReplaceName.Trim();
                    customer.ADDRESS = ReplaceAddress.Trim();
                    customer.PHONE = ReplacePhone.Trim();
                    customer.EMAIL = ReplaceEmail.Trim();
                    customer.OPENING_BALANCE = ReplaceOpening_balance;
                    customer.BUSINESS_NAME = ReplaceBusiness_name;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool DeleteCustomer(string Name)
        {
            try
            {
                Db.Transact(() =>
                {
                    Db.SlowSQL("DELETE FROM Customer WHERE Name = ?", Name.Trim());
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
