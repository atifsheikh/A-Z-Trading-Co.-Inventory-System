using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class CustomerVoucher : Concept
    {
        public Customer Customer;
        public DateTime VOUCHER_DATE;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;
        public int ID;

        internal static bool AddVoucherPayment(Customer CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            try
            {
                CustomerVoucher customerVoucher = new CustomerVoucher();
                customerVoucher.Customer = CustomerID;
                customerVoucher.VOUCHER_DATE = BillDate;
                customerVoucher.AMOUNT = BillTotal;
                customerVoucher.REMARKS = Remarks;
                customerVoucher.CUSTOMER_BALANCE = CustomerBalance;
                customerVoucher.ID = GetNewVoucherNumber();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static int GetNewVoucherNumber()
        {
            IObjectView MinId = Db.SQL<IObjectView>("SELECT MIN(b.ID) FROM Bill").First;
            return Convert.ToInt32(MinId.GetInt64(0)) - 1;
        }
    }
}
