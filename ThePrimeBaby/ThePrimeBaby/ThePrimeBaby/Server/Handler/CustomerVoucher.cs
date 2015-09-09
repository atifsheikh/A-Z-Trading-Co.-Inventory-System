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

            Handle.POST("/ThePrimeBaby/AddCustomerVoucherPayment", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.CustomerVoucher customerVoucher = Db.SQL<Database.CustomerVoucher>("SELECT c FROM ThePrimeBaby.Database.CustomerVoucher c WHERE c.Name = ?", Attributes[0]).First;
                if (customerVoucher == null)
                {
                    Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                    bool Result = Database.CustomerVoucher.AddVoucherPayment(customer,Convert.ToDateTime(Attributes[1]),Convert.ToDecimal(Attributes[2]), Attributes[3], Convert.ToDecimal(Attributes[4]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetBills
            //Handle.GET("/ThePrimeBaby/GetCustomerVouchers", (Request r) =>
            //{
            //    return 200;
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });

            //same as
            ///ThePrimeBaby/ModifyBillAmmountByBillNumber
            //Handle.POST("/ThePrimeBaby/ModifyCustomerVoucherById", (Request r) =>
            //{
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
