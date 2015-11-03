using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using InventoryManagement.Classes;
using System.Threading;
using Newtonsoft.Json;
using System.Xml;
using InventoryManagement.DataSets;
namespace InventoryManagement.UI
{
    public partial class InvoicePrintViewBox : Form
    {
        public InvoicePrintViewBox(string BillNumber)
        {
            InitializeComponent();
            DisplayReport(BillNumber);
        }

        private void DisplayReport(string BillNumber)
        {
            try
            {
                string jsonstring = DatabaseCalls.GET_String("http://" + global::InventoryManagement.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/" + BillNumber);
                CustomerInvoice customerInvoice = JsonConvert.DeserializeObject<CustomerInvoice>(jsonstring);
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.Clear();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CustomerInvoice", customerInvoice.GetBillDetail()));

                DateTime BillDate = Convert.ToDateTime(customerInvoice.Bill.DATED.ToString());
                string BillDateString = BillDate.ToShortDateString();

                ReportParameter[] param = new ReportParameter[7];
                param[0] = new ReportParameter("CustomerName", customerInvoice.Customer.NAME);
                param[1] = new ReportParameter("CustomerBusinessName", customerInvoice.Customer.BUSINESS_NAME);
                param[2] = new ReportParameter("CustomerPhone", customerInvoice.Customer.PHONE);
                param[3] = new ReportParameter("CustomerBalance", customerInvoice.Customer.AMOUNT.ToString());
                param[4] = new ReportParameter("InvoiceDate", BillDateString);
                param[5] = new ReportParameter("InvoiceNumber", customerInvoice.Bill.ID.ToString());
                int PreviousBalance = decimal.ToInt32(Convert.ToDecimal(customerInvoice.CustomerPreviousBalance));
                if (PreviousBalance > 0)
                    param[6] = new ReportParameter("PreviousBalance", PreviousBalance.ToString());
                else
                    param[6] = new ReportParameter("PreviousBalance", "0");
                this.reportViewer1.LocalReport.SetParameters(param);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        static DataSet CustomerDataSet = new DataSet();
        static DataSet BillDataSet = new DataSet();
        private void Form1_Load(object sender, EventArgs e) 
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void InvoicePrintViewBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("W, Control"))
                this.Close();
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            { }
        }
    }
}
