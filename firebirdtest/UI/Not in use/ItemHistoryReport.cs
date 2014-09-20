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
    public partial class ItemHistoryReport : Form
    {
        private string p;

        public ItemHistoryReport()
        {
            InitializeComponent();
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetItems();

            //Result1.Tables[0].Columns["Item_Code"].ColumnName = "Item Code";
            for (int loop = 0; loop < Result1.Tables[0].Rows.Count; loop++)//each (DataRow asdf in Result1.Tables[0].Rows[]["CODE"])
            {
                ItemName_txt.Items.Add(Result1.Tables[0].Rows[loop]["CODE"]);
            }
        }
        
        public ItemHistoryReport(ComboBox ItemName_txtImported, string ItemCode)
        {
            InitializeComponent();
            try
            {
                foreach (string ItemName in ItemName_txtImported.Items)
                {
                    ItemName_txt.Items.Add(ItemName);
                }
                this.ItemName_txt.Text = ItemCode;
                button7_Click(this, null);
            }
            catch (System.Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void ItemHistoryReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ItemName_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.iTEMHISTORYTableAdapter.FillBy1(this.itemHistoryDataSource.ITEMHISTORY, ItemName_txt.Text);
            this.reportViewer1.RefreshReport();
        }

        private void ItemName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void ItemName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (ItemName_txt.Text != null) RandomAlgos.comboKeyPressed(ItemName_txt);
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

        private void ItemHistoryReport_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }

        }
    }
}
