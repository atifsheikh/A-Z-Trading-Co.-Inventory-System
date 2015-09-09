using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class VendorVoucher : Concept
    {
        public Vendor Vendor;
        public DateTime VOUCHER_DATE;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal CUSTOMER_BALANCE;

        internal static bool AddVoucherPayment(Vendor CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            try
            {
                VendorVoucher vendorVoucher = new VendorVoucher();
                vendorVoucher.ID = Convert.ToInt32(Db.SQL<IObjectView>("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.VendorVoucher b").First) + 1;
                vendorVoucher.Vendor = CustomerID;
                vendorVoucher.VOUCHER_DATE = BillDate;
                vendorVoucher.AMOUNT = BillTotal;
                vendorVoucher.REMARKS = Remarks;
                vendorVoucher.CUSTOMER_BALANCE = CustomerBalance;
                vendorVoucher.ID = GetNewVoucherNumber();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static int GetNewVoucherNumber()
        {
            IObjectView MinId = Db.SQL<IObjectView>("SELECT MIN(s.ID) FROM ThePrimeBaby.Database.Shipment s").First;
            return Convert.ToInt32(MinId.GetInt64(0)) - 1;
        }
    }
}
