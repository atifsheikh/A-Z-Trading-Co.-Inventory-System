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
    public partial class BillPrint : Form
    {
        public BillPrint()
        {
            InitializeComponent();
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
            //Bills
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                BillDataSet = DatabaseCalls.GetBills();
                foreach (DataRow GridViewColumn in BillDataSet.Tables[0].Rows)
                {
                    BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0].ToString());
                }

                BillDataSet.Tables[0].Columns.Add("Customer");

                for (int loop = 0; loop < BillDataSet.Tables[0].Rows.Count; loop++)
                {
                    for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                    {
                        if (CustomerDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(BillDataSet.Tables[0].Rows[loop]["CustomerID"].ToString()) == true)
                        {
                            BillDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                            break;
                        }
                    }
                    if (Convert.ToInt32(BillDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        BillDataSet.Tables[0].Rows[loop].Delete();
                }

                BillDataGridView.DataSource = BillDataSet.Tables[0];
                BillDataGridView.Sort(BillDataGridView.Columns["DATED"], ListSortDirection.Descending);
                BillDataGridView.CurrentCell = null;
                BillDataGridView.Columns[0].HeaderText = "Bill Number";


                BillDataGridView.Columns["CustomerID"].Visible = false;
                BillDataGridView.Columns["AMOUNT"].Visible = false;
                BillDataGridView.Columns["REMARKS"].Visible = false;
                BillDataGridView.Columns["NAME"].Visible = false;

                BillDataGridView.Columns["Customer"].DisplayIndex = 1;
                BillDataGridView.Update();                
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
            
            //Customers
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    CustomerNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            Variables.NotificationStatus = true;
            }
        }


        private void CustomerNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            //Customer Detail
            try
            {
                BillDataGridView.CurrentCell = null;
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    if (GridViewColumn.ItemArray[1].ToString().Contains(CustomerNameSearch_txt.Text) == true)
                    {
                        for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                        {
                            if (!StaticClass.Contain(BillDataGridView.Rows[loop].Cells["CUSTOMERNAME"].Value.ToString(), CustomerNameSearch_txt.Text, StringComparison.OrdinalIgnoreCase))
                            {
                                BillDataGridView.Rows[loop].Visible = false;
                            }
                            else
                                BillDataGridView.Rows[loop].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            Variables.NotificationStatus = true;
            }
        }

        private void BillDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (PrintBatch_CB.Checked == false)
                {
                    this.reportViewer1.LocalReport.DisplayName = BillDataGridView.CurrentRow.Cells["NAME"].Value.ToString() + " - " + BillDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                    BillNumberSearch_txt.Text = BillDataGridView.CurrentRow.Cells["ID"].Value.ToString();

                    DisplayReport();

                }
                BillNumberSearch_txt.DroppedDown = false;
                button2.Focus();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void DisplayReport()
        {
            try
            {
                string jsonstring = DatabaseCalls.GET_String("http://" + global::InventoryManagement.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/" + BillNumberSearch_txt.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (BillDataGridView.SelectedRows.Count > 0)
            {
                if (BillNumberSearch_txt.Text != BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString())
                {
                    BillNumberSearch_txt.Text = BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                    BillDataGridView.SelectedRows[0].Selected = false;
                }
                else
                    reportViewer1.RefreshReport();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void BillPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("W, Control"))
                this.Close();
        }


        public static void PrintwithDialog(Microsoft.Reporting.WinForms.ReportViewer viewer)
        {
            object[] parms = { viewer};
        }

        public bool RenderingComp { get; set; }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            try
            {
                if (PrintBatch_CB.Checked == true)
                {
                    System.Drawing.Printing.PrinterSettings _PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                    _PrinterSettings.PrinterName = Variables.PrinterName;
                    reportViewer1.PrintDialog(_PrinterSettings);

                    if (BillDataGridView.SelectedRows.Count > 0)
                    {
                        BillNumberSearch_txt.Text = BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        BillDataGridView.SelectedRows[0].Selected = false;

                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = BillDataGridView.SelectedRows.Count.ToString();
                        Variables.NotificationStatus = true;
                    }
                }
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
                if (PrintBatch_CB.Checked == true)
                {
                    System.Drawing.Printing.PrinterSettings _PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                    _PrinterSettings.PrinterName = Variables.PrinterName;
                    reportViewer1.PrintDialog(_PrinterSettings);

                    if (BillDataGridView.SelectedRows.Count > 0)
                    {
                        BillNumberSearch_txt.Text = BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        BillDataGridView.SelectedRows[0].Selected = false;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = BillDataGridView.SelectedRows.Count.ToString();
                        Variables.NotificationStatus = true;
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void CustomerNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void BillNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void CustomerNameSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (CustomerNameSearch_txt.Text != null)
                        RandomAlgos.comboKeyPressed(CustomerNameSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void CustomerNameSearch_txt_Enter(object sender, EventArgs e)
        {
            CustomerNameSearch_txt.DroppedDown = true;
        }

        private void BillNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            BillNumberSearch_txt.DroppedDown = true;
        }
    }
}
