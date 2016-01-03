using System;
using Starcounter;
using System.Data;
using System.Web;
using System.Text.RegularExpressions;

namespace ThePrimeBaby.Server.Handler
{
    public class Item
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetItemsForShipment", (Request r) =>
            {
                //"SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0"
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemsForBill", (Request r) =>
            {
                //"SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0"
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemsForSale", (Request r) =>
            {
                //SELECT a.ID, a.QTY_BOX, a.PRICE, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)) as Quantity, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) as CTN_LEFT, a.CODE, a.MODEL FROM ITEMINVENTORY a where ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) > 0
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemHistory/{?}", (string ItemCode, Request r) =>
            {
                //"Select * from ITEMHISTORY where ITEM_CODE = '" + ItemCode + "'", myConnection1);
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/Get_Ctn_Bill", (Request r) =>
            {
                //"Select * from CTN_BILL_SUM"
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            Handle.GET("/ThePrimeBaby/GetInventoryDetails", (Request r) =>
            {
                /*string Result = FunctionsVariables.GET("http://localhost:8080/ThePrimeBaby/GetItems");
                DataSet ItemDataSet = FunctionsVariables.JsonToDataSet(Result);

                Database.BillDetail sale = Db.SQL<Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c").First;
                Database.ShipmentDetail shipmentDetail = Db.SQL<Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c").First;
                Database.BillDetail billDetail = Db.SQL<Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c ").First;
                try
                {
                    FbDataAdapter ItemDataAdapter = new FbDataAdapter("Select * from ITEM", myConnection1);
                    ItemDataSet.Tables[0].Columns.Add("Total Quantity", typeof(string));
                    ItemDataSet.Tables[0].Columns[7].SetOrdinal(2);

                    FbDataAdapter SaleDataAdapter = new FbDataAdapter("Select ITEM_CODE, QTY from SALE", myConnection1);
                    FbDataAdapter ShipmentDataAdapter = new FbDataAdapter("Select ITEM_CODE, T_QUANTITY from SHIPMENT_DETAIL", myConnection1);

                    for (int loop = 0; loop < ItemDataSet.Tables[0].Rows.Count; loop++)
                    {
                        string SalesCount = "0";
                        foreach (DataRow SalesRow in SaleDataSet.Tables[0].Rows)
                        {
                            if (SalesRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                                SalesCount = SalesRow["QTY"].ToString();
                        }

                        string ShipmentCount = "0";
                        foreach (DataRow ShipmentRow in ShipmentDataSet.Tables[0].Rows)
                        {
                            if (ShipmentRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                                ShipmentCount = ShipmentRow["T_QUANTITY"].ToString();
                        }

                        int TotalCount = Convert.ToInt32(ShipmentCount) - Convert.ToInt32(SalesCount);
                        ItemDataSet.Tables[0].Rows[loop]["Total Quantity"] = TotalCount.ToString();
                    }*/
                return 444;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemCount/{?}", (string ItemCode, Request r) =>
            {
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Code = ?", HttpUtility.UrlDecode(ItemCode)).First;
                return item.T_QUANTITY;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetItemShipmentHistory/{?}", (string ItemName, Request r) =>
            {
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Code = ?", HttpUtility.UrlDecode(ItemName)).First;
                if (item != null)
                {
                    Regex regex = new Regex("(.*?)\\.");
                    Match match = regex.Match("");
                    
                    string tokenParsed = "oauth_token: " + match.Groups[1].Value;


                    QueryResultRows<IObjectView> ShipmentDetails = Db.SQL<IObjectView>("SELECT sd.Shipment.Id, sd.Item.code, sd.Item.model, sd.CTN, sd.QTY_PER_BOX, sd.T_QUANTITY, sd.PRICE, sd.SUBTOTAL, sd.Shipment.DATED from ShipmentDetail sd where sd.Item = ? AND sd.Shipment.Id > ?", item, 0);
                    ItemShipmentHistoryJson itemShipmentHistoryJson = new ItemShipmentHistoryJson();
                    foreach (IObjectView ShipmentDetail in ShipmentDetails)
                    {
                        var itemShipmentHistory = itemShipmentHistoryJson.ItemShipmentHistory.Add();
                        itemShipmentHistory.SHIP_ID = long.Parse(ShipmentDetail.GetString(0));
                        itemShipmentHistory.ITEM_CODE = ShipmentDetail.GetString(1);
                        itemShipmentHistory.MODEL = ShipmentDetail.GetString(2);
                        itemShipmentHistory.CTN = long.Parse(ShipmentDetail.GetString(3));
                        itemShipmentHistory.QTY_PER_BOX = long.Parse(ShipmentDetail.GetString(4));
                        itemShipmentHistory.T_QUANTITY = long.Parse(ShipmentDetail.GetString(5));
                        
                        match = regex.Match(ShipmentDetail.GetString(6));
                        itemShipmentHistory.PRICE = match.Groups[1].Value;
                        
                        match = regex.Match(ShipmentDetail.GetString(7));
                        itemShipmentHistory.SUBTOTAL = match.Groups[1].Value;
                        itemShipmentHistory.DATED = ShipmentDetail.GetString(8);
                    }
                    return itemShipmentHistoryJson;
                }
                else
                    return null;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.GET("/ThePrimeBaby/GetItemSaleHistory/{?}", (string ItemName, Request r) =>
            {
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c WHERE c.Code = ?", HttpUtility.UrlDecode(ItemName)).First;
                if (item != null)
                {
                    Regex regex = new Regex("(.*?)\\.");
                    Match match = regex.Match("");

                    QueryResultRows<IObjectView> billDetails = Db.SQL<IObjectView>("SELECT bd.ID, bd.ctn, bd.Bill.Id, bd.Item.code, bd.Item.model, bd.QTY_PER_BOX, bd.T_QUANTITY, bd.PRICE, bd.SUBTOTAL, bd.bill.Customer.NAME , bd.Bill.DATED FROM ThePrimeBaby.Database.BillDetail bd WHERE bd.Item = ? AND bd.Bill.Id > ?", item, 0);
                    ItemSaleHistoryJson itemSaleHistoryJson = new ItemSaleHistoryJson();
                    foreach (IObjectView billDetail in billDetails) 
                    {
                        var itemSaleHistory = itemSaleHistoryJson.ItemSaleHistory.Add();
                        itemSaleHistory.ID = long.Parse(billDetail.GetString(0));
                        itemSaleHistory.QTY = long.Parse(billDetail.GetString(1));
                        itemSaleHistory.BILL_ID = long.Parse(billDetail.GetString(2));
                        itemSaleHistory.ITEM_CODE= billDetail.GetString(3);
                        itemSaleHistory.ITEM_NAME= billDetail.GetString(4);
                        itemSaleHistory.PCS_CTN = long.Parse(billDetail.GetString(5));
                        itemSaleHistory.T_QUANTITY = long.Parse(billDetail.GetString(6));

                        match = regex.Match(billDetail.GetString(7));
                        itemSaleHistory.UNITPRICE = match.Groups[1].Value;

                        match = regex.Match(billDetail.GetString(8));
                        itemSaleHistory.SUBTOTAL = match.Groups[1].Value;
                        
                        itemSaleHistory.CUSTOMERS_NAME = billDetail.GetString(9);
                        itemSaleHistory.DATED = billDetail.GetString(10);
                    }
                    return itemSaleHistoryJson;
                }
                else 
                    return null;
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

            Handle.POST("/ThePrimeBaby/ModifyItemsById/10", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Id = ?", Convert.ToInt32(Attributes[0])).First;
                if (item != null)
                {
                    bool Result = Database.Base.Item.ModifyItems(Attributes[0], Attributes[1], Attributes[2], Attributes[4], Attributes[5], Attributes[6], Attributes[7], Convert.ToInt32(Attributes[8]), item, Attributes[9], Convert.ToBoolean(Attributes[10]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddItem/8", (Request r) =>
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
                    bool Result = ThePrimeBaby.Database.Base.Item.AddItem(Attributes[0], Attributes[1], Convert.ToInt32(Attributes[2]), Convert.ToDecimal(Attributes[3]), Convert.ToDecimal(Attributes[4]), Attributes[5], category, Convert.ToDecimal(Attributes[7]), Convert.ToBoolean(Attributes[8]));
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
