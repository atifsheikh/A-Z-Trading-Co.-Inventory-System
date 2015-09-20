using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Shipment
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetNewShipmentNumber", (Request r) =>
            {
                return ThePrimeBaby.Database.Shipment.GetNewShipmentNumber().ToString();
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddShipment/4", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (shipment == null)
                {
                    Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    if (vendor != null)
                    {
                        bool Result = ThePrimeBaby.Database.Shipment.AddShipment(Convert.ToInt32(Attributes[0]), vendor, Convert.ToDateTime(Attributes[2]), Attributes[3]);
                        if (Result == true)
                            return 200;
                    }
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            

            Handle.GET("/ThePrimeBaby/GetShipmentByShipmentNumber/{?}", (string ShipmentNumber, Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT b FROM ThePrimeBaby.Database.Shipment b WHERE b.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(ShipmentNumber)));
                ShipmentJson shipmentJson = new ShipmentJson();
                shipmentJson.Shipments.Data = shipment;
                return shipmentJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetShipments", (Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c");
                ShipmentJson shipmentJson = new ShipmentJson();
                shipmentJson.Shipments.Data = shipment;
                return shipmentJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
