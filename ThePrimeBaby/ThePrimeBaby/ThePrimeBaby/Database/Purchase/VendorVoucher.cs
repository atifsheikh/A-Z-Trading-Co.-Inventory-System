using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class VendorVoucher : Concept
    {
        public DateTime DATED;
        public string REMARKS;
        public Vendor Vendor;
        public decimal AMOUNT;
        public decimal VENDOR_BALANCE
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.Shipment> shipments = Db.SQL<ThePrimeBaby.Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE s.Vendor = ? AND s.DATED <= ? AND s.ID > ? AND s.ID <= ? ", this.Vendor, this.DATED, 0, this.ID);
                decimal vendorBalance = 0.0m;
                foreach (Shipment shipment in shipments)
                {
                    vendorBalance += shipment.AMOUNT;
                }

                QueryResultRows<ThePrimeBaby.Database.VendorVoucher> vouchers = Db.SQL<ThePrimeBaby.Database.VendorVoucher>("SELECT s FROM ThePrimeBaby.Database.VendorVoucher s WHERE s.Vendor = ? AND s.DATED <= ? AND s.ID > ? AND s.ID <= ? ", this.Vendor, this.DATED, this.ID, 0);
                decimal vendorVoucher = 0.0m;
                foreach (VendorVoucher voucher in vouchers)
                {
                    vendorVoucher += voucher.AMOUNT;
                }

                return ((vendorBalance + this.Vendor.OPENING_BALANCE) - vendorVoucher);
            }
        }
        
        internal static bool AddVoucherPayment(Vendor VendorID, DateTime BillDate, Decimal BillTotal, string Remarks)
        {
            try
            {
                Db.Transact(() =>
                {

                    VendorVoucher vendorVoucher = new VendorVoucher();
                    vendorVoucher.ID = GetNewVoucherNumber();
                    vendorVoucher.Vendor = VendorID;
                    vendorVoucher.DATED = BillDate;
                    vendorVoucher.AMOUNT = BillTotal;
                    vendorVoucher.REMARKS = Remarks.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static int GetNewVoucherNumber()
        {
            return Convert.ToInt32((Int64)Db.SlowSQL("SELECT MIN(b.ID) FROM ThePrimeBaby.Database.VendorVoucher b").First) - 1;
        }
    }
}
