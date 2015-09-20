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
                            if (ItemsDataGridView.Rows[loop].Visible == true)// && ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString() == ItemCode_txt.Text)
                            {
                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop].Cells["PRICE"].Value.ToString().Trim();
                                ItemCode_txt.Text = ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString().Trim();
                                ItemName_txt.Text = ItemsDataGridView.Rows[loop].Cells["Model"].Value.ToString().Trim();
                                Qty_txt.Text = ItemsDataGridView.Rows[loop].Cells["QTY_BOX"].Value.ToString();
                                //RemainingPcs_txt.Text = ItemsDataGridView.Rows[.CurrentRow.Index].Cells["CTN_LEFT"].Value.ToString();
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
            //            SelectedItemForInvoice = ItemCode_txt.Text;

            //    }
            ////}
            //else if (e.KeyCode == Keys.Enter)
            //{
            //    string temp = ItemCode_txt.Text;
            //    if (ItemCode_txt.SelectedIndex == -1)
            //    {
            //        {
            //            if (ItemCode_txt.Items[0].ToString().Contains(SelectedItemForInvoice) == true)
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


        DataTable InvoiceDataTable = new DataTable();
        private void EnterDataInGrid(object sender, KeyEventArgs e)
        {
            try
            {
                string[] row = { (InvoiceDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString() };
                InvoiceDetailDataGridView.Rows.Add(row);
                InvoiceDetailDataGridView.Update();
                TOTAL_CTN_txt.Text = (Convert.ToInt32(TOTAL_CTN_txt.Text) + Convert.ToInt32(Ctn_txt.Text)).ToString();
                int temp = Convert.ToInt32(textBox7.Text);
                textBox7.Text = (++temp).ToString();
                RandomAlgos.AddDataInSalesFile((InvoiceDetailDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, ItemName_txt.Text, Qty_txt.Text, Ctn_txt.Text, Quant_txt.Text, UnitPrice_txt.Text, (Convert.ToInt32(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString(), CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_CTN_txt.Text, textBox7.Text);
                Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) + Convert.ToDecimal(Quant_txt.Text) * Convert.ToDecimal(UnitPrice_txt.Text)).ToString();
                //BalanceNew_txt.Text = (Convert.ToDecimal(CustomerBalance_txt.Text) + Convert.ToDecimal(Total_txt.Text)).ToString();
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
                        CustomerID_txt.Text = GridViewColumn.ItemArray[0].ToString();//ID
                        CustomerAddress_txt.Text = GridViewColumn.ItemArray[2].ToString();//address
                        CustomerEmail_txt.Text = GridViewColumn.ItemArray[4].ToString();//phone
                        CustomerBalance_txt.Text = GridViewColumn.ItemArray[6].ToString();//balance
                        CustomerPhone_txt.Text = GridViewColumn.ItemArray[3].ToString();//email
                        //if (ModifyingInvoice == true)
                        //{
                        //    BalanceNew_txt.Text = (Convert.ToDecimal(CustomerBalance_txt.Text) - Convert.ToDecimal(InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[4].Value) + Convert.ToDecimal(Total_txt.Text)).ToString();
                        //}
                        //else
                        //{
                        //    BalanceNew_txt.Text = InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[5].Value.ToString();//(Convert.ToDecimal(CustomerBalance_txt.Text) + Convert.ToDecimal(Total_txt.Text)).ToString();
                        //}
                        //decimal CalculatedBalance = Convert.ToDecimal(DatabaseCalls.GetCurrentRowBalance(CustomerID_txt.Text, InvoiceNumber_txt.Text));
                        //if (CalculatedBalance != Convert.ToDecimal(CustomerBalance_txt.Text))
                        //{
                        //    //Variables.NotificationStatus = true;
                        //    //Variables.NotificationMessageTitle = "Inform Atif, Which variable is showing correct value?";
                        //    //Variables.NotificationMessageText = "Critical : CustomerBalance_txt.Text = " + CustomerBalance_txt.Text + " AND CalculatedBalance = " + CalculatedBalance;
                        //}
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
                            if (AddSaleResult == "")
                            {
                                ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());
                                int UpdatedItem_Quantity = (Convert.ToInt32(ItemDetails.Tables[0].Rows[0]["T_Quantity"]) - Convert.ToInt32(GridViewRow.Cells[5].Value));
                                String UpdateItemResult = DatabaseCalls.AddItemQutantity(GridViewRow.Cells[1].Value.ToString(), UpdatedItem_Quantity);
                                if (UpdateItemResult != "")
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

                        //InvoiceNumber_txt.Text = (++Result1).ToString();
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
                    if (Ctn_txt.Text == "0" && ItemCode_txt.Text == InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value.ToString())
                    {
                        InvoiceDetailDataGridView.Rows.RemoveAt(InvoiceDetailDataGridView.CurrentRow.Index);
                        ItemCode_txt.Text = "";
                        ItemName_txt.Text = "None";
                        Ctn_txt.Text = "0";
                        Qty_txt.Text = "0";
                        Quant_txt.Text = "0";
                        UnitPrice_txt.Text = "0";
                        //InvoiceDate_txt.Focus();
                        Total_txt_Leave(sender, e);
                        ItemCode_txt.Focus();
                    }
                    else if (Ctn_txt.Text != "" && Ctn_txt.Text != "0")
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
                decimal InvoiceTotal = 0;
                foreach (DataGridViewRow SubTotal in InvoiceDetailDataGridView.Rows)
                {
                    InvoiceTotal += Convert.ToDecimal(SubTotal.Cells[7].Value);
                }
                //if (InvoiceTotal != 0 && Total_txt.Text == (InvoiceTotal).ToString())//+ Convert.ToInt32(Quant_txt.Text) * Convert.ToInt32(UnitPrice_txt.Text)
                //if (ModifyingInvoice == true)
                //{
                //    BalanceNew_txt.Text = (Convert.ToDecimal(InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[5].Value) - Convert.ToDecimal(InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[4].Value) + Convert.ToDecimal(Total_txt.Text)).ToString();
                //}
                //else
                //{
                //    BalanceNew_txt.Text = InvoiceDataGridView.Rows[InvoiceDataGridView.CurrentRow.Index].Cells[5].Value.ToString();//(Convert.ToDecimal(CustomerBalance_txt.Text) + Convert.ToDecimal(Total_txt.Text)).ToString();
                //}
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
                    //            BalanceNew_txt.Visible = false;
                    toolStripButton1_Click(sender, e);
                    //            InvoiceDetailDataGridView.Rows.Clear();
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
                            


                            TOTAL_CTN_txt.Text = (Convert.ToInt32(TOTAL_CTN_txt.Text) + (InvoiceDetailDataGridView.Rows[r].Cells[4].Value == ""? 0 : Convert.ToInt32(InvoiceDetailDataGridView.Rows[r].Cells[4].Value))).ToString();
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
                    //                Total_txt_Leave(sender, e);
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
//            ItemCode_txt.Focus();
            //            InvoiceDetailDataGridView.Columns["ITEM_CODE"] = Result1.Tables[0].Columns["ITEM_CODE"];
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
                            if (InvoiceDataGridView.Rows[loop].Cells["Customer_ID"].Value.ToString() != (GridViewColumn.ItemArray[0].ToString()))
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
                TOTAL_CTN_txt.Text = "0";
                textBox7.Text = "0";
                Total_txt.Text = "0";
                decimal CostAmmount = 0;
                int NumberOfItems = 0;
                int NumberOfCTN = 0;
                RandomAlgos.DeleteSalesFile();
                for (int loop = 0; loop < InvoiceDetailDataGridView.Rows.Count - 1; loop++)// DataGridViewRow OneRow in InvoiceDataGridView.Rows)
                {
                    RandomAlgos.AddDataInSalesFile(InvoiceDetailDataGridView.Rows[loop].Cells[0].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[1].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[2].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[3].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[4].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[5].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[6].Value.ToString(),
                        InvoiceDetailDataGridView.Rows[loop].Cells[7].Value.ToString(),
                        CustomerName_txt.Text, BalanceNew_txt.Text, Total_txt.Text, TOTAL_CTN_txt.Text, textBox7.Text);
                    //                RandomAlgos.DeleteDataFromFile(SrNo, string ItemCode, string ItemName, string Ctn, string Qty, string Quant, string UnitPrice, string SubTotal,string CustomerName,string BalanceNew,string Total,string textBox8,string textBox7);
                    CostAmmount += Convert.ToDecimal(InvoiceDetailDataGridView.Rows[loop].Cells["SUBTOTAL"].Value);
                    NumberOfItems++;// += Convert.ToInt32(OneRow["Sub-Total"]);
                    NumberOfCTN += Convert.ToInt32(InvoiceDetailDataGridView.Rows[loop].Cells["Qty"].Value);
                }
                textBox7.Text = NumberOfItems.ToString();
                TOTAL_CTN_txt.Text = NumberOfCTN.ToString();
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
                                        MatchFound = true;                //item
                                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[loop2].Cells["Quantity"].Value.ToString();
                                        ItemCode_txt.Text = ItemsDataGridView.Rows[loop2].Cells["CODE"].Value.ToString().Trim();
                                        UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["COSTPRICE"].Value.ToString().Trim();
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
                                                UnitPrice_txt.Text = ItemsDataGridView.Rows[loop2].Cells["COSTPRICE"].Value.ToString().Trim();
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
                    //decimal CustomerNewBalance = Convert.ToDecimal(BalanceNew_txt.Text);
                    //                CustomerNewBalance -= Convert.ToDecimal(
                    //DatabaseCalls.ModifyCustomer(InvoiceDataSet.Tables[0].Rows[0]["CustomerID"].ToString(), CustomerNewBalance.ToString());
                    DatabaseCalls.DeleteBillDetails(InvoiceNumber_txt.Text);
                    //DatabaseCalls.DeleteInvoice(InvoiceNumberSearch_txt.Text);

                    //add Updated Invoice Detail
                    //Add Invoice Details
                    foreach (DataGridViewRow GridViewRow in InvoiceDetailDataGridView.Rows)
                    {
                        if (GridViewRow.Cells[2].Value != null)
                        {
                            // PCS_CTN, QUANT, CUSTOMER_ID

                            string AddSaleResult = DatabaseCalls.AddBillDetail(GridViewRow.Cells["ITEM_CODE"].Value.ToString(), InvoiceNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["QUANT"].Value), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), GridViewRow.Cells["ItemName"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Qty"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SubTotal"].Value));
                            if (AddSaleResult == "")
                            {
                                ItemDetails = DatabaseCalls.GetItems(GridViewRow.Cells[1].Value.ToString());
                                int UpdatedItem_Quantity = (Convert.ToInt32(ItemDetails.Tables[0].Rows[0]["T_Quantity"]) - Convert.ToInt32(GridViewRow.Cells[5].Value));
                                String UpdateItemResult = DatabaseCalls.AddItemQutantity(GridViewRow.Cells[1].Value.ToString(), UpdatedItem_Quantity);
                                if (UpdateItemResult != "")
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


                    //bool resultUpdateInvoices = UpdateInvoices();

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

                        //InvoiceNumber_txt.Text = (++Result1).ToString();
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                    }
                    InvoiceNumber_txt.Text = "";
                    //                DeleteInvoice_Load(sender, e);
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
                //BalanceNew_txt.Text = CustomerBalance_txt.Text;
                ModifyingInvoice = true; 
                BalanceNew_txt.Visible = true;
                if (InvoiceDetailDataGridView.Enabled == false)
                {
                    InvoiceDetailDataGridView.Enabled = true;
                    ItemCode_txt.Enabled = true;
                    InvoiceDetailDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
                    InvoiceDetailDataGridView.Focus();
                    //CustomerBalance_txt.Text = (Convert.ToInt32(CustomerBalance_txt.Text) - Convert.ToInt32(Total_txt.Text)).ToString();
                    //            DatabaseCalls.ModifyCustomer(Convert.ToInt32(CustomerID_txt.Text), Current Blc - Convert.ToInt32(InvoiceNumber_txt.Text)  );
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
                    //item
                    ItemCode_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ITEM_CODE"].Value.ToString();

                    //Des
                    ItemName_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["ItemName"].Value.ToString();

                    //CTN
                    Ctn_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Qty"].Value.ToString();

                    //QTY
                    Qty_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Ctn"].Value.ToString();

                    //Quant
                    Quant_txt.Text = InvoiceDetailDataGridView.Rows[InvoiceDetailDataGridView.CurrentRow.Index].Cells["Quant"].Value.ToString();

                    //unit price
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

                            //                            Variables.NotificationStatus = true;
                            //                            Variables.NotificationMessageTitle = this.Name;
                            //                            Variables.NotificationMessageText = "Item is already added in invoice...";
                            
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
            //Invoice Detail
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
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }




            //TO GET ITEM LIST
            try
            {
//                ItemDetailsDataSet = DatabaseCalls.GetItems();
                ItemDetailsDataSet = DatabaseCalls.GetItemsForBill();
                if (ItemDetailsDataSet != null && ItemDetailsDataSet.Tables.Count > 0)
                {
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
                    //InvoiceNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                    _InvoiceCollectionArray.Add(GridViewColumn.ItemArray[0].ToString());
                }
                _InvoiceCollectionObject = _InvoiceCollectionArray.ToArray();

//                InvoiceDataSet.Tables[0].Columns.Add("Customer");
                for (int loop = 0; loop < InvoiceDataSet.Tables[0].Rows.Count; loop++)
                {
                    //for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                    {
//                        if (CustomerDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(InvoiceDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) == true)
                        {
                            //InvoiceDataSet.Tables[0].Rows[loop]["CUSTOMER_BALANCE"] = DatabaseCalls.GetCurrentRowBalance(InvoiceDataSet.Tables[0].Rows[loop]["CustomerID"].ToString(), InvoiceDataSet.Tables[0].Rows[loop][0].ToString());
//                            InvoiceDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                            break;
                        }
                    }
                    if (Convert.ToInt32(InvoiceDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        InvoiceDataSet.Tables[0].Rows[loop].Delete();
                }

                //InvoiceDataGridView.DataSource = InvoiceDataSet.Tables[0];
                ////                InvoiceDataGridView.Sort(-1);
                //InvoiceDataGridView.CurrentCell = null;
                //InvoiceDataGridView.Columns[0].HeaderText = "Invoice Number";


                //InvoiceDataGridView.Columns["Customer_ID"].Visible = false;
                //InvoiceDataGridView.Columns["Customer"].DisplayIndex = 1;
                //InvoiceDataGridView.Update();
                //                InvoiceDataGridView.Columns["Customer_ID"].HeaderText = "Customer";
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
                RandomAlgos.RestoreOldSlaesDataInGrid(InvoiceDetailDataGridView, CustomerName_txt, BalanceNew_txt, Total_txt, TOTAL_CTN_txt, textBox7, CustomerBalance_txt);
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
                //ItemCode_txt.Items.AddRange(_ItemDetailsCollectionObject);                
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
                    //InvoiceDataGridView.Columns["TOTAL_CTN"].HeaderText = "Ctn";
                    InvoiceDataGridView.Columns["CUSTOMER_BALANCE"].HeaderText = "Balance";

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
                    Qty_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["QTY_BOX"].Value.ToString();
                    UnitPrice_txt.Text = ItemsDataGridView.Rows[e.RowIndex].Cells["COSTPRICE"].Value.ToString().Trim();
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

        string BILL_ITEM_ID = "";
        private void ItemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //if (Convert.ToInt32(ItemsDataGridView.Rows[.CurrentRow.Index].Cells["T_Quantity"].Value.ToString()) > 0)
                    {
                        ItemsDataGridView.Visible = false;
                        Ctn_txt.Focus();
                        //                        ItemsDataGridView.Rows
                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[.CurrentRow.Index].Cells["Quantity"].Value.ToString();
                        ItemCode_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["CODE"].Value.ToString().Trim();

                        UnitPrice_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["COSTPRICE"].Value.ToString().Trim();
                        ItemName_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["Model"].Value.ToString().Trim();
                        Qty_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["QTY_BOX"].Value.ToString();
                        //RemainingPcs_txt.Text = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["CTN_LEFT"].Value.ToString();
                        //BILL_ITEM_ID = ItemsDataGridView.Rows[ItemsDataGridView.CurrentRow.Index].Cells["ID"].Value.ToString().Trim();
                    }
                    //else
                    //{
                    //    Variables.NotificationStatus = true;
                    //    Variables.NotificationMessageTitle = this.Name;
                    //    Variables.NotificationMessageText = "Stock Empty...";
                    //}
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
                else if (Ctn_txt.Text != ""&& Ctn_txt.Text != "0")
                    Quant_txt.Text = (0 * Convert.ToInt32(Ctn_txt.Text)).ToString();
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
                //if (ItemPictureBox.ImageLocation == null || ItemPictureBox.ImageLocation == "")
                //{
                //    if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPG") == true)
                //    {
                //        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPG";
                //    }
                //    else if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPEG") == true)
                //    {
                //        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPEG";
                //    }
                //}
                Result = DatabaseCalls.AddItem(ItemCodeCons_txt.Text, ItemModelCons_txt.Text, Convert.ToInt32(ItemQuantityCons_txt.Text), Convert.ToDecimal(ItemPriceCons_txt.Text), Convert.ToDecimal(ItemCostPriceCons_txt.Text), ItemPictureBox.ImageLocation, ItemCategoryCons_txt.Text);
                ItemCodeCons_txt.Text = "";
                ItemModelCons_txt.Text= "";
                ItemQuantityCons_txt.Text= "";
                ItemPriceCons_txt.Text= "";
                ItemCostPriceCons_txt.Text= "";
                ItemPictureBox.ImageLocation= "";
                ItemCategoryCons_txt.Text = "";

                if (Result != "")
                {
                    return;
                }
                GetItemsForInvoicePage();
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ItemCostPriceCons_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Total_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BalanceNew_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TOTAL_CTN_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public bool ModifyingInvoice { get; set; }
    }
}
