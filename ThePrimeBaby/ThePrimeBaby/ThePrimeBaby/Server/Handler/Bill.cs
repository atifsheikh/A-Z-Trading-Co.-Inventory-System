using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Bill
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetLedgerCustomerId/{?}", (string CustomerId, Request r) =>
            {
                if (CustomerId != "All")
                {
                    Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId))).First;
                    QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT bd FROM ThePrimeBaby.Database.Bill bd WHERE bd.Customer = ?", customer);
                    BillJson billJson = new BillJson();
                    billJson.Bills.Data = bill;
                    return billJson;
                }
                else
                {
                    QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT bd FROM ThePrimeBaby.Database.Bill bd");
                    BillJson billJson = new BillJson();
                    billJson.Bills.Data = bill;
                    return billJson;
                }
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetBillsbyCustomerById/{?}", (string CustomerId, Request r) =>
            {
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Id = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId))).First;
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE Customer = ?", customer);
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.GET("/ThePrimeBaby/GetNewBillNumber", (Request r) =>
            {
                return ThePrimeBaby.Database.Bill.GetNewBillNumber().ToString();
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetNewConsignmentNumber", (Request r) =>
            {
                return ThePrimeBaby.Database.Bill.GetNewConsignmentNumber().ToString();
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteBillByBillNumber", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.SlowSQL("DELETE FROM Bill v WHERE v.ID= ?", Convert.ToInt32(Attributes[0]));
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddBill/6", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Bill bill = Db.SQL<Database.Bill>("SELECT c FROM ThePrimeBaby.Database.Bill c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (bill == null)
                {
                    Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    bool Result = ThePrimeBaby.Database.Bill.AddBill(Convert.ToInt32(Attributes[0]),customer, Convert.ToDateTime(Attributes[2]), Convert.ToDecimal(Attributes[3]),Convert.ToDecimal(Attributes[4]),Attributes[5]);
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            Handle.GET("/ThePrimeBaby/GetBills", (Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b");
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetBillByBillNumber/{?}", (string BillNumber, Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(BillNumber)));
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
