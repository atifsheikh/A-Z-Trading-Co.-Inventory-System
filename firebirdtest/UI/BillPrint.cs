using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.Reporting.WinForms;
using firebirdtest.Classes;
using System.Threading;
using Newtonsoft.Json;
using System.Xml;
namespace firebirdtest.UI
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

            //try
            //{
            //    string jsonstring = DatabaseCalls.GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/1");


            //    rptDataSource = new ReportDataSource("sp name from rdlc", dtname);
            //    rptViewer.LocalReport.DataSources.Add(rptDataSource);

            //    //JObject json = JsonConvert.DeserializeObject<JObject>(jsonstring);
            //    //foreach (Dictionary<string, object> item in data["Elements"])
            //    //{
            //    //    foreach (string val in item.Values)
            //    //    {
            //    //        Console.WriteLine(val);
            //    //    }
            //    //}

            //    DataTable tester = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));


            //    DataSet asdf = JsonConvert.DeserializeObject<DataSet>(jsonstring);

            //    // To convert JSON text contained in string json into an XML node
            //    XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonstring);

            //    //string xmlString = "";
            //    //using (var stringWriter = new StringWriter())
            //    //using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            //    //{
            //    //    doc.WriteTo(xmlTextWriter);
            //    //    xmlTextWriter.Flush();
            //    //    xmlString = stringWriter.GetStringBuilder().ToString();
            //    //}

            //    DataSet ds = new DataSet(); byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(doc.OuterXml);
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
            //    ds.ReadXml(ms, XmlReadMode.InferSchema); ms.Close();
            //    ds.WriteXmlSchema(@"InvoiceDataSet.xsd");


            //    //InvoiceDataSet myDataSet = JsonConvert.DeserializeObject<InvoiceDataSet>(xmlString);

            //}
            //catch (Exception ex)
            //{ }



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
//                            BillDataSet.Tables[0].Rows[loop]["CUSTOMER_BALANCE"] = DatabaseCalls.GetCurrentRowBalance(BillDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString(), BillDataSet.Tables[0].Rows[loop][0].ToString());
                            BillDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                            break;
                        }
                    }
                    if (Convert.ToInt32(BillDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        BillDataSet.Tables[0].Rows[loop].Delete();
                }

                BillDataGridView.DataSource = BillDataSet.Tables[0];
                BillDataGridView.CurrentCell = null;
                BillDataGridView.Columns[0].HeaderText = "Bill Number";


                BillDataGridView.Columns["CustomerID"].Visible = false;
                BillDataGridView.Columns["AMOUNT"].Visible = false;
                BillDataGridView.Columns["REMARKS"].Visible = false;
                //BillDataGridView.Columns["CUSTOMER_BALANCE"].Visible = false;
                BillDataGridView.Columns["NAME"].Visible = false;

                BillDataGridView.Columns["Customer"].DisplayIndex = 1;
                BillDataGridView.Update();
                //                BillDataGridView.Columns["Customer_ID"].HeaderText = "Customer";
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
            
            ////Bills
            //try
            //{
            //    DataSet Result2 = new DataSet();
            //    Result2 = DatabaseCalls.GetBills();
            //    foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
            //    {
            //        if (Convert.ToInt32(GridViewColumn.ItemArray[0]) > -1)
            //        {
            //            BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
            //        }
            //        else
            //        {
            //            GridViewColumn.Delete();
            //        }
            //    } 
            //    BillDataGridView.DataSource = Result2.Tables[0];
            //    BillDataGridView.Columns[0].HeaderText = "Bill #";
            //    BillDataGridView.Columns["Customer_ID"].Visible = false;
                
            //    //BillNumber_txt.Text = (++Result1).ToString();
            //}
            //catch (Exception ex)
            //{
            //    Variables.NotificationStatus = true;
            //Variables.NotificationMessageTitle = this.Name;
            //Variables.NotificationMessageText = ex.Message;
            //}

            //Customers
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                //BillDataGridView.DataSource = CustomerDataSet.Tables[0];
                //BillDataGridView.Columns[0].Visible = false;

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

        //string MakeImageSrcData(byte[] filebytes)
        //{
        //    return "data:image/png;base64," + Convert.ToBase64String(filebytes, Base64FormattingOptions.None);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.DataSet1 = DatabaseCalls.GetBillDetails("1");
                this.SALETableAdapter.Fill(this.DataSet1.SALE);
                DataSet BillDataSet = new DataSet();
                BillDataSet = DatabaseCalls.GetBill(BillNumberSearch_txt.Text);


                ReportParameter[] _ReportParameter = new ReportParameter[8];
                String CustomerID = BillDataGridView.CurrentRow.Cells["CUSTOMER_ID"].Value.ToString();
                decimal CalculatedBalance = Convert.ToDecimal(DatabaseCalls.GetCurrentRowBalance(CustomerID, BillNumberSearch_txt.Text));
                foreach (DataRow GridViewColumn in BillDataSet.Tables[0].Rows)
                {
                    _ReportParameter[0] = new ReportParameter("BillNumber", BillNumberSearch_txt.Text);
                    _ReportParameter[1] = new ReportParameter("InvoiceDate", Convert.ToDateTime(GridViewColumn.ItemArray[2]).ToShortDateString());
                    _ReportParameter[2] = new ReportParameter("BillBalance", GridViewColumn.ItemArray[5].ToString());
                    _ReportParameter[6] = new ReportParameter("Total", BillDataGridView.Rows[BillDataGridView.CurrentCell.RowIndex].Cells["CUSTOMER_BALANCE"].Value.ToString());
                    CustomerID = GridViewColumn.ItemArray[1].ToString();
                }
                DataSet CustomerDataSet = new DataSet();
                CustomerDataSet = DatabaseCalls.GetCustomer(Convert.ToInt32(CustomerID));
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    _ReportParameter[3] = new ReportParameter("CustomerName", GridViewColumn.ItemArray[1].ToString());
                    _ReportParameter[4] = new ReportParameter("CustomerShipAddress", GridViewColumn.ItemArray[4].ToString());
                    decimal CustomerBalanceCalculated = Convert.ToDecimal(BillDataGridView.Rows[BillDataGridView.CurrentCell.RowIndex].Cells["CUSTOMER_BALANCE"].Value.ToString()) - Convert.ToDecimal(BillDataGridView.Rows[BillDataGridView.CurrentCell.RowIndex].Cells["AMOUNT"].Value.ToString());
                    _ReportParameter[5] = new ReportParameter("CustomerBalance", CustomerBalanceCalculated.ToString());
                }
                DataSet BillDetailDataSet = new DataSet();
                BillDetailDataSet = DatabaseCalls.GetSale(BillNumberSearch_txt.Text);
                int TotalCTNs = 0;
                foreach (DataRow BillDetail in BillDetailDataSet.Tables[0].Rows)
                {
                    TotalCTNs += Convert.ToInt32(BillDetail["QTY"].ToString());
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
        

        private void BillNumber_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void BillNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    //if (BillNumberSearch_txt.Text != null)
                    //    RandomAlgos.comboKeyPressed(BillNumberSearch_txt);
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
                if (BillNumberSearch_txt.Text != "" && BillNumberSearch_txt.Items.Contains(BillNumberSearch_txt.Text))
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
                else if (BillNumberSearch_txt.Text != "")
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Invalid Bill Number.";
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
                            if (CustomerNameSearch_txt.Text != "" && BillDataGridView.Rows[loop].Cells["Customer_ID"].Value.ToString() != (GridViewColumn.ItemArray[0].ToString()))
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
                    //CustomerNameSearch_txt.Text = BillDataGridView.CurrentRow.Cells["NAME"].Value.ToString();
                    BillNumberSearch_txt.Text = BillDataGridView.CurrentRow.Cells["ID"].Value.ToString();
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

                    if (BillDataGridView.SelectedRows.Count > 0)
                    {
                        //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Dataset1", BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString()));
                        BillNumberSearch_txt.Text = BillDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        BillDataGridView.SelectedRows[0].Selected = false;

                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = BillDataGridView.SelectedRows.Count.ToString();
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

        private void BillPrint_Load(object sender, EventArgs e)
        {
            try
            {

                // Set Processing Mode
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                // Set RDL file
                reportViewer1.LocalReport.ReportPath = "BillInvoice.rdlc";

                // Supply data corresponding to each report data source.


                string jsonstring = DatabaseCalls.GET_String("http://" + global::firebirdtest.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetBillInvoice/1");
                Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonstring);
                try
                {
                    Merchant merchant = new Merchant();
                    this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Product", merchant.GetProducts()));
                    this.reportViewer1.RefreshReport();

                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceDetails", invoice));
                    //reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                { }
            }
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = "CustomerBill.rdlc";



                //ReportDataSource rptDataSource = new ReportDataSource("sp name from rdlc", dtname);
            //reportViewer1.LocalReport.DataSources.Add(rptDataSource);


                //JObject json = JsonConvert.DeserializeObject<JObject>(jsonstring);
            //foreach (Dictionary<string, object> item in data["Elements"])
            //{
            //    foreach (string val in item.Values)
            //    {
            //        Console.WriteLine(val);
            //    }
            //}

                //DataTable tester = (DataTable)JsonConvert.DeserializeObject(jsonstring, (typeof(DataTable)));


                //DataSet asdf = JsonConvert.DeserializeObject<DataSet>(jsonstring);

                // To convert JSON text contained in string json into an XML node
            //XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonstring);

                //string xmlString = "";
            //using (var stringWriter = new StringWriter())
            //using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            //{
            //    doc.WriteTo(xmlTextWriter);
            //    xmlTextWriter.Flush();
            //    xmlString = stringWriter.GetStringBuilder().ToString();
            //}

                //DataSet ds = new DataSet(); byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(doc.OuterXml);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
            //ds.ReadXml(ms, XmlReadMode.InferSchema); ms.Close();
            //ds.WriteXmlSchema(@"InvoiceDataSet.xsd");


                //InvoiceDataSet myDataSet = JsonConvert.DeserializeObject<InvoiceDataSet>(xmlString);


            catch (Exception ex)
            { }

        }
    }
}
