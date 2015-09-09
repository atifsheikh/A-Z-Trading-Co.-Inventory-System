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
            IObjectView CTN_BILL_SUM = Db.SQL<IObjectView>("SELECT SUM(b.QTY) FROM Bill b WHERE b.ID = ?", BillID).First;
            return (Convert.ToInt32(CTN_BILL_SUM.GetInt64(0)));
        }
        internal static bool AddBill(Customer Customer, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
        {
            try
            {
                Db.Transact(() =>
                {
                    Bill bill = new Bill();
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
            IObjectView MinId = Db.SQL<IObjectView>("SELECT MAX(b.ID) FROM Bill b").First;
            return (Convert.ToInt32(MinId.GetInt64(0))+1);
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
                Bill BillVoucher = Db.SQL<Bill>("SELECT b FROM Bill b WHERE b.ID = ?", ID).First;
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
                Database.Bill bill = Db.SQL<Database.Bill>("SELECT i FROM Database.Bill i WHERE i.Id = ?", BillNumber).First;
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
    }
}