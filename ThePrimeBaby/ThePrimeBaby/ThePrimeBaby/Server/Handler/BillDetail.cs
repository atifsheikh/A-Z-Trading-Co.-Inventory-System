using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class BillDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.BillDetail> billDetail = Db.SQL<Database.BillDetail>("SELECT bd FROM Database.BillDetail bd");
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
