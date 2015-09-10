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

        internal static bool AddConsignment(int ConsignmentNumber, DateTime ConsignmentDate)
        {
            try
            {
                Db.Transact(() => 
                {
                    Shipment shipment = new Shipment();
                    shipment.SHIP_DATE = ConsignmentDate;
                    shipment.ID = ConsignmentNumber;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
        {
            try
            {
                Db.Transact(() => 
                {
                    Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT s FROM ThePrimeBaby.Database.Shipment s WHERE s.ID = ?", Convert.ToInt32(FindID)).First;
                    shipment.SHIP_DATE = ConsignmentDate;
                    shipment.DESCRIPTION = ConsignmentDesc;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool AddShipment(int shipmentID, Vendor Vendor, DateTime ShipmentDate, decimal ShipmentTotal, decimal VendorBalance, string Remarks)
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
                    shipment.ID = GetNewShipmentNumber();
                    shipment.Vendor = Vendor;
                    shipment.SHIP_DATE = ShipmentDate;
                    shipment.AMOUNT = ShipmentTotal;
                    shipment.VENDOR_BALANCE = VendorBalance;
                    shipment.REMARKS = Remarks;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static int GetNewShipmentNumber()
        {
            return (Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Shipment b").First) + 1);
        }
    }
}
