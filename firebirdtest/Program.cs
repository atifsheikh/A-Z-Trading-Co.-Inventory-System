using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using firebirdtest.DataSets;
using System.Xml;

namespace firebirdtest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string jsonstring = DatabaseCalls.GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/1");

                // To convert JSON text contained in string json into an XML node
                XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonstring);

                //string xmlString = "";
                //using (var stringWriter = new StringWriter())
                //using (var xmlTextWriter = XmlWriter.Create(stringWriter))
                //{
                //    doc.WriteTo(xmlTextWriter);
                //    xmlTextWriter.Flush();
                //    xmlString = stringWriter.GetStringBuilder().ToString();
                //}

                DataSet ds = new DataSet(); byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(doc.OuterXml);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                ds.ReadXml(ms, XmlReadMode.InferSchema); ms.Close();
                ds.WriteXmlSchema(@"InvoiceDataSet.xsd");


                //InvoiceDataSet myDataSet = JsonConvert.DeserializeObject<InvoiceDataSet>(xmlString);

            }
            catch (Exception ex)
            { }

            try
            {
                if (Directory.Exists("ItemImages") == false)
                {
                    Directory.CreateDirectory("ItemImages");
                }

                if (File.Exists("A-Z.png") == true && File.Exists("Interop.VBIDE.dll") == true && File.Exists("Interop.Microsoft.Office.Interop.Excel.dll") == true && File.Exists("ExcelParse.exe") == true && File.Exists("FirebirdSql.Data.FirebirdClient.dll") == true)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Home());
                }
                else if (File.Exists("A-Z.png") == false)
                {
                    MessageBox.Show("A-Z.png is missing");
                }
                else
                {
                    MessageBox.Show("Dlls Missing...");
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "PROGRAM.CS";
                Variables.NotificationMessageText = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
