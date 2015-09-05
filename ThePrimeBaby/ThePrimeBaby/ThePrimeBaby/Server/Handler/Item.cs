using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Item
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetItems", (Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                ItemJson itemJson = new ItemJson();
                itemJson.Items.Data = item;
                return itemJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
