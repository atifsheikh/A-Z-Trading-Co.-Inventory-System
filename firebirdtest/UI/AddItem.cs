using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;

namespace firebirdtest.UI
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        public AddItem(string SelectedItemCode)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.SelectedItemCode = SelectedItemCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result = "";
            try
            {
                if (ItemCode_txt.Text == "")
                    return;
                if (ItemPictureBox.ImageLocation == null || ItemPictureBox.ImageLocation == "")
                {
                    if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPG") == true)
                    {
                        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPG";
                    }
                    else if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPEG") == true)
                    {
                        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPEG";
                    }
                }
                Result = DatabaseCalls.AddItem(ItemCode_txt.Text, ItemName_txt.Text, Convert.ToInt32(ItemQuantity_txt.Text), Convert.ToDecimal(ItemPrice_txt.Text), Convert.ToDecimal(ItemCostPrice_txt.Text), ItemPictureBox.ImageLocation, ItemCategory_txt.Text);

                if (Result!="")
                {
                    return;
                }

                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetItems();
                RandomAlgos.CleanUpGridView(Result1, ItemsDataGridView);//ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle= this.Name;
                Variables.NotificationStatus = true;
                Console.WriteLine(ex.Message);
            }
            button6_Click(sender, e);
            SortItems();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            //TO GET ITEM LIST
            try
            {
                DataSet ItemsDataset = new DataSet();
                ItemsDataset = DatabaseCalls.GetItems();
                RandomAlgos.CleanUpGridView(ItemsDataset, ItemsDataGridView);
                //ItemsDataGridView.DataSource = Result1.Tables[0];
                
                if (ItemsDataset.Tables.Count > 0)
                {
                    //Result1.Tables[0].Columns["Item_Code"].ColumnName = "Item Code";
                    ItemCodeSearch_txt.Items.Clear();
                    for (int loop = 0; loop < ItemsDataset.Tables[0].Rows.Count; loop++)//each (DataRow asdf in Result1.Tables[0].Rows[]["CODE"])
                    {
                        ItemCodeSearch_txt.Items.Add(ItemsDataset.Tables[0].Rows[loop]["CODE"]);
                    }
                }
                if (ItemsDataGridView.Columns.Count > 0)
                {
                    SortItems();
                }
                DataSet CategoryDataset = new DataSet();
                CategoryDataset = DatabaseCalls.GetCategory();
                for (int loop = 0; loop < CategoryDataset.Tables[0].Rows.Count; loop++)
                {
                    ItemCategory_txt.Items.Add(CategoryDataset.Tables[0].Rows[loop]["NAME"]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void SortItems()
        {
            ItemsDataGridView.Columns["ID"].Visible = false;
            ItemsDataGridView.Columns["NAME"].Visible = false;
            ItemsDataGridView.Columns["IMAGE"].Visible = false;
            ItemsDataGridView.Columns["T_QUANTITY"].Visible = false;
            ItemsDataGridView.Columns["CODE"].DisplayIndex = 0;
            ItemsDataGridView.Columns["MODEL"].DisplayIndex = 1;
            ItemsDataGridView.Columns["QTY_BOX"].DisplayIndex = 2;
            ItemsDataGridView.Columns["COSTPRICE"].DisplayIndex = 3;
            ItemsDataGridView.Columns["PRICE"].DisplayIndex = 4;
            ItemsDataGridView.Columns["CategoryNAME"].DisplayIndex = 7;
        }

        private void ItemsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private int currentRow = 0;
        private string SelectedItemCode;

        private void ItemsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsDataGridView.CurrentCell != null && currentRow != ItemsDataGridView.CurrentCell.RowIndex)
                {
                    currentRow = ItemsDataGridView.CurrentCell.RowIndex;
                    ItemName_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["NAME"].Value.ToString();
                    ItemCode_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CODE"].Value.ToString();
                    //ItemCodeSearch_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CODE"].Value.ToString();
                    ItemName_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["MODEL"].Value.ToString();
                    ItemQuantity_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["QTY_BOX"].Value.ToString();
                    ItemPrice_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["PRICE"].Value.ToString();
                    ItemCostPrice_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["COSTPRICE"].Value.ToString();
                    ItemCategory_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CATEGORYNAME"].Value.ToString();
                    TQUANTITY_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["T_QUANTITY"].Value.ToString();
                    //TODO : SC Task
                    //byte[] byteBLOBData = (byte[])ItemsDataGridView.Rows[currentRow].Cells["IMAGE"].Value;
                    //System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                    //Image img = (Image)converter.ConvertFrom(byteBLOBData);
                    //MemoryStream ms = new MemoryStream(byteBLOBData); 
                    //ms.Write(byteBLOBData, 0, byteBLOBData.Length);
                    //ms.Position = 0; // THIS !!!!!
                    //ItemPictureBox.Image = Image.FromStream(ms, true); 
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemPictureBox.ImageLocation == null || ItemPictureBox.ImageLocation == "")
            {
                if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPG") == true)
                {
                    ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPG";
                }
                else if (File.Exists("ItemImages\\" + ItemCode_txt.Text + ".JPEG") == true)
                {
                    ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemCode_txt.Text + ".JPEG";
                }
            }

            string Result = DatabaseCalls.ModifyItems(ItemsDataGridView.Rows[currentRow].Cells["ID"].Value.ToString(), ItemCode_txt.Text, ItemName_txt.Text, ItemQuantity_txt.Text, ItemPrice_txt.Text, ItemCostPrice_txt.Text, "Image Blob String", ItemCategory_txt.Text, Convert.ToInt32(TQUANTITY_txt.Text));
            if (Result != "")
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = Result;
            }
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetItems();
            RandomAlgos.CleanUpGridView(Result1,ItemsDataGridView);//.DataSource = Result1.Tables[0];
            ItemsDataGridView.Columns[0].Visible = false;
            SortItems();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemPictureBox.Image = null;
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ItemFileBrowser_Dialogue = new OpenFileDialog();
            ItemFileBrowser_Dialogue.ShowDialog();
            ItemPictureBox.ImageLocation = textBox2.Text = ItemFileBrowser_Dialogue.FileName;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string AddCategoryResult = DatabaseCalls.AddCategory(ItemCategory_txt.Text);
            if (AddCategoryResult != "")
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = AddCategoryResult;
            }
            DataSet CategoriesDataSet = new DataSet();
            CategoriesDataSet = DatabaseCalls.GetCategory();
            ItemCategory_txt.Items.Clear();
            if (CategoriesDataSet.Tables.Count > 0)
            { 
                foreach (DataRow categoryDataRow in CategoriesDataSet.Tables[0].Rows)
                {
                    ItemCategory_txt.Items.Add(categoryDataRow.ItemArray[1]);
                }
            }
        }

        private void ItemName_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count && ItemsDataGridView.Rows[loop] != null && ItemsDataGridView.Rows[loop].Cells["CODE"].Value != null; loop++)
                {
                    if (StaticClass.Contain(ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString(),ItemCodeSearch_txt.Text,StringComparison.OrdinalIgnoreCase))
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

        private void AddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ItemCode_txt.Text = "None";
            ItemName_txt.Text = "None";
            ItemQuantity_txt.Text = "0";
            ItemPrice_txt.Text = "0";
            TQUANTITY_txt.Text = "0";
            ItemPictureBox.ImageLocation = "";
            textBox2.Text = "";
            ItemCode_txt.Focus();
        }

        private void TQUANTITY_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void AddItem_Shown(object sender, EventArgs e)
        {
            ItemCode_txt.Focus();
        }

        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            //comboKeyPressed(ItemName_txt);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ItemHistoryView _ItemHistoryReport = new ItemHistoryView();
                Home.Home_pnl.Visible = false;
                _ItemHistoryReport.MdiParent = this.MdiParent;
                _ItemHistoryReport.Show();
                _ItemHistoryReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void ItemName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 27)
            //{
            //    this.AllowDrop = false;
            //}
            //(e.KeyChar
        }

        private void ItemName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
            //    {
            //        if (ItemCodeSearch_txt.Text != null)
            //            RandomAlgos.comboKeyPressed(ItemCodeSearch_txt);
            //    }
            //    else if (e.KeyCode == Keys.Enter)
            //    {
            //        //ItemName_txt.Text = ItemName_txt.;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Variables.NotificationMessageTitle = this.Name;
            //    Variables.NotificationMessageText = ex.Message;
            //    Variables.NotificationStatus = true;
            //}

        }

        private void ItemName_txt_Enter(object sender, EventArgs e)
        {
            //ItemCodeSearch_txt.DroppedDown = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (ItemsDataGridView.Rows[loop].Cells["MODEL"].Value.ToString().Contains(textBox1.Text))//(GridViewColumn.ItemArray[0].ToString()))
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

        private void ItemQuantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ItemPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ItemCostPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
