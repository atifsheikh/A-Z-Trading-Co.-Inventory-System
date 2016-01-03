using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class CustomerVoucher
    {
        internal static void Register()
        {
            Handle.POST("/ThePrimeBaby/AddCustomerVoucher/4", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.CustomerVoucher.AddVoucherPayment(customer, Convert.ToDateTime(Attributes[1]), Convert.ToDecimal(Attributes[2]), Attributes[3]);
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyCustomerVoucher/5", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.CustomerVoucher.ModifyVoucherPayment(customer, Convert.ToDateTime(Attributes[1]), Convert.ToDecimal(Attributes[2]), Attributes[3], Convert.ToInt32(Attributes[4]));
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerVouchers", (Request r) =>
            {
                QueryResultRows<Database.CustomerVoucher> customerVoucher = Db.SQL<Database.CustomerVoucher>("SELECT b FROM ThePrimeBaby.Database.CustomerVoucher b");
                CustomerVoucherJson customerVoucherJson = new CustomerVoucherJson();
                customerVoucherJson.CustomerVouchers.Data = customerVoucher;
                return customerVoucherJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
