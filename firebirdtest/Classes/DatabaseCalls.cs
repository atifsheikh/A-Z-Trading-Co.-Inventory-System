using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "Database Side Error";
                Variables.NotificationMessageText = ex.Message;
                Variables.DisplayTime = 5000;
                return "{}";
            }
        }

        public static string GET_String(string url)
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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "Database Side Error";
                Variables.NotificationMessageText = ex.Message;
                Variables.DisplayTime = 5000;
                return null;
            }
        }

        public static DataSet GET(string url)
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
                string NestedJson = response.ToString().TrimEnd();
                string PlainJson = RemoveNestedJson(NestedJson);
                return JsonConvert.DeserializeObject<DataSet>(PlainJson);
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "Database Side Error";
                Variables.NotificationMessageText = ex.Message;
                Variables.DisplayTime = 5000;
                return new DataSet();
            }
        }

        public static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        private static string RemoveNestedJson(string NestedJson)
        {
            try
            {
                string ReplaceString = "";
                string TableName = firebirdtest.Classes.RandomAlgos.Group1(NestedJson, "{[^{]+{[^{]+\"([^:]+)\":\\s*{");
                string FindString = "";
                if (TableName != null && TableName != "")
                {
                    List<string> TableRows = firebirdtest.Classes.RandomAlgos.AllGroups(NestedJson, "{[^{]+\"[^:]+\":\\s*{([^}]+)}");
                    foreach (string TableRow in TableRows)
                    {
                        List<string> Subtables = firebirdtest.Classes.RandomAlgos.AllGroups(TableRow, "\\s*\"([^,|}]+)+");

                        FindString = firebirdtest.Classes.RandomAlgos.Group1(NestedJson, "{[^{]+{[^{]+(\"[^:]+\":\\s*{[^}]+})");
                        

                        foreach (string SubtableRow in Subtables)
                        {
                            ReplaceString += "\"" + TableName + SubtableRow + ",";
                        }
                        ReplaceString = ReplaceString.Remove(ReplaceString.Length - 1);
                        NestedJson = ReplaceFirst(NestedJson, FindString, ReplaceString);
                        FindString = "";
                        ReplaceString = "";
                    }
                }
                return NestedJson;
            }
            catch (Exception ex)
            {
                return NestedJson;
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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "Database Side Error";
                Variables.NotificationMessageText = ex.Message;
                Variables.DisplayTime = 5000;
                return null;
            }
        }

        //Vendor
        internal static DataSet GetVendors()
        {
            return DatabaseCalls.GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendors");
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
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomers");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetCustomer(String Name)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerByName/" + Name);
            //return JsonToDataSet(Result);
        }
        internal static string GetCustomerName(int ID)
        {
            return GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerName/" + ID);
        }
        internal static DataSet GetVendor(int ID)
        {
            string Result = POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendorById/" + ID, "");
            return JsonToDataSet(Result);
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
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddCustomer/6", Name + "/" + address + "/" + phone + "/" + email+ "/" + ballance_limit+ "/" + opening_balance);
        }
        internal static string ModifyCustomer(string Find, string Replace)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyCustomer/2", Find+ "/" + Replace);
        }
        internal static string ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
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
        internal static string AddItem(string Code, String Model, int QTY_Box, decimal Price, decimal CostPrice, String ImagePath, string ItemCategory)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddItem/7", Code + "/" + Model + "/" + QTY_Box + "/" + Price+"/"+CostPrice+"/"+ImagePath+"/"+ItemCategory);
        }
        internal static string DeleteItem(string Name)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteItemByName", Name);
        }
        internal static string ModifyItems(string FindName, string ReplaceName)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyItemsByName/2", FindName + "/" + ReplaceName);
        }
        internal static string ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, string ReplaceImage, string ItemCategory, int T_Quantity)
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
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddConsignmentByNumber/2" + ConsignmentNumber + "/" + ConsignmentDate.ToString().Replace('/', '-'), "");
        }
        internal static string ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyConsignmentById/3", FindID + "/" + ConsignmentDate.ToString().Replace('/', '-') + "/" + ConsignmentDesc);
        }
        internal static string AddConsignmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddConsignmentDetailByItemName/8" , ItemName + "/" + ShipID + "/" + T_QUANTITY + "/" + QTY_PER_BOX+"/"+MODEL+"/"+CTN+"/"+PRICE+"/"+SUBTOTAL);
        }

        //Bill
        internal static string AddBill(int BillNumber, int CustomerID, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddBill/6", BillNumber + "/" + CustomerID + "/" + BillDate.ToString().Replace('/','-') + "/" + BillTotal+ "/" + CustomerBalance+ "/" + Remarks);
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
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddSale/9", UnitPrice + "/" + QTY + "/" + BILL_ID + "/" + SUBTOTAL+ "/" +ITEM_CODE+ "/" +ITEM_NAME+ "/" +PCS_CTN+ "/" +QUANT+ "/" +CUSTOMER_ID);
        }
        internal static string AddVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddCustomerVoucherPayment", CustomerID + "/" + BillDate.ToString().Replace('/', '-') + "/" + BillTotal + "/" + Remarks + "/" + CustomerBalance);
        }
        internal static string ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyBillAmmountByBillNumber", ID + "/" + UpdateAmount + "/" + UpdateCUSTOMER_BALANCE);
        }

        //Get Calls
        internal static decimal GetCurrentRowBalance(string CustomerID, string Billnumber)
        {
            decimal CalulateBalance = 0;
            DataSet _BillDataSet = GetBill(Billnumber);
            try
            {
                if (_BillDataSet.Tables[0].Rows.Count == 0)
                {
                    DataSet _BillbyCustomerDataSet = GetBillsbyCustomer(CustomerID);
                    foreach (DataRow BillRow in _BillbyCustomerDataSet.Tables[0].Rows)
                    {
                        CalulateBalance += Convert.ToInt32(BillRow["AMOUNT"]);
                    }
                }
                else
                {
                    DataSet _BillbyCustomerDataSet = GetBillsbyCustomer(CustomerID);
                    foreach (DataRow BillRow in _BillbyCustomerDataSet.Tables[0].Rows)
                    {
                        CalulateBalance += Convert.ToInt32(BillRow["AMOUNT"]);
                        if (Convert.ToInt32(Billnumber) == Convert.ToInt32(BillRow["ID"]))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            } 
            return CalulateBalance;
        }
        internal static DataSet GetLedger(string CustomerID)
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetLedgerCustomerId/"+ CustomerID);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetVouchers()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBills");
            //return JsonToDataSet(Result);
        }
        internal static DataSet Get_Ctn_Bill()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/Get_Ctn_Bill");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItems()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItems");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItems (String ItemField)
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemsByName/"+ItemField);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetCategory()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCategory");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItemDetails(string FindTable, string FindString)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItemDetails/" + FindTable + "/" + FindString);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItemHistory(string ItemCode)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItemHistory/" + ItemCode);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItemSaleHistory(string p)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItemSaleHistory/" + p);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItemShipmentHistory(string p)
        {
            string Result = POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemShipmentHistory/" + p, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForSale()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItemsForSale");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForBill()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItemsForBill");
            //return JsonToDataSet(Result);
        }
        internal static string GetItemCount(string ItemCode)
        {
            return GET_String("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetItemCount/" + ItemCode);
        }
        internal static DataSet GetInventoryDetails()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetInventoryDetails");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignments()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetConsignments");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignmentDetails()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetConsignmentDetails");
            //return JsonToDataSet(Result);
        }
        internal static string GetNewBillNumber()
        {
            return GET_String("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetNewBillNumber");
        }
        internal static DataSet GetBills()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBills");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBill(string BillNumber)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillByBillNumber/" + BillNumber);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignment(string ConsignmentNumber)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetConsignmentByConsignmentNumber/" + ConsignmentNumber);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBillsbyCustomer(string CustomerID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillsbyCustomerById/" + CustomerID);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBillDetails(string BillNumber)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillDetailsByBillNumber/" + BillNumber);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetSale(string Bill_ID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetSaleByBillId/" + Bill_ID);
            //return JsonToDataSet(Result);
        }
        internal static string GetNewVoucherNumber()
        {
            return GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetNewCustomerVoucherNumber");
        }

        internal static DataSet JsonToDataSet(string jsonText)
        {
            DataSet jsonDataSet = new DataSet();
            try
            {
                //Deserialization of Json String to DataSet
                XmlDocument xd1 = new XmlDocument();
                xd1 = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonText);
                jsonDataSet.ReadXml(new XmlNodeReader(xd1));
            }
            catch (Exception ex)
            {
                if (jsonText == null)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = "No Response From DB Server";
                    Variables.NotificationMessageText = "Please Make sure that DB Server (http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + " is Up...?";
                    Variables.DisplayTime = 10000;
                }
            }
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
