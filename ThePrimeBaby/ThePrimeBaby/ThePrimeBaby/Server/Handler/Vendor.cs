using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Vendor
    {
        public static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendorById/{?}", (string VendorId, Request r) =>
            {
                QueryResultRows<Database.Vendor> Vendor = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ? ", Convert.ToInt32(HttpUtility.UrlDecode(VendorId)));
                VendorJson VendorJson = new VendorJson();
                VendorJson.Vendors.Data = Vendor;
                return VendorJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddVendor/6", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.NAME = ?", Attributes[0]).First;
                if (vendor == null)
                {
                    bool Result = ThePrimeBaby.Database.Vendor.AddVendor(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[5]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.Vendor> vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c");
                VendorJson vendorJson = new VendorJson();
                vendorJson.Vendors.Data = vendor;
                return vendorJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyVendor/7", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT v FROM ThePrimeBaby.Database.Vendor v WHERE v.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (vendor != null)
                {
                    bool Result = ThePrimeBaby.Database.Vendor.ModifyVendor(Convert.ToInt32(Attributes[0]), Attributes[1], Attributes[2], Attributes[3], Attributes[4], Convert.ToDecimal(Attributes[5]),Convert.ToDecimal(Attributes[6]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.POST("/ThePrimeBaby/ModifyVendor/2", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT v FROM ThePrimeBaby.Database.Vendor v WHERE v.ID = ?", Convert.ToInt32(Attributes[0])).First;
                //if (vendor != null)
                //{
                //    bool Result = ThePrimeBaby.Database.Vendor.ModifyVendor(Convert.ToInt32(Attributes[0]), Attributes[1], Attributes[2], Attributes[3], Attributes[4], Convert.ToDecimal(Attributes[5]), Convert.ToDecimal(Attributes[6]));
                //    return 200;
                //}
                //else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyVendorBalance/2", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT v FROM ThePrimeBaby.Database.Vendor v WHERE v.ID = ?", Convert.ToInt32(Attributes[0])).First;
                //if (vendor != null)
                //{
                //    bool Result = ThePrimeBaby.Database.Vendor.ModifyVendor(Convert.ToInt32(Attributes[0]), Attributes[1], Attributes[2], Attributes[3], Attributes[4], Convert.ToDecimal(Attributes[5]), Convert.ToDecimal(Attributes[6]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteVendor", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.SlowSQL("DELETE FROM Vendor v WHERE v.NAME = ?", Attributes[0]);
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
