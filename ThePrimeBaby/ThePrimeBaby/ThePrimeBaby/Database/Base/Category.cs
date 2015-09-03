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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
