using System.Data;
using System.Xml;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Net;
using Starcounter;

namespace ThePrimeBaby
{
    public static class FunctionsVariables
    {
        public static void Init_Data()
        {
            Db.Transact(() =>
            {
                ThePrimeBaby.Database.Base.Category category = Db.SQL<ThePrimeBaby.Database.Base.Category>("SELECT c FROM ThePrimeBaby.Database.Base.Category c").First;
                if (category == null)
                {
                    category = new Database.Base.Category();
                    category.ID = 0;
                }
                var item = Db.SQL<ThePrimeBaby.Database.Base.Item>("SELECT c FROM ThePrimeBaby.Database.Base.Item c").First;//Item
                if (item == null)
                {
                    item = new Database.Base.Item();
                    item.ID = 0;
                    item.NAME = "Admin";
                    item.MODEL = "Admin";
                    item.QTY_BOX = 0;
                    item.PRICE = 0;
                    item.IMAGE = "Admin";
                    item.CODE = "Admin";
                    item.Category = category;
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.Shipment>("SELECT c FROM ThePrimeBaby.Database.Shipment c").First;//Shipment
                    if (DbObject == null)
                    {
                        DbObject = new Database.Shipment();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.ShipmentDetail>("SELECT c FROM ThePrimeBaby.Database.ShipmentDetail c").First;//ShipmentDetail
                    if (DbObject == null)
                    {
                        DbObject = new Database.ShipmentDetail();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.Vendor>("SELECT c FROM ThePrimeBaby.Database.Vendor c").First;//Vendor
                    if (DbObject == null)
                    {
                        DbObject = new Database.Vendor();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.VendorVoucher>("SELECT c FROM ThePrimeBaby.Database.VendorVoucher c").First;//VendorVoucher
                    if (DbObject == null)
                    {
                        DbObject = new Database.VendorVoucher();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.Bill>("SELECT c FROM ThePrimeBaby.Database.Bill c").First;//Bill
                    if (DbObject == null)
                    {
                        DbObject = new Database.Bill();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.BillDetail>("SELECT c FROM ThePrimeBaby.Database.BillDetail c").First;//BillDetail
                    if (DbObject == null)
                    {
                        DbObject = new Database.BillDetail();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.Customer>("SELECT c FROM ThePrimeBaby.Database.Customer c").First;//Customer
                    if (DbObject == null)
                    {
                        DbObject = new Database.Customer();
                        DbObject.ID = 0;
                    }
                }
                {
                    var DbObject = Db.SQL<ThePrimeBaby.Database.CustomerVoucher>("SELECT c FROM ThePrimeBaby.Database.CustomerVoucher c").First;//CustomerVoucher
                    if (DbObject == null)
                    {
                        DbObject = new Database.CustomerVoucher();
                        DbObject.ID = 0;
                    }
                }
            });
        }

        public static DataSet JsonToDataSet(string jsonText)
        {
            //Deserialization of Json String to DataSet
            XmlDocument xd1 = new XmlDocument();
            xd1 = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonText);
            DataSet jsonDataSet = new DataSet();
            jsonDataSet.ReadXml(new XmlNodeReader(xd1));
            return jsonDataSet;
        }

        public static string DataSetToJson(DataSet dataSet)
        {
            //Serialization of DataSet to json string
            string json = JsonConvert.SerializeObject(dataSet, new DataSetConverter()); 
            return json;
        }

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


    }
}
