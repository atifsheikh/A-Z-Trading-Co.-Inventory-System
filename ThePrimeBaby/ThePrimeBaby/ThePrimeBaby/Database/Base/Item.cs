using Starcounter;
using System;

namespace ThePrimeBaby.Database.Base
{
    public class Item : Concept
    {
        public int QTY_BOX;
        public decimal COSTPRICE;
        public decimal PRICE;
        public string IMAGE;
        public string MODEL;
        public string CODE;
        public int T_QUANTITY;
        public Category Category;
        internal static bool AddItem(string Code, string Model, int QTY_Box, decimal Price,decimal CostPrice, string ImagePath, Category ItemCategory)
        {
            try
            {
                Db.Transact(() => {
                    Item item = new Item();
                    item.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Base.Item b").First) + 1; 
                    item.CODE = Code;
                    item.MODEL = Model;
                    item.QTY_BOX = QTY_Box;
                    item.PRICE = Price;
                    item.COSTPRICE = CostPrice;
                    item.IMAGE = ImagePath;
                    item.Category = ItemCategory;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool DeleteItem(string Name)
        {
            try
            {
                Db.Transact(() => 
                {
                    Db.SlowSQL("DELETE FROM Item Where i.Name = ?", Name);
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItems(string FindName, string ReplaceName, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Name = ?", FindName).First;
                Db.Transact(() => 
                {
                    item.NAME = ReplaceName;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItems(string FindID, string ReplaceCode, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, string ReplaceImage, string ItemCategory, int T_Quantity, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Id = ?", Convert.ToInt32(FindID)).First;
                Db.Transact(() =>
                {
                    item.ID = Convert.ToInt32(FindID);
                    item.CODE = ReplaceCode;
                    item.MODEL = ReplaceModel;
                    item.QTY_BOX= Convert.ToInt32(ReplaceQuantity);
                    item.PRICE= Convert.ToDecimal(ReplacePrice);
                    item.COSTPRICE = Convert.ToDecimal(ReplaceCostPrice);
                    item.IMAGE= ReplaceImage;
                    item.Category = Db.SQL<Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c WHERE c.Name = ?", ItemCategory).First;
                    if (item.Category == null)
                    {
                        item.Category = new Category();
                        item.Category.NAME = ItemCategory;
                    }
                    item.T_QUANTITY= T_Quantity;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItemPriceByName(string ItemName, decimal ItemPrice, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Name = ?", ItemName).First;
                Db.Transact(() =>
                {
                    item.PRICE = ItemPrice;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool ModifyItemPriceByCode(string ItemCode, decimal ItemPrice, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Code = ?", ItemCode).First;
                Db.Transact(() =>
                {
                    item.PRICE = ItemPrice;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal static bool AddItemQutantity(string ItemName, int ItemQuantity, Database.Base.Item item)
        {
            try
            {
                //Database.Base.Item item = Db.SQL<Database.Base.Item>("SELECT i FROM ThePrimeBaby.Database.Base.Item i WHERE i.Name = ?", ItemName).First;
                Db.Transact(() =>
                {
                    item.T_QUANTITY = ItemQuantity;
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
