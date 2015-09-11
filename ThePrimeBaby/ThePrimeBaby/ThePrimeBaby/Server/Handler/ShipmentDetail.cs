using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class ShipmentDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetShipmentDetailsByShipmentId/{?}", (string ShipmentID, Request r) =>
            {
                QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT bd FROM ThePrimeBaby.Database.ShipmentDetail bd WHERE bd.Shipment.Id = ?", Convert.ToInt32(HttpUtility.UrlDecode(ShipmentID)));
                ShipmentDetailJson shipmentDetailJson = new ShipmentDetailJson();
                shipmentDetailJson.ShipmentDetails.Data = shipmentDetail;
                return shipmentDetailJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.POST("/ThePrimeBaby/ModifyShipmentAmmountByShipmentNumber", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT i FROM ThePrimeBaby.Database.Shipment i WHERE i.Id = ?", Convert.ToInt32(Attributes[0])).First;
                if (shipment != null)
                {
                    bool Result = Database.Shipment.ModifyShipmentAmmount(Convert.ToInt32(Attributes[0]), Convert.ToDecimal(Attributes[1]), shipment);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteShipmentDetailsByShipmentNumber", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.Transact(() => { 
                    Db.SlowSQL("DELETE FROM ThePrimeBaby.Database.ShipmentDetail WHERE Shipment.ID = ?", Convert.ToInt32(Attributes[0]));
                });
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetShipmentDetails", (Request r) =>
            {
                QueryResultRows<Database.ShipmentDetail> shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c");
                ShipmentDetailJson shipmentDetailJson = new ShipmentDetailJson();
                shipmentDetailJson.ShipmentDetails.Data = shipmentDetail;
                return shipmentDetailJson; 
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddShipmentDetailByItemName/8", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.CODE = ?", Attributes[0]).First;
                Database.Shipment shipment = Db.SQL<Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                if (shipment != null)
                {
                    bool Result = ThePrimeBaby.Database.ShipmentDetail.AddShipmentDetail(item,shipment,Convert.ToInt32(Attributes[2]),Convert.ToInt32(Attributes[3]),Attributes[4], Convert.ToInt32(Attributes[5]), Convert.ToDecimal(Attributes[6]), Convert.ToDecimal(Attributes[7]));
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
