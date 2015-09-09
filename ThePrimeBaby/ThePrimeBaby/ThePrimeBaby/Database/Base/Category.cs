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
                    category.NAME = ItemCategory;
                    category.ID = Convert.ToInt32((Int64)Db.SlowSQL("SELECT MAX(b.ID) FROM ThePrimeBaby.Database.Base.Category b").First) + 1; 
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
