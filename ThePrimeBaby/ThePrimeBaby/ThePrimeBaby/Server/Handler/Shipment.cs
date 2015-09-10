using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Shipment
    {
        internal static void Register()
        {
            Handle.POST("/ThePrimeBaby/AddConsignment/6", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (shipment == null)
                {
                    Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    bool Result = ThePrimeBaby.Database.Shipment.AddShipment(Convert.ToInt32(Attributes[0]), vendor, Convert.ToDateTime(Attributes[2]), Convert.ToDecimal(Attributes[3]), Convert.ToDecimal(Attributes[4]), Attributes[5]);
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            

            Handle.GET("/ThePrimeBaby/GetConsignmentByConsignmentNumber/{?}", (string ConsignmentNumber, Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT b FROM ThePrimeBaby.Database.Shipment b WHERE b.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(ConsignmentNumber)));
                ShipmentJson shipmentJson = new ShipmentJson();
                shipmentJson.Shipments.Data = shipment;
                return shipmentJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetConsignments", (Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c");
                ShipmentJson shipmentJson = new ShipmentJson();
                shipmentJson.Shipments.Data = shipment;
                return shipmentJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddConsignmentByNumber/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.Id = ?", Convert.ToInt32(Attributes[0])).First;
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
