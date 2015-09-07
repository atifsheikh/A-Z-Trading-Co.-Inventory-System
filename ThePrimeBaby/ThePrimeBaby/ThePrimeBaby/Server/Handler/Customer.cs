using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Customer
    {
        public static void Register()
        {
            ///ThePrimeBaby/GetCustomerById/{?}
            Handle.GET("/ThePrimeBaby/GetCustomerById/{?}", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            ///ThePrimeBaby/GetCustomerName/" + ID
            Handle.GET("/ThePrimeBaby/GetCustomerName/{?}", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerByName/{?}", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomers", () =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyCustomer/2
            Handle.POST("/ThePrimeBaby/ModifyCustomer/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                if (customer == null)
                {
                    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            ///ThePrimeBaby/DeleteCustomerByName
            Handle.POST("/ThePrimeBaby/DeleteCustomerByName", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyCustomerById/2
            Handle.POST("/ThePrimeBaby/ModifyCustomerById/2", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            ///ThePrimeBaby/ModifyCustomer/7
            Handle.POST("/ThePrimeBaby/ModifyCustomer/7", (Request r) =>
            {
                //string[] Attributes = r.Body.Split('/');
                //Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                //if (customer == null)
                //{
                //    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                //    return 200;
                //}
                //else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddCustomer/6", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                if (customer == null)
                {
                    //bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToDecimal(Attributes[4]), Convert.ToDecimal(Attributes[0]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
