using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;

namespace firebirdtest
{
    class DatabaseCalls
    {
        //internal static DataSet GetItemHistory(string ItemCode)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from ITEMHISTORY where ITEM_CODE = '" + ItemCode + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetItemSaleHistory(string p)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();
        //        FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT SALE.ID, SALE.QTY, SALE.BILL_ID, SALE.ITEM_CODE, SALE.ITEM_NAME, SALE.PCS_CTN, SALE.T_QUANTITY, SALE.UNITPRICE, SALE.SUBTOTAL, CUSTOMERS.NAME , BILL.DATED from SALE,CUSTOMERS,BILL where ITEM_CODE = '" + p + "' AND CUSTOMERS.ID = SALE.CUSTOMER_ID AND SALE.BILL_ID > 0 AND SALE.BILL_ID = BILL.ID", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetItemShipmentHistory(string p)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();


        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select a.ID, a.SHIP_ID, a.ITEM_CODE, a.T_QUANTITY, a.QTY_PER_BOX, a.MODEL, a.CTN, a.PRICE, a.SUBTOTAL ,b.SHIP_DATE from SHIPMENT_DETAIL a,SHIPMENT b where ITEM_CODE = '" + p + "' AND a.SHIP_ID = b.ID", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetItemsForSale()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, a.QTY_BOX, a.PRICE, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)) as Quantity, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) as CTN_LEFT, a.CODE, a.MODEL FROM ITEMINVENTORY a where ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) > 0", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;


        //    throw new NotImplementedException();
        //}
        //internal static DataSet GetItemsForBill()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0", myConnection1);
        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;


        //    throw new NotImplementedException();
        //}
        //internal static int GetItemCount(string ItemCode)
        //{
        //    FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //    try
        //    {
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT SALECTN, SHIPCTN, SALEQUANTITY, SHIPMENTQUANTITY FROM ITEMINVENTORY WHERE (CODE = '" + ItemCode + "')", myConnection1);
        //        //"Select SALEQUANTITY,SHIPMENTQUANTITY from ITEMINVENTORY where CODE = '" + p + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();//=Fields!SHIPCTN.Value- Fields!SALECTN.Value
        //        return Convert.ToInt32(myDataSet.Tables[0].Rows[0]["SHIPCTN"]) - Convert.ToInt32(myDataSet.Tables[0].Rows[0]["SALECTN"]);
        //    }
        //    catch (Exception ex)
        //    {
        //        myConnection1.Close();
        //        return 0;
        //    }
        //}
        //internal static DataSet GetInventoryDetails()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet ItemDataSet = new DataSet();
        //        FbDataAdapter ItemDataAdapter = new FbDataAdapter("Select * from ITEM", myConnection1);
        //        ItemDataAdapter.Fill(ItemDataSet);
        //        ItemDataSet.Tables[0].Columns.Add("Total Quantity", typeof(string));
        //        ItemDataSet.Tables[0].Columns[7].SetOrdinal(2);

        //        DataSet SaleDataSet = new DataSet();
        //        FbDataAdapter SaleDataAdapter = new FbDataAdapter("Select ITEM_CODE, QTY from SALE", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);
        //        SaleDataAdapter.Fill(SaleDataSet);

        //        DataSet ShipmentDataSet = new DataSet();
        //        FbDataAdapter ShipmentDataAdapter = new FbDataAdapter("Select ITEM_CODE, T_QUANTITY from SHIPMENT_DETAIL", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);
        //        ShipmentDataAdapter.Fill(ShipmentDataSet);
        //        myConnection1.Close();

        //        for (int loop = 0; loop < ItemDataSet.Tables[0].Rows.Count; loop++)// DataRow ItemDataRow in ItemDataSet.Tables[0].Rows)
        //        {
        //            string SalesCount = "0";
        //            foreach (DataRow SalesRow in SaleDataSet.Tables[0].Rows)
        //            {
        //                if (SalesRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
        //                    SalesCount = SalesRow["QTY"].ToString();
        //            }

        //            string ShipmentCount = "0";
        //            foreach (DataRow ShipmentRow in ShipmentDataSet.Tables[0].Rows)
        //            {
        //                if (ShipmentRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
        //                    ShipmentCount = ShipmentRow["T_QUANTITY"].ToString();
        //            }

        //            int TotalCount = Convert.ToInt32(ShipmentCount) - Convert.ToInt32(SalesCount);
        //            ItemDataSet.Tables[0].Rows[loop]["Total Quantity"] = TotalCount.ToString();
        //        }
        //        return ItemDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetConsignments()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SHIPMENT", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetConsignmentDetails()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SHIPMENT_DETAIL", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static int GetNewBillNumber()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();
        //        DataSet myDataSet = new DataSet();
        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from BILL", myConnection1);
        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();
        //        if (myDataSet.Tables[0].Rows[0].ItemArray[0].ToString() == "")
        //            return 0;
        //        return Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0].ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return 0;
        //}
        //internal static DataSet GetBills()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, b.NAME, a.DATED, a.AMOUNT, a.REMARKS, a.CUSTOMER_BALANCE,a.CUSTOMER_ID  FROM BILL a,CUSTOMERS b where a.CUSTOMER_ID = b.ID ORDER BY ID DESC", myConnection1);//"Select * from BILL ORDER BY ID DESC", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetBill(string BillNumber)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where ID = '" + BillNumber + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetBillsbyCustomer(string CustomerID)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where CUSTOMER_ID = '" + CustomerID + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetBillDetails(string BillNumber)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where ID = '" + BillNumber + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static DataSet GetSale(string Bill_ID)
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();

        //        DataSet myDataSet = new DataSet();

        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SALE WHERE BILL_ID = '" + Bill_ID + "'", myConnection1);

        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();

        //        return myDataSet;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return null;
        //}
        //internal static int GetNewVoucherNumber()
        //{
        //    try
        //    {
        //        FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
        //        myConnection1.Open();
        //        DataSet myDataSet = new DataSet();
        //        FbDataAdapter myDataAdapter = new FbDataAdapter("Select MIN(ID) from BILL", myConnection1);
        //        myDataAdapter.Fill(myDataSet);
        //        myConnection1.Close();
        //        if (myDataSet.Tables[0].Rows[0].ItemArray[0].ToString() == "")
        //            return 0;
        //        return Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0].ToString()) - 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        Variables.NotificationMessageText = ex.Message;
        //        Variables.NotificationMessageTitle = "DB Call";
        //        Variables.NotificationStatus = true;
        //    }
        //    return 0;
        //}
    }
}
