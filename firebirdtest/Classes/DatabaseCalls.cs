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
        public static string GET(string url)
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
        public static string PUT(string url, string attributes)
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

        //Vendor
        internal static string GetVendors()
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetVendor","");
        }
        internal static string AddVendor(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            //TODO Send Attributes
            return POST("http://OMER:9090/ThePrimeBaby/AddVendor/" + Name + "/" + address + "/" + phone + "/" + email, "");
        }

        //Customer
        internal static string AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            //TODO Send Attributes
            return POST("http://OMER:9090/ThePrimeBaby/AddCustomer/" + Name + "/" + address + "/" + phone + "/" + email, "");
        }
        internal static string ModifyCustomer(string Find, string Replace)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyCustomer/" + Find+ "/" + Replace, "");
        }
        internal static string ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            //TODO Send Attributes
            return POST("http://OMER:9090/ThePrimeBaby/ModifyCustomer/" + FindID + "/" + ReplaceName + "/" + ReplaceAddress + "/" + ReplacePhone, "");
        }
        internal static string ModifyCustomer(int CustomerID, decimal NewBalance)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyCustomer/" + CustomerID + "/" + NewBalance, "");
        }
        internal static string DeleteCustomer(string Name)
        {
            return POST("http://OMER:9090/ThePrimeBaby/DeleteCustomer/" + Name, "");
        }

        //Item
        internal static string AddItem(string Name, String Model, int QTY_Box, decimal Price, decimal CostPrice, String ImagePath, string ItemCategory)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyItems/" + Name + "/" + Model + "/" + QTY_Box + "/" + Price, "");
        }

        internal static string DeleteItem(string Name)
        {
            return POST("http://OMER:9090/ThePrimeBaby/DeleteItem/" + Name, "");
        }
        internal static string ModifyItems(string FindName, string ReplaceName)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyItems/" + FindName + "/" + ReplaceName, "");
        }
        internal static string ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, System.Windows.Forms.PictureBox ReplaceImage, string ItemCategory, int T_Quantity)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyItems/" + FindID + "/" + ReplaceName + "/" + ReplaceModel + "/" + ReplaceQuantity, "");
        }
        internal static string AddCategory(string ItemCategory)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddCategory/" + ItemCategory, "");
        }
        internal static string AddItemQutantity(string ItemName, int ItemQuantity)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddItemQutantity/" + ItemName + "/" + ItemQuantity, "");
        }
        internal static string ModifyItemPrice(string ItemName, decimal ItemPrice)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyItemPrice/" + ItemName + "/" + ItemPrice, "");
        }

        //Consignments
        internal static string AddConsignment(string ConsignmentNumber, DateTime ConsignmentDate)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddConsignment/" + ConsignmentNumber + "/" + ConsignmentDate, "");
        }
        internal static string ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyConsignment/" + FindID + "/" + ConsignmentDate + "/" + ConsignmentDesc, "");
        }
        internal static string AddConsignmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddConsignmentDetail/" + ItemName + "/" + ShipID + "/" + T_QUANTITY + "/" + QTY_PER_BOX, "");
        }

        //Bill
        internal static string AddBill(int BillNumber, int CustomerID, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddBill/" + BillNumber + "/" + CustomerID + "/" + BillDate + "/" + BillTotal, "");
        }
        internal static string DeleteBill(string BillNumber)
        {
            return POST("http://OMER:9090/ThePrimeBaby/DeleteBill/" + BillNumber, "");
        }
        internal static string DeleteBillDetails(string BillNumber)
        {
            return POST("http://OMER:9090/ThePrimeBaby/DeleteBillDetails/" + BillNumber, "");
        }
        internal static string ModifyBillAmmount(int BillNumber, decimal CustomerBalance)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyBillAmmount/" + BillNumber + "/" + CustomerBalance, "");
        }

        //Sale
        internal static string AddSale(decimal UnitPrice, int QTY, int BILL_ID, decimal SUBTOTAL, String ITEM_CODE, string ITEM_NAME, int PCS_CTN, int QUANT, int CUSTOMER_ID)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddSale/" + UnitPrice + "/" + QTY + "/" + BILL_ID + "/" + SUBTOTAL, "");
        }
        internal static string AddVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            return POST("http://OMER:9090/ThePrimeBaby/AddVoucherPayment/" + CustomerID + "/" + BillDate + "/" + BillTotal + "/" + Remarks + "/" + CustomerBalance, "");
        }
        internal static string ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
        {
            return POST("http://OMER:9090/ThePrimeBaby/ModifyVoucher/" + ID + "/" + UpdateAmount + "/" + UpdateCUSTOMER_BALANCE, "");
        }

        //Get Calls
        internal static string GetCurrentRowBalance(string CustomerID, string Billnumber)
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetCurrentRowBalance/" + CustomerID + "/" + Billnumber, "");
        }
        internal static DataSet GetLedger(string CustomerID)
        {
            string Result =  POST("http://OMER:9090/ThePrimeBaby/GetLedger/" + CustomerID, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetVouchers()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetVouchers", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet Get_Ctn_Bill()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/Get_Ctn_Bill", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetCustomers()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetCustomers", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetCustomer(String Name)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetCustomer/" + Name, "");
            return JsonToDataSet(Result);
        }
        internal static string GetCustomerName(int ID)
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetCustomerName/" + ID, "");
        }
        internal static DataSet GetCustomer(int ID)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetCustomer/" + ID, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItems()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItems" , "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItems(String ItemField)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItems/"+ItemField, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetCategory()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetCategory", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemDetails(string FindTable, string FindString)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemDetails/" + FindTable + "/" + FindString, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemHistory(string ItemCode)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemHistory/" + ItemCode, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemSaleHistory(string p)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemSaleHistory/" + p, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemShipmentHistory(string p)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemShipmentHistory/" + p, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForSale()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemsForSale", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetItemsForBill()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetItemsForBill" , "");
            return JsonToDataSet(Result);
        }
        internal static string GetItemCount(string ItemCode)
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetItemCount/" + ItemCode, "");
        }
        internal static DataSet GetInventoryDetails()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetInventoryDetails", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignments()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetConsignments", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetConsignmentDetails()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetConsignmentDetails", "");
            return JsonToDataSet(Result);
        }
        internal static string GetNewBillNumber()
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetNewBillNumber" , "");
        }
        internal static DataSet GetBills()
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetBills", "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBill(string BillNumber)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetBill/" + BillNumber, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBillsbyCustomer(string CustomerID)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetBillsbyCustomer/" + CustomerID, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetBillDetails(string BillNumber)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetBillDetails/" + BillNumber, "");
            return JsonToDataSet(Result);
        }
        internal static DataSet GetSale(string Bill_ID)
        {
            string Result = POST("http://OMER:9090/ThePrimeBaby/GetSale/" + Bill_ID, "");
            return JsonToDataSet(Result);
        }
        internal static string GetNewVoucherNumber()
        {
            return POST("http://OMER:9090/ThePrimeBaby/GetNewVoucherNumber", "");
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
