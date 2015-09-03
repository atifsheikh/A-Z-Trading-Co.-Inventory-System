using Starcounter;
using System;

namespace ThePrimeBaby.Database.Base
{
    public class Item : Concept
    {
        public int QTY_BOX;
        public int COSTPRICE;
        public int PRICE;
        public int IMAGE;
        public string MODEL;
        public string CODE;
        public int T_QUANTITY;


        internal static bool AddItem(string Name, string Model, int QTY_Box, decimal Price, string ImagePath, string ItemCategory)
        {
            try
            {
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyItems(string FindName, string ReplaceName)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceImage, string ItemCategory, int T_Quantity)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool ModifyItemPrice(string ItemName, decimal ItemPrice)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static bool AddItemQutantity(string ItemName, int ItemQuantity)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
