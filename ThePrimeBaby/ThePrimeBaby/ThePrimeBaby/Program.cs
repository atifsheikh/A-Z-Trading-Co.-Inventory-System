﻿using System;
using Starcounter;
using ThePrimeBaby.Database;

namespace ThePrimeBaby
{
    public class Program
    {
        static void Main()
        {
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
            
            Handle.GET("/ThePrimeBaby/DeveloperTools", (Request r) =>
            {
                FunctionsVariables.Register();
                //ThePrimeBaby.FunctionsVariables.Init_Data();
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}