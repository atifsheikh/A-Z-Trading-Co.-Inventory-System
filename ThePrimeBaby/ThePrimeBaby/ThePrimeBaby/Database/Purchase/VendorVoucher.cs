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
        public decimal VENDOR_BALANCE;

        internal static bool AddVoucherPayment(Vendor VendorID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal VendorBalance)
        {
            try
            {
                VendorVoucher vendorVoucher = new VendorVoucher();
                vendorVoucher.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.VendorVoucher b").First) + 1;
                vendorVoucher.Vendor = VendorID;
                vendorVoucher.VOUCHER_DATE = BillDate;
                vendorVoucher.AMOUNT = BillTotal;
                vendorVoucher.REMARKS = Remarks;
                vendorVoucher.VENDOR_BALANCE = VendorBalance;
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
