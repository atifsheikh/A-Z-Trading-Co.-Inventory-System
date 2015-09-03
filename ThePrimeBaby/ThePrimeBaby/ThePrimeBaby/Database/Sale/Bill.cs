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



        internal static bool AddBill(int BillNumber, int CustomerID, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
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
        internal static bool DeleteBill(string BillNumber)
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


        internal static bool ModifyBillAmmount(int BillNumber, decimal CustomerBalance)
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

        internal static bool ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
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
