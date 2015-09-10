using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Bill : Concept
    {
        public Customer CUSTOMER;
        public DateTime DATED;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;
        public int BillNumber;

        internal static int CTN_BILL_SUM(int BillID)
        {
            IObjectView CTN_BILL_SUM = Db.SQL<IObjectView>("SELECT SUM(b.QTY) FROM ThePrimeBaby.Database.Bill b WHERE b.ID = ?", Convert.ToInt32(BillID)).First;
            return (Convert.ToInt32(CTN_BILL_SUM.GetInt64(0)));
        }
        internal static bool AddBill(int billID, Customer Customer, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
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
                        bill.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Bill b").First) + 1;
                    }
                    bill.BillNumber = GetNewBillNumber();
                    bill.CUSTOMER = Customer;
                    bill.DATED = BillDate;
                    bill.AMOUNT = BillTotal;
                    bill.CUSTOMER_BALANCE = CustomerBalance;
                    bill.REMARKS = Remarks;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static int GetNewBillNumber()
        {
            return (Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Bill b").First) + 1);
        }

        internal static bool DeleteBill(string BillNumber)
        {
            try
            {
                Db.Transact(() =>
                {
                    Db.SlowSQL("DELETE FROM Bill WHERE BillNumber = ?", BillNumber);
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
        {
            try
            {
                Database.Bill BillVoucher = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.ID = ?", Convert.ToInt32(ID)).First;
                Db.Transact(() =>
                {
                    BillVoucher.AMOUNT = UpdateAmount;
                    BillVoucher.CUSTOMER_BALANCE = UpdateCUSTOMER_BALANCE;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyBillAmmount(int BillNumber, decimal CustomerBalance)
        {
            try
            {
                Database.Bill bill = Db.SQL<Database.Bill>("SELECT i FROM ThePrimeBaby.Database.Bill i WHERE i.Id = ?", Convert.ToInt32(BillNumber)).First;
                Db.Transact(() =>
                {
                    bill.AMOUNT = CustomerBalance;
                    bill.CUSTOMER_BALANCE = CustomerBalance;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static object GetNewConsignmentNumber()
        {
            return (Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Shipment b").First) + 1);
        }
    }
}