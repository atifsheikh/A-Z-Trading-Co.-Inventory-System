using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Item
    {
        internal static void Register()
        {
            ///ThePrimeBaby/GetInventoryDetails
            Handle.GET("/ThePrimeBaby/GetInventoryDetails", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemCount/{?}
            Handle.GET("/ThePrimeBaby/GetItemCount/{?}", (string ItemCode, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemsForBill
            Handle.GET("/ThePrimeBaby/GetItemsForBill", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemsForSale
            Handle.GET("/ThePrimeBaby/GetItemsForSale", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemSaleHistory/{?}      ItemName
            Handle.GET("/ThePrimeBaby/GetItemSaleHistory/{?}", (string ItemName, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemHistory/{?}          ItemCode
            Handle.GET("/ThePrimeBaby/GetItemHistory/{?}", (string ItemCode, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemDetails/{?}/{?}      FindTable + "/" + FindString
            Handle.GET("/ThePrimeBaby/GetItemDetails/{?}/{?}", (string FindTable ,string FindString,Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItemsByName/{?} name
            Handle.GET("/ThePrimeBaby/GetItemsByName/{?}", (string ItemName, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetItems
            Handle.GET("/ThePrimeBaby/GetItems", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/Get_Ctn_Bill
            Handle.GET("/ThePrimeBaby/Get_Ctn_Bill", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetLedgerCustomerId
            Handle.GET("/ThePrimeBaby/GetLedgerCustomerId/{?}", (string CustomerId, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/GetCurrentRowBalanceByCustomerId
            Handle.GET("/ThePrimeBaby/GetCurrentRowBalanceByCustomerId/{?}/{?}", (string CustomerID, string Billnumber, Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            ///ThePrimeBaby/ModifyItemPrice
            Handle.POST("/ThePrimeBaby/ModifyItemPrice/2", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddItemQutantityByName/
            Handle.POST("/ThePrimeBaby/AddItemQutantityByName/2", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            
            ///ThePrimeBaby/ModifyItemsByName/2
            Handle.POST("/ThePrimeBaby/ModifyItemsByName/2", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/ModifyItemsById/9
            Handle.POST("/ThePrimeBaby/ModifyItemsById/9", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            ///ThePrimeBaby/AddItem/7
            Handle.POST("/ThePrimeBaby/AddItem/7", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            ///ThePrimeBaby/DeleteItemByName
            Handle.POST("/ThePrimeBaby/DeleteItemByName", (Request r) =>
            {
                //QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                //ItemJson itemJson = new ItemJson();
                //itemJson.Items.Data = item;
                //return itemJson;
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.GET("/ThePrimeBaby/GetItems", (Request r) =>
            {
                QueryResultRows<Database.Base.Item> item = Db.SQL<Database.Base.Item>("SELECT i FROM Item i");
                ItemJson itemJson = new ItemJson();
                itemJson.Items.Data = item;
                return itemJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddItem", (Request r) =>
            {
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
