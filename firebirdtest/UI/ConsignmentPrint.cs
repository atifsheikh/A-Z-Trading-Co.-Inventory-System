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
    public partial class ConsignmentPrint : Form
    {
        public ConsignmentPrint()
        {
            InitializeComponent();
        }

        static DataSet VendorDataSet = new DataSet();
        static DataSet ConsignmentDataSet = new DataSet();
        private void Form1_Load(object sender, EventArgs e) 
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            //Consignments
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                ConsignmentDataSet = DatabaseCalls.GetShipments();
                foreach (DataRow GridViewColumn in ConsignmentDataSet.Tables[0].Rows)
                {
                    ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0].ToString());
                }

                ConsignmentDataSet.Tables[0].Columns.Add("Vendor");

                for (int loop = 0; loop < ConsignmentDataSet.Tables[0].Rows.Count; loop++)
                {
                    for (int loop1 = 0; loop1 < VendorDataSet.Tables[0].Rows.Count; loop1++)
                    {
                        if (VendorDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(ConsignmentDataSet.Tables[0].Rows[loop]["VendorID"].ToString()) == true)
                        {
                            ConsignmentDataSet.Tables[0].Rows[loop]["Vendor"] = VendorDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                            break;
                        }
                    }
                    if (Convert.ToInt32(ConsignmentDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        ConsignmentDataSet.Tables[0].Rows[loop].Delete();
                }

                ConsignmentDataGridView.DataSource = ConsignmentDataSet.Tables[0];
                ConsignmentDataGridView.Sort(ConsignmentDataGridView.Columns["DATED"], ListSortDirection.Descending);
                ConsignmentDataGridView.CurrentCell = null;
                ConsignmentDataGridView.Columns[0].HeaderText = "Consignment Number";


                ConsignmentDataGridView.Columns["VendorID"].Visible = false;
                ConsignmentDataGridView.Columns["AMOUNT"].Visible = false;
                ConsignmentDataGridView.Columns["REMARKS"].Visible = false;

                ConsignmentDataGridView.Columns["Vendor"].DisplayIndex = 1;
                ConsignmentDataGridView.Update();                
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
            
            //Vendors
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                {
                    VendorNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            Variables.NotificationStatus = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        

        private void ConsignmentNumber_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void ConsignmentNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ConsignmentNumberSearch_txt.Text != "" && ConsignmentNumberSearch_txt.Items.Contains(ConsignmentNumberSearch_txt.Text))
                {
                    try
                    {
                        button1_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("One or more rows contain values violating non-null, ") == false)
                        {
                            Variables.NotificationMessageTitle = this.Name;
                            Variables.NotificationMessageText = ex.Message;
                            Variables.NotificationStatus = true;
                        }
                        else
                            button1_Click(sender, e);
                    }
                }
                else if (ConsignmentNumberSearch_txt.Text != "")
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Invalid Consignment Number.";
                    Variables.NotificationStatus = true;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }


        private void VendorNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            //Vendor Detail
            try
            {
                ConsignmentDataGridView.CurrentCell = null;
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                {
                    if (GridViewColumn.ItemArray[1].ToString().Contains(VendorNameSearch_txt.Text) == true)
                    {
                        for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count; loop++)
                        {
                            if (!StaticClass.Contain(ConsignmentDataGridView.Rows[loop].Cells["CUSTOMERNAME"].Value.ToString(), VendorNameSearch_txt.Text, StringComparison.OrdinalIgnoreCase))
                            {
                                ConsignmentDataGridView.Rows[loop].Visible = false;
                            }
                            else
                                ConsignmentDataGridView.Rows[loop].Visible = true;
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

        private void ConsignmentDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (PrintBatch_CB.Checked == false)
                {
                    this.reportViewer1.LocalReport.DisplayName = ConsignmentDataGridView.CurrentRow.Cells["VendorNAME"].Value.ToString() + " - " + ConsignmentDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                    ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.CurrentRow.Cells["ID"].Value.ToString();

                    DisplayReport();

                }
                ConsignmentNumberSearch_txt.DroppedDown = false;
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
                string jsonstring = DatabaseCalls.GET_String("http://" + global::InventoryManagement.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetConsignmentInvoice/" + ConsignmentNumberSearch_txt.Text);
                VendorInvoice vendorInvoice = JsonConvert.DeserializeObject<VendorInvoice>(jsonstring);
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.Clear();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Invoice", vendorInvoice.GetShipmentDetail()));

                DateTime ConsignmentDate = Convert.ToDateTime(vendorInvoice.Shipment.DATED.ToString());
                string ConsignmentDateString = ConsignmentDate.ToShortDateString();

                ReportParameter[] param = new ReportParameter[7];
                param[0] = new ReportParameter("VendorName", vendorInvoice.Vendor.NAME);
                param[1] = new ReportParameter("VendorBusinessName", vendorInvoice.Vendor.BUSINESS_NAME);
                param[2] = new ReportParameter("VendorPhone", vendorInvoice.Vendor.PHONE);
                param[3] = new ReportParameter("VendorBalance", vendorInvoice.Vendor.AMOUNT.ToString());
                param[4] = new ReportParameter("InvoiceDate", ConsignmentDateString);
                param[5] = new ReportParameter("InvoiceNumber", vendorInvoice.Shipment.ID.ToString());
                int PreviousBalance = decimal.ToInt32(Convert.ToDecimal(vendorInvoice.VendorPreviousBalance));
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
            if (ConsignmentDataGridView.SelectedRows.Count > 0)
            {
                if (ConsignmentNumberSearch_txt.Text != ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString())
                {
                    ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                    ConsignmentDataGridView.SelectedRows[0].Selected = false;
                }
                else
                    reportViewer1.RefreshReport();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ConsignmentPrint_KeyDown(object sender, KeyEventArgs e)
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

                    if (ConsignmentDataGridView.SelectedRows.Count > 0)
                    {
                        ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        ConsignmentDataGridView.SelectedRows[0].Selected = false;

                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ConsignmentDataGridView.SelectedRows.Count.ToString();
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

                    if (ConsignmentDataGridView.SelectedRows.Count > 0)
                    {
                        ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        ConsignmentDataGridView.SelectedRows[0].Selected = false;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ConsignmentDataGridView.SelectedRows.Count.ToString();
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

        private void VendorNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void ConsignmentNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void VendorNameSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (VendorNameSearch_txt.Text != null)
                        RandomAlgos.comboKeyPressed(VendorNameSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void VendorNameSearch_txt_Enter(object sender, EventArgs e)
        {
            VendorNameSearch_txt.DroppedDown = true;
        }

        private void ConsignmentNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            ConsignmentNumberSearch_txt.DroppedDown = true;
        }

        private void ConsignmentPrint_Load(object sender, EventArgs e)
        {
        }
    }
}
