using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Item
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT c FROM Database.Base.Item c");
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
