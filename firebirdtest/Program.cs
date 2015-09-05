using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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
