using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;

namespace firebirdtest.UI
{
    public partial class AddConsignmentAdvanced : Form
    {
        public AddConsignmentAdvanced()
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

        static DataSet ItemDataSet = new DataSet();
        private void AddConsignmentAdvanced_Shown(object sender, EventArgs e)
        {
            //TO GET ITEM LIST
            try
            {
                ItemDataSet = DatabaseCalls.GetItems();
                ItemCode_txt.Items.Clear();
                foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
                {
                    ItemCode_txt.Items.Add(asdf["CODE"]);
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
                RandomAlgos.RestoreOldConsignmentDataInGrid(ConsignmentDataGridView, ConsignmentNumber_txt, textBox9, textBox8, textBox7);
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
            string Result = "";
            try
            {

                Result = DatabaseCalls.AddItem(ItemNewName_txt.Text, ItemModel_txt.Text, Convert.ToInt32(ItemQuantity_txt.Text), Convert.ToDecimal(ItemPrice_txt.Text), Convert.ToDecimal(ItemCostPrice_txt.Text), ItemPictureBox.ImageLocation, ItemCategory_txt.Text);
                if (Result.StartsWith("Item Added with") != true)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = Result;
                    return;
                }
                ItemDataSet = DatabaseCalls.GetItems();
                ItemCode_txt.Items.Clear();
                foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
                {
                    ItemCode_txt.Items.Add(asdf["CODE"]);
                }
                ItemCode_txt.Focus();
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = Result;
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
                    SendKeys.Send("{TAB}");
                }
                //Variables.NotificationStatus = true;
                //Variables.NotificationMessageTitle = this.Name;
                //Variables.NotificationMessageText = Result;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddDataToGrid();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void AddDataToGrid()
        {
            try
            {
                decimal PriceMultiplied_TQuantity = (Convert.ToDecimal(Price_txt.Text) * Convert.ToDecimal(TQuantity_txt.Text));
                string[] row = { (ConsignmentDataGridView.NewRowIndex + 1).ToString(), ItemCode_txt.Text, Description_txt.Text, Ctn_txt.Text, QtyPerBox_txt.Text, TQuantity_txt.Text, Price_txt.Text, PriceMultiplied_TQuantity.ToString() };
                textBox7.Text = (ConsignmentDataGridView.NewRowIndex + 1).ToString();
                textBox8.Text = (Convert.ToDecimal(textBox8.Text) + Convert.ToDecimal(Ctn_txt.Text)).ToString();
                textBox1.Text = (Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(TQuantity_txt.Text)).ToString();
                textBox9.Text = (Convert.ToDecimal(textBox9.Text) + PriceMultiplied_TQuantity).ToString();
                RandomAlgos.AddDataInConsignmentFile((ConsignmentDataGridView.NewRowIndex).ToString(), ItemCode_txt.Text, Description_txt.Text, QtyPerBox_txt.Text, Ctn_txt.Text, TQuantity_txt.Text, Price_txt.Text, (Convert.ToDecimal(TQuantity_txt.Text) * Convert.ToDecimal(Price_txt.Text)).ToString(), ConsignmentNumber_txt.Text, textBox8.Text, textBox7.Text, textBox9.Text);
                
                ConsignmentDataGridView.Rows.Add(row);
                ConsignmentDataGridView.Update();
                ItemCode_txt.Text = "";
                QtyPerBox_txt.Text = "0";
                Description_txt.Text = "None";
                Ctn_txt.Text = "0";
                TQuantity_txt.Text = "0";
                Price_txt.Text = "0";
                ItemCode_txt.Focus();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ItemName1_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter &&ItemCode_txt.Text != "")
                {
                    if (ItemCode_txt.Items.Contains(ItemCode_txt.Text) == false)
                    {
                        ItemNewName_txt.Text = ItemCode_txt.Text;
                        ItemNewName_txt.Focus();
                    }
                    else
                    {
                        bool DontAdd = false;
                        for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count - 1; loop++) //String ItemCodeGridData in ConsignmentDataGridView[)
                        {
                            if (ConsignmentDataGridView["ItemCode", loop].Value.Equals(ItemCode_txt.Text) == true)
                            {
                                DontAdd = true;
                                break;
                            }
                        }
                        if (DontAdd == false)
                        {
                            Ctn_txt.Focus();
                            foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
                            {
                                if (asdf["CODE"].ToString() == ItemCode_txt.Text)
                                {
                                    QtyPerBox_txt.Text = asdf["QTY_BOX"].ToString();
                                    Description_txt.Text = asdf["MODEL"].ToString();
                                    Price_txt.Text = asdf["PRICE"].ToString();
                                }
                            }
                        }
                        else
                        {
                            Variables.NotificationStatus = true;
                            Variables.NotificationMessageTitle = this.Name;
                            Variables.NotificationMessageText = "This Item is already Added";
                        }
                    }
                }
                else if (e.KeyCode == Keys.Enter && ItemCode_txt.Items.Count > 0)
                {
                    ItemCode_txt.Text = ItemCode_txt.Items[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void Carton_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Ctn_txt.Text != "" && e.KeyCode == Keys.Enter)
                {
                    TQuantity_txt.Text = (Convert.ToInt32(Ctn_txt.Text) * Convert.ToInt32(QtyPerBox_txt.Text)).ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ItemFileBrowser_Dialogue = new OpenFileDialog();
                ItemFileBrowser_Dialogue.ShowDialog();
                ItemPictureBox.ImageLocation = PicPath_txt.Text = ItemFileBrowser_Dialogue.FileName;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPictureBox.Image = null;
                PicPath_txt.Text = "";
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        static DataSet ItemDetails = new DataSet();

        private void AddConsignmentAdvanced_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddConsignmentAdvanced_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData.ToString().Contains("Control"))
                {
                    if (e.KeyData.ToString().Contains("W, Control"))
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void comboKeyPressed()
        {
            try
            {
                ItemCode_txt.DroppedDown = true;

                object[] originalList = (object[])ItemCode_txt.Tag;
                if (originalList == null)
                {
                    // backup original list
                    originalList = new object[ItemCode_txt.Items.Count];
                    ItemCode_txt.Items.CopyTo(originalList, 0);
                    ItemCode_txt.Tag = originalList;
                }

                // prepare list of matching items
                string s = ItemCode_txt.Text.ToLower();
                IEnumerable<object> newList = originalList;
                if (s.Length > 0)
                {
                    newList = originalList.Where(item => item.ToString().ToLower().Contains(s));
                }

                // clear list (loop through it, otherwise the cursor would move to the beginning of the textbox...)
                while (ItemCode_txt.Items.Count > 0)
                {
                    ItemCode_txt.Items.RemoveAt(0);
                }

                // re-set list
                ItemCode_txt.Items.AddRange(newList.ToArray());
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ConsignmentDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                textBox9.Text = "0";
                decimal CostAmmount = 0;
                decimal NumberOfItems = 0;
                decimal NumberOfCTN = 0;
                for (int loop = 0; loop < ConsignmentDataGridView.Rows.Count - 1; loop++)// DataGridViewRow OneRow in ConsignmentDataGridView.Rows)
                {

                    CostAmmount += Convert.ToDecimal(ConsignmentDataGridView.Rows[loop].Cells["SUBTOTAL"].Value);
                    NumberOfItems++;// += Convert.ToInt32(OneRow["Sub-Total"]);
                    NumberOfCTN += Convert.ToDecimal(ConsignmentDataGridView.Rows[loop].Cells["Ctn"].Value);
                }
                textBox7.Text = NumberOfItems.ToString();
                textBox8.Text = NumberOfCTN.ToString();
                textBox9.Text = CostAmmount.ToString();
                //;
            }
            catch(Exception ex)
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
                if (ConsignmentNumber_txt.Text == "")
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Please Enter The consignment Name..";
                    Variables.NotificationStatus = true;

                    return;
                }
                string Result = "";
                try
                {
                    //Add Consignment
                    Result = DatabaseCalls.AddConsignment(ConsignmentNumber_txt.Text, Convert.ToDateTime(ConsignmentDate_txt.Text));
                    if (Result.StartsWith("Consignment Added with ID") != true)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result;
                        return;
                    }

                    //Add Consignment Details
                    foreach (DataGridViewRow GridViewRow in ConsignmentDataGridView.Rows)
                    {
                        try
                        {
                            if (GridViewRow.Cells[2].Value != null && GridViewRow.Cells[2].Value.ToString() != "None" && GridViewRow.Cells[2].Value != "")
                            {
                                //if qty_box != same ... add item 
                                string ItemCode = GridViewRow.Cells["ItemCode"].Value.ToString();
                                foreach (DataRow DR in ItemDataSet.Tables[0].Rows)
                                {
                                    if (GridViewRow.Cells["ItemCode"].Value.ToString() == DR["Code"].ToString())
                                    {
                                        if (GridViewRow.Cells["ItemCode"].Value.ToString() == "302")
                                        { }
                                        if (GridViewRow.Cells["QtyPerBox"].Value.ToString() != DR["QTY_BOX"].ToString())
                                        {
                                            string result = "";
                                            try
                                            {
                                                ItemCode = ItemCode + "(" + GridViewRow.Cells["QtyPerBox"].Value.ToString() + "P)";
                                                GridViewRow.Cells[1].Value = ItemCode;
                                                result = DatabaseCalls.AddItem(ItemCode, GridViewRow.Cells["Description"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["QtyPerBox"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["CostPrice"].Value), "", "Toys");
                                            }
                                            catch (Exception ex)
                                            {
                                                ItemCode = ItemCode + "(" + GridViewRow.Cells["QtyPerBox"].Value.ToString() + "P)";
                                                GridViewRow.Cells[1].Value = ItemCode;
                                            }
                                        }
                                        break;
                                    }
                                }
                                String Result2 = DatabaseCalls.AddConsignmentDetail(ItemCode, ConsignmentNumber_txt.Text, Convert.ToInt32(GridViewRow.Cells["TQuantity"].Value), Convert.ToInt32(GridViewRow.Cells["QtyPerBox"].Value), GridViewRow.Cells["Description"].Value.ToString(), Convert.ToInt32(GridViewRow.Cells["Ctn"].Value), Convert.ToDecimal(GridViewRow.Cells["Price"].Value), Convert.ToDecimal(GridViewRow.Cells["SUBTOTAL"].Value));
                                if (Result2.StartsWith("Consignment added with id") != true)
                                {
                                    Variables.NotificationStatus = true;
                                    Variables.NotificationMessageTitle = this.Name;
                                    Variables.NotificationMessageText = Result2;
                                    return;
                                }
                                ItemDetails = DatabaseCalls.GetItemDetails("code", GridViewRow.Cells[1].Value.ToString());
                                int UpdatedItem_Quantity = (Convert.ToInt32(ItemDetails.Tables[0].Rows[0]["T_QUANTITY"]) + Convert.ToInt32(GridViewRow.Cells[5].Value));
                                String UpdateItemResult = DatabaseCalls.AddItemQutantity(GridViewRow.Cells[1].Value.ToString(), UpdatedItem_Quantity);
                                if (UpdateItemResult.StartsWith("Item Quantity Modified") != true)
                                {
                                    Variables.NotificationStatus = true;
                                    Variables.NotificationMessageTitle = this.Name;
                                    Variables.NotificationMessageText = UpdateItemResult;
                                    return;
                                }

                                String AddSaleResult = DatabaseCalls.AddSale(0, 0, -1, 0, GridViewRow.Cells[1].Value.ToString(), "Name", 0, 0, -1);
                                if (UpdateItemResult.StartsWith("Item Quantity Modified") != true)
                                {
                                    Variables.NotificationStatus = true;
                                    Variables.NotificationMessageTitle = this.Name;
                                    Variables.NotificationMessageText = UpdateItemResult;
                                    return;
                                }

                                //UPDATE PRICE IF MODIFIED
                                foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
                                {
                                    if (asdf["CODE"].ToString() == GridViewRow.Cells["ItemCode"].Value.ToString())
                                    {
                                        if (Price_txt.Text != GridViewRow.Cells["Price"].Value.ToString())
                                        {
                                            string ModifyCustomerResult = DatabaseCalls.ModifyItemPrice(GridViewRow.Cells["ItemCode"].Value.ToString(), Convert.ToDecimal(GridViewRow.Cells["Price"].Value));
                                            if (ModifyCustomerResult.StartsWith("Item Price Modified") != true)
                                            {
                                                Variables.NotificationStatus = true;
                                                Variables.NotificationMessageTitle = this.Name;
                                                Variables.NotificationMessageText = ModifyCustomerResult;
                                                return;
                                            }
                                            //Item Price Modified
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
                    //ClearAllData();
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "Consignment Added Successfully... :)";
                    this.Close();
                    //ClearAllData();
                }
                catch (Exception ex)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }
                RandomAlgos.DeleteConsignmentFile();
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
                toolStripButton4.Enabled = true;
                toolStripButton5.Enabled = false;
                OpenFileDialog _OpenFileDialog = new OpenFileDialog();
                _OpenFileDialog.ShowDialog();
                //string filename =
                if (_OpenFileDialog.FileName != null && _OpenFileDialog.FileName != "")
                {
                    ExcelReader.Variables.FileName = _OpenFileDialog.FileName;
                    ExcelReader.ExcelTool _tool = new ExcelReader.ExcelTool();
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
                string Result = "";
                ItemDataSet = DatabaseCalls.GetItems();
                ItemCode_txt.Items.Clear();
                foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
                {
                    ItemCode_txt.Items.Add(asdf["CODE"]);
                }

                string ItemCode = " ";
                for (int loop = ExcelReader.Variables.RangeCurrentIndex; loop < ExcelReader.Variables.Range.Length && ItemCode != "" && ItemCode != "-----"; loop++)
                {
                    try
                    {
                        ItemCode = ExcelReader.Variables.Range[loop][0];
                        if (ItemCode != "-----" )
                        {
                            try
                            {
                                ItemCode_txt.Text = ExcelReader.Variables.Range[loop][0];
                                Description_txt.Text = ExcelReader.Variables.Range[loop][1];
                                Ctn_txt.Text = ExcelReader.Variables.Range[loop][2];
                                QtyPerBox_txt.Text = ExcelReader.Variables.Range[loop][3];
                                TQuantity_txt.Text = ExcelReader.Variables.Range[loop][4]; 
                                Price_txt.Text = ExcelReader.Variables.Range[loop][5];
                                if (ItemCode_txt.Items.Equals(ItemCode_txt.Text) == false && ItemCode_txt.Text != "" && Description_txt.Text != "" && Convert.ToInt32(QtyPerBox_txt.Text) > 0 && Convert.ToDecimal(Price_txt.Text) > 0)
                                {
                                    try
                                    {
                                        Result = DatabaseCalls.AddItem(ItemCode_txt.Text, Description_txt.Text, Convert.ToInt32(QtyPerBox_txt.Text), Convert.ToDecimal(Price_txt.Text), Convert.ToDecimal(ItemCostPrice_txt.Text), ItemPictureBox.ImageLocation, "Toys");
                                        Variables.NotificationStatus = true;
                                        Variables.NotificationMessageTitle = this.Name;
                                        Variables.NotificationMessageText = Result;
                                        if (Result.StartsWith("Item Added with") != true)
                                        {
                                            Variables.NotificationMessageTitle = this.Name;
                                            Variables.NotificationMessageText = Result;
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
                            }
                            catch (Exception ex)
                            {
                                Variables.NotificationMessageTitle = this.Name;
                                Variables.NotificationMessageText = ex.Message;
                                Variables.NotificationStatus = true;
                            }
                        }
//                        if (ItemCode_txt.Items.Contains(ItemCode) == true)
                        {
                            AddDataToGrid();
                        }
                    }
                    catch (Exception ex)
                    { }
                    //= ExcelReader.Variables.Range[loop][6];
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentDataGridView.Rows.Clear();
                ItemCode_txt.Text = "None";
                Description_txt.Text = "None";
                Ctn_txt.Text = "0";
                TQuantity_txt.Text = "0";
                QtyPerBox_txt.Text = "0";
                Price_txt.Text = "0";
                System.IO.File.Delete("Consignment.txt");
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void ItemCode_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Enter && e.KeyValue != 27)
                {
                    try
                    {
                        if (ItemCode_txt.Text != null)
                            RandomAlgos.comboKeyPressed(ItemCode_txt);
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = ex.Message;
                        Variables.NotificationStatus = true;
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

        private void ItemCode_txt_Enter(object sender, EventArgs e)
        {
            ItemCode_txt.DroppedDown = true;
        }

        private void AddConsignmentAdvanced_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void button6_Click(object sender, EventArgs e)
        {
            ItemDataSet = DatabaseCalls.GetItems();
            ItemCode_txt.Items.Clear();
            foreach (DataRow asdf in ItemDataSet.Tables[0].Rows)
            {
                ItemCode_txt.Items.Add(asdf["CODE"]);
            }
        } 
    }
}
