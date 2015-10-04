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
    public partial class AddConsignment : Form
    {
        public AddConsignment()
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
                VendorName_txt.Enabled = true;
                ModifyingConsignment = false;
                ItemCode_txt.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton5.Enabled = false;
                ConsignmentDetailDataGridView.Rows.Clear();
                VendorName_txt.Text = "None";
                VendorName_txt.Focus();
                VendorAddress_txt.Text = "None";
                VendorEmail_txt.Text = "None";
                BusinessName_txt.Text = "None";
                VendorBalance_txt.Text = "0";
                VendorPhone_txt.Text = "None";
                VendorID_txt.Text = "";
                ClearData();
                //Consignment Detail
                try
                {
                    int Result1 = 0;
                    Result1 = Convert.ToInt32(DatabaseCalls.GetNewShipmentNumber());
                    ConsignmentNumber_txt.Text = (Result1).ToString();
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

        private void ClearData()
        {
            UnitSalePrice_txt.Text = "0";
            UnitCostPrice_txt.Text = "0";
            RetailPrice_txt.Text = "0";
            Total_txt.Text = "0";
            BalanceNew_txt.Text = "0";
            Qty_Box_txt.Text = "0";
        }

        public static string SelectedItemForConsignment = "";
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
                                UnitCostPrice_txt.Text = ItemsDataGridView.Rows[loop].Cells["COSTPRICE"].Value.ToString().Trim();
                                UnitSalePrice_txt.Text = ItemsDataGridView.Rows[loop].Cells["PRICE"].Value.ToString().Trim();
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


        DataTable ConsignmentDataTable = new DataTable();
        private void EnterDataInGrid(object sender, KeyEventArgs e)
        {
            try
            {
                if (Quant_txt.Text != "0")
                {
                    string[] row = { (ConsignmentDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitCostPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitCostPrice_txt.Text)).ToString() };
                    ConsignmentDetailDataGridView.Rows.Add(row);
                    ConsignmentDetailDataGridView.Update();
                    if (TOTAL_CTN_txt.Text == "")
                        TOTAL_CTN_txt.Text = "0";
                    if (Ctn_txt.Text == "")
                        Ctn_txt.Text = "0";
                    TOTAL_CTN_txt.Text = (Convert.ToInt32(TOTAL_CTN_txt.Text) + Convert.ToInt32(Ctn_txt.Text)).ToString();
                    int temp = Convert.ToInt32(textBox7.Text);
                    textBox7.Text = (++temp).ToString();
                    RandomAlgos.AddDataInSalesFile((ConsignmentDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitCostPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitCostPrice_txt.Text)).ToString(), VendorName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_CTN_txt.Text, textBox7.Text);
                }
                Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) + Convert.ToDecimal(Quant_txt.Text) * Convert.ToDecimal(UnitCostPrice_txt.Text)).ToString();
                
                ItemCode_txt.Text = "";
                ItemName_txt.Text = "None";
                RetailPrice_txt.Text = "0";
                Ctn_txt.Text = "0";
                Qty_txt.Text = "0";
                Quant_txt.Text = "0";
                UnitCostPrice_txt.Text = "0";
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

        static DataSet ConsignmentDataSet = new DataSet();
        static DataSet VendorDataSet = new DataSet();
        static DataSet ItemDetailsDataSet = new DataSet();
        static int NewConsignmentNumber = 0;

        DataSet ConsignmentDetailsDataSet = new DataSet();
        
        private void AddConsignment_Load(object sender, EventArgs e)
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
                    GetItemsForConsignmentPage();
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

        private void GetItemsForConsignmentPage()
        {
            ConsignmentDetailsDataSet = new DataSet();
            ConsignmentDetailsDataSet = DatabaseCalls.GetItems();

            try
            {
                if (ConsignmentDetailsDataSet != null && ConsignmentDetailsDataSet.Tables.Count > 0)
                {
                    ItemsDataGridView.DataSource = ConsignmentDetailsDataSet.Tables[0];
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

        private void VendorName_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (VendorName_txt.Text != "" && VendorName_txt.Text != "None")
                {
                    DataSet Result1 = new DataSet();
                    Result1 = DatabaseCalls.GetVendorByName(VendorName_txt.Text);
                    
                    foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                    {
                        VendorID_txt.Text = GridViewColumn.ItemArray[0].ToString();
                        VendorAddress_txt.Text = GridViewColumn.ItemArray[2].ToString();
                        VendorEmail_txt.Text = GridViewColumn.ItemArray[4].ToString();
                        BusinessName_txt.Text = GridViewColumn.ItemArray[8].ToString();
                        VendorBalance_txt.Text = GridViewColumn.ItemArray[6].ToString();
                        VendorPhone_txt.Text = GridViewColumn.ItemArray[3].ToString();
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
            //Add Consignment Number
            try
            {
                if (VendorID_txt.Text == "")
                {
                    MessageBox.Show("Please Select a Vendor");
                    VendorName_txt.Focus();
                    return;
                }
                if (ConsignmentNumber_txt.Text == "")
                {
                    ConsignmentNumber_txt.Text = DatabaseCalls.GetNewShipmentNumber();
                }
                String Result1 = DatabaseCalls.AddShipment(Convert.ToInt32(ConsignmentNumber_txt.Text), Convert.ToInt32(VendorID_txt.Text), Convert.ToDateTime(DateTime.Now), "Consignment");
                if (Result1 == "")
                {
                    //Add Consignment Details
                    foreach (DataGridViewRow GridViewRow in ConsignmentDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            if (GridViewRow.Cells["QUANT"].Value == "")
                            {
                                GridViewRow.Cells["QUANT"].Value = "0";
                            }
                            if (GridViewRow.Cells["Ctn"].Value == "")
                            {
                                GridViewRow.Cells["Ctn"].Value = "0";
                            }
                            if (GridViewRow.Cells["Qty"].Value == "")
                            {
                                GridViewRow.Cells["Qty"].Value = "0";
                            }
                            if (GridViewRow.Cells["SubTotal"].Value == "")
                            {
                                GridViewRow.Cells["SubTotal"].Value = "0";
                            }
                            if (GridViewRow.Cells["Price"].Value == "")
                            {
                                GridViewRow.Cells["Price"].Value = "0";
                            }

                            string AddSaleResult = DatabaseCalls.AddShipmentDetail(GridViewRow.Cells["ITEM_CODE"].Value.ToString(), ConsignmentNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["QUANT"].Value), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), GridViewRow.Cells["ItemName"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Qty"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SubTotal"].Value));
                            if (AddSaleResult == "")
                            {
                                ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());
                            }
                        }
                    }

                    toolStripButton1_Click(sender, e);


                    //Consignments
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetShipments();
                        ConsignmentDataGridView.DataSource = Result2.Tables[0];
                        ConsignmentDataGridView.Columns[0].HeaderText = "Consignment Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
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
                decimal ConsignmentTotal = 0;
                foreach (DataGridViewRow SubTotal in ConsignmentDetailDataGridView.Rows)
                {
                    ConsignmentTotal += Convert.ToDecimal(SubTotal.Cells[7].Value);
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
       
        private void ConsignmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet Result1 = new DataSet();
                try
                {
                    toolStripButton1_Click(sender, e);
                    ConsignmentDetailDataGridView.Enabled = false;
                    ConsignmentDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
                    toolStripButton2.Enabled = false;
                    ItemCode_txt.Enabled = false;
                    toolStripButton5.Enabled = true;


                    Total_txt.Text = ConsignmentDataGridView.Rows[ConsignmentDataGridView.CurrentRow.Index].Cells[5].Value.ToString();

                    ConsignmentDetailDataGridView.Focus();

                    Result1 = DatabaseCalls.GetShipmentDetails(ConsignmentDataGridView.Rows[ConsignmentDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
                    

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
                            ConsignmentDetailDataGridView.Rows.Add();
                            ConsignmentDetailDataGridView.Rows[r].Cells[0].Value = (r + 1).ToString();
                            ConsignmentDetailDataGridView.Rows[r].Cells[1].Value = Result1.Tables[0].Rows[r].ItemArray[4];
                            ConsignmentDetailDataGridView.Rows[r].Cells[2].Value = Result1.Tables[0].Rows[r].ItemArray[5];
                            ConsignmentDetailDataGridView.Rows[r].Cells[3].Value = Result1.Tables[0].Rows[r].ItemArray[7];
                            ConsignmentDetailDataGridView.Rows[r].Cells[4].Value = Result1.Tables[0].Rows[r].ItemArray[9];
                            ConsignmentDetailDataGridView.Rows[r].Cells[5].Value = (Convert.ToInt32(Result1.Tables[0].Rows[r].ItemArray[6])).ToString();
                            ConsignmentDetailDataGridView.Rows[r].Cells[6].Value = Result1.Tables[0].Rows[r].ItemArray[10];
                            ConsignmentDetailDataGridView.Rows[r].Cells[7].Value = Result1.Tables[0].Rows[r].ItemArray[11];
                            


                            TOTAL_CTN_txt.Text = (Convert.ToInt32(TOTAL_CTN_txt.Text) + (ConsignmentDetailDataGridView.Rows[r].Cells[4].Value == ""? 0 : Convert.ToInt32(ConsignmentDetailDataGridView.Rows[r].Cells[4].Value))).ToString();
                            int temp = Convert.ToInt32(textBox7.Text);
                            textBox7.Text = (++temp).ToString();
                            CostAmmount += Convert.ToInt32(ConsignmentDetailDataGridView.Rows[r].Cells["SUBTOTAL"].Value);
                            

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
                        

                        VendorID_txt.Text = Result1.Tables[0].Rows[0].ItemArray[3].ToString();
                        VendorName_txt.Text = DatabaseCalls.GetVendorName(Convert.ToInt32(VendorID_txt.Text));
                        

                        ConsignmentNumber_txt.Text = Result1.Tables[0].Rows[0].ItemArray[2].ToString();
                        

                        VendorName_txt_Leave(this, null);
                        

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
            VendorName_txt.Enabled = false;
        }

        private void Qty_txt_TextChanged(object sender, EventArgs e)
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

        private void ConsignmentNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Consignments
                for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count; loop++)
                {
                    ConsignmentDataGridView.CurrentCell = null;
                    if ((ConsignmentNumberSearch_txt.Text != "") && (ConsignmentDataGridView.Rows[loop].Cells["ID"].Value.ToString() != (ConsignmentNumberSearch_txt.Text)))
                    {
                        ConsignmentDataGridView.Rows[loop].Visible = false;
                    }
                    else
                        ConsignmentDataGridView.Rows[loop].Visible = true;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void VendorNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //Vendor Detail
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                {
                    for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count; loop++)
                    {
                        ConsignmentDataGridView.CurrentCell = null;
                        if (!StaticClass.Contain(ConsignmentDataGridView.Rows[loop].Cells["VENDORNAME"].Value.ToString(), VendorNameSearch_txt.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            ConsignmentDataGridView.Rows[loop].Visible = false;
                        }
                        else
                            ConsignmentDataGridView.Rows[loop].Visible = true;
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

        private void AddConsignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddConsignment_KeyDown(object sender, KeyEventArgs e)
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

        private void ConsignmentDetailDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                TOTAL_CTN_txt.Text = "0";
                textBox7.Text = "0";
                Total_txt.Text = "0";
                decimal CostAmmount = 0;
                int NumberOfItems = 0;
                int NumberOfCTN = 0;
                RandomAlgos.DeleteSalesFile();
                for (int loop = 0; loop < ConsignmentDetailDataGridView.Rows.Count - 1; loop++)
                {
                    RandomAlgos.AddDataInSalesFile(ConsignmentDetailDataGridView.Rows[loop].Cells[0].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[1].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[2].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[3].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[4].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[5].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[6].Value.ToString(),
                        ConsignmentDetailDataGridView.Rows[loop].Cells[7].Value.ToString(),
                        VendorName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_CTN_txt.Text, textBox7.Text);
                    CostAmmount += Convert.ToDecimal(ConsignmentDetailDataGridView.Rows[loop].Cells["SUBTOTAL"].Value);
                    NumberOfItems++;
                    if (ConsignmentDetailDataGridView.Rows[loop].Cells["Qty"].Value != "")
                    {
                        NumberOfCTN += Convert.ToInt32(ConsignmentDetailDataGridView.Rows[loop].Cells["Qty"].Value);
                    }
                    if (ConsignmentDetailDataGridView.Rows[loop].Cells["Qty"].Value == "0")
                    {
                        NumberOfCTN += Convert.ToInt32(0);
                    }
                }
                textBox7.Text = NumberOfItems.ToString();
                TOTAL_CTN_txt.Text = NumberOfCTN.ToString();
                Total_txt.Text = CostAmmount.ToString();
                ConsignmentDetailDataGridView.Enabled = true;
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
                ConsignmentDetailDataGridView.Enabled = true;
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
                    PopulateConsignmentData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Consignment Data. ";
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

        private void PopulateConsignmentData(object sender, EventArgs e)
        {
            try
            {
                for (int loop = ExcelReader.Variables.RangeCurrentIndex; loop < ExcelReader.Variables.Range.Length; loop++)
                {
                    try
                    {
                        if (VendorName_txt.Items.Contains(ExcelReader.Variables.Range[0][loop]) == true)
                        {
                            VendorName_txt.Text = ExcelReader.Variables.Range[0][loop];
                        }
                        else
                        {
                            SelectVendorName _SelectVendorName = new SelectVendorName(ExcelReader.Variables.Range[0][loop]);
                            _SelectVendorName.ShowDialog();
                            VendorName_txt.Text = _SelectVendorName.SelectedVendorName;
                            ExcelReader.Variables.Range[0][loop] = _SelectVendorName.SelectedVendorName;
                            _SelectVendorName.Dispose();
                        }
                        VendorName_txt.Focus();
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
                                        UnitSalePrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString();
                                        ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                        UnitCostPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["COSTPRICE"].Value.ToString().Trim();
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
                                                UnitCostPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["COSTPRICE"].Value.ToString().Trim();
                                                ItemName_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Model"].Value.ToString().Trim();
                                                Qty_Box_txt.Text = ItemsDataGridView.Rows[loop2].Cells["QTY_BOX"].Value.ToString();
                                                UnitSalePrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString();
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

                                    Qty_txt.Text = ItemQuantity;
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
                Variables.NotificationMessageText = "Consignment Added\r\nGetting new Consignment.";

                ExcelReader.Variables.RangeCurrentIndex++;
                if (ExcelReader.Variables.Range != null && ExcelReader.Variables.RangeCurrentIndex < ExcelReader.Variables.Range.Length && ExcelReader.Variables.Range[0][ExcelReader.Variables.RangeCurrentIndex] != "-----")
                {
                    PopulateConsignmentData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Consignment Data. ";
                }
                else if (ExcelReader.Variables.Range[0][ExcelReader.Variables.RangeCurrentIndex] == "-----")
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "End of Vendors List";
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
                VendorName_txt.Enabled = true;
                ModifyingConsignment = false;
                if (ConsignmentNumber_txt.Text != "")
                {
                    DataSet ConsignmentDataSet = new DataSet();
                    ConsignmentDataSet = DatabaseCalls.GetShipment(ConsignmentNumber_txt.Text);
                    if (ConsignmentDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Consignment Found";
                        return;
                    }

                    DataSet VendorDataSet = new DataSet();
                    VendorDataSet = DatabaseCalls.GetVendor(Convert.ToInt32(ConsignmentDataSet.Tables[0].Rows[0]["VendorID"].ToString()));
                    if (VendorDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Vendor Found";
                        return;
                    }
                    DatabaseCalls.DeleteShipmentDetails(ConsignmentNumber_txt.Text);

                    //add Updated Consignment Detail
                    //Add Consignment Details
                    foreach (DataGridViewRow GridViewRow in ConsignmentDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            // PCS_CTN, QUANT, CUSTOMER_ID

                            string AddSaleResult = DatabaseCalls.AddShipmentDetail(GridViewRow.Cells["ITEM_CODE"].Value.ToString(), ConsignmentNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["QUANT"].Value), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), GridViewRow.Cells["ItemName"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Qty"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SubTotal"].Value));
                            if (AddSaleResult == "")
                            {
                                ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());    
                            }
                        }
                    }

                    toolStripButton1_Click(sender, e);

                    //Consignments
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetShipments();
                        ConsignmentDataGridView.DataSource = Result2.Tables[0];
                        ConsignmentDataGridView.Columns[0].HeaderText = "Consignment Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    ConsignmentNumber_txt.Text = "";
                }
                ConsignmentNumberSearch_txt.Text = "";
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
                ModifyingConsignment = true; 
                BalanceNew_txt.Visible = true;
                if (ConsignmentDetailDataGridView.Enabled == false)
                {
                    ConsignmentDetailDataGridView.Enabled = true;
                    ItemCode_txt.Enabled = true;
                    ConsignmentDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
                    ConsignmentDetailDataGridView.Focus();
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

        private void ConsignmentDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (ConsignmentDataGridView.Columns.Count> 0)
                    ConsignmentDataGridView.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count; loop++)
                {
                    if (Convert.ToInt32(ConsignmentDataGridView.Rows[loop].Cells["ID"].Value) < 0)
                    {
                        ConsignmentDataGridView.Rows[loop].Visible = false;
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

        private void VendorNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ConsignmentNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void VendorName_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void VendorName_txt_KeyUp(object sender, KeyEventArgs e)
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
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (VendorName_txt.Text != null) RandomAlgos.comboKeyPressed(VendorName_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

        }

        private void ConsignmentNumberSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (ConsignmentNumberSearch_txt.Text != null) RandomAlgos.comboKeyPressed(ConsignmentNumberSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void VendorName_txt_Enter(object sender, EventArgs e)
        {
            VendorName_txt.DroppedDown = true;
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

        private void VendorNameSearch_txt_Enter_1(object sender, EventArgs e)
        {
            VendorNameSearch_txt.DroppedDown = true;
        }

        private void ConsignmentNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            ConsignmentNumberSearch_txt.DroppedDown = true;
        }

        private void ConsignmentDetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value != null)
                {
                    ItemCode_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value.ToString();
                    ItemName_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["ItemName"].Value.ToString();
                    Ctn_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    Qty_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["Ctn"].Value.ToString();
                    Quant_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["Quant"].Value.ToString();
                    UnitCostPrice_txt.Text = ConsignmentDetailDataGridView.Rows[ConsignmentDetailDataGridView.CurrentRow.Index].Cells["Price"].Value.ToString();

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
                    UnitCostPrice_txt.Focus();
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
                    UnitSalePrice_txt.Focus();
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
            //Consignment Detail
            try
            {
                NewConsignmentNumber = 0;
                NewConsignmentNumber = Convert.ToInt32(DatabaseCalls.GetNewShipmentNumber());
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            //Vendor Detail
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                _CutomerNameCollectionObject = new object[VendorDataSet.Tables[0].Rows.Count];
                
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
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
                ItemDetailsDataSet = DatabaseCalls.GetItems();
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



            //Consignments
            try
            {
                ConsignmentDataSet = DatabaseCalls.GetShipments();
                _ConsignmentCollectionObject = new object[ConsignmentDataSet.Tables[0].Rows.Count];
                foreach (DataRow GridViewColumn in ConsignmentDataSet.Tables[0].Rows)
                {
                    _ConsignmentCollectionArray.Add(GridViewColumn.ItemArray[0].ToString());
                }
                _ConsignmentCollectionObject = _ConsignmentCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void SpeedTest_BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool Result = UpdateConsignments();


            try
            {
                RandomAlgos.RestoreOldSlaesDataInGrid(ConsignmentDetailDataGridView, VendorName_txt, BalanceNew_txt, Total_txt, TOTAL_CTN_txt, textBox7, VendorBalance_txt);
                VendorName_txt_Leave(sender, e);
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            
            try
            {
                ConsignmentNumber_txt.Text = (NewConsignmentNumber).ToString();
                ConsignmentNumberSearch_txt.Items.AddRange(_ConsignmentCollectionObject);
                if (_CutomerNameCollectionObject != null)
                {
                    VendorName_txt.Items.AddRange(_CutomerNameCollectionObject);
                    VendorNameSearch_txt.Items.AddRange(_CutomerNameCollectionObject);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private bool UpdateConsignments()
        {
            try
            {
                ConsignmentDataGridView.DataSource = ConsignmentDataSet.Tables[0];
                ConsignmentDataGridView.CurrentCell = null;
                if (ConsignmentDataGridView.Columns.Count > 0)
                {
                    ConsignmentDataGridView.Columns["ID"].HeaderText = "S.NO";
                    ConsignmentDataGridView.Columns["VENDORNAME"].HeaderText = "Vendor";
                    ConsignmentDataGridView.Columns["DATED"].HeaderText = "Date";
                    ConsignmentDataGridView.Columns["TOTAL_CTN"].HeaderText = "Ctn";
                    ConsignmentDataGridView.Columns["VENDOR_BALANCE"].HeaderText = "Balance";
                    ConsignmentDataGridView.Columns["REMARKS"].HeaderText = "Remarks";

                    ConsignmentDataGridView.Columns["VendorID"].Visible = false;
                    ConsignmentDataGridView.Update();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public object[] _ConsignmentCollectionObject { get; set; }
        public List<string> _ConsignmentCollectionArray = new List<string>();
        

        public object[] _CutomerNameCollectionObject { get; set; }
        public List<string> _CutomerNameCollectionArray = new List<string>();


        public object[] _ItemDetailsCollectionObject { get; set; }
        public List<string> _ItemDetailsCollectionArray = new List<string>();

        private void ItemCode_txt_TextChanged(object sender, EventArgs e)
        {
            //Vendor Detail
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
                    UnitCostPrice_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["COSTPRICE"].Value.ToString().Trim();
                    ItemName_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["Model"].Value.ToString().Trim();
                    UnitSalePrice_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["PRICE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        string SHIPMENT_ITEM_ID = "";
        private void ItemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ItemsDataGridView.Visible = false;
                    Ctn_txt.Focus();
                    if (ItemsDataGridView.CurrentRow != null)
                    {
                        int RowNumber = ItemsDataGridView.CurrentRow.Index;
                        ItemCode_txt.Text = ItemsDataGridView.Rows[RowNumber].Cells["CODE"].Value.ToString().Trim();
                        UnitCostPrice_txt.Text = ItemsDataGridView.Rows[RowNumber].Cells["COSTPRICE"].Value.ToString().Trim();
                        ItemName_txt.Text = ItemsDataGridView.Rows[RowNumber].Cells["Model"].Value.ToString().Trim();
                        Qty_Box_txt.Text = ItemsDataGridView.Rows[RowNumber].Cells["QTY_BOX"].Value.ToString();
                        UnitSalePrice_txt.Text = ItemsDataGridView.Rows[RowNumber].Cells["PRICE"].Value.ToString();
                    }
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

        private void button7_Click(object sender, EventArgs e)
        {
            AddItemPnl.Visible = true;
            ItemCodeCons_txt.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Result = "";
            try
            {
                if (ItemCodeCons_txt.Text == "")
                {
                    AddItemPnl.Visible = false;
                    return;
                }
                Result = DatabaseCalls.AddItem(ItemCodeCons_txt.Text, ItemModelCons_txt.Text, Convert.ToInt32(ItemQuantityCons_txt.Text), Convert.ToDecimal(ItemPriceCons_txt.Text), Convert.ToDecimal(ItemCostPriceCons_txt.Text), "", ItemCategoryCons_txt.Text, Convert.ToDecimal(RetailPrice_txt.Text));
                ItemCodeCons_txt.Text = "";
                ItemModelCons_txt.Text= "";
                ItemQuantityCons_txt.Text= "";
                ItemPriceCons_txt.Text= "";
                ItemCostPriceCons_txt.Text= "";
                ItemCategoryCons_txt.Text = "";

                if (Result != "")
                {
                    return;
                }
                GetItemsForConsignmentPage();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
                Console.WriteLine(ex.Message);
            }

            AddItemPnl.Visible = false;
        }

        private void ItemQuantityCons_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ItemPriceCons_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ItemCostPriceCons_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
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

        public bool ModifyingConsignment { get; set; }

        private void UnitSalePrice_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UnitCostPrice_txt.Text == "")
                    UnitCostPrice_txt.Text = "0";
                if (Quant_txt.Text == "")
                    Quant_txt.Text = "0";
                if (Qty_txt.Text == "")
                    Qty_txt.Text = "0";
                if (Ctn_txt.Text == "")
                    Ctn_txt.Text = "0";
                if (Qty_Box_txt.Text == "")
                    Qty_Box_txt.Text = "0";
                
                DatabaseCalls.ModifyItemPrice(ItemCode_txt.Text, Convert.ToDecimal(UnitCostPrice_txt.Text), Convert.ToDecimal(UnitSalePrice_txt.Text));
                bool Added = false;
                for (int loop = 0; loop < ConsignmentDetailDataGridView.Rows.Count; loop++)
                {
                    if (ConsignmentDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value != null && ConsignmentDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value.Equals(ItemCode_txt.Text))
                    {
                        ConsignmentDetailDataGridView.Rows.RemoveAt(loop);
                            loop--;
                    }
                }

                for (int loop = 0; loop < ConsignmentDetailDataGridView.Rows.Count; loop++)
                {
                    if (ConsignmentDetailDataGridView.Rows[loop].Cells["Quant"].Value == "" || ConsignmentDetailDataGridView.Rows[loop].Cells["Quant"].Value == "0")
                    {
                        ConsignmentDetailDataGridView.Rows.RemoveAt(loop);
                            loop--;
                    }
                }

                if (Added == false)
                {
                    EnterDataInGrid(sender, e);
                    ItemCode_txt.Focus();
                }
                GetItemsForConsignmentPage();
                ClearData();
            }
        }

        private void UpdateItemPrices_btn_Click(object sender, EventArgs e)
        {
        }

        private void RetailPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void RetailPrice_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    SendKeys.Send("{TAB}");
            }
        }

        private void ItemCostPriceCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    SendKeys.Send("{TAB}");
            }
        }

        private void ItemPriceCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ItemQuantityCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ItemModelCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddItemPnl.Visible = false;
        }

        private void ItemCodeCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ItemCategoryCons_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
