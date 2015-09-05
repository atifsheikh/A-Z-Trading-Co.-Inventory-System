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
    public partial class AddBill : Form
    {
        public AddBill()
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
                ItemCode_txt.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton5.Enabled = false;
                BillDetailDataGridView.Rows.Clear();
                CustomerName_txt.Text = "None";
                CustomerName_txt.Focus();
                CustomerAddress_txt.Text = "None";
                CustomerEmail_txt.Text = "None";
                CustomerBalance_txt.Text = "0";
                CustomerPhone_txt.Text = "None";
                CustomerID_txt.Text = "";
                Total_txt.Text = "0";
                BalanceNew_txt.Text = "0";
                //Bill Detail
                try
                {
                    int Result1 = 0;
                    Result1 = Convert.ToInt32(DatabaseCalls.GetNewBillNumber());
                    BillNumber_txt.Text = (++Result1).ToString();
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

        public static string SelectedItemForBill = "";
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
                            if (ItemsDataGridView.Rows[loop].Visible == true)// && ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString() == ItemCode_txt.Text)
                            {
                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop].Cells["PRICE"].Value.ToString().Trim();
                                ItemCode_txt.Text = ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString().Trim();
                                ItemName_txt.Text = ItemsDataGridView.Rows[loop].Cells["Model"].Value.ToString().Trim();
                                Qty_txt.Text = ItemsDataGridView.Rows[loop].Cells["QTY_BOX"].Value.ToString();
                                //RemainingPcs_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["CTN_LEFT"].Value.ToString();
                                //Qty_txt.Text = ItemsDataGridView.Rows[loop].Cells["INNER_BOX"].Value.ToString();
                                //Qty_txt.Text = 
                                //Quant_txt.Text = ItemsDataGridView.Rows[loop].Cells["T_QUANTITY"].Value.ToString();
                                //Qty_inner_txt.Text = ItemsDataGridView.Rows[loop].Cells["QTY_INNER"].Value.ToString();
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



            //if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Enter && e.KeyValue != 27)
            //{
            //    if (ItemName_txt.Text != null && ItemName_txt.Text != "None")
            //    {
            //        RandomAlgos.comboKeyPressed(ItemCode_txt);
            //        if (ItemCode_txt.Text != "")
            //            SelectedItemForBill = ItemCode_txt.Text;

            //    }
            ////}
            //else if (e.KeyCode == Keys.Enter)
            //{
            //    string temp = ItemCode_txt.Text;
            //    if (ItemCode_txt.SelectedIndex == -1)
            //    {
            //        {
            //            if (ItemCode_txt.Items[0].ToString().Contains(SelectedItemForBill) == true)
            //            {
            //                temp = ItemCode_txt.Items[0].ToString();
            //                //ItemCode_txt.DroppedDown = false;
            //                Qty_txt.Focus();
            //                //ItemCode_txt_Leave(sender, e);
            //                ItemCode_txt.SelectedIndex = -1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Qty_txt.Focus();
            //    //    ItemCode_txt_Leave(sender, e);
            //    }
            //    ItemCode_txt.Text = temp;
            //    //SendKeys.Send("{TAB}");
            //}
            //}
            //catch (Exception ex)
            //{
            //    Variables.NotificationStatus = true;
            //    Variables.NotificationMessageTitle = this.Name;
            //    Variables.NotificationMessageText = ex.Message;
            //}
        }


        DataTable BillDataTable = new DataTable();
        private void EnterDataInGrid(object sender, KeyEventArgs e)
        {
            try
            {
                string[] row = { (BillDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString() };
                BillDetailDataGridView.Rows.Add(row);
                BillDetailDataGridView.Update();
                textBox8.Text = (Convert.ToInt32(textBox8.Text) + Convert.ToInt32(Ctn_txt.Text)).ToString();
                int temp = Convert.ToInt32(textBox7.Text);
                textBox7.Text = (++temp).ToString();
                RandomAlgos.AddDataInSalesFile((BillDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString(), CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, textBox8.Text, textBox7.Text);
                Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) + Convert.ToDecimal(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString();
                ItemCode_txt.Text = "";
                ItemName_txt.Text = "None";
                Ctn_txt.Text = "0";
                Qty_txt.Text = "0";
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

        static DataSet BillDataSet = new DataSet();
        static DataSet CustomerDataSet = new DataSet();
        static DataSet ItemDetailsDataSet = new DataSet();
        static int NewBillNumber = 0;

        DataSet ConsignmentDetailsDataSet = new DataSet();
        
        private void AddBill_Load(object sender, EventArgs e)
        {
            try
            {
                SpeedTest_BGWorker.RunWorkerAsync();                //TO GET Consingment Detail LIST
                try
                {
                    ConsignmentDetailsDataSet = new DataSet();
                    ConsignmentDetailsDataSet = DatabaseCalls.GetItemsForSale();//.GetConsignmentDetails();
                    //ConsignmentDetailsDataSet.Tables[0].Columns.Add("Stock");
                    //for (int loop = 0; loop < ConsignmentDetailsDataSet.Tables[0].Rows.Count; loop++)
                    //{
                    //    //ConsignmentDetailsDataSet.Tables[0].Rows[loop]["Stock"] = (Convert.ToInt32(ConsignmentDetailsDataSet.Tables[0].Rows[loop]["T_QUANTITY"]) - Convert.ToInt32(ConsignmentDetailsDataSet.Tables[0].Rows[loop]["T_QUANTITY_SOLD"])).ToString();
                    //}

                    try
                    {
                        ItemsDataGridView.DataSource = ConsignmentDetailsDataSet.Tables[0];
                        try
                        {
                            ItemsDataGridView.Columns[0].Visible = false;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -4"); }

                        try
                        {
                            //ItemsDataGridView.Columns["SHIP_ID"].Visible = false;//.DisplayIndex = 0;
                            ItemsDataGridView.Columns["CODE"].DisplayIndex = 0;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -4"); }

                        try
                        {
                            ItemsDataGridView.Columns["MODEL"].DisplayIndex = 1;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -5"); }
                        //                ItemsDataGridView.Columns["MODEL"].HeaderText = "Discription";
                        try
                        {
                            ItemsDataGridView.Columns["QTY_BOX"].DisplayIndex = 3;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -7"); }
                        try
                        {
                            ItemsDataGridView.Columns["QUANTITY"].DisplayIndex = 4;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -8"); }
                        //                    ItemsDataGridView.Columns["QTY_INNER"].DisplayIndex = 5;
                        //                  ItemsDataGridView.Columns["INNER_BOX"].DisplayIndex = 6;
                        //ItemsDataGridView.Columns["PURCHASE_PRICE"].DisplayIndex = 5;
                        //ItemsDataGridView.Columns["P_SUBTOTAL"].DisplayIndex = 7;
                        try
                        {
                            ItemsDataGridView.Columns["PRICE"].DisplayIndex = 5;
                        }
                        catch (Exception ex)
                        { MessageBox.Show("error -9"); }
                    }
                    catch (Exception ex)
                    { MessageBox.Show("error -3"); }


                    //ItemsDataGridView.Columns["ITEM_ID"].Visible = false;



                    //for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                    //{
                    //    if (VendorName_txt.Items.Contains(ItemsDataGridView.Rows[loop].Cells["SHIP_ID"].Value) == false)
                    //    {
                    //        VendorName_txt.Items.Add(ItemsDataGridView.Rows[loop].Cells["SHIP_ID"].Value);
                    //    }
                    //}
                    //VendorName_txt.Text = "   ";
                    //ItemSearchName_txt_TextChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error -1");
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
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
                if (CustomerName_txt.Text != "")
                {
                    DataSet Result1 = new DataSet();
                    Result1 = DatabaseCalls.GetCustomer(CustomerName_txt.Text);
                    
                    foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                    {
                        CustomerID_txt.Text = GridViewColumn.ItemArray[0].ToString();//ID
                        CustomerAddress_txt.Text = GridViewColumn.ItemArray[2].ToString();//address
                        CustomerPhone_txt.Text = GridViewColumn.ItemArray[4].ToString();//phone
                        CustomerBalance_txt.Text = GridViewColumn.ItemArray[5].ToString();//balance
                        BalanceNew_txt.Text = (Convert.ToDecimal(CustomerBalance_txt.Text) + Convert.ToDecimal(Total_txt.Text)).ToString();
                        CustomerEmail_txt.Text = GridViewColumn.ItemArray[3].ToString();//email
                        decimal CalculatedBalance = Convert.ToDecimal(DatabaseCalls.GetCurrentRowBalance(CustomerID_txt.Text, BillNumber_txt.Text));
                        if (CalculatedBalance != Convert.ToDecimal(CustomerBalance_txt.Text))
                        {
                            Variables.NotificationStatus = true;
                            Variables.NotificationMessageTitle = this.Name;
                            Variables.NotificationMessageText = "Critical Message for Admin: The CUSTOMER_BALANCE is incorrect :| ";
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Add Bill Number
            try
            {
                String Result1 = DatabaseCalls.AddBill(Convert.ToInt32(BillNumber_txt.Text), Convert.ToInt32(CustomerID_txt.Text), Convert.ToDateTime(BillDate_txt.Text), Convert.ToDecimal(Total_txt.Text), Convert.ToDecimal(BalanceNew_txt.Text),"Bill");
                if (Result1.StartsWith("Bill Added with ID") == true)
                {
                    //Add Bill Details
                    foreach (DataGridViewRow GridViewRow in BillDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            // PCS_CTN, QUANT, CUSTOMER_ID

                            String AddSaleResult = DatabaseCalls.AddSale(Convert.ToDecimal(GridViewRow.Cells[6].Value), Convert.ToInt32(GridViewRow.Cells[4].Value), Convert.ToInt32(BillNumber_txt.Text), Convert.ToDecimal(GridViewRow.Cells[7].Value), GridViewRow.Cells[1].Value.ToString(), GridViewRow.Cells[2].Value.ToString(), Convert.ToInt32(GridViewRow.Cells[3].Value), Convert.ToInt32(GridViewRow.Cells[5].Value), Convert.ToInt32(CustomerID_txt.Text));
                            if (AddSaleResult.StartsWith("Customer Balance Updated") != true)
                            {
                                ItemDetails = DatabaseCalls.GetItemDetails("code", GridViewRow.Cells[1].Value.ToString());
                                int UpdatedItem_Quantity = (Convert.ToInt32(ItemDetails.Tables[0].Rows[0]["T_QUANTITY"]) - Convert.ToInt32(GridViewRow.Cells[5].Value));
                                String UpdateItemResult = DatabaseCalls.AddItemQutantity(GridViewRow.Cells[1].Value.ToString(), UpdatedItem_Quantity);
                                if (UpdateItemResult.StartsWith("Item Quantity Modified") != true)
                                {
                                    Variables.NotificationStatus = true;
                                    Variables.NotificationMessageTitle = this.Name;
                                    Variables.NotificationMessageText = UpdateItemResult;
                                    //return;
                                }
                            }
                        }
                    }

                    toolStripButton1_Click(sender, e);


                    //Bills
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetBills();
                        BillDataGridView.DataSource = Result2.Tables[0];
                        BillDataGridView.Columns[0].HeaderText = "Bill Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                        }

                        //BillNumber_txt.Text = (++Result1).ToString();
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
            //try
            //{
            //    if (ItemCode_txt.Text != "")
            //    {
            //        ItemDetails = DatabaseCalls.GetItemDetails("code", ItemCode_txt.Text);
                    
            //        if (ItemDetails.Tables[0].Rows.Count <= 0)
            //        {
            //            Variables.NotificationMessageTitle = this.Name;
            //            Variables.NotificationMessageText = "Item Does Not Exist";
            //            Variables.NotificationStatus = true;
            //            ItemCode_txt.Focus();
            //        }
            //        foreach (DataRow GridViewColumn in ItemDetails.Tables[0].Rows)
            //        {
            //            int RemainingCount = DatabaseCalls.GetItemCount(ItemCode_txt.Text);
            //            if (RemainingCount < 1)
            //            {
            //                Variables.NotificationMessageText = "Item Count is 0";
            //                Variables.NotificationMessageTitle = this.Name;
            //                Variables.NotificationStatus = true;
            //                ItemCode_txt.Focus();
            //                break;
            //            }
            //            else 
            //            {
            //                ItemName_txt.Text = GridViewColumn.ItemArray[5].ToString();
            //                Ctn_txt.Text = GridViewColumn.ItemArray[1].ToString();
            //                Qty_txt.Text = "0";
            //                Quant_txt.Text = (Convert.ToInt32(Ctn_txt.Text) * Convert.ToInt32(Qty_txt.Text)).ToString();
            //                UnitPrice_txt.Text = GridViewColumn.ItemArray[2].ToString();
            //                RemainingPcs_txt.Text = RemainingCount.ToString();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Variables.NotificationStatus = true;
            //Variables.NotificationMessageTitle = this.Name;
            //Variables.NotificationMessageText = ex.Message;
            //}
        }

        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Ctn_txt.Text == "0")
                    {
                        BillDetailDataGridView.Rows.RemoveAt(rowIndex);
                        ItemCode_txt.Text = "";
                        ItemName_txt.Text = "None";
                        Ctn_txt.Text = "0";
                        Qty_txt.Text = "0";
                        Quant_txt.Text = "0";
                        UnitPrice_txt.Text = "0";
                        //BillDate_txt.Focus();
                        Total_txt_Leave(sender, e);
                        ItemCode_txt.Focus();
                    }
                    else
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

        private void Total_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal BillTotal = 0;
                foreach (DataGridViewRow SubTotal in BillDetailDataGridView.Rows)
                {
                    BillTotal += Convert.ToDecimal(SubTotal.Cells[7].Value);
                }
                //if (BillTotal != 0 && Total_txt.Text == (BillTotal).ToString())//+ Convert.ToInt32(Quant_txt.Text) * Convert.ToInt32(UnitPrice_txt.Text)

                BalanceNew_txt.Text = (Convert.ToDecimal(CustomerBalance_txt.Text) + Convert.ToDecimal(Total_txt.Text)).ToString();
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
       
        private void BillDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = e.RowIndex;
                DataSet Result1 = new DataSet();
                try
                {
                    //            BalanceNew_txt.Visible = false;
                    toolStripButton1_Click(sender, e);
                    //            BillDetailDataGridView.Rows.Clear();
                    BillDetailDataGridView.Enabled = false;
                    BillDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

                    toolStripButton2.Enabled = false;
                    ItemCode_txt.Enabled = false;
                    toolStripButton5.Enabled = true;


                    Total_txt.Text = BillDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
                    Result1 = DatabaseCalls.GetSale(BillDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
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
                            BillDetailDataGridView.Rows.Add();
                            BillDetailDataGridView.Rows[r].Cells[0].Value = (r + 1).ToString();
                            BillDetailDataGridView.Rows[r].Cells[1].Value = Result1.Tables[0].Rows[r].ItemArray[3];
                            BillDetailDataGridView.Rows[r].Cells[2].Value = Result1.Tables[0].Rows[r].ItemArray[4];
                            BillDetailDataGridView.Rows[r].Cells[3].Value = Result1.Tables[0].Rows[r].ItemArray[5];
                            BillDetailDataGridView.Rows[r].Cells[4].Value = Result1.Tables[0].Rows[r].ItemArray[1];
                            BillDetailDataGridView.Rows[r].Cells[5].Value = (Convert.ToInt32(Result1.Tables[0].Rows[r].ItemArray[6]) * (-1)).ToString();
                            BillDetailDataGridView.Rows[r].Cells[6].Value = Result1.Tables[0].Rows[r].ItemArray[7];
                            BillDetailDataGridView.Rows[r].Cells[7].Value = Result1.Tables[0].Rows[r].ItemArray[8];

                            textBox8.Text = (Convert.ToInt32(textBox8.Text) + Convert.ToInt32(BillDetailDataGridView.Rows[r].Cells[4].Value)).ToString();
                            int temp = Convert.ToInt32(textBox7.Text);
                            textBox7.Text = (++temp).ToString();
                            CostAmmount += Convert.ToInt32(BillDetailDataGridView.Rows[r].Cells["SUBTOTAL"].Value);
                        }
                        Total_txt.Text = CostAmmount.ToString();
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    //                Total_txt_Leave(sender, e);
                    try
                    {
                        CustomerID_txt.Text = Result1.Tables[0].Rows[0].ItemArray[9].ToString();
                        CustomerName_txt.Text = DatabaseCalls.GetCustomerName(Convert.ToInt32(CustomerID_txt.Text));
                        BillNumber_txt.Text = Result1.Tables[0].Rows[0].ItemArray[2].ToString();
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
                    try
                    {
                    Result1 = DatabaseCalls.GetBill(BillDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                    
                        CustomerID_txt.Text = Result1.Tables[0].Rows[0].ItemArray[1].ToString();
                        CustomerName_txt.Text = DatabaseCalls.GetCustomerName(Convert.ToInt32(CustomerID_txt.Text));
                        BillNumber_txt.Text = Result1.Tables[0].Rows[0].ItemArray[0].ToString();
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
            BillNumber_txt.Focus();
//            ItemCode_txt.Focus();
            //            BillDetailDataGridView.Columns["ITEM_CODE"] = Result1.Tables[0].Columns["ITEM_CODE"];
        }

        private void Qty_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void BillNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Bills
                for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                {
                    BillDataGridView.CurrentCell = null;
                    if ((BillNumberSearch_txt.Text != "") && (BillDataGridView.Rows[loop].Cells["ID"].Value.ToString() != (BillNumberSearch_txt.Text)))
                    {
                        BillDataGridView.Rows[loop].Visible = false;
                    }
                    else
                        BillDataGridView.Rows[loop].Visible = true;
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
                        for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                        {
                            BillDataGridView.CurrentCell = null;
                            if (BillDataGridView.Rows[loop].Cells["Customer_ID"].Value.ToString() != (GridViewColumn.ItemArray[0].ToString()))
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
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void AddBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddBill_KeyDown(object sender, KeyEventArgs e)
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

        private void BillDetailDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                textBox8.Text = "0";
                textBox7.Text = "0";
                Total_txt.Text = "0";
                decimal CostAmmount = 0;
                int NumberOfItems = 0;
                int NumberOfCTN = 0;
                RandomAlgos.DeleteSalesFile();
                for (int loop = 0; loop < BillDetailDataGridView.Rows.Count - 1; loop++)// DataGridViewRow OneRow in ConsignmentDataGridView.Rows)
                {
                    RandomAlgos.AddDataInSalesFile(BillDetailDataGridView.Rows[loop].Cells[0].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[1].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[2].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[3].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[4].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[5].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[6].Value.ToString(),
                        BillDetailDataGridView.Rows[loop].Cells[7].Value.ToString(),
                        CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, textBox8.Text, textBox7.Text);
                    //                RandomAlgos.DeleteDataFromFile(SrNo, string ItemCode, string ItemName, string Ctn, string Qty, string Quant, string UnitPrice, string SubTotal,string CustomerName,string BalanceNew,string Total,string textBox8,string textBox7);
                    CostAmmount += Convert.ToDecimal(BillDetailDataGridView.Rows[loop].Cells["SUBTOTAL"].Value);
                    NumberOfItems++;// += Convert.ToInt32(OneRow["Sub-Total"]);
                    NumberOfCTN += Convert.ToInt32(BillDetailDataGridView.Rows[loop].Cells["Qty"].Value);
                }
                textBox7.Text = NumberOfItems.ToString();
                textBox8.Text = NumberOfCTN.ToString();
                Total_txt.Text = CostAmmount.ToString();
                BillDetailDataGridView.Enabled = true;
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
                BillDetailDataGridView.Enabled = true;
                OpenFileDialog _OpenFileDialog = new OpenFileDialog();
                _OpenFileDialog.ShowDialog();
                //string filename =
                if (_OpenFileDialog.FileName.EndsWith(".xlsx") || _OpenFileDialog.FileName.EndsWith(".xls"))
                {

                    ExcelReader.Variables.FileName = _OpenFileDialog.FileName;
                    ExcelReader.ExcelTool _tool = new ExcelTool();
                    _tool.ShowDialog();
                    _tool.Close();
                    _tool.Dispose();
                    ExcelReader.Variables.FileName = "";
                    ExcelReader.Variables.RangeCurrentIndex = 1;
                    PopulateBillData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Bill Data. ";
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

        private void PopulateBillData(object sender, EventArgs e)
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
                                        MatchFound = true;                //item
                                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Quantity"].Value.ToString();
                                        ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                        UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString().Trim();
                                        ItemName_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Model"].Value.ToString().Trim();
                                        Qty_txt.Text = ItemsDataGridView.Rows[loop2].Cells["QTY_BOX"].Value.ToString();
                                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CTN_LEFT"].Value.ToString();
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
                                                MatchFound = true;                //item
                                                //RemainingPcs_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Quantity"].Value.ToString();
                                                ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["PRICE"].Value.ToString().Trim();
                                                ItemName_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Model"].Value.ToString().Trim();
                                                Qty_txt.Text = ItemsDataGridView.Rows[loop2].Cells["QTY_BOX"].Value.ToString();
                                                //RemainingPcs_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CTN_LEFT"].Value.ToString();
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
                                    //                                KeyEventArgs KeyEvent = new KeyEventArgs(Keys.Enter);
//                                    EnterDataInGrid(sender, null);
                                }
                                //textBox8_KeyDown(null, KeyEvent);
                                //break;
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
                Variables.NotificationMessageText = "Bill Added\r\nGetting new Bill.";

                ExcelReader.Variables.RangeCurrentIndex++;
                if (ExcelReader.Variables.Range != null && ExcelReader.Variables.RangeCurrentIndex < ExcelReader.Variables.Range.Length && ExcelReader.Variables.Range[0][ExcelReader.Variables.RangeCurrentIndex] != "-----")
                {
                    PopulateBillData(sender, e);
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Confirm the Bill Data. ";
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
                if (BillNumber_txt.Text != "")
                {
                    DataSet BillDataSet = new DataSet();
                    BillDataSet = DatabaseCalls.GetBill(BillNumber_txt.Text);
                    if (BillDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Bill Found";
                        return;
                    }

                    DataSet CustomerDataSet = new DataSet();
                    CustomerDataSet = DatabaseCalls.GetCustomer(Convert.ToInt32(BillDataSet.Tables[0].Rows[0]["CUSTOMER_ID"].ToString()));
                    if (CustomerDataSet.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Customer Found";
                        return;
                    }
                    decimal CustomerNewBalance = Convert.ToDecimal(BalanceNew_txt.Text);
                    //                CustomerNewBalance -= Convert.ToDecimal(
                    DatabaseCalls.ModifyCustomer(Convert.ToInt32(BillDataSet.Tables[0].Rows[0]["Customer_ID"]), CustomerNewBalance);
                    DatabaseCalls.DeleteBillDetails(BillNumber_txt.Text);
                    DatabaseCalls.ModifyVoucher(Convert.ToInt32(BillNumber_txt.Text), Convert.ToDecimal(Total_txt.Text), CustomerNewBalance);
                    //DatabaseCalls.DeleteBill(BillNumberSearch_txt.Text);

                    //add Updated Bill Detail
                    //Add Bill Details
                    foreach (DataGridViewRow GridViewRow in BillDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            // PCS_CTN, QUANT, CUSTOMER_ID

                            String AddSaleResult = DatabaseCalls.AddSale(Convert.ToDecimal(GridViewRow.Cells[6].Value), Convert.ToInt32(GridViewRow.Cells[4].Value), Convert.ToInt32(BillNumber_txt.Text), Convert.ToDecimal(GridViewRow.Cells[7].Value), GridViewRow.Cells[1].Value.ToString(), GridViewRow.Cells[2].Value.ToString(), Convert.ToInt32(GridViewRow.Cells[3].Value), Convert.ToInt32(GridViewRow.Cells[5].Value), Convert.ToInt32(CustomerID_txt.Text));
                            if (AddSaleResult.StartsWith("Customer Balance Updated") != true)
                            {
                                ItemDetails = DatabaseCalls.GetItemDetails("code", GridViewRow.Cells[1].Value.ToString());
                                int UpdatedItem_Quantity = (Convert.ToInt32(ItemDetails.Tables[0].Rows[0]["T_QUANTITY"]) - Convert.ToInt32(GridViewRow.Cells[5].Value));
                                String UpdateItemResult = DatabaseCalls.AddItemQutantity(GridViewRow.Cells[1].Value.ToString(), UpdatedItem_Quantity);
                                if (UpdateItemResult.StartsWith("Item Quantity Modified") != true)
                                {
                                    Variables.NotificationStatus = true;
                                    Variables.NotificationMessageTitle = this.Name;
                                    Variables.NotificationMessageText = UpdateItemResult;
                                    //return;
                                }
                            }
                        }
                    }

                    //Update Customer New Balance
                    string ModifyCustomerResult = DatabaseCalls.ModifyCustomer(Convert.ToInt32(CustomerID_txt.Text), Convert.ToDecimal(BalanceNew_txt.Text));
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ModifyCustomerResult;
                    if (ModifyCustomerResult.StartsWith("Customer Balance Updated") != true)
                    {
                        return;
                    }
                    toolStripButton1_Click(sender, e);


                    //Bills
                    try
                    {
                        DataSet Result2 = new DataSet();
                        Result2 = DatabaseCalls.GetBills();
                        BillDataGridView.DataSource = Result2.Tables[0];
                        BillDataGridView.Columns[0].HeaderText = "Bill Number";
                        foreach (DataRow GridViewColumn in Result2.Tables[0].Rows)
                        {
                            BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                        }

                        //BillNumber_txt.Text = (++Result1).ToString();
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    BillNumber_txt.Text = "";
                    //                DeleteBill_Load(sender, e);
                }
                BillNumberSearch_txt.Text = "";
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
                BalanceNew_txt.Text = CustomerBalance_txt.Text;
                BalanceNew_txt.Visible = true;
                if (BillDetailDataGridView.Enabled == false)
                {
                    BillDetailDataGridView.Enabled = true;
                    ItemCode_txt.Enabled = true;
                    BillDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
                    BillDetailDataGridView.Focus();
                    CustomerBalance_txt.Text = (Convert.ToInt32(CustomerBalance_txt.Text) - Convert.ToInt32(Total_txt.Text)).ToString();
                    //            DatabaseCalls.ModifyCustomer(Convert.ToInt32(CustomerID_txt.Text), Current Blc - Convert.ToInt32(BillNumber_txt.Text)  );
                    //          ;
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

        private void BillDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                BillDataGridView.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                {
                    if (Convert.ToInt32(BillDataGridView.Rows[loop].Cells["ID"].Value) < 0)
                    {
                        BillDataGridView.Rows[loop].Visible = false;
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

        private void BillNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BillNumberSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (BillNumberSearch_txt.Text != null) RandomAlgos.comboKeyPressed(BillNumberSearch_txt);
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
//                ItemCode_txt.Items.Clear();

////                ItemDetailsDataSet = DatabaseCalls.GetItems();
////                foreach (DataRow asdf in ItemDetailsDataSet.Tables[0].Rows)
////                {
////                    int RemainingCount = DatabaseCalls.GetItemCount(asdf.ItemArray[6].ToString());
////                    if (RemainingCount > 0)
////                        _ItemDetailsCollectionArray.Add(asdf.ItemArray[6].ToString());

//////                    ItemCode_txt.Items.Add(asdf.ItemArray[6]);
////                }
//                ItemCode_txt.Items.AddRange(_ItemDetailsCollectionObject);                
//                ItemCode_txt.DroppedDown = true;
//                SendKeys.Send("{BS}");
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

        private void BillNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            BillNumberSearch_txt.DroppedDown = true;
        }

        public static int rowIndex = 0;
        private void BillDetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = e.RowIndex;
                BillDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                //item
                ItemCode_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["ITEM_CODE"].Value.ToString();

                //Des
                ItemName_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["ItemName"].Value.ToString();

                //CTN
                Ctn_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["Qty"].Value.ToString();

                //QTY
                Qty_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["Ctn"].Value.ToString(); 

                //Quant
                Quant_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["Quant"].Value.ToString();

                //unit price
                UnitPrice_txt.Text = BillDetailDataGridView.Rows[rowIndex].Cells["Price"].Value.ToString();

                Ctn_txt.Focus();
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
                    for (int loop = 0; loop < BillDetailDataGridView.Rows.Count; loop++)
                    {
                        if (BillDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value != null && BillDetailDataGridView.Rows[loop].Cells["ITEM_CODE"].Value.Equals(ItemCode_txt.Text))
                        {
                            BillDetailDataGridView.Rows.RemoveAt(loop);

                            //                            Variables.NotificationStatus = true;
                            //                            Variables.NotificationMessageTitle = this.Name;
                            //                            Variables.NotificationMessageText = "Item is already added in bill...";
                            
                            //     Added = true;
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
            //Bill Detail
            try
            {
                NewBillNumber = 0;
                NewBillNumber = Convert.ToInt32(DatabaseCalls.GetNewBillNumber());
                NewBillNumber++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 1");
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            //Customer Detail
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                _CutomerNameCollectionObject = new object[CustomerDataSet.Tables[0].Rows.Count];
                
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
//                    CustomerNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                    _CutomerNameCollectionArray.Add(GridViewColumn.ItemArray[1].ToString());
                }
                _CutomerNameCollectionObject = _CutomerNameCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 2"); 
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }




            //TO GET ITEM LIST
            try
            {
//                ItemDetailsDataSet = DatabaseCalls.GetItems();
                ItemDetailsDataSet = DatabaseCalls.GetItemsForBill();
                _ItemDetailsCollectionObject = new object[ItemDetailsDataSet.Tables[0].Rows.Count];
                foreach (DataRow asdf in ItemDetailsDataSet.Tables[0].Rows)
                {
//                    if (Convert.ToInt32(asdf.ItemArray[7]) > 0)
                    {
                        //int RemainingCount = DatabaseCalls.GetItemCount(asdf.ItemArray[6].ToString());
                        //if (RemainingCount > 0)
                            _ItemDetailsCollectionArray.Add(asdf.ItemArray[6].ToString());
                        //ItemCode_txt.Items.Add(asdf.ItemArray[6]);
                    }
                }
                _ItemDetailsCollectionObject = _ItemDetailsCollectionArray.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 3");
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }



            //Bills
            try
            {
                BillDataSet = DatabaseCalls.GetBills();
                _BillCollectionObject = new object[BillDataSet.Tables[0].Rows.Count];
                foreach (DataRow GridViewColumn in BillDataSet.Tables[0].Rows)
                {
                    //BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                    _BillCollectionArray.Add(GridViewColumn.ItemArray[0].ToString());
                }
                _BillCollectionObject = _BillCollectionArray.ToArray();

//                BillDataSet.Tables[0].Columns.Add("Customer");
                for (int loop = 0; loop < BillDataSet.Tables[0].Rows.Count; loop++)
                {
                    //for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                    {
//                        if (CustomerDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(BillDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) == true)
                        {
                            BillDataSet.Tables[0].Rows[loop]["CUSTOMER_BALANCE"] = DatabaseCalls.GetCurrentRowBalance(BillDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString(), BillDataSet.Tables[0].Rows[loop][0].ToString());
//                            BillDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                            break;
                        }
                    }
                    if (Convert.ToInt32(BillDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        BillDataSet.Tables[0].Rows[loop].Delete();
                }

                //BillDataGridView.DataSource = BillDataSet.Tables[0];
                ////                BillDataGridView.Sort(-1);
                //BillDataGridView.CurrentCell = null;
                //BillDataGridView.Columns[0].HeaderText = "Bill Number";


                //BillDataGridView.Columns["Customer_ID"].Visible = false;
                //BillDataGridView.Columns["Customer"].DisplayIndex = 1;
                //BillDataGridView.Update();
                //                BillDataGridView.Columns["Customer_ID"].HeaderText = "Customer";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 4");
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            //restore process
        }

        private void SpeedTest_BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                ////BillNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                BillDataGridView.DataSource = BillDataSet.Tables[0];
                //                BillDataGridView.Sort(-1);
                BillDataGridView.CurrentCell = null;
                BillDataGridView.Columns[0].HeaderText = "Bill Number";


                BillDataGridView.Columns["Customer_ID"].Visible = false;
                BillDataGridView.Columns["NAME"].DisplayIndex = 1;
                BillDataGridView.Update();
            }
            catch (Exception ex)
            {
            }

            try
            {
                RandomAlgos.RestoreOldSlaesDataInGrid(BillDetailDataGridView, CustomerName_txt, BalanceNew_txt, Total_txt, textBox8, textBox7, CustomerBalance_txt);
                CustomerName_txt_Leave(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 6");
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            
            try
            {
                BillNumber_txt.Text = (NewBillNumber).ToString();
                BillNumberSearch_txt.Items.AddRange(_BillCollectionObject);
                
                CustomerName_txt.Items.AddRange(_CutomerNameCollectionObject);
                CustomerNameSearch_txt.Items.AddRange(_CutomerNameCollectionObject);
                
                //ItemCode_txt.Items.AddRange(_ItemDetailsCollectionObject);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 7");
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        public object[] _BillCollectionObject { get; set; }
        public List<string> _BillCollectionArray = new List<string>();
        

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
                    if (ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString().Contains(ItemCode_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
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

        int SelectedRowIndex = 0;
        private void ItemsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ItemsDataGridView.Visible == true)
                {
                    SelectedRowIndex = e.RowIndex;
                    Thread.Sleep(100);
                    Qty_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["QTY_BOX"].Value.ToString();
                    UnitPrice_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["PRICE"].Value.ToString().Trim();
                    ItemName_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["Model"].Value.ToString().Trim();
                }
                //                ItemCode_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["ITEM_CODE"].Value.ToString().Trim();
                //Qty_txt.Text = ItemsDataGridView.Rows[loop].Cells["INNER_BOX"].Value.ToString();
                //Qty_txt.Text = 
                //Quant_txt.Text = ItemsDataGridView.Rows[loop].Cells["T_QUANTITY"].Value.ToString();
                //Qty_inner_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["QTY_INNER"].Value.ToString();
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
                    if (Convert.ToInt32(ItemsDataGridView.Rows[SelectedRowIndex].Cells["Quantity"].Value.ToString()) > 0)
                    {
                        ItemsDataGridView.Visible = false;
                        Ctn_txt.Focus();
                        //                        ItemsDataGridView.Rows
                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["Quantity"].Value.ToString();
                        ItemCode_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["CODE"].Value.ToString().Trim();

                        UnitPrice_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["PRICE"].Value.ToString().Trim();
                        ItemName_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["Model"].Value.ToString().Trim();
                        Qty_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["QTY_BOX"].Value.ToString();
                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[SelectedRowIndex].Cells["CTN_LEFT"].Value.ToString();
                        //SHIPMENT_ITEM_ID = ItemsDataGridView.Rows[SelectedRowIndex].Cells["ID"].Value.ToString().Trim();
                    }
                    else
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "Stock Empty...";
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
                if (Qty_txt.Text != "" && Ctn_txt.Text != "")
                    Quant_txt.Text = (Convert.ToInt32(Qty_txt.Text) * Convert.ToInt32(Ctn_txt.Text)).ToString();
                else
                    Quant_txt.Text = (0 * Convert.ToInt32(Ctn_txt.Text)).ToString();
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
