using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Shipment
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetConsignments
            Handle.GET("/ThePrimeBaby/GetConsignments", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyConsignmentById
            Handle.POST("/ThePrimeBaby/ModifyConsignmentById/3", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddConsignmentByNumber/2
            Handle.POST("/ThePrimeBaby/AddConsignmentByNumber/2", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}
