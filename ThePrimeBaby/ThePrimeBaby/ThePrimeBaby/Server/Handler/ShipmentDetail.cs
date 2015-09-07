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

            ///ThePrimeBaby/GetConsignmentDetails
            Handle.GET("/ThePrimeBaby/GetConsignmentDetails", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddConsignmentDetailByItemName/8
            Handle.POST("/ThePrimeBaby/AddConsignmentDetailByItemName/8", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


        }
    }
}
