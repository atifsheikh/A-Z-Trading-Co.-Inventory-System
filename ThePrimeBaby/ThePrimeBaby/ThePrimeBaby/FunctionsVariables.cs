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

namespace ThePrimeBaby
{
    public static class FunctionsVariables
    {
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
