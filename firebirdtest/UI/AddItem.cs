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
                if (ItemNewName_txt.Text == "")
                    return;
                if (ItemPictureBox.ImageLocation == null || ItemPictureBox.ImageLocation == "")
                {
                    if (File.Exists("ItemImages\\" + ItemNewName_txt.Text + ".JPG") == true)
                    {
                        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemNewName_txt.Text + ".JPG";
                    }
                    else if (File.Exists("ItemImages\\" + ItemNewName_txt.Text + ".JPEG") == true)
                    {
                        ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemNewName_txt.Text + ".JPEG";
                    }
                }
                Result = DatabaseCalls.AddItem(ItemNewName_txt.Text, ItemModel_txt.Text, Convert.ToInt32(ItemQuantity_txt.Text), Convert.ToDecimal(ItemPrice_txt.Text), Convert.ToDecimal(ItemCostPrice_txt.Text), ItemPictureBox.ImageLocation, ItemCategory_txt.Text);
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = Result;

                if (Result.StartsWith("Item Added with") != true)
                {
                    return;
                }

                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetItems();
                ItemsDataGridView.DataSource = Result1.Tables[0];
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
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetItems();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns["ID"].Visible = false;
                ItemsDataGridView.Columns["IMAGE"].Visible = false;
                
                //Result1.Tables[0].Columns["Item_Code"].ColumnName = "Item Code";
                for(int loop = 0 ;loop < Result1.Tables[0].Rows.Count;loop++)//each (DataRow asdf in Result1.Tables[0].Rows[]["CODE"])
                {
                    ItemName_txt.Items.Add(Result1.Tables[0].Rows[loop]["CODE"]);
                }
                ItemsDataGridView.Columns["CODE"].DisplayIndex = 0;
                ItemsDataGridView.Columns["MODEL"].DisplayIndex = 1;
                ItemsDataGridView.Columns["QTY_BOX"].DisplayIndex = 2;
                ItemsDataGridView.Columns["PRICE"].DisplayIndex = 3;
                ItemsDataGridView.Columns["T_QUANTITY"].Visible= false; 
                ItemsDataGridView.Columns["CATEGORYNAME"].Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
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
                    ItemNewName_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CODE"].Value.ToString();
                    //ItemName_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CODE"].Value.ToString();
                    ItemModel_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["MODEL"].Value.ToString();
                    ItemQuantity_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["QTY_BOX"].Value.ToString();
                    ItemPrice_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["PRICE"].Value.ToString();
                    ItemCategory_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["CATEGORYNAME"].Value.ToString();
                    TQUANTITY_txt.Text = ItemsDataGridView.Rows[currentRow].Cells["T_QUANTITY"].Value.ToString();
                    byte[] byteBLOBData = (byte[])ItemsDataGridView.Rows[currentRow].Cells["IMAGE"].Value;
                    
                    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                    Image img = (Image)converter.ConvertFrom(byteBLOBData);


                    MemoryStream ms = new MemoryStream(byteBLOBData); 
                    ms.Write(byteBLOBData, 0, byteBLOBData.Length);
                    ms.Position = 0; // THIS !!!!!
                    ItemPictureBox.Image = Image.FromStream(ms, true); 

                    

                    //byte[] imgData = (byte[])ItemsDataGridView.Rows[currentRow].Cells[5].Value;
                    //MemoryStream ms = new MemoryStream(imgData);
                    //ms.Seek(0, SeekOrigin.Begin);
                    //Bitmap bmp = new Bitmap(ms);
                    //ItemPictureBox.Image = Image.FromStream(ms);


                    //Bitmap IMG = new Bitmap(ItemPictureBox.Image);
                    //MemoryStream stream = new MemoryStream();
                    //IMG.
                    //IMG.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

//                    Bitmap image = new Bitmap();
//                    ItemPictureBox.Image = 
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
                if (File.Exists("ItemImages\\" + ItemNewName_txt.Text + ".JPG") == true)
                {
                    ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemNewName_txt.Text + ".JPG";
                }
                else if (File.Exists("ItemImages\\" + ItemNewName_txt.Text + ".JPEG") == true)
                {
                    ItemPictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\ItemImages\\" + ItemNewName_txt.Text + ".JPEG";
                }
            }

            string Result = DatabaseCalls.ModifyItems(ItemsDataGridView.Rows[currentRow].Cells["ID"].Value.ToString(), ItemNewName_txt.Text, ItemModel_txt.Text, ItemQuantity_txt.Text, ItemPrice_txt.Text, ItemCostPrice_txt.Text, ItemPictureBox, ItemCategory_txt.Text, Convert.ToInt32(TQUANTITY_txt.Text));
            if (Result.StartsWith("Item modified") != true)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = Result;
                return;
            }
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetItems();
            ItemsDataGridView.DataSource = Result1.Tables[0];
            ItemsDataGridView.Columns[0].Visible = false;
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
            string Result = DatabaseCalls.AddCategory(ItemCategory_txt.Text);
            if (Result.StartsWith("Category added") != true)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = Result;
                return;
            }
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetCategory();
            ItemCategory_txt.Items.Clear();
            foreach (DataRow asdf in Result1.Tables[0].Rows)
            {
                ItemCategory_txt.Items.Add(asdf.ItemArray[0]);
            }
        }

        private void ItemName_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString().Contains(ItemName_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
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
            ItemNewName_txt.Text = "None";
            ItemModel_txt.Text = "None";
            ItemQuantity_txt.Text = "0";
            ItemPrice_txt.Text = "0";
            TQUANTITY_txt.Text = "0";
            ItemPictureBox.ImageLocation = "";
            textBox2.Text = "";
            ItemNewName_txt.Focus();
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
            ItemNewName_txt.Focus();
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
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
            //(e.KeyChar
        }

        private void ItemName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (ItemName_txt.Text != null)
                        RandomAlgos.comboKeyPressed(ItemName_txt);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    //ItemName_txt.Text = ItemName_txt.;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void ItemName_txt_Enter(object sender, EventArgs e)
        {
            ItemName_txt.DroppedDown = true;
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
    }
}
