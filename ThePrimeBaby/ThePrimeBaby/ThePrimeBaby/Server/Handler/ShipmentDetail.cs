using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class ShipmentDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM Database.ShipmentDetail c");
                //Customer CustomerJson = new Customer();
                //CustomerJson.Customers.Data = vendor;
                //return CustomerJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
