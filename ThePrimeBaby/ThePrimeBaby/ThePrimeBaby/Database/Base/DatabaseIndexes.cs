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
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDetailIdIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillDetailIdIndex ON BillDetail (Id)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDetailItemIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillDetailItemIndex ON BillDetail (Item)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDetailBillIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillDetailBillIndex ON BillDetail (Bill)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDetailIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillDetailIndex ON BillDetail (Item , Bill, Id)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillDATEDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillDATEDIndex ON Bill (DATED)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillCustomerIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillCustomerIndex ON Bill (Customer)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillIDIndex ON Bill (ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "BillIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX BillIndex ON Bill (Customer,DATED,ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerIDIndex ON ThePrimeBaby.Database.Customer (ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerNameIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerNameIndex ON ThePrimeBaby.Database.Customer (Name)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerIndex ON ThePrimeBaby.Database.Customer (Name, ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerVoucherIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerVoucherIDIndex ON CustomerVoucher (ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerVoucherDATEDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerVoucherDATEDIndex ON CustomerVoucher (DATED)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerVoucherCustomerIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerVoucherCustomerIndex ON CustomerVoucher (Customer)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CustomerVoucherIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CustomerVoucherIndex ON CustomerVoucher (Customer, DATED, ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentIDIndex ON Shipment (ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentDATEDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentDATEDIndex ON Shipment (DATED)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentVendorIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentVendorIndex ON Shipment (Vendor)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentIndex ON Shipment (Vendor ,DATED ,ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentdetailShipmentIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentdetailShipmentIndex ON Shipmentdetail (Shipment)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentdetailItemIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentdetailItemIndex ON Shipmentdetail (Item)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ShipmentdetailIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ShipmentdetailIndex ON Shipmentdetail (Shipment, Item )"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorNAMEIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorNAMEIndex ON Vendor (NAME)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorIDIndex ON Vendor (ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorIndex ON Vendor (ID, NAME)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorVoucherIDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorVoucherIDIndex ON VendorVoucher (ID)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorVoucherDATEDIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorVoucherDATEDIndex ON VendorVoucher (DATED)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorVoucherVendorIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorVoucherVendorIndex ON VendorVoucher (Vendor)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "VendorVoucherIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX VendorVoucherIndex ON VendorVoucher (Vendor , DATED , ID)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CategoryIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX CategoryIndex ON ThePrimeBaby.Database.Base.Category (Name)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ItemCodeIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ItemCodeIndex ON Item (Code)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ItemIdIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ItemIdIndex ON Item (Id)"); }

            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ItemIndex").First == null)
            { System.Threading.Thread.Sleep(5000); Starcounter.Db.SQL("CREATE INDEX ItemIndex ON Item (Id , Code)"); }
        }
    }
}
