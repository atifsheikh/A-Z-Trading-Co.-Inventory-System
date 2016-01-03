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
        public decimal OPENING_BALANCE;
        public decimal BALANCE_LIMIT;
        public decimal AMOUNT
        {
            get
            {
                QueryResultRows<Database.Bill> AllBills = Db.SQL<Database.Bill>("SELECT s FROM ThePrimeBaby.Database.Bill s WHERE Customer = ?", this);
                decimal BillCalc = 0.0m;
                foreach (Database.Bill OneBill in AllBills)
                {
                    BillCalc += OneBill.AMOUNT;
                }
                QueryResultRows<Database.CustomerVoucher> AllCustomerVouchers = Db.SQL<Database.CustomerVoucher>("SELECT s FROM ThePrimeBaby.Database.CustomerVoucher s WHERE Customer = ?", this);
                decimal CustomerCalc = 0.0m;
                foreach (Database.CustomerVoucher OneCustomerVoucher in AllCustomerVouchers)
                {
                    CustomerCalc += OneCustomerVoucher.AMOUNT;
                }
                return ((BillCalc + this.OPENING_BALANCE) - CustomerCalc);
            }
        }
        public decimal TotalAmount
        {
            get
            {
                QueryResultRows<Database.Bill> AllBills = Db.SQL<Database.Bill>("SELECT s FROM ThePrimeBaby.Database.Bill s WHERE Customer = ?", this);
                decimal Calc = 0.0m;
                foreach (Database.Bill OneBill in AllBills)
                {
                    Calc += OneBill.AMOUNT;
                }
                return (Calc + this.OPENING_BALANCE);
            }
        }
        internal static string PreviousBalance(Database.Customer customer, DateTime dateTime)
        {
            QueryResultRows<Database.Bill> AllBills = Db.SQL<Database.Bill>("SELECT s FROM ThePrimeBaby.Database.Bill s WHERE Customer = ? AND DATED < ?", customer, dateTime);
            decimal BillCalc = 0.0m;
            foreach (Database.Bill OneBill in AllBills)
            {
                BillCalc += OneBill.AMOUNT;
            }
            QueryResultRows<Database.CustomerVoucher> AllCustomerVouchers = Db.SQL<Database.CustomerVoucher>("SELECT s FROM ThePrimeBaby.Database.CustomerVoucher s WHERE Customer = ? AND DATED < ?", customer, dateTime);
            decimal CustomerCalc = 0.0m;
            foreach (Database.CustomerVoucher OneCustomerVoucher in AllCustomerVouchers)
            {
                CustomerCalc += OneCustomerVoucher.AMOUNT;
            }
            return ((BillCalc + customer.OPENING_BALANCE) - CustomerCalc).ToString();

        }
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
        internal static bool ModifyCustomer(int FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, Database.Customer customer, string ReplaceBusiness_name)
        {
            try
            {
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
    }
}
