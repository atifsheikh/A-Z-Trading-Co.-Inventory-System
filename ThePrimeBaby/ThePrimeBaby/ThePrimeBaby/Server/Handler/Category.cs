using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Category
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetCategory", (Request r) =>
            {
                QueryResultRows<Database.Base.Category> category = Db.SQL<Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c");
                CategoryJson categoryJson = new CategoryJson();
                categoryJson.Categories.Data = category;
                return categoryJson;

            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddCategory", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Database.Base.Category category = Db.SQL<Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c WHERE c.Name = ?", Attributes[0]).First;
                if (category == null)
                {
                    bool Result = ThePrimeBaby.Database.Base.Category.AddCategory(Attributes[0]);
                    if (Result == true)
                        return 200;
                }
                return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}