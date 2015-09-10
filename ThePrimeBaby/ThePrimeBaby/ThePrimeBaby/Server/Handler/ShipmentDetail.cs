﻿using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class ShipmentDetail
    {
        internal static void Register()
        {
            Handle.POST("/ThePrimeBaby/DeleteConsignmentDetailsByConsignmentNumber", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.SlowSQL("DELETE FROM ShipmentDetail v WHERE v.Shipment.ID = ?", Attributes[0]);
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetConsignmentDetails", (Request r) =>
            {
                QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c");
                ShipmentDetailJson shipmentDetailJson = new ShipmentDetailJson();
                shipmentDetailJson.ShipmentDetails.Data = shipmentDetail;
                return shipmentDetailJson; 
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddConsignmentDetailByItemName/8", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.CODE = ?", Attributes[0]).First;
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                if (shipment == null)
                {
                    bool Result = ThePrimeBaby.Database.ShipmentDetail.AddConsignmentDetail(item,shipment,Convert.ToInt32(Attributes[2]),Convert.ToInt32(Attributes[3]),Attributes[4], Convert.ToInt32(Attributes[5]), Convert.ToDecimal(Attributes[6]), Convert.ToDecimal(Attributes[7]));
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            //Same as below function
            //Handle.GET("/ThePrimeBaby/GetShipmentDetail", (Request r) =>
            //{
            //    QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c");
            //    ShipmentDetailJson shipmentDetailJson = new ShipmentDetailJson();
            //    shipmentDetailJson.ShipmentDetails.Data = shipmentDetail;
            //    return shipmentDetailJson;
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
