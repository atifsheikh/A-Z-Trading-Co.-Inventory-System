using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class CustomerVoucher
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetNewCustomerVoucherNumber", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetCustomerVouchers
            Handle.GET("/ThePrimeBaby/GetCustomerVouchers", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyCustomerVoucherById
            Handle.POST("/ThePrimeBaby/ModifyCustomerVoucherById", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddCustomerVoucherPayment
            Handle.POST("/ThePrimeBaby/AddCustomerVoucherPayment", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}
