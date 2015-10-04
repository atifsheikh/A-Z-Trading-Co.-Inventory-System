using ExcelReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;
using System.Threading;

namespace firebirdtest.UI
{
    public partial class AddInvoice : Form
    {
        public AddInvoice()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName_txt.Enabled = true;
                ModifyingInvoice = false;
                ItemCode_txt.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton5.Enabled = false;
                InvoiceDetailDataGridView.Rows.Clear();
                CustomerName_txt.Text = "None";
                CustomerName_txt.Focus();
                CustomerAddress_txt.Text = "None";
                CustomerEmail_txt.Text = "None";
                BusinessName_txt.Text = "None";
                CustomerBalance_txt.Text = "0";
                CustomerPhone_txt.Text = "None";
                CustomerID_txt.Text = "";
                Total_txt.Text = "0";
                BalanceNew_txt.Text = "0";
                //Invoice Detail
                try
                {
                    int Result1 = 0;
                    Result1 = Convert.ToInt32(DatabaseCalls.GetNewBillNumber());
                    InvoiceNumber_txt.Text = (Result1).ToString();
                }
                catch (Exception ex)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        public static string SelectedItemForInvoice = "";
        private void comboBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    ItemsDataGridView.Visible = !ItemsDataGridView.Visible;
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    ItemsDataGridView.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (ItemCode_txt.Text == "")
                    {
                        Total_txt.Focus();
                        return;
                    }
                    if (ItemsDataGridView.SelectedRows.Count <= 0)
                    {
                        for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                        {
                            if (ItemsDataGridView.Rows[loop].Visible == true)
                            {
                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop].Cells["PRICE"].Value.ToString().Trim();
                                ItemCode_txt.Text = ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString().Trim();
                                ItemName_txt.Text = ItemsDataGridView.Rows[loop].Cells["Model"].Value.ToString().Trim();
                                Qty_Box_txt.Text = ItemsDataGridView.Rows[loop].Cells["QTY_BOX"].Value.ToString();
                                Ctn_txt.Focus();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }


        DataTable InvoiceDataTable = new DataTable();
        private void EnterDataInGrid(object sender, KeyEventArgs e)
        {
            try
            {
                string[] row = { (InvoiceDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_Box_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString() };
                InvoiceDetailDataGridView.Rows.Add(row);
                InvoiceDetailDataGridView.Update();
                TOTAL_ITEMS_txt.Text = (Quant_txt.Text == "" ? 0 : (Convert.ToInt32(Quant_txt.Text) + Convert.ToInt32(TOTAL_ITEMS_txt.Text))).ToString();

                int temp = Convert.ToInt32(textBox7.Text);
                textBox7.Text = (++temp).ToString();
                RandomAlgos.AddDataInSalesFile((InvoiceDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_Box_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString(), CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_ITEMS_txt.Text, textBox7.Text);
                Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) + Convert.ToDecimal(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString();

                ItemCode_txt.Text = "";
                ItemName_txt.Text = "None";
                Ctn_txt.Text = "0";
                Qty_txt.Text = "0";
                Qty_Box_txt.Text = "0";
                Quant_txt.Text = "0";
                UnitPrice_txt.Text = "0";
                Total_txt_Leave(sender, e);

            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

            ItemCode_txt.Focus();
        }

        static DataSet InvoiceDataSet = new DataSet();
        static DataSet CustomerDataSet = new DataSet();
        static DataSet ItemDetailsDataSet = new DataSet();
        static int NewInvoiceNumber = 0;

        DataSet InvoiceDetailsDataSet = new DataSet();
        
        private void AddInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                try 
                {
                    System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                    this.Icon = ico;
                }
                catch (Exception ex)
                { }
                SpeedTest_BGWorker.RunWorkerAsync();                //TO GET Consingment Detail LIST
                try
                {
                    GetItemsForInvoicePage();
                }
                catch (Exception ex)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void GetItemsForInvoicePage()
        {
            InvoiceDetailsDataSet = new DataSet();
            InvoiceDetailsDataSet = DatabaseCalls.GetItems();

            try
            {
                if (InvoiceDetailsDataSet != null && InvoiceDetailsDataSet.Tables.Count > 0)
                {
                    ItemsDataGridView.DataSource = InvoiceDetailsDataSet.Tables[0];
                    if (ItemsDataGridView.Columns.Count > 0)
                    {
                        ItemsDataGridView.Columns["NAME"].Visible = false;
                        ItemsDataGridView.Columns["IMAGE"].Visible = false;
                        ItemsDataGridView.Columns[0].Visible = false;
                        ItemsDataGridView.Columns["CODE"].DisplayIndex = 0;
                        ItemsDataGridView.Columns["MODEL"].DisplayIndex = 1;
                        ItemsDataGridView.Columns["QTY_BOX"].DisplayIndex = 3;
                        ItemsDataGridView.Columns["T_QUANTITY"].DisplayIndex = 4;
                        ItemsDataGridView.Columns["PRICE"].DisplayIndex = 5;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerName_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CustomerName_txt.Text != "" && CustomerName_txt.Text != "None")
                {
                    DataSet Result1 = new DataSet();
                    Result1 = DatabaseCalls.GetCustomerByName(CustomerName_txt.Text);
                    
                    foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                    {
                        CustomerID_txt.Text = GridViewColumn.ItemArray[0].ToString();
                        CustomerAddress_txt.Text = GridViewColumn.ItemArray[2].ToString();
                        CustomerEmail_txt.Text = GridViewColumn.ItemArray[4].ToString();
                        BusinessName_txt.Text = GridViewColumn.ItemArray[8].ToString();
                        CustomerBalance_txt.Text = GridViewColumn.ItemArray[6].ToString();
                        CustomerPhone_txt.Text = GridViewColumn.ItemArray[3].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Add Invoice Number
            try
            {
                if (CustomerID_txt.Text == "")
                {
                    MessageBox.Show("Please Select a Customer");
                    CustomerName_txt.Focus();
                    return;
                }
                if (InvoiceNumber_txt.Text == "")
                {
                    InvoiceNumber_txt.Text = DatabaseCalls.GetNewBillNumber();
                }
                String Result1 = DatabaseCalls.AddBill(Convert.ToInt32(InvoiceNumber_txt.Text), Convert.ToInt32(CustomerID_txt.Text), Convert.ToDateTime(DateTime.Now), "Invoice");
                if (Result1 == "")
                {
                    //Add Invoice Details
                    foreach (DataGridViewRow GridViewRow in InvoiceDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            // PCS_CTN, QUANT, CUSTOMER_ID

                            string AddSaleResult = DatabaseCalls.AddBillDetail(GridViewRow.Cells["ITEM_CODE"].Value.ToString(), InvoiceNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["QUANT"].Value), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), GridViewRow.Cells["ItemName"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Qty"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SubTotal"].Value));
                            //if (AddSaleResult == "")
                            //{
                            //    ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());
                            //}
                        }
                    }

                    toolStripButton1_Click(sender, e);


                    //Invoices
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetBills();
                        InvoiceDataGridView.DataSource = Result2.Tables[0];
                        InvoiceDataGridView.Columns[0].HeaderText = "Invoice Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            InvoiceNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
                    }
                }
                else
                {
                    Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = Result1;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

            try
            {
                RandomAlgos.DeleteSalesFile();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ItemCode_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        static DataSet ItemDetails = new DataSet();
        private void ItemCode_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ItemsDataGridView.Focused == false)
                    ItemsDataGridView.Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Ctn_txt.Text == "")
                        Ctn_txt.Text = "0";
                    Qty_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void Total_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal InvoiceTotal = 0;
                foreach (DataGridViewRow SubTotal in InvoiceDetailDataGridView.Rows)
                {
                    InvoiceTotal += Convert.ToDecimal(SubTotal.Cells[7].Value);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void Total_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void Total_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Total_txt_Leave(sender, e);
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }
       
        private void InvoiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet Result1 = new DataSet();
                try
                {
                    toolStripButton1_Click(sender, e);
                    InvoiceDetailDataGridView.Enabled = false;
                    InvoiceDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
                    toolStripButton2.Enabled = false;
                    ItemCode_txt.Enabled = false;
                    toolStripButton5.Enabled = true;


                    Total_txt.Text = InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[5].Value.ToString();

                    InvoiceDetailDataGridView.Focus();

                    Result1 = DatabaseCalls.GetBillDetails(InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
                    

                }
                catch (Exception ex)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }


                if (Result1.Tables.Count > 0 && Result1.Tables[0].Rows.Count > 0)
                {
                    int CostAmmount = 0;
                    try
                    {
                        
                        for (int r = 0; r <= (Result1.Tables[0].Rows.Count - 1); r++)
                        {
                            InvoiceDetailDataGridView.Rows.Add();
                            InvoiceDetailDataGridView.Rows[r].Cells[0].Value = (r + 1).ToString();
                            InvoiceDetailDataGridView.Rows[r].Cells[1].Value = Result1.Tables[0].Rows[r].ItemArray[4];
                            InvoiceDetailDataGridView.Rows[r].Cells[2].Value = Result1.Tables[0].Rows[r].ItemArray[5];
                            InvoiceDetailDataGridView.Rows[r].Cells[3].Value = Result1.Tables[0].Rows[r].ItemArray[7];
                            InvoiceDetailDataGridView.Rows[r].Cells[4].Value = Result1.Tables[0].Rows[r].ItemArray[9];
                            InvoiceDetailDataGridView.Rows[r].Cells[5].Value = (Convert.ToInt32(Result1.Tables[0].Rows[r].ItemArray[6])).ToString();
                            InvoiceDetailDataGridView.Rows[r].Cells[6].Value = Result1.Tables[0].Rows[r].ItemArray[10];
                            InvoiceDetailDataGridView.Rows[r].Cells[7].Value = Result1.Tables[0].Rows[r].ItemArray[11];
                            TOTAL_ITEMS_txt.Text = (InvoiceDetailDataGridView.Rows[r].Cells["Quant"].Value == "" ? 0 : (Convert.ToInt32(InvoiceDetailDataGridView.Rows[r].Cells["Quant"].Value) + Convert.ToInt32(TOTAL_ITEMS_txt.Text))).ToString();
                            int temp = Convert.ToInt32(textBox7.Text);
                            textBox7.Text = (++temp).ToString();
                            CostAmmount += Convert.ToInt32(InvoiceDetailDataGridView.Rows[r].Cells["SUBTOTAL"].Value);
                        }
                        Total_txt.Text = CostAmmount.ToString();
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    
                    try
                    {
                        

                        CustomerID_txt.Text = Result1.Tables[0].Rows[0].ItemArray[2].ToString();
                        CustomerName_txt.Text = DatabaseCalls.GetCustomerName(Convert.ToInt32(CustomerID_txt.Text));
                        

                        InvoiceNumber_txt.Text = Result1.Tables[0].Rows[0].ItemArray[2].ToString();
                        

                        CustomerName_txt_Leave(this, null);
                        

                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            SendKeys.Send("{TAB}");
            CustomerName_txt.Enabled = false;
      }

        private void Qty_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void InvoiceNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Invoices
                for (int loop = 0; loop < InvoiceDataGridView.Rows.Count; loop++)
                {
                    InvoiceDataGridView.CurrentCell = null;
                    if ((InvoiceNumberSearch_txt.Text != "") && (InvoiceDataGridView.Rows[loop].Cells["ID"].Value.ToString() != (InvoiceNumberSearch_txt.Text)))
                    {
                        InvoiceDataGridView.Rows[loop].Visible = false;
                    }
                    else
                        InvoiceDataGridView.Rows[loop].Visible = true;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //Customer Detail
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    if (GridViewColumn.ItemArray[1].ToString() == CustomerNameSearch_txt.Text)
                    {
                        for (int loop = 0; loop < InvoiceDataGridView.Rows.Count; loop++)
                        {
                            InvoiceDataGridView.CurrentCell = null;
                            if (!StaticClass.Contain(InvoiceDataGridView.Rows[loop].Cells["CUSTOMERNAME"].Value.ToString(),CustomerNameSearch_txt.Text, StringComparison.OrdinalIgnoreCase))
                            {
                                InvoiceDataGridView.Rows[loop].Visible = false;
                            }
                            else
                                InvoiceDataGridView.Rows[loop].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void AddInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void InvoiceDetailDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                TOTAL_ITEMS_txt.Text = "0";
                textBox7.Text = "0";
                Total_txt.Text = "0";
                decimal CostAmmount = 0;
                int NumberOfItems = 0;
                int NumberOfCTN = 0;
                RandomAlgos.DeleteSalesFile();
                for (int loop = 0; loop < InvoiceDetailDataGridView.Rows.Count - 1; loop++)
                {
                    RandomAlgos.AddDataInSalesFile(InvoiceDetailDataGridView.Rows[loop].Cells[0].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[1].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[2].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[3].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[4].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[5].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[6].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[7].Value.ToString(),
                        CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_ITEMS_txt.Text, textBox7.Text);
                    CostAmmount += Convert.ToDecimal(InvoiceDetailDataGridView.Rows[loop].Cells["SUBTOTAL"].Value);
                    NumberOfItems++;
                    TOTAL_ITEMS_txt.Text = (InvoiceDetailDataGridView.Rows[loop].Cells["Quant"].Value == "" ? 0 : (Convert.ToInt32(InvoiceDetailDataGridView.Rows[loop].Cells["Quant"].Value) + Convert.ToInt32(TOTAL_ITEMS_txt.Text))).ToString();
                }
                textBox7.Text = NumberOfItems.ToString();
                Total_txt.Text = CostAmmount.ToString();
                InvoiceDetailDataGridView.Enabled = true;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripButton2.Enabled = false;
                toolStripButton4.Enabled = true;
                toolStripButton5.Enabled = false;
                InvoiceDetailDataGridView.Enabled = true;
                OpenFileDialog _OpenFileDialog = new OpenFileDialog();
                _OpenFileDialog.ShowDialog();
                
                if (_OpenFileDialog.FileName.EndsWith(".xlsx") || _OpenFileDialog.FileName.EndsWith(".xls"))
                {

                    ExcelReader.Variables.FileName = _OpenFileDialog.FileName;
                    ExcelReader.ExcelTool _tool = new ExcelTool();
                    _tool.ShowDialog();
                    _tool.Close();
                    _tool.Dispose();
                    ExcelReader.Variables.FileName = "";
                    ExcelReader.Variables.RangeCurrentIndex = 1;
                    PopulateInvoiceData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Invoice Data. ";
                }
                else
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Please select the correct File..";
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void PopulateInvoiceData(object sender, EventArgs e)
        {
            try
            {
                for (int loop = ExcelReader.Variables.RangeCurrentIndex; loop < ExcelReader.Variables.Range.Length; loop++)
                {
                    try
                    {
                        if (CustomerName_txt.Items.Contains(ExcelReader.Variables.Range[0][loop]) == true)
                        {
                            CustomerName_txt.Text = ExcelReader.Variables.Range[0][loop];
                        }
                        else
                        {
                            SelectCustomerName _SelectCustomerName = new SelectCustomerName(ExcelReader.Variables.Range[0][loop]);
                            _SelectCustomerName.ShowDialog();
                            CustomerName_txt.Text = _SelectCustomerName.SelectedCustomerName;
                            ExcelReader.Variables.Range[0][loop] = _SelectCustomerName.SelectedCustomerName;
                            _SelectCustomerName.Dispose();
                        }
                        CustomerName_txt.Focus();
                    }
                    catch (Exception ex)
                    {
                    }
                    for (int loop1 = 1; loop1 < ExcelReader.Variables.Range[loop].Length; loop1++)
                    {
                        try
                        {
                            string ItemQuantity = ExcelReader.Variables.Range[loop1][loop];
                            string ItemCode = "";
                            if (ItemQuantity != "-----" && Convert.ToInt32(ItemQuantity) > 0)
                            {
                                ItemCode = ExcelReader.Variables.Range[loop1][0];

                                bool MatchFound = false;
                                for (int loop2 = 0; loop2 < ItemsDataGridView.Rows.Count; loop2++)
                                {
                                    if (ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Equals(ItemCode) == true)
                                    {
                                        MatchFound = true;
                                        ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                        UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString().Trim();
                                        ItemName_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Model"].Value.ToString().Trim();
                                        Qty_Box_txt.Text = ItemsDataGridView.Rows[loop2].Cells["QTY_BOX"].Value.ToString();
                                        
                                        Ctn_txt.Text = ItemQuantity;

                                        EnterDataInGrid(sender, null);
                                        break;
                                    }
                                    else
                                        MatchFound = false;
                                }
                                    if (MatchFound == true)
                                    {
                                        ItemCode_txt.Text = ItemCode;
                                    }
                                    else if (ItemCode != "" && ItemCode != "-----")
                                    {
                                        SelectItemCode _SelectItemCode = new SelectItemCode(ExcelReader.Variables.Range[loop1][0]);
                                        _SelectItemCode.ShowDialog();
                                        _SelectItemCode.Dispose();
                                        ItemCode_txt.Text = _SelectItemCode.SelectedItemCode;
                                        ExcelReader.Variables.Range[loop1][0] = _SelectItemCode.SelectedItemCode;


                                        for (int loop2 = 0; loop2 < ItemsDataGridView.Rows.Count; loop2++)
                                        {
                                            if (ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().StartsWith("7"))
                                            { }
                                            if (ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Equals(ItemCode_txt.Text) == true)
                                            {
                                                MatchFound = true;
                                                ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString().Trim();
                                                ItemName_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Model"].Value.ToString().Trim();
                                                Qty_Box_txt.Text = ItemsDataGridView.Rows[loop2].Cells["QTY_BOX"].Value.ToString();
                                                
                                                Ctn_txt.Text = ItemQuantity;

                                                EnterDataInGrid(sender, null);
                                                break;
                                            }
                                            else
                                                MatchFound = false;
                                        }
                                    }

                                if (ItemCode != "" && ItemCode != "-----")
                                {
                                    ItemCode_txt.Focus();
                                    ItemCode_txt_Leave(sender, e);

                                    Qty_Box_txt.Text = ItemQuantity;
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripButton2_Click(sender, e);
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = "Invoice Added\r\nGetting new Invoice.";

                ExcelReader.Variables.RangeCurrentIndex++;
                if (ExcelReader.Variables.Range != null && ExcelReader.Variables.RangeCurrentIndex < ExcelReader.Variables.Range.Length && ExcelReader.Variables.Range[0][ExcelReader.Variables.RangeCurrentIndex] != "-----")
                {
                    PopulateInvoiceData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Invoice Data. ";
                }
                else if (ExcelReader.Variables.Range[0][ExcelReader.Variables.RangeCurrentIndex] == "-----")
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "End of Customers List";
                    toolStripButton2.Enabled = true;
                    toolStripButton4.Enabled = false;
                    toolStripButton5.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName_txt.Enabled = true;
                ModifyingInvoice = false;
                if (InvoiceNumber_txt.Text != "")
                {
                    DataSet InvoiceDataSet = new DataSet();
                    InvoiceDataSet = DatabaseCalls.GetBill(InvoiceNumber_txt.Text);
                    if (InvoiceDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Invoice Found";
                        return;
                    }

                    DataSet CustomerDataSet = new DataSet();
                    CustomerDataSet = DatabaseCalls.GetCustomer(Convert.ToInt32(InvoiceDataSet.Tables[0].Rows[0]["CustomerID"].ToString()));
                    if (CustomerDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Customer Found";
                        return;
                    }
                    DatabaseCalls.DeleteBillDetails(InvoiceNumber_txt.Text);

                    //add Updated Invoice Detail
                    //Add Invoice Details
                    foreach (DataGridViewRow GridViewRow in InvoiceDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            string AddSaleResult = DatabaseCalls.AddBillDetail(GridViewRow.Cells["ITEM_CODE"].Value.ToString(), InvoiceNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["QUANT"].Value), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), GridViewRow.Cells["ItemName"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Qty"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SubTotal"].Value));
                            //if (AddSaleResult == "")
                            //{
                            //    ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());
                            //}
                        }
                    }

                    toolStripButton1_Click(sender, e);

                    //Invoices
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetBills();
                        InvoiceDataGridView.DataSource = Result2.Tables[0];
                        InvoiceDataGridView.Columns[0].HeaderText = "Invoice Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            InvoiceNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    InvoiceNumber_txt.Text = "";
                }
                InvoiceNumberSearch_txt.Text = "";
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyingInvoice = true; 
                BalanceNew_txt.Visible = true;
                if (InvoiceDetailDataGridView.Enabled == false)
                {
                    InvoiceDetailDataGridView.Enabled = true;
                    ItemCode_txt.Enabled = true;
                    InvoiceDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
                    InvoiceDetailDataGridView.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.FormRefresh = this.Name;
                this.Close();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void InvoiceDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (InvoiceDataGridView.Columns.Count> 0)
                    InvoiceDataGridView.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int loop = 0; loop < InvoiceDataGridView.Rows.Count; loop++)
                {
                    if (Convert.ToInt32(InvoiceDataGridView.Rows[loop].Cells["ID"].Value) < 0)
                    {
                        InvoiceDataGridView.Rows[loop].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    this.AllowDrop = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void InvoiceNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    this.AllowDrop = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CustomerName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    this.AllowDrop = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ItemCode_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    this.AllowDrop = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ItemCode_txt.Focus();
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
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (CustomerName_txt.Text != null) RandomAlgos.comboKeyPressed(CustomerName_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

        }

        private void InvoiceNumberSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (InvoiceNumberSearch_txt.Text != null) RandomAlgos.comboKeyPressed(InvoiceNumberSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void CustomerName_txt_Enter(object sender, EventArgs e)
        {
            CustomerName_txt.DroppedDown = true;
        }

        private void ItemCode_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                ItemsDataGridView.Visible = true;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
        }

        private void CustomerNameSearch_txt_Enter_1(object sender, EventArgs e)
        {
            CustomerNameSearch_txt.DroppedDown = true;
        }

        private void InvoiceNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            InvoiceNumberSearch_txt.DroppedDown = true;
        }

        private void InvoiceDetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value != null)
                {
                    ItemCode_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value.ToString();
                    ItemName_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ItemName"].Value.ToString();
                    Ctn_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    Qty_Box_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Ctn"].Value.ToString();
                    Quant_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Quant"].Value.ToString();
                    UnitPrice_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Price"].Value.ToString();
                    Ctn_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void Qty_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    UnitPrice_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void UnitPrice_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bool Added = false;
                    for (int loop = 0; loop < InvoiceDetailDataGridView.Rows.Count; loop++)
                    {
                        if (InvoiceDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value != null && InvoiceDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value.Equals(ItemCode_txt.Text))
                        {
                            InvoiceDetailDataGridView.Rows.RemoveAt(loop);
                            break;
                        }
                    }
                    if (Added == false)
                    {
                        EnterDataInGrid(sender, e);
                        ItemCode_txt.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void SpeedTest_BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                NewInvoiceNumber = 0;
                NewInvoiceNumber = Convert.ToInt32(DatabaseCalls.GetNewBillNumber());
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                _CutomerNameCollectionObject = new object[CustomerDataSet.Tables[0].Rows.Count];
                
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    _CutomerNameCollectionArray.Add(GridViewColumn.ItemArray[1].ToString());
                }
                _CutomerNameCollectionObject = _CutomerNameCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            //TO GET ITEM LIST
            try
            {
                if (ItemDetailsDataSet != null && ItemDetailsDataSet.Tables.Count > 0)
                {
                    _ItemDetailsCollectionObject = new object[ItemDetailsDataSet.Tables[0].Rows.Count];

                    foreach (DataRow asdf in ItemDetailsDataSet.Tables[0].Rows)
                    {
                        _ItemDetailsCollectionArray.Add(asdf.ItemArray[6].ToString());
                    }
                }
                _ItemDetailsCollectionObject = _ItemDetailsCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }



            //Invoices
            try
            {
                InvoiceDataSet = DatabaseCalls.GetBills();
                _InvoiceCollectionObject = new object[InvoiceDataSet.Tables[0].Rows.Count];
                foreach (DataRow GridViewColumn in InvoiceDataSet.Tables[0].Rows)
                {
                    _InvoiceCollectionArray.Add(GridViewColumn.ItemArray[0].ToString());
                }
                _InvoiceCollectionObject = _InvoiceCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            //restore process
        }

        private void SpeedTest_BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool Result = UpdateInvoices();


            try
            {
                RandomAlgos.RestoreOldSlaesDataInGrid(InvoiceDetailDataGridView, CustomerName_txt, BalanceNew_txt, Total_txt, TOTAL_ITEMS_txt, textBox7, CustomerBalance_txt);
                CustomerName_txt_Leave(sender, e);
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            
            try
            {
                InvoiceNumber_txt.Text = (NewInvoiceNumber).ToString();
                InvoiceNumberSearch_txt.Items.AddRange(_InvoiceCollectionObject);
                if (_CutomerNameCollectionObject != null)
                {
                    CustomerName_txt.Items.AddRange(_CutomerNameCollectionObject);
                    CustomerNameSearch_txt.Items.AddRange(_CutomerNameCollectionObject);
                }
                
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private bool UpdateInvoices()
        {
            try
            {
                InvoiceDataGridView.DataSource = InvoiceDataSet.Tables[0];
                InvoiceDataGridView.CurrentCell = null;
                if (InvoiceDataGridView.Columns.Count > 0)
                {
                    InvoiceDataGridView.Columns["ID"].HeaderText = "S.NO";
                    InvoiceDataGridView.Columns["CUSTOMERNAME"].HeaderText = "Customer";
                    InvoiceDataGridView.Columns["DATED"].HeaderText = "Date";
                    InvoiceDataGridView.Columns["CUSTOMER_BALANCE"].HeaderText = "Balance";
                    InvoiceDataGridView.Columns["TOTAL_CTN"].Visible = false;
                    InvoiceDataGridView.Columns["CustomerID"].Visible = false;
                    InvoiceDataGridView.Columns["NAME"].Visible = false;
                    InvoiceDataGridView.Update();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public object[] _InvoiceCollectionObject { get; set; }
        public List<string> _InvoiceCollectionArray = new List<string>();
        

        public object[] _CutomerNameCollectionObject { get; set; }
        public List<string> _CutomerNameCollectionArray = new List<string>();


        public object[] _ItemDetailsCollectionObject { get; set; }
        public List<string> _ItemDetailsCollectionArray = new List<string>();

        private void ItemCode_txt_TextChanged(object sender, EventArgs e)
        {
            //Customer Detail
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (StaticClass.Contain(ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString(),ItemCode_txt.Text,StringComparison.OrdinalIgnoreCase))
                    {
                        ItemsDataGridView.Rows[loop].Visible = true;
                    }
                    else
                    {
                        ItemsDataGridView.CurrentCell = null;
                        ItemsDataGridView.Rows[loop].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

        }

        private void ItemsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ItemsDataGridView.Visible == true)
                {
                    Thread.Sleep(100);
                    Qty_Box_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["QTY_BOX"].Value.ToString();
                    UnitPrice_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["PRICE"].Value.ToString().Trim();
                    ItemName_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["Model"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        string BILL_ITEM_ID = "";
        private void ItemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ItemsDataGridView.Visible = false;
                    Ctn_txt.Focus();
                    ItemCode_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["CODE"].Value.ToString().Trim();
                    UnitPrice_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["PRICE"].Value.ToString().Trim();
                    ItemName_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["Model"].Value.ToString().Trim();
                    Qty_Box_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["QTY_BOX"].Value.ToString();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    ItemCode_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

        }

        private void Ctn_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Value1 = 0;
                int Value2 = 0;
                int Value3 = 0;
                bool ResutlValue1 = Int32.TryParse(Ctn_txt.Text, out Value1);
                bool ResutlValue2 = Int32.TryParse(Qty_Box_txt.Text, out Value2);
                bool ResutlValue3 = Int32.TryParse(Qty_txt.Text, out Value3);
                if (!ResutlValue1)
                    Value1 = 0;
                if (!ResutlValue2)
                    Value2 = 0;
                if (!ResutlValue3)
                    Value3 = 0; 
                Quant_txt.Text = ((Value1 * Value2) + Value3).ToString();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void Ctn_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Qty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Quant_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UnitPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Total_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void BalanceNew_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TOTAL_CTN_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public bool ModifyingInvoice { get; set; }

        private void Qty_txt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UnitPrice_txt.Focus();

                if (Ctn_txt.Text == "0" && Qty_txt.Text == "0" && InvoiceDetailDataGridView.Rows.Count > 0 && ItemCode_txt.Text == InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value.ToString())
                {
                    InvoiceDetailDataGridView.Rows.RemoveAt(InvoiceDetailDataGridView.CurrentRow.Index);
                    ItemCode_txt.Text = "";
                    ItemName_txt.Text = "None";
                    Ctn_txt.Text = "0";
                    Qty_Box_txt.Text = "0";
                    Quant_txt.Text = "0";
                    UnitPrice_txt.Text = "0";
                    Total_txt_Leave(sender, e);
                    ItemCode_txt.Focus();
                }
            }
        }

        private void Qty_txt_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int Value1 = 0;
                int Value2 = 0;
                int Value3 = 0;
                bool ResutlValue1 = Int32.TryParse(Ctn_txt.Text, out Value1);
                bool ResutlValue2 = Int32.TryParse(Qty_Box_txt.Text, out Value2);
                bool ResutlValue3 = Int32.TryParse(Qty_txt.Text, out Value3);
                if (!ResutlValue1)
                    Value1 = 0;
                if (!ResutlValue2)
                    Value2 = 0;
                if (!ResutlValue3)
                    Value3 = 0;
                Quant_txt.Text = ((Value1 * Value2) + Value3).ToString();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }
    }
}
