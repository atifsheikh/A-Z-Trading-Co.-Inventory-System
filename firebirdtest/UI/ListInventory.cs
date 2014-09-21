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
    public partial class ListInventory : Form
    {
        public ListInventory()
        {
            InitializeComponent();
        }

        private void ListInventory_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            // TODO: This line of code loads data into the 'itemInventory_DataSet1.ITEMINVENTORY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'itemInventoryDataSet.ITEMINVENTORY' table. You can move, or remove it, as needed.
            try
            {
                this.iTEMINVENTORYTableAdapter.Fill(this.itemInventory_DataSet1.ITEMINVENTORY);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ListInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ListInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
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

        private void CustomerNameSearch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (CustomerNameSearch_txt.Text != null) RandomAlgos.comboKeyPressed(CustomerNameSearch_txt);
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

        private void ListInventory_Load_1(object sender, EventArgs e)
        {

        }

        private void itemInventoryDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void iTEMINVENTORYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
