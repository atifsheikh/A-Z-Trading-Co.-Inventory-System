using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Bill
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetNewBillNumber
            Handle.GET("/ThePrimeBaby/GetNewBillNumber", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/DeleteBillByBillNumber
            Handle.POST("", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddBill/6
            Handle.POST("/ThePrimeBaby/AddBill/6", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            ///ThePrimeBaby/GetBills
            Handle.GET("/ThePrimeBaby/GetBills", (Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM Bill b");
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetBillByBillNumber/{?}
            Handle.GET("/ThePrimeBaby/GetBillByBillNumber/{?}", (string BillNumber, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


        }
    }
}
