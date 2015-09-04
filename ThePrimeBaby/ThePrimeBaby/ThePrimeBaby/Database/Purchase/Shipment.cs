using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Shipment : Concept
    {
        public string ID;
        public DateTime SHIP_DATE;
        public string DESCRIPTION;
        public Vendor Vendor;

        internal static bool AddConsignment(string ConsignmentNumber, DateTime ConsignmentDate)
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
                    Shipment shipment = Db.SQL<Shipment>("SELECT s FROM Shipment s WHERE s.ID = ?", FindID).First;
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
    }
}
