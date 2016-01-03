using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrimeBaby.Database.Base
{
    class DatabaseIndexes
    {
        internal static void CreateIndexes()
        {
            try
            {
                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDetailIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX BillDetailIndex ON BillDetail (Item , Bill, Id)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX BillIndex ON Bill (Customer,DATED,ID)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX CustomerIndex ON ThePrimeBaby.Database.Customer (Name, ID)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerVoucherIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX CustomerVoucherIndex ON CustomerVoucher (Customer, DATED, ID)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX ShipmentIndex ON Shipment (Vendor ,DATED ,ID)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentdetailIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX ShipmentdetailIndex ON Shipmentdetail (Shipment, Item )"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX VendorIndex ON Vendor (ID, NAME)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorVoucherIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX VendorVoucherIndex ON VendorVoucher (Vendor , DATED , ID)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CategoryIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX CategoryIndex ON ThePrimeBaby.Database.Base.Category (Name)"); }

                if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ItemIndex").First == null)
                { Starcounter.Db.SQL("CREATE INDEX ItemIndex ON Item (Id , Code)"); }
            }
            catch (Exception ex)
            {
 
            }
        }
    }
}
