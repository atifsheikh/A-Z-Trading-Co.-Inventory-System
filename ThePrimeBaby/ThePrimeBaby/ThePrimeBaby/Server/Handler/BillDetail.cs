using System;
using Starcounter;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class BillDetail
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetBillDetailsByBillID/{?}", (string BillID, Request r) =>
            {
                QueryResultRows<Database.BillDetail> billDetail = Db.SQL<Database.BillDetail>("SELECT bd FROM ThePrimeBaby.Database.BillDetail bd WHERE bd.Bill.ID = ?", Convert.ToInt32(HttpUtility.UrlDecode(BillID)));
                BillDetailJson billDetailJson = new BillDetailJson();
                billDetailJson.BillDetails.Data = billDetail;
                return billDetailJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddBillDetailByItemName/8", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.CODE = ?", Attributes[0]).First;
                if (item != null)
                {
                    Database.Bill bill = Db.SQL<Database.Bill>("SELECT c FROM ThePrimeBaby.Database.Bill c WHERE c.ID = ?", Convert.ToInt32(Attributes[1])).First;
                    if (bill != null)
                    {
                        bool Result = ThePrimeBaby.Database.BillDetail.AddBillDetail(item, bill, Convert.ToInt32(Attributes[2]), Convert.ToInt32(Attributes[3]), Convert.ToInt32(Attributes[5]), Convert.ToDecimal(Attributes[6]), Convert.ToDecimal(Attributes[7]));
                        if (Result == true)
                            return 200;
                    }
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteBillDetailsByBillID", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.Transact(() => { Db.SlowSQL("DELETE FROM BillDetail v WHERE v.Bill.ID = ?", Attributes[0]); });
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            //Handle.POST("/ThePrimeBaby/AddSale/9", (Request r) =>
            //{
            //    string[] Attributes = r.Body.Split('/');
            //    Database.BillDetail billDetail = Db.SQL<Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c WHERE c.NAME = ?", Attributes[0]).First;
            //    if (billDetail == null)
            //    {
            //        Database.Bill bill = Db.SQL<Database.Bill>("SELECT b FROM ThePrimeBaby.Database.Bill b WHERE b.Id = ?", Convert.ToInt32(Attributes[2])).First;
            //        Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT b FROM ThePrimeBaby.Database.Base.Item b WHERE b.Code = ?", Attributes[4]).First;
            //        Database.Customer customer = Db.SQL<Database.Customer>("SELECT b FROM ThePrimeBaby.Database.Customer b WHERE b.Id = ?", Convert.ToInt32(Attributes[8])).First;
            //        bool Result = ThePrimeBaby.Database.BillDetail.AddSale(Convert.ToDecimal(Attributes[0]), Convert.ToInt32(Attributes[1]), bill,Convert.ToDecimal(Attributes[3]),item, Convert.ToInt32(Attributes[6]), Convert.ToInt32(Attributes[7]),customer);
            //        if (Result == true )
            //            return 200;
            //    }
            //    return 209;
            //}, new HandlerOptions() { SkipMiddlewareFilters = true });

        }
    }
}
