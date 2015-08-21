using Starcounter;
using System;

namespace ThePrimeBaby.Database
{
    public class Shipment : Concept
    {
        public DateTime SHIP_DATE;
        public string DESCRIPTION;
        public Vendor Vendor;
    }
}
