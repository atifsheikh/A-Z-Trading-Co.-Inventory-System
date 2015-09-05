using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Customer : Concept
    {
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT;
        public decimal OPENNING_BALANCE;
        public decimal BALANCE_LIMIT;

        internal static bool AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            try
            {
                Db.Transact(() =>
                {
                    Customer customer = new Customer();
                    customer.NAME = Name;
                    customer.ADDRESS = address;
                    customer.PHONE = phone;
                    customer.EMAIL = email;
                    customer.BALANCE_LIMIT = 0;
                    customer.OPENNING_BALANCE = 0;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(string Find, string Replace)
        {
            try
            {
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?",Find).First;
                Db.Transact(() => {
                    customer.NAME = Replace;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            try
            {
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Obid = ?", FindID).First;
                Db.Transact(() =>
                {
                    customer.NAME = ReplaceName;
                    customer.ADDRESS = ReplaceAddress;
                    customer.PHONE = ReplacePhone;
                    customer.EMAIL = ReplaceEmail;
                    customer.AMOUNT = CalculatedAmount;
                    customer.OPENNING_BALANCE = ReplaceOpening_balance;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(int CustomerID, decimal NewBalance)
        {
            try
            {
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Obid = ?", CustomerID).First;
                Db.Transact(() =>
                {
                    customer.AMOUNT = NewBalance;
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
                    Db.SlowSQL("DELETE FROM Customer WHERE Name = ?",Name);
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
