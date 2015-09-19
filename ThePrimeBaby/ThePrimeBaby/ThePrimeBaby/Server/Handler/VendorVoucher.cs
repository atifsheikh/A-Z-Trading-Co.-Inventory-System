using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class VendorVoucher
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendorVouchers", (Request r) =>
            {
                QueryResultRows<Database.VendorVoucher> vendorVoucher = Db.SQL<Database.VendorVoucher>("SELECT b FROM ThePrimeBaby.Database.VendorVoucher b");
                VendorVoucherJson vendorVoucherJson = new VendorVoucherJson();
                vendorVoucherJson.VendorVouchers.Data = vendorVoucher;
                return vendorVoucherJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.POST("/ThePrimeBaby/AddVendorVoucher/4", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (vendor != null)
                {
                    bool Result = ThePrimeBaby.Database.VendorVoucher.AddVoucherPayment(vendor, Convert.ToDateTime(Attributes[1]), Convert.ToDecimal(Attributes[2]), Attributes[3]);
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}
