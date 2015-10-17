using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Bill : Concept
    {
        public DateTime DATED;

        public Customer CUSTOMER;
        public string REMARKS;
        public decimal AMOUNT
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.BillDetail> billDetails = Db.SQL<ThePrimeBaby.Database.BillDetail>("SELECT sd FROM ThePrimeBaby.Database.BillDetail sd WHERE sd.Bill = ?", this);
                decimal amountSum = 0.0m;
                foreach (BillDetail billDetail in billDetails)
                {
                    amountSum += billDetail.SUBTOTAL;
                }
                return amountSum;
            }
        }
        public decimal CUSTOMER_BALANCE
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.Bill> bills = Db.SQL<ThePrimeBaby.Database.Bill>("SELECT s FROM ThePrimeBaby.Database.Bill s WHERE s.Customer = ? AND s.DATED <= ? AND s.ID > ?", this.CUSTOMER, this.DATED, 0);
                decimal customerBalance = 0.0m;
                foreach (Bill bill in bills)
                {
                    customerBalance += bill.AMOUNT;
                }

                QueryResultRows<ThePrimeBaby.Database.CustomerVoucher> vouchers = Db.SQL<ThePrimeBaby.Database.CustomerVoucher>("SELECT s FROM ThePrimeBaby.Database.CustomerVoucher s WHERE s.Customer = ? AND s.DATED <= ? AND s.ID <= ? ", this.CUSTOMER, this.DATED, 0);
                decimal customerVoucher = 0.0m;
                foreach (CustomerVoucher voucher in vouchers)
                {
                    customerVoucher += voucher.AMOUNT;
                }

                return ((customerBalance + this.CUSTOMER.OPENING_BALANCE) - customerVoucher);
            }
        }

        public int TOTAL_CTN
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.BillDetail> billDetails = Db.SQL<ThePrimeBaby.Database.BillDetail>("SELECT sd FROM ThePrimeBaby.Database.BillDetail sd WHERE sd.Bill = ?", this);
                int totalCtn = 0;
                foreach (BillDetail billDetail in billDetails)
                {
                    totalCtn += billDetail.CTN;
                }
                return totalCtn;
            }
        }
        public int QUANT_TOTAL
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.BillDetail> billDetails = Db.SQL<ThePrimeBaby.Database.BillDetail>("SELECT sd FROM ThePrimeBaby.Database.BillDetail sd WHERE sd.Bill = ?", this);
                int totalQuant = 0;
                foreach (BillDetail billDetail in billDetails)
                {
                    totalQuant += billDetail.T_QUANTITY;
                }
                return totalQuant;
            }
        }
        internal static bool AddBill(int billID, Customer Customer, DateTime BillDate, string Remarks)
        {
            try
            {
                Db.Transact(() =>
                {
                    Bill bill = new Bill();
                    if (billID != 0 || billID != null)
                    {
                        bill.ID = billID;
                    }
                    else
                    {
                        bill.ID = GetNewBillID();
                    }
                    bill.CUSTOMER = Customer;
                    bill.DATED = BillDate;
                    bill.REMARKS = Remarks.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static int GetNewBillID()
        {
            try
            {
                return (Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Bill b").First) + 1);
            }
            catch (Exception ex)
            { return 1; }
        }
    }
}