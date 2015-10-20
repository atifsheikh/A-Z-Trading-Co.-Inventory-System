using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Customer
    {
        public static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetCustomerById/{?}", (string CustomerId,Request r) =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<ThePrimeBaby.Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ? ", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId)));
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;            
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerName/{?}", (string CustomerId, Request r) =>
            {
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ? ", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId))).First;
                return customer.NAME;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerByName/{?}", (string CustomerName, Request r) =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Name = ? ", HttpUtility.UrlDecode(CustomerName));
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomers", () =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c");
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            //Handle.POST("/ThePrimeBaby/DeleteCustomerByName", (Request r) =>
            //{
            //    string[] Attributes = r.Body.Split('/');
            //    Db.Transact(() => { Db.SlowSQL("DELETE FROM Customer v WHERE v.Name = ?", Attributes[0]); });
            //    return 200;
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyCustomer/8", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.ModifyCustomer(Convert.ToInt32(Attributes[0]), Attributes[1], Attributes[2], Attributes[3], Attributes[4], Convert.ToDecimal(Attributes[5]), customer, Attributes[7]);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddCustomer/7", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Name = ?", Attributes[0]).First;
                if (customer == null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToInt32(Attributes[4]), Convert.ToInt32(Attributes[5]), Attributes[6]);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/GerCustomerPreviousBalance", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    return ThePrimeBaby.Database.Customer.PreviousBalance(customer, Convert.ToDateTime(Attributes[1]));
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
