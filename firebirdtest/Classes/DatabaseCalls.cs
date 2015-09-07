using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Newtonsoft.Json;

namespace firebirdtest
{
    class DatabaseCalls
    {
        public static string POST(string url, string attributes)
        {
            try
            {

                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "POST";
                Stream postStream = request.GetRequestStream();
                var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
                postStream.Write(bytes1, 0, bytes1.Length);
                postStream.Close();

                // Get the response.
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string GET(string url)
        {
            try
            {
                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "GET";
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string PUT(string url, string attributes)
        {
            try
            {
                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "PUT";
                Stream postStream = request.GetRequestStream();
                var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
                postStream.Write(bytes1, 0, bytes1.Length);
                postStream.Close();

                // Get the response.
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Vendor
        internal static string GetVendors()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetVendors");
        }
        internal static string AddVendor(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddVendor/6" , Name + "/" + address + "/" + phone + "/" + email + "/" + ballance_limit+ "/" + opening_balance);
        }
        internal static string ModifyVendor(string Find, string Replace)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyVendor/2", Find + "/" + Replace);
        }
        internal static string ModifyVendor(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            //TODO Send Attributes
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyVendor/7", FindID + "/" + ReplaceName + "/" + ReplaceAddress + "/" + ReplacePhone + "/" + ReplaceEmail + "/" + ReplaceOpening_balance + "/" + CalculatedAmount);
        }
        internal static string ModifyVendorBalance(int VendorID, decimal NewBalance)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyVendorBalance/2", VendorID + "/" + NewBalance);
        }
        internal static string DeleteVendor(string Name)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/DeleteVendor",Name);
        }
        
        //Customer
        internal static DataSet GetCustomers()
        {
            string Result = GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomers");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetCustomer(String Name)
        {
            string Result = GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerByName/" + Name);
            return JsonToDataSet(Result);
        }
        internal static string GetCustomerName(int ID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerName/" + ID);
        }
        internal static DataSet GetCustomer(int ID)
        {
            string Result = POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerById/" + ID, "");
            return JsonToDataSet(Result);
        }
        //internal static string GetCustomers()
        //{
        //    return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomers", "");
        //}
        internal static string AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            //TODO Send Attributes
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddCustomer/6", Name + "/" + address + "/" + phone + "/" + email);
        }
        internal static string ModifyCustomer(string Find, string Replace)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyCustomer/2", Find+ "/" + Replace);
        }
        internal static string ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            //TODO Send Attributes
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyCustomer/7", FindID + "/" + ReplaceName + "/" + ReplaceAddress + "/" + ReplacePhone + "/" + ReplaceEmail + "/" + ReplaceOpening_balance + "/" + CalculatedAmount);
        }
        internal static string ModifyCustomer(int CustomerID, decimal NewBalance)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyCustomerById/2", CustomerID + "/" + NewBalance);
        }
        internal static string DeleteCustomer(string Name)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteCustomerByName", Name);
        }

        //Item
        internal static string AddItem(string Name, String Model, int QTY_Box, decimal Price, decimal CostPrice, String ImagePath, string ItemCategory)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddItem/7", Name + "/" + Model + "/" + QTY_Box + "/" + Price+"/"+CostPrice+"/"+ImagePath+"/"+ItemCategory);
        }
        internal static string DeleteItem(string Name)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteItemByName", Name);
        }
        internal static string ModifyItems(string FindName, string ReplaceName)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyItemsByName/2", FindName + "/" + ReplaceName);
        }
        internal static string ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, System.Windows.Forms.PictureBox ReplaceImage, string ItemCategory, int T_Quantity)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyItemsById/9", FindID + "/" + ReplaceName + "/" + ReplaceModel + "/" + ReplaceQuantity + "/" + ReplacePrice + "/" + ReplaceCostPrice + "/" + ReplaceImage + "/" + ItemCategory + "/" + T_Quantity);
        }
        internal static string AddCategory(string ItemCategory)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddCategory" , ItemCategory);
        }
        internal static string AddItemQutantity(string ItemName, int ItemQuantity)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddItemQutantityByName/2", ItemName + "/" + ItemQuantity);
        }
        internal static string ModifyItemPrice(string ItemName, decimal ItemPrice)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyItemPrice/2", ItemName + "/" + ItemPrice);
        }

        //Consignments
        internal static string AddConsignment(string ConsignmentNumber, DateTime ConsignmentDate)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddConsignmentByNumber/2" + ConsignmentNumber + "/" + ConsignmentDate, "");
        }
        internal static string ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyConsignmentById/3", FindID + "/" + ConsignmentDate + "/" + ConsignmentDesc);
        }
        internal static string AddConsignmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddConsignmentDetailByItemName/8" , ItemName + "/" + ShipID + "/" + T_QUANTITY + "/" + QTY_PER_BOX+"/"+MODEL+"/"+CTN+"/"+PRICE+"/"+SUBTOTAL);
        }

        //Bill
        internal static string AddBill(int BillNumber, int CustomerID, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddBill/6", BillNumber + "/" + CustomerID + "/" + BillDate + "/" + BillTotal+ "/" + CustomerBalance+ "/" + Remarks);
        }
        internal static string DeleteBill(string BillNumber)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteBillByBillNumber", BillNumber);
        }
        internal static string DeleteBillDetails(string BillNumber)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteBillDetailsByBillNumber" , BillNumber);
        }
        internal static string ModifyBillAmmount(int BillNumber, decimal CustomerBalance)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyBillAmmountByBillNumber" , BillNumber + "/" + CustomerBalance);
        }

        //Sale
        internal static string AddSale(decimal UnitPrice, int QTY, int BILL_ID, decimal SUBTOTAL, String ITEM_CODE, string ITEM_NAME, int PCS_CTN, int QUANT, int CUSTOMER_ID)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddSale/9", UnitPrice + "/" + QTY + "/" + BILL_ID + "/" + SUBTOTAL);
        }
        internal static string AddVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddCustomerVoucherPayment",CustomerID + "/" + BillDate + "/" + BillTotal + "/" + Remarks + "/" + CustomerBalance);
        }
        internal static string ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyCustomerVoucherById",  ID + "/" + UpdateAmount + "/" + UpdateCUSTOMER_BALANCE);
        }

        //Get Calls
        internal static string GetCurrentRowBalance(string CustomerID, string Billnumber)
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetCurrentRowBalanceByCustomerId/"  +CustomerID + "/" + Billnumber);
        }
        internal static DataSet GetLedger(string CustomerID)
        {
            string Result =  GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetLedgerCustomerId/"+ CustomerID);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetVouchers()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetCustomerVouchers");
            return JsonToDataSet(Result);
        }
        internal static DataSet Get_Ctn_Bill()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/Get_Ctn_Bill");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItems()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItems");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItems (String ItemField)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemsByName/"+ItemField);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetCategory()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetCategory");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemDetails(string FindTable, string FindString)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemDetails/" + FindTable + "/" + FindString);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemHistory(string ItemCode)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemHistory/" + ItemCode);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemSaleHistory(string p)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemSaleHistory/" + p);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemShipmentHistory(string p)
        {
            string Result = POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemShipmentHistory/" + p, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForSale()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemsForSale");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForBill()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemsForBill");
            return JsonToDataSet(Result);
        }
        internal static string GetItemCount(string ItemCode)
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemCount/" + ItemCode);
        }
        internal static DataSet GetInventoryDetails()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetInventoryDetails");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignments()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetConsignments");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignmentDetails()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetConsignmentDetails");
            return JsonToDataSet(Result);
        }
        internal static string GetNewBillNumber()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetNewBillNumber");
        }
        internal static DataSet GetBills()
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetBills");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBill(string BillNumber)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetBillByBillNumber/" + BillNumber);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBillsbyCustomer(string CustomerID)
        {
            string Result = GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillsbyCustomerById/" + CustomerID);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBillDetails(string BillNumber)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetBillDetailsByBillNumber/" + BillNumber);
            return JsonToDataSet(Result);
        }
        internal static DataSet GetSale(string Bill_ID)
        {
            string Result = GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetSaleByBillId/" + Bill_ID);
            return JsonToDataSet(Result);
        }
        internal static string GetNewVoucherNumber()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetNewCustomerVoucherNumber");
        }

        internal static DataSet JsonToDataSet(string jsonText)
        {
            //Deserialization of Json String to DataSet
            XmlDocument xd1 = new XmlDocument();
            xd1 = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonText);
            DataSet jsonDataSet = new DataSet();
            jsonDataSet.ReadXml(new XmlNodeReader(xd1)); 
            return jsonDataSet;
        }
        internal static string DataSetToJson(DataSet dataSet)
        {
            // Serialization of DataSet to json string
            //StringWriter sw = new StringWriter();
            //versionUpGetData.WriteXml(sw, XmlWriteMode.WriteSchema);
            //XmlDocument xd = new XmlDocument();
            //xd.LoadXml(sw.ToString());
            //String jsonText = JsonConvert.SerializeXmlNode(xd);
            //File.WriteAllText(“d:/datasetJson.txt”,jsonText); 
            return "";
        }
    }
}
