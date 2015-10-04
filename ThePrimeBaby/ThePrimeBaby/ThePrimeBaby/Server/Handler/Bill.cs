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
                    //Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId))).First;
                    QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT bd FROM ThePrimeBaby.Database.Bill bd WHERE bd.Customer.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId)));
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
                //Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.Id = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId))).First;
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE Customer.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(CustomerId)));
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.GET("/ThePrimeBaby/GetNewBillID", (Request r) =>
            {
                return ThePrimeBaby.Database.Bill.GetNewBillID().ToString();
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteBillByBillID", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.Transact(() => { Db.SlowSQL("DELETE FROM Bill v WHERE v.ID= ?", Convert.ToInt32(Attributes[0])); });
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddBill/4", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Bill bill = Db.SQL<Database.Bill>("SELECT c FROM ThePrimeBaby.Database.Bill c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (bill == null)
                {
                    Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    if (customer != null)
                    {
                        bool Result = ThePrimeBaby.Database.Bill.AddBill(Convert.ToInt32(Attributes[0]), customer, Convert.ToDateTime(Attributes[2]), Attributes[3]);
                        if (Result == true)
                            return 200;
                    }
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            //Handle.POST("/ThePrimeBaby/AddBill/6", (Request r) =>
            //{
            //    string[] Attributes = r.Body.Split('/');
            //    Database.Bill bill = Db.SQL<Database.Bill>("SELECT c FROM ThePrimeBaby.Database.Bill c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
            //    if (bill == null)
            //    {
            //        Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
            //        if (customer != null)
            //        {
            //            bool Result = ThePrimeBaby.Database.Bill.AddBill(Convert.ToInt32(Attributes[0]), customer, Convert.ToDateTime(Attributes[2]), Convert.ToDecimal(Attributes[3]), Convert.ToDecimal(Attributes[4]), Attributes[5]);
            //            if (Result == true)
            //                return 200;
            //        }
            //    }
            //    return 209;
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            Handle.GET("/ThePrimeBaby/GetBills", (Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b");
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetBillInvoice/{?}", (string BillID, Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.Id = ?", Convert.ToInt32(BillID));
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT b FROM ThePrimeBaby.Database.Customer b WHERE b = ?", bill.First.CUSTOMER);
                QueryResultRows<Database.BillDetail> billdetiail = Db.SQL<Database.BillDetail>("SELECT b FROM ThePrimeBaby.Database.Billdetail b WHERE bill.Id = ?", Convert.ToInt32(BillID));
                BillInvoiceJson billInvoiceJson = new BillInvoiceJson();
                billInvoiceJson.Customer.Data = customer.First;
                billInvoiceJson.Bill.Data = bill.First;
                billInvoiceJson.BillDetail.Data = billdetiail;
                billInvoiceJson.CustomerPreviousBalance = ThePrimeBaby.Database.Customer.PreviousBalance(customer.First, bill.First.DATED);
                return billInvoiceJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetBillByBillID/{?}", (string BillID, Request r) =>
            {
                QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(BillID)));
                BillJson billJson = new BillJson();
                billJson.Bills.Data = bill;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
