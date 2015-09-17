﻿using System;
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

            Handle.POST("/ThePrimeBaby/AddShipment/7", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (shipment == null)
                {
                    Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    if (vendor != null)
                    {
                        bool Result = ThePrimeBaby.Database.Shipment.AddShipment(Convert.ToInt32(Attributes[0]), vendor, Convert.ToDateTime(Attributes[2]), Attributes[5], Convert.ToInt32(Attributes[6]));
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

            Handle.POST("/ThePrimeBaby/AddShipmentByNumber/4", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.Id = ?", Convert.ToInt32(Attributes[0])).First;
                if (shipment == null)
                {
                    Database.Vendor vendor = Db.SQL<Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c WHERE c.ID = ?", Convert.ToInt32(Attributes[2])).First;
                    if (vendor != null)
                    {
                        bool Result = ThePrimeBaby.Database.Shipment.AddShipment(Convert.ToInt32(Attributes[0]), Convert.ToDateTime(Attributes[1]), vendor, Attributes[3]);
                        if (Result == true)
                            return 200;
                    }
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            //No calls in EXE
            //Handle.POST("/ThePrimeBaby/ModifyShipmentById/3", (Request r) =>
            //{
            //    //        myCommand.CommandText = "Update SHIPMENT set ID = @ID , SHIP_DATE = @SHIP_DATE , DESCRIPTION = @DESCRIPTION";
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
