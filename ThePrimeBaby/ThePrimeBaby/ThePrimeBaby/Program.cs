using System;
using Starcounter;
using ThePrimeBaby.Database;

namespace ThePrimeBaby
{
    public class Program
    {
        static void Main()
        {
            Handle.POST("/ThePrimeBaby/AddCustomer/{?}/{?}/{?}/{?}", (string Name, string address, string phone, string email, Request r) =>
            {
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Name).First;
                if (customer == null)
                {
                    Db.Transact(() =>
                    {
                        customer = new Customer();
                        customer.Name = Name;
                        customer.ADDRESS = address;
                        customer.PHONE = phone;
                        customer.EMAIL = email;
                        customer.OPENNING_BALANCE = 0;
                        customer.BALANCE_LIMIT = 0;
                    });
                    return 200;
                }
                else
                    return 209;                
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddVendor/{?}/{?}/{?}/{?}", (string Name, string address, string phone, string email, Request r) =>
            {
                Vendor vendor = Db.SQL<Vendor>("SELECT c FROM Vendor c WHERE c.Name = ?", Name).First;
                if (vendor == null)
                {
                    Db.Transact(() =>
                    {
                        vendor = new Vendor();
                        vendor.NAME = Name;
                        vendor.ADDRESS = address;
                        vendor.PHONE = phone;
                        vendor.EMAIL = email;
                        vendor.OPENNING_BALANCE = 0;
                        vendor.BALANCE_LIMIT = 0;
                    });
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetVendors", (Request r) =>
            {
                QueryResultRows<Vendor> vendor = Db.SQL<Vendor>("SELECT c FROM Vendor c");
                CustomerVendor CustomerVendor = new CustomerVendor();
                CustomerVendor.CustomersVendors.Data = vendor;
                return CustomerVendor;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}