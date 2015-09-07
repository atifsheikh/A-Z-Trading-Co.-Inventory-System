using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Category
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetCategory
            Handle.GET("/ThePrimeBaby/GetCategory", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });



            ///ThePrimeBaby/AddCategory
            Handle.POST("/ThePrimeBaby/AddCategory", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}

///ThePrimeBaby/AddCategory
