using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Shipment
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetConsignments", (Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT c FROM Database.Shipment c");
                ShipmentJson shipmentJson = new ShipmentJson();
                shipmentJson.Shipments.Data = shipment;
                return shipmentJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddConsignmentByNumber/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM Database.Shipment c WHERE c.Id = ?",Convert.ToInt32(Attributes[0])).First;
                if (shipment == null)
                {
                    bool Result = ThePrimeBaby.Database.Shipment.AddConsignment(Convert.ToInt32(Attributes[0]), Convert.ToDateTime(Attributes[1]));
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            //No calls in EXE
            //Handle.POST("/ThePrimeBaby/ModifyConsignmentById/3", (Request r) =>
            //{
            //    //        myCommand.CommandText = "Update SHIPMENT set ID = @ID , SHIP_DATE = @SHIP_DATE , DESCRIPTION = @DESCRIPTION";
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
