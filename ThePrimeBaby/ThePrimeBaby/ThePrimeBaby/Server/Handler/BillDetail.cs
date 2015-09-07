using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class BillDetail
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetSaleByBillId/{?}
            Handle.GET("/ThePrimeBaby/GetSaleByBillId/{?}", (string BillId, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetBillDetailsByBillNumber/{?}
            Handle.GET("/ThePrimeBaby/GetBillDetailsByBillNumber/{?}", (string BillNumber, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetBillsbyCustomerById/{?}
            Handle.GET("/ThePrimeBaby/GetBillsbyCustomerById/{?}", (string CustomerId, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyBillAmmountByBillNumber
            Handle.POST("", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/DeleteBillDetailsByBillNumber
            Handle.POST("", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddSale/9
            Handle.POST("", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}
