using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class CustomerVoucher
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.CustomerVoucher> customerVoucher = Db.SQL<Database.CustomerVoucher>("SELECT c FROM Database.CustomerVoucher c");
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
