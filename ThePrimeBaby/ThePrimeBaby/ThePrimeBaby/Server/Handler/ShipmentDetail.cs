using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class ShipmentDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetShipmentDetail", (Request r) =>
            {
                QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM Database.ShipmentDetail c");
                ShipmentDetailJson shipmentDetailJson = new ShipmentDetailJson();
                shipmentDetailJson.ShipmentDetails.Data = shipmentDetail;
                return shipmentDetailJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
