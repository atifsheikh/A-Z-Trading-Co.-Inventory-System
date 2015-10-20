using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Shipment : Concept
    {
        public DateTime DATED;
        public string DESCRIPTION;
        public Vendor Vendor;
        public string REMARKS;
        public decimal AMOUNT
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.ShipmentDetail> shipmentDetails = Db.SQL<ThePrimeBaby.Database.ShipmentDetail>("SELECT sd FROM ThePrimeBaby.Database.ShipmentDetail sd WHERE sd.Shipment = ?", this);
                decimal amountSum = 0.0m;
                foreach (ShipmentDetail shipmentDetail in shipmentDetails)
                {
                    amountSum += shipmentDetail.SUBTOTAL;
                }
                return amountSum;
            }
        }
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

                QueryResultRows<ThePrimeBaby.Database.VendorVoucher> vouchers = Db.SQL<ThePrimeBaby.Database.VendorVoucher>("SELECT s FROM ThePrimeBaby.Database.VendorVoucher s WHERE s.Vendor = ? AND s.DATED <= ? AND s.ID <= ? ", this.Vendor, this.DATED, 0);
                decimal vendorVoucher = 0.0m;
                foreach (VendorVoucher voucher in vouchers)
                {
                    vendorVoucher += voucher.AMOUNT;
                }

                return ((vendorBalance + this.Vendor.OPENING_BALANCE) - vendorVoucher);
            }
        }
        public int TOTAL_CTN 
        {
            get
            {
                QueryResultRows<ThePrimeBaby.Database.ShipmentDetail> shipmentDetails = Db.SQL<ThePrimeBaby.Database.ShipmentDetail>("SELECT sd FROM ThePrimeBaby.Database.ShipmentDetail sd WHERE sd.Shipment = ?", this);
                int totalCtn = 0;
                foreach (ShipmentDetail shipmentDetail in shipmentDetails)
                {
                    totalCtn += shipmentDetail.CTN;
                }
                return totalCtn;
            }
        }
        internal static bool AddShipment(int shipmentID, Vendor Vendor, DateTime ShipmentDate, string Remarks)
        {
            try
            {
                Db.Transact(() =>
                {
                    Shipment shipment = new Shipment();
                    if (shipmentID != 0 || shipmentID != null)
                    {
                        shipment.ID = shipmentID;
                    }
                    else
                    {
                        shipment.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Shipment b").First) + 1;
                    }
                    shipment.Vendor = Vendor;
                    shipment.DATED = ShipmentDate;
                    shipment.REMARKS = Remarks.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static object GetNewShipmentNumber()
        {
            try { return (Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Shipment b").First) + 1); }
            catch (Exception ex)
            { return 1; }

        }
    }
}
