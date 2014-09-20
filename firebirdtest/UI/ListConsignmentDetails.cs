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
    public partial class ListConsignmentDetails : Form
    {
        public ListConsignmentDetails()
        {
            InitializeComponent();
        }

        private void ListConsignmentDetails_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            
            //TO GET Consingment Detail LIST
            try
            {

                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignmentDetails();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;
                ItemsDataGridView.Columns["SHIP_ID"].DisplayIndex = 0;
                ItemsDataGridView.Columns["ITEM_CODE"].DisplayIndex = 1;
                ItemsDataGridView.Columns["MODEL"].DisplayIndex = 2;
                ItemsDataGridView.Columns["MODEL"].HeaderText = "Discription";
                ItemsDataGridView.Columns["CTN"].DisplayIndex = 3;
                ItemsDataGridView.Columns["QTY_PER_BOX"].DisplayIndex = 4;
                ItemsDataGridView.Columns["T_QUANTITY"].DisplayIndex = 5;


                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (ItemSearchName_txt.Items.Contains(ItemsDataGridView.Rows[loop].Cells["SHIP_ID"].Value) == false)
                        ItemSearchName_txt.Items.Add(ItemsDataGridView.Rows[loop].Cells["SHIP_ID"].Value);
                }
                ItemSearchName_txt.Text = "   ";
                //ItemSearchName_txt_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ItemSearchName_txt_TextChanged(object sender, EventArgs e)
        {
            
            //Customer Detail
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (ItemsDataGridView.Rows[loop].Cells["SHIP_ID"].Value.ToString().Contains(ItemSearchName_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Customer Detail
            try
            {
                for (int loop = 0; loop < ItemsDataGridView.Rows.Count; loop++)
                {
                    if (ItemsDataGridView.Rows[loop].Cells["ITEM_CODE"].Value.ToString().Contains(ItemModel_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
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

        private void ListConsignmentDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ListConsignmentDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();
        }

        private void ItemSearchName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void ItemSearchName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (ItemSearchName_txt.Text != null) RandomAlgos.comboKeyPressed(ItemSearchName_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void ItemSearchName_txt_Enter(object sender, EventArgs e)
        {
            ItemSearchName_txt.DroppedDown = true;
        }
    }
}
