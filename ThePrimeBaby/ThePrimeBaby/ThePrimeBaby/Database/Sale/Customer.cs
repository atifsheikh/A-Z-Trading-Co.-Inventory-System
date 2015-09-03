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

        internal static bool AddCustomer(string Name, string address, string phone, string email)
        {
            try
            {
                Db.Transact(() =>
                {
                    Customer customer = new Customer();
                    customer.Name = Name;
                    customer.ADDRESS = address;
                    customer.PHONE = phone;
                    customer.EMAIL = email;
                    customer.OPENNING_BALANCE = 0;
                    customer.BALANCE_LIMIT = 0;
                });
                return true;
            }
            catch (Exception ex)
            { return false; }
        }

        internal static bool AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
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

        internal static bool ModifyCustomer(string Find, string Replace)
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

        internal static bool ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
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

        internal static bool ModifyCustomer(int CustomerID, decimal NewBalance)
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

        internal static bool DeleteCustomer(string Name)
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
