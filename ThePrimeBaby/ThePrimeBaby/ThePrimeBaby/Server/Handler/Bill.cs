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

            Handle.GET("/ThePrimeBaby/GetConsignments", (Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT b FROM ThePrimeBaby.Database.Shipment b");
                BillJson billJson = new BillJson();
                billJson.Bills.Data = shipment;
                return billJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCreditorSummary", (Request r) =>
            {
                QueryResultRows<Database.Vendor> vendors = Db.SQL<Database.Vendor>("SELECT b FROM ThePrimeBaby.Database.Vendor b");
                //QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT b FROM ThePrimeBaby.Database.Shipment b WHERE b.Id = ?", Convert.ToInt32(ShipmentID));
                CreditorSummary creditorSummaryJson = new CreditorSummary();
                creditorSummaryJson.Vendor.Data = vendors;
                //shipmentInvoiceJson.Shipment.Data = shipment.First;
                return creditorSummaryJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetDebitorSummary", (Request r) =>
            {
                QueryResultRows<Database.Customer> customers = Db.SQL<Database.Customer>("SELECT b FROM ThePrimeBaby.Database.Customer b");
                //QueryResultRows<Database.Bill> bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.Id = ?", Convert.ToInt32(BillID));
                DebitorSummary debitorSummaryJson = new DebitorSummary();
                debitorSummaryJson.Customer.Data = customers;
                //billInvoiceJson.Bill.Data = bill.First;
                return debitorSummaryJson;
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

            Handle.GET("/ThePrimeBaby/GetConsignmentInvoice/{?}", (string ConsignmentID, Request r) =>
            {
                QueryResultRows<Database.Shipment> shipment = Db.SQL<Database.Shipment>("SELECT b FROM ThePrimeBaby.Database.Shipment b WHERE b.Id = ?", Convert.ToInt32(ConsignmentID));
                QueryResultRows<Database.Vendor> vendor = Db.SQL<Database.Vendor>("SELECT b FROM ThePrimeBaby.Database.Vendor b WHERE b = ?", shipment.First.Vendor);
                QueryResultRows<Database.ShipmentDetail> shipmentdetiail = Db.SQL<Database.ShipmentDetail>("SELECT b FROM ThePrimeBaby.Database.Shipmentdetail b WHERE shipment.Id = ?", Convert.ToInt32(ConsignmentID));
                ShipmentInvoiceJson shipmentInvoiceJson = new ShipmentInvoiceJson();
                shipmentInvoiceJson.Vendor.Data = vendor.First;
                shipmentInvoiceJson.Shipment.Data = shipment.First;
                shipmentInvoiceJson.ShipmentDetail.Data = shipmentdetiail;
                shipmentInvoiceJson.VendorPreviousBalance = ThePrimeBaby.Database.Vendor.PreviousBalance(vendor.First, shipment.First.DATED);
                return shipmentInvoiceJson;
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
