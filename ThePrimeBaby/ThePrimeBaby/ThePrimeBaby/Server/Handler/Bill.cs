using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Bill
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetBills", (Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM Bill b");
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
