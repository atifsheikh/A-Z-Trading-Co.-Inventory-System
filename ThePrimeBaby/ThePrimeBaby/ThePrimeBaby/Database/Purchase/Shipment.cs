using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Shipment : Concept
    {
        public DateTime SHIP_DATE;
        public string DESCRIPTION;
        public Vendor Vendor;
        public decimal AMOUNT;
        public string REMARKS;
        public decimal VENDOR_BALANCE;
        public int TOTAL_CTN;
        internal static bool AddShipment(int ShipmentNumber, DateTime ShipmentDate)
        {
            try
            {
                Db.Transact(() => 
                {
                    Shipment shipment = new Shipment();
                    shipment.SHIP_DATE = ShipmentDate;
                    shipment.ID = ShipmentNumber;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyShipment(string FindID, DateTime ShipmentDate, string ShipmentDesc, Database.Shipment shipment)
        {
            try
            {
                Db.Transact(() => 
                {
                    shipment.SHIP_DATE = ShipmentDate;
                    shipment.DESCRIPTION = ShipmentDesc.Trim();
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyShipmentAmmount(int ShipmentNumber, decimal ShipmentAmount, Database.Shipment shipment)
        {
            try
            {
                Db.Transact(() =>
                {
                    shipment.Vendor.AMOUNT -= shipment.AMOUNT;
                    shipment.Vendor.AMOUNT += ShipmentAmount;
                    shipment.AMOUNT = ShipmentAmount;
                    shipment.VENDOR_BALANCE = shipment.Vendor.AMOUNT;
                    //TODO modify future Shipments
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        

        internal static bool AddShipment(int shipmentID, Vendor Vendor, DateTime ShipmentDate, decimal ShipmentTotal, decimal VendorBalance, string Remarks, int TOTAL_CTN)
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
                    shipment.SHIP_DATE = ShipmentDate;
                    shipment.AMOUNT = ShipmentTotal;
                    shipment.VENDOR_BALANCE = VendorBalance;
                    shipment.REMARKS = Remarks.Trim();
                    shipment.TOTAL_CTN = TOTAL_CTN;
                    shipment.Vendor.AMOUNT += ShipmentTotal;
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
