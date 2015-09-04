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
                QueryResultRows<ThePrimeBaby.Database.VendorVoucher> vendorVoucher = Db.SQL<ThePrimeBaby.Database.VendorVoucher>("SELECT v FROM ThePrimeBaby.Database.VendorVoucher v");
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
