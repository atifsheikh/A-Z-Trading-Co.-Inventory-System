using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class CustomerVoucher : Concept
    {
        public Customer Customer;
        public DateTime DATED;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.Bill> bills = Db.SQL<ThePrimeBaby.Database.Bill>("SELECT s FROM ThePrimeBaby.Database.Bill s WHERE s.Customer = ? AND s.DATED <= ? AND s.ID > ?", this.Customer, this.DATED, 0);
                decimal customerBalance = 0.0m;
                foreach (Bill bill in bills)
                {
                    customerBalance += bill.AMOUNT;
                }

                QueryResultRows<ThePrimeBaby.Database.CustomerVoucher> vouchers = Db.SQL<ThePrimeBaby.Database.CustomerVoucher>("SELECT s FROM ThePrimeBaby.Database.CustomerVoucher s WHERE s.Customer = ? AND s.DATED <= ? AND s.ID >= ? AND s.ID <= ? ", this.Customer, this.DATED, this.ID, 0);
                decimal customerVoucher = 0.0m;
                foreach (CustomerVoucher voucher in vouchers)
                {
                    customerVoucher += voucher.AMOUNT;
                }

                return ((customerBalance + this.Customer.OPENING_BALANCE) - customerVoucher);
            }
        }
        internal static int GetNewVoucherNumber()
        {
            return Convert.ToInt32((Int64)Db.SlowSQL("SELECT MIN(b.ID) FROM ThePrimeBaby.Database.CustomerVoucher b").First) - 1;
        }
        internal static bool AddVoucherPayment(Customer CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks)
        {
            try
            {
                Db.Transact(() =>
                {

                    CustomerVoucher customerVoucher = new CustomerVoucher();
                    customerVoucher.ID = GetNewVoucherNumber();
                    customerVoucher.Customer = CustomerID;
                    customerVoucher.DATED = BillDate;
                    customerVoucher.AMOUNT = BillTotal;
                    customerVoucher.REMARKS = Remarks.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyVoucherPayment(Customer CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, int VoucherNumber)
        {
            try
            {
                CustomerVoucher customerVoucher = Db.SQL<CustomerVoucher>("SELECT vv FROM CustomerVoucher vv WHERE vv.ID = ?", VoucherNumber).First;
                Db.Transact(() =>
                {
                    //customerVoucher.Customer = CustomerID;
                    //customerVoucher.DATED = BillDate;
                    customerVoucher.AMOUNT = BillTotal;
                    customerVoucher.REMARKS = Remarks.Trim();
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
