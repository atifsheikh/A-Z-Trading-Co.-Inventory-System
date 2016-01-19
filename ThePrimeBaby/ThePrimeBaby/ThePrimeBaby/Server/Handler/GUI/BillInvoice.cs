using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrimeBaby.Server.GUI;

namespace ThePrimeBaby.Server.Handler.GUI
{
    public class BillInvoice
    {
        internal static void Register()
        {
            Handle.GET("/ThePrimeBaby/Invoice", (Request r) =>
            {
                CreateBill createbill = new CreateBill();
                createbill.Html = "";
                createbill.Customers = Db.SQL<Database.Customer>("SELECT c FROM Customer c");
                return "";
            });
        }
    }
}
