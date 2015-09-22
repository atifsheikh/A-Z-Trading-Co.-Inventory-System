using System;
using Starcounter;
using System.Data;
using System.Web;

namespace ThePrimeBaby.Server.Handler
{
    public class Item
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetItemsForShipment
            Handle.GET("/ThePrimeBaby/GetItemsForShipment", (Request r) =>
            {
                //"SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0"
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemsForBill
            Handle.GET("/ThePrimeBaby/GetItemsForBill", (Request r) =>
            {
                //"SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0"
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemsForSale
            Handle.GET("/ThePrimeBaby/GetItemsForSale", (Request r) =>
            {
                //SELECT a.ID, a.QTY_BOX, a.PRICE, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)) as Quantity, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) as CTN_LEFT, a.CODE, a.MODEL FROM ITEMINVENTORY a where ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) > 0
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemHistory/{?}          ItemCode
            Handle.GET("/ThePrimeBaby/GetItemHistory/{?}", (string ItemCode, Request r) =>
            {
                //"Select * from ITEMHISTORY where ITEM_CODE = '" + ItemCode + "'", myConnection1);
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/Get_Ctn_Bill
            Handle.GET("/ThePrimeBaby/Get_Ctn_Bill", (Request r) =>
            {
                //"Select * from CTN_BILL_SUM"
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            ///ThePrimeBaby/GetInventoryDetails
            Handle.GET("/ThePrimeBaby/GetInventoryDetails", (Request r) =>
            {
                //string Result = FunctionsVariables.GET("http://localhost:8080/ThePrimeBaby/GetItems");
                //DataSet ItemDataSet = FunctionsVariables.JsonToDataSet(Result);

                //Database.BillDetail sale = Db.SQL<Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c").First;
                //Database.ShipmentDetail shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c").First;
                ////Database.BillDetail billDetail = Db.SQL<Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c ").First;
                //try
                //{
                //    //FbDataAdapter ItemDataAdapter = new FbDataAdapter("Select * from ITEM", myConnection1);
                //    ItemDataSet.Tables[0].Columns.Add("Total Quantity", typeof(string));
                //    ItemDataSet.Tables[0].Columns[7].SetOrdinal(2);

                //    //FbDataAdapter SaleDataAdapter = new FbDataAdapter("Select ITEM_CODE, QTY from SALE", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);
                //    //FbDataAdapter ShipmentDataAdapter = new FbDataAdapter("Select ITEM_CODE, T_QUANTITY from SHIPMENT_DETAIL", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);

                //    for (int loop = 0; loop < ItemDataSet.Tables[0].Rows.Count; loop++)// DataRow ItemDataRow in ItemDataSet.Tables[0].Rows)
                //    {
                //        string SalesCount = "0";
                //        foreach (DataRow SalesRow in SaleDataSet.Tables[0].Rows)
                //        {
                //            if (SalesRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                //                SalesCount = SalesRow["QTY"].ToString();
                //        }

                //        string ShipmentCount = "0";
                //        foreach (DataRow ShipmentRow in ShipmentDataSet.Tables[0].Rows)
                //        {
                //            if (ShipmentRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                //                ShipmentCount = ShipmentRow["T_QUANTITY"].ToString();
                //        }

                //        int TotalCount = Convert.ToInt32(ShipmentCount) - Convert.ToInt32(SalesCount);
                //        ItemDataSet.Tables[0].Rows[loop]["Total Quantity"] = TotalCount.ToString();
                //    }
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemCount/{?}", (string ItemCode, Request r) =>
            {
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Code = ?", HttpUtility.UrlDecode(ItemCode)).First;
                return item.T_QUANTITY;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemSaleHistory/{?}", (string ItemName, Request r) =>
            {
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Name = ?", HttpUtility.UrlDecode(ItemName)).First;
                QueryResultRows<IObjectView> billDetail = Db.SQL<IObjectView>("SELECT bd.ID, bd.QTY, bd.Bill.Id, bd.Item.ITEM_CODE, bd.Item.ITEM_NAME, bd.PCS_CTN, bd.T_QUANTITY, bd.UNITPRICE, bd.SUBTOTAL, bd.Customer.NAME , bd.Bill.DATED FROM ThePrimeBaby.Database.BillDetail bd WHERE bd.Item = ? AND bd.Bill.Id > ?", item, 0);
                ItemSaleHistoryJson itemSaleHistoryJson = new ItemSaleHistoryJson();
                itemSaleHistoryJson.ItemSaleHistory.Data = billDetail;
                return itemSaleHistoryJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemDetails/{?}", (string FindString,Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Code = ?", HttpUtility.UrlDecode(FindString));
                ItemJson itemJson = new ItemJson();
                itemJson.Items.Data = item;
                return itemJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemsByName/{?}", (string ItemName, Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.CODE = ?", HttpUtility.UrlDecode(ItemName));
                ItemJson itemJson = new ItemJson();
                itemJson.Items.Data = item;
                return itemJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItems", (Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i");
                ItemJson itemJson = new ItemJson();
                itemJson.Items.Data = item;
                return itemJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyItemPrice/3", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Code = ?", Attributes[0]).First;
                if (item != null)
                {
                    bool Result = Database.Base.Item.ModifyItemPriceByCode(Convert.ToDecimal(Attributes[1]), Convert.ToDecimal(Attributes[2]), item);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddItemQutantityByName/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Name = ?", Attributes[0]).First;
                if (item == null)
                {
                    bool Result = ThePrimeBaby.Database.Base.Item.AddItemQutantity(Attributes[0], Convert.ToInt32(Attributes[1]),item);
                    return 200;
                }
                else
                { return 300; }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            
            Handle.POST("/ThePrimeBaby/ModifyItemsByName/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Code = ?", Attributes[0]).First;
                if (item != null)
                {
                    bool Result = Database.Base.Item.ModifyItemPriceByName(Attributes[0], Convert.ToDecimal(Attributes[1]),item);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyItemsById/9", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Id = ?", Convert.ToInt32(Attributes[0])).First;
                if (item != null)
                {
                    bool Result = Database.Base.Item.ModifyItems(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Attributes[4], Attributes[5], Attributes[6], Attributes[7], Convert.ToInt32(Attributes[8]),item);
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/DeleteItemByName", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.Transact(() => { Db.SlowSQL("DELETE FROM Item v WHERE v.Name = ?", Attributes[0]); });
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.POST("/ThePrimeBaby/AddItem/7", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Code = ?", Attributes[0]).First;
                if (item == null)
                {
                    Database.Base.Category category = Db.SQL<Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c WHERE c.NAME = ?", Attributes[6]).First;
                    if (category == null)
                    {
                        Db.Transact(() => 
                        {
                            category = new Database.Base.Category();
                            category.NAME = Attributes[6];
                        });
                    }
                    bool Result = ThePrimeBaby.Database.Base.Item.AddItem(Attributes[0], Attributes[1], Convert.ToInt32(Attributes[2]), Convert.ToDecimal(Attributes[3]), Convert.ToDecimal(Attributes[4]), Attributes[5], category);
                    if (Result == true)
                        return 200;
                }
                else
                    return 300;
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
