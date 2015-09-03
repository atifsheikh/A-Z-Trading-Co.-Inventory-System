using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Shipment : Concept
    {
        public DateTime SHIP_DATE;
        public string DESCRIPTION;
        public Vendor Vendor;

        internal static bool AddConsignment(string ConsignmentNumber, DateTime ConsignmentDate)
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

        internal static bool ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
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
