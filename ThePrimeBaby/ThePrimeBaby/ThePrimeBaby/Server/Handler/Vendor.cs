using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Vendor
    {
        public static void Register()
        {
            Handle.POST("/ThePrimeBaby/AddVendor/{?}/{?}/{?}/{?}", (string Name, string address, string phone, string email, Request r) =>
            {
                Vendor vendor = Db.SQL<Vendor>("SELECT c FROM Vendor c WHERE c.Name = ?", Name).First;
                if (vendor == null)
                {
                    bool Result = ThePrimeBaby.Database.Vendor.AddVendor(Name, address, phone, email);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.Vendor> vendor = Db.SQL<Database.Vendor>("SELECT c FROM Vendor c");
                VendorJson vendorJson = new VendorJson();
                vendorJson.Vendors.Data = vendor;
                return vendorJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });             
        }
    }
}
