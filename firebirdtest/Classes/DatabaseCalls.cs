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
                //System.IO.File.WriteAllText(@"H:\SC_Inventory\JsonBefore.txt", NestedJson);
                //System.IO.File.WriteAllText(@"H:\SC_Inventory\JsonAfter.txt", PlainJson);
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
                while (TableName != "")
                {
                    string FindString = "";
                    if (TableName != null && TableName != "")
                    {
                        List<string> TableRows = firebirdtest.Classes.RandomAlgos.AllGroups(NestedJson, "{[^{]+\"[^:]+\":\\s*{([^}]+)}");
                        FindString = firebirdtest.Classes.RandomAlgos.Group1(NestedJson, "{[^{]+{[^{]+(\"[^:]+\":\\s*{[^}]+})");
                        foreach (string TableRow in TableRows)
                        {
                            List<string> Subtables = firebirdtest.Classes.RandomAlgos.AllGroups(TableRow, "\\s*\"([^,|}]+)+");



                            foreach (string SubtableRow in Subtables)
                            {
                                ReplaceString += "\"" + TableName + SubtableRow + ",";
                            }
                            ReplaceString = ReplaceString.Remove(ReplaceString.Length - 1);
                            //NestedJson = ReplaceFirst(NestedJson, FindString, ReplaceString);
                            NestedJson = NestedJson.Replace(FindString, ReplaceString);
                            ReplaceString = "";
                        }
                        FindString = "";
                        //TableName = "";
                    }
                    TableName = firebirdtest.Classes.RandomAlgos.Group1(NestedJson, "{[^{]+{[^{]+\"([^:]+)\":\\s*{");
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
        internal static string AddVendor(string Name, string address, string phone, string email, int ballance_limit, int opening_balance,string BusinessName)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddVendor/7", Name + "/" + address + "/" + phone + "/" + email + "/" + ballance_limit + "/" + opening_balance + "/" + BusinessName);
        }
        internal static string ModifyVendor(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount, string BusinessName)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyVendor/8", FindID + "/" + ReplaceName + "/" + ReplaceAddress + "/" + ReplacePhone + "/" + ReplaceEmail + "/" + ReplaceOpening_balance + "/" + CalculatedAmount + "/" + BusinessName);
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
        internal static DataSet GetVendorByName(String Name)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendorByName/" + Name);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetCustomerByName(String Name)
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
            return  GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendorById/" + ID);
            //return JsonToDataSet(Result);
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
        internal static string AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance, string BusinessName)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddCustomer/7", Name + "/" + address + "/" + phone + "/" + email + "/" + ballance_limit + "/" + opening_balance + "/" + BusinessName);
        }
        internal static string ModifyCustomer(string Find, string Replace)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyCustomer/2", Find+ "/" + Replace);
        }
        internal static string ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount, string BusinessName)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyCustomer/8", FindID + "/" + ReplaceName + "/" + ReplaceAddress + "/" + ReplacePhone + "/" + ReplaceEmail + "/" + ReplaceOpening_balance + "/" + CalculatedAmount + "/" + BusinessName);
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
        internal static string AddItem(string Code, String Model, int QTY_Box, decimal Price, decimal CostPrice, String ImagePath, string ItemCategory, decimal RetailPrice)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddItem/8", Code + "/" + Model + "/" + QTY_Box + "/" + Price + "/" + CostPrice + "/" + ImagePath + "/" + ItemCategory + "/" + RetailPrice);
        }
        internal static string DeleteItem(string Name)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteItemByName", Name);
        }
        internal static string ModifyItems(string FindName, string ReplaceName)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyItemsByName/2", FindName + "/" + ReplaceName);
        }
        internal static string ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, string ReplaceImage, string ItemCategory, int T_Quantity, string RetailPrice)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyItemsById/10", FindID + "/" + ReplaceName + "/" + ReplaceModel + "/" + ReplaceQuantity + "/" + ReplacePrice + "/" + ReplaceCostPrice + "/" + ReplaceImage + "/" + ItemCategory + "/" + T_Quantity + "/" + RetailPrice);
        }
        internal static string AddCategory(string ItemCategory)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddCategory" , ItemCategory);
        }
        //internal static string AddItemQutantity(string ItemName, int ItemQuantity)
        //{
        //    return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddItemQutantityByName/2", ItemName + "/" + ItemQuantity);
        //}
        internal static string ModifyItemPrice(string ItemName, decimal ItemCostPrice,decimal ItemPrice)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyItemPrice/3", ItemName + "/" + ItemCostPrice + "/" + ItemPrice);
        }

        //Shipments
        internal static string AddShipment(string ShipmentNumber, DateTime ShipmentDate,int VendorId)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddShipmentByNumber/4" , ShipmentNumber + "/" + ShipmentDate.ToString().Replace('/', '-')+"/"+VendorId+"/Remarks");
        }
        internal static string ModifyShipment(string FindID, DateTime ShipmentDate, string ShipmentDesc)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyShipmentById/3", FindID + "/" + ShipmentDate.ToString().Replace('/', '-') + "/" + ShipmentDesc);
        }
        internal static string AddShipmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/AddShipmentDetailByItemName/8" , ItemName + "/" + ShipID + "/" + T_QUANTITY + "/" + QTY_PER_BOX+"/"+MODEL+"/"+CTN+"/"+PRICE+"/"+SUBTOTAL);
        }

        //Bill
        internal static string AddBill(int BillID, int CustomerID, DateTime BillDate, string Remarks)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddBill/4", BillID + "/" + CustomerID + "/" + BillDate.ToString().Replace('/', '-') + "/" + Remarks);
        }
        internal static string AddBillDetail(string ItemName, string BillID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddBillDetailByItemName/8", ItemName + "/" + BillID + "/" + T_QUANTITY + "/" + QTY_PER_BOX + "/" + MODEL + "/" + CTN + "/" + PRICE + "/" + SUBTOTAL);
        }
        internal static string DeleteBill(string BillID)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteBillByBillID", BillID);
        }
        internal static string DeleteBillDetails(string BillID)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/DeleteBillDetailsByBillID" , BillID);
        }
        internal static string ModifyBillAmmount(int BillID, decimal CustomerBalance)
        {
            return POST("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/ModifyBillAmmountByBillID" , BillID + "/" + CustomerBalance);
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
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyShipmentAmmountByShipmentNumber", ID + "/" + UpdateAmount + "/" + UpdateCUSTOMER_BALANCE);
        }

        //Get Calls
        internal static decimal GetCurrentRowBalance(string CustomerID, string BillID)
        {
            decimal CalulateBalance = 0;
            DataSet _BillDataSet = GetBill(BillID);
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
                        if (Convert.ToInt32(BillID) == Convert.ToInt32(BillRow["ID"]))
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
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVouchers");
            //return JsonToDataSet(Result);
        }
        internal static DataSet Get_Ctn_Bill()
        {
            return GET("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/Get_Ctn_Bill");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetItems(String ItemField)
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
        internal static DataSet GetShipments()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetShipments");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetShipmentDetails()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetShipmentDetails");
            //return JsonToDataSet(Result);
        }
        internal static string GetNewBillID()
        {
            return GET_String("http://"+global::firebirdtest.Properties.Settings.Default.SC_Server+"/ThePrimeBaby/GetNewBillID");
        }
        internal static DataSet GetBills()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBills");
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBillsInvoice(string BillID)
        {
            ///ThePrimeBaby/GetBillInvoice/{?}
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/"+BillID);
            //return JsonToDataSet(Result);
        }

        internal static DataSet GetBill(string BillID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillByBillID/" + BillID);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetShipment(string ShipmentNumber)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetShipmentByShipmentNumber/" + ShipmentNumber);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBillsbyCustomer(string CustomerID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillsbyCustomerById/" + CustomerID);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetBillDetails(string BillID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillDetailsByBillID/" + BillID);
            //return JsonToDataSet(Result);
        }
        internal static DataSet GetShipmentDetails(string ShipmentID)
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetShipmentDetailsByShipmentId/" + ShipmentID);
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

        internal static string GetNewShipmentNumber()
        {
            return GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetNewShipmentNumber");
        }

        internal static string GetNewBillNumber()
        {
            return GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetNewBillID");
        }

        internal static string GetVendorName(int ID)
        {
            return GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendorName/" + ID);
        }

        internal static string DeleteShipmentDetails(string ShipmentNumber)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/DeleteShipmentDetailsByShipmentNumber", ShipmentNumber);
        }

        internal static DataSet GetItems()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetItems");
        }

        internal static string AddShipment(int ShipmentNumber, int VendorID, DateTime ShipmentDate, string Remarks)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddShipment/4", ShipmentNumber + "/" + VendorID + "/" + ShipmentDate.ToString().Replace('/', '-') + "/" + Remarks);
        }

        internal static void DeleteEverything()
        {
            try
            {
                GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/DeveloperTools");
            }
            catch (Exception ex)
            { }
            GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/DelAll");
        }

        internal static DataSet Get_Ctn_Voucher()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/Get_Ctn_Voucher");
        }

        internal static string AddVendorVoucherPayment(int VendorID, DateTime BillDate, Decimal BillTotal, string Remarks)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddVendorVoucher/4", VendorID + "/" + BillDate.ToString().Replace('/', '-') + "/" + BillTotal + "/" + Remarks);
        }

        internal static DataSet GetVendorVoucher()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetVendorVouchers");

        }

        internal static DataSet GetCustomerVoucher()
        {
            return GET("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCustomerVouchers");

        }

        internal static string UpdateVendorVoucherPayment(int VendorID, DateTime BillDate, Decimal BillTotal, string Remarks,string VoucherNumber)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyVendorVoucher/5", VendorID + "/" + BillDate.ToString().Replace('/', '-') + "/" + BillTotal + "/" + Remarks + "/" + VoucherNumber);
        }

        internal static string AddCustomerVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/AddCustomerVoucher/4", CustomerID + "/" + BillDate.ToString().Replace('/', '-') + "/" + BillTotal + "/" + Remarks);
        }

        internal static string UpdateCustomerVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, string VoucherNumber)
        {
            return POST("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/ModifyCustomerVoucher/5", CustomerID + "/" + BillDate.ToString().Replace('/', '-') + "/" + BillTotal + "/" + Remarks + "/" + VoucherNumber);
        }
    }
}
