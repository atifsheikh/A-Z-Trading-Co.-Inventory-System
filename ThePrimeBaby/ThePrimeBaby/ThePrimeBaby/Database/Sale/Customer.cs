﻿using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Customer : Concept
    {
        public string ADDRESS;
        public string EMAIL;
        public string PHONE;
        public decimal AMOUNT;
        public decimal OPENING_BALANCE;
        public decimal BALANCE_LIMIT;

        internal static bool AddCustomer(string Name, string address, string phone, string email, int balance_limit, int opening_balance)
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

        internal static bool ModifyCustomer(int FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount, Database.Customer customer)
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
                    customer.AMOUNT = CalculatedAmount;
                    customer.OPENING_BALANCE = ReplaceOpening_balance;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyCustomer(int CustomerID, decimal NewBalance, Database.Customer customer)
        {
            try
            {
                //Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Id = ?", Convert.ToInt32(CustomerID)).First;
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
