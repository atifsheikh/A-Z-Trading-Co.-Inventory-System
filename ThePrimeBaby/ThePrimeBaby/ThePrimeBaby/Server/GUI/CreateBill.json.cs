using Starcounter;

namespace ThePrimeBaby.Server.GUI
{
    partial class CreateBill : Json
    {
        public QueryResultRows<Database.Customer> Customers_
        {
            get
            {
                if (!string.IsNullOrEmpty(this.CustomerSearchName))
                {
                    return Db.SQL<Database.Customer>("SELECT c FROM Customer c WHERE Name like ? fetch ?", "%" + this.CustomerSearchName + "%",10);
                }
                return null;
            }
        }



        public QueryResultRows<Database.Base.Item> Items_
        {
            get
            {
                if (!string.IsNullOrEmpty(this.SearchedItemCode))
                {
                    return Db.SQL<Database.Base.Item>("SELECT c FROM Item c WHERE Name like ? fetch ?", "%" + this.SearchedItemCode + "%",10);
                }
                return null;
            }
        }
    }
}
