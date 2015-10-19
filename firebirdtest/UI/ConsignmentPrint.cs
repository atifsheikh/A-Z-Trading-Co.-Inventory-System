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
                    ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                }

                ConsignmentDataSet.Tables[0].Columns.Add("Vendor");

                for (int loop = 0; loop < ConsignmentDataSet.Tables[0].Rows.Count; loop++)
                {
                    for (int loop1 = 0; loop1 < VendorDataSet.Tables[0].Rows.Count; loop1++)
                    {
                        if (VendorDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(ConsignmentDataSet.Tables[0].Rows[loop]["VendorID"].ToString()) == true)
                        {
//                            ConsignmentDataSet.Tables[0].Rows[loop]["CUSTOMER_BALANCE"] = DatabaseCalls.GetCurrentRowBalance(ConsignmentDataSet.Tables[0].Rows[loop]["Vendor_ID"].ToString(), ConsignmentDataSet.Tables[0].Rows[loop][0].ToString());
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
                //ConsignmentDataGridView.Columns["AMOUNT"].Visible = false;
                //ConsignmentDataGridView.Columns["REMARKS"].Visible = false;
                ////ConsignmentDataGridView.Columns["CUSTOMER_BALANCE"].Visible = false;
                //ConsignmentDataGridView.Columns["NAME"].Visible = false;

                ConsignmentDataGridView.Columns["Vendor"].DisplayIndex = 1;
                ConsignmentDataGridView.Update();
                //                ConsignmentDataGridView.Columns["Vendor_ID"].HeaderText = "Vendor";
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
            
            ////Consignments
            //try
            //{
            //    DataSet Result2 = new DataSet();
            //    Result2 = DatabaseCalls.GetConsignments();
            //    foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
            //    {
            //        if (Convert.ToInt32(GridViewColumn.ItemArray[0]) > -1)
            //        {
            //            ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
            //        }
            //        else
            //        {
            //            GridViewColumn.Delete();
            //        }
            //    } 
            //    ConsignmentDataGridView.DataSource = Result2.Tables[0];
            //    ConsignmentDataGridView.Columns[0].HeaderText = "Consignment #";
            //    ConsignmentDataGridView.Columns["Vendor_ID"].Visible = false;
                
            //    //ConsignmentNumber_txt.Text = (++Result1).ToString();
            //}
            //catch (Exception ex)
            //{
            //    Variables.NotificationStatus = true;
            //Variables.NotificationMessageTitle = this.Name;
            //Variables.NotificationMessageText = ex.Message;
            //}

            //Vendors
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                //ConsignmentDataGridView.DataSource = VendorDataSet.Tables[0];
                //ConsignmentDataGridView.Columns[0].Visible = false;

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

        //string MakeImageSrcData(byte[] filebytes)
        //{
        //    return "data:image/png;base64," + Convert.ToBase64String(filebytes, Base64FormattingOptions.None);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.SALETableAdapter.Fill(this.DataSet1.SALE);
                DataSet ConsignmentDataSet = new DataSet();
                ConsignmentDataSet = DatabaseCalls.GetShipment(ConsignmentNumberSearch_txt.Text);


                ReportParameter[] _ReportParameter = new ReportParameter[8];
                String VendorID = ConsignmentDataGridView.CurrentRow.Cells["CUSTOMER_ID"].Value.ToString();
                decimal CalculatedBalance = Convert.ToDecimal(DatabaseCalls.GetCurrentRowBalance(VendorID, ConsignmentNumberSearch_txt.Text));
                foreach (DataRow GridViewColumn in ConsignmentDataSet.Tables[0].Rows)
                {
                    _ReportParameter[0] = new ReportParameter("ConsignmentNumber", ConsignmentNumberSearch_txt.Text);
                    _ReportParameter[1] = new ReportParameter("InvoiceDate", Convert.ToDateTime(GridViewColumn.ItemArray[2]).ToShortDateString());
                    _ReportParameter[2] = new ReportParameter("ConsignmentBalance", GridViewColumn.ItemArray[5].ToString());
                    _ReportParameter[6] = new ReportParameter("Total", ConsignmentDataGridView.Rows[ConsignmentDataGridView.CurrentCell.RowIndex].Cells["CUSTOMER_BALANCE"].Value.ToString());
                    VendorID = GridViewColumn.ItemArray[1].ToString();
                }
                DataSet VendorDataSet = new DataSet();
                VendorDataSet = DatabaseCalls.GetVendor(Convert.ToInt32(VendorID));
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                {
                    _ReportParameter[3] = new ReportParameter("VendorName", GridViewColumn.ItemArray[1].ToString());
                    _ReportParameter[4] = new ReportParameter("VendorShipAddress", GridViewColumn.ItemArray[4].ToString());
                    decimal VendorBalanceCalculated = Convert.ToDecimal(ConsignmentDataGridView.Rows[ConsignmentDataGridView.CurrentCell.RowIndex].Cells["CUSTOMER_BALANCE"].Value.ToString()) - Convert.ToDecimal(ConsignmentDataGridView.Rows[ConsignmentDataGridView.CurrentCell.RowIndex].Cells["AMOUNT"].Value.ToString());
                    _ReportParameter[5] = new ReportParameter("VendorBalance", VendorBalanceCalculated.ToString());
                }
                DataSet ConsignmentDetailDataSet = new DataSet();
                ConsignmentDetailDataSet = DatabaseCalls.GetSale(ConsignmentNumberSearch_txt.Text);
                int TotalCTNs = 0;
                foreach (DataRow ConsignmentDetail in ConsignmentDetailDataSet.Tables[0].Rows)
                {
                    TotalCTNs += Convert.ToInt32(ConsignmentDetail["QTY"].ToString());
                }
                _ReportParameter[7] = new ReportParameter("TotalCTN", TotalCTNs.ToString());

                reportViewer1.LocalReport.SetParameters(_ReportParameter);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("One or more rows contain values violating non-null, ") == true)
                    button1_Click(sender, e);
                else
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                    Variables.NotificationStatus = true;
                }
            }
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
                {
                    //if (ConsignmentNumberSearch_txt.Text != null)
                    //    RandomAlgos.comboKeyPressed(ConsignmentNumberSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

            try
            {
                if (ConsignmentNumberSearch_txt.Text != "" && ConsignmentNumberSearch_txt.Items.Contains(Convert.ToInt32(ConsignmentNumberSearch_txt.Text)))
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
                            if (VendorNameSearch_txt.Text != "" && ConsignmentDataGridView.Rows[loop].Cells["Vendor_ID"].Value.ToString() != (GridViewColumn.ItemArray[0].ToString()))
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
                    this.reportViewer1.LocalReport.DisplayName = ConsignmentDataGridView.CurrentRow.Cells["NAME"].Value.ToString() + " - " + ConsignmentDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                    //VendorNameSearch_txt.Text = ConsignmentDataGridView.CurrentRow.Cells["NAME"].Value.ToString();
                    ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.CurrentRow.Cells["ID"].Value.ToString();
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
            {
                object[] parms = { viewer};
             //   ExecuteFunction(viewer, parms, "OnPrint");
            }
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
                        //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Dataset1", ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString()));
                        ConsignmentNumberSearch_txt.Text = ConsignmentDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        ConsignmentDataGridView.SelectedRows[0].Selected = false;

                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ConsignmentDataGridView.SelectedRows.Count.ToString();
                        Variables.NotificationStatus = true;

                        //reportViewer1.PrintDialog();
                    }
                }
            }
            catch (Exception ex)
            { }
            //           PrintwithDialog(reportViewer1);
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
    }
}
