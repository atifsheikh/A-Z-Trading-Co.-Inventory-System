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
using Newtonsoft.Json.Linq;

namespace firebirdtest
{
/*    public class CUSTOMER
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public int AMOUNT { get; set; }
        public int OPENING_BALANCE { get; set; }
        public int BALANCE_LIMIT { get; set; }
    }

    public class Bill
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DATED { get; set; }
        public int AMOUNT { get; set; }
        public string REMARKS { get; set; }
        public int CUSTOMER_BALANCE { get; set; }
        public int TOTAL_CTN { get; set; }
    }

    public class Item
    {
        public string CODE { get; set; }
    }

    public class BillDetail
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public Item Item { get; set; }
        public int T_QUANTITY { get; set; }
        public int QTY_PER_BOX { get; set; }
        public string MODEL { get; set; }
        public int CTN { get; set; }
        public int PRICE { get; set; }
        public int SUBTOTAL { get; set; }
    }

    public class RootObject
    {
        public CUSTOMER CUSTOMER { get; set; }
        public Bill Bill { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }*/


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
