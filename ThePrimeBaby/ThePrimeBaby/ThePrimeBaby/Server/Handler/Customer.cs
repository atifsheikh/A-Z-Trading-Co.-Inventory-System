using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Customer
    {
        public static void Register()
        {
            Handle.POST("/ThePrimeBaby/AddCustomer/{?}/{?}/{?}/{?}", (string Name, string address, string phone, string email, Request r) =>
            {
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Name).First;
                if (customer == null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Name, address, phone, email, 0, 0);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
