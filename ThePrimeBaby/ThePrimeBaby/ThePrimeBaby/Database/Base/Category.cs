using Starcounter;
using System;

namespace ThePrimeBaby.Database.Base
{
    public class Category : Concept
    {
        internal static bool AddCategory(string ItemCategory)
        {
            try
            {
                Db.Transact(() => 
                {
                    Category category = new Category();
                    category.Name = ItemCategory;
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
