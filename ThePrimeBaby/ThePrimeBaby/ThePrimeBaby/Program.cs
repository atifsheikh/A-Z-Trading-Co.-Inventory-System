using System;
using Starcounter;
using ThePrimeBaby.Database;

namespace ThePrimeBaby
{
    public class Program
    {
        static void Main()
        {
            Db.Transact(() => 
            {
                QueryResultRows<ThePrimeBaby.Database.ShipmentDetail> sds = Db.SQL<ShipmentDetail>("SELECT sd FROM ShipmentDetail sd");
                foreach (ThePrimeBaby.Database.ShipmentDetail sd in sds)
                {
                    if (string.IsNullOrEmpty(sd.NAME))
                    {
                        sd.NAME = sd.Item.CODE;
                    }
                }
            });

            ThePrimeBaby.Server.Handler.Category.Register();
            ThePrimeBaby.Server.Handler.Bill.Register();
            ThePrimeBaby.Server.Handler.BillDetail.Register();
            ThePrimeBaby.Server.Handler.Customer.Register();
            ThePrimeBaby.Server.Handler.CustomerVoucher.Register();
            ThePrimeBaby.Server.Handler.Item.Register();
            ThePrimeBaby.Server.Handler.Shipment.Register();
            ThePrimeBaby.Server.Handler.ShipmentDetail.Register();
            ThePrimeBaby.Server.Handler.Vendor.Register();
            ThePrimeBaby.Server.Handler.VendorVoucher.Register();
            ThePrimeBaby.Server.Handler.GUI.BillInvoice.Register();
            
            Handle.GET("/ThePrimeBaby/DeveloperTools", (Request r) =>
            {
                FunctionsVariables.Register();
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ThePrimeBaby.Database.Base.DatabaseIndexes.CreateIndexes();
        }
    }
}