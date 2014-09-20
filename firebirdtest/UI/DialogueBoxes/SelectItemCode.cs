using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace firebirdtest.UI
{
    public partial class SelectItemCode : Form
    {
        public SelectItemCode()
        {
            InitializeComponent();
        }

        public SelectItemCode(string ItemCode)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            ItemCode_txt.Text = ItemCode;
        }

        public string ItemCode { get; set; }

        public string SelectedItemCode { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedItemCode_txt.Text != null && SelectedItemCode_txt.Text != "")
            {
                SelectedItemCode = SelectedItemCode_txt.Text;
                this.Close();
            }
            else
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = "Select an item dummass...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItem _AddItem = new AddItem(SelectedItemCode);
            _AddItem.Size = new System.Drawing.Size(273, 514);
            _AddItem.MaximizeBox = false;
            _AddItem.MinimizeBox = false;
            _AddItem.ShowDialog();
        }

        static DataSet ItemDetailsDataSet = new DataSet();
        private void SelectItemCode_Load(object sender, EventArgs e)
        {
            //TO GET ITEM LIST
            try
            {

                ItemDetailsDataSet = DatabaseCalls.GetItems();
                foreach (DataRow asdf in ItemDetailsDataSet.Tables[0].Rows)
                {
                    SelectedItemCode_txt.Items.Add(asdf.ItemArray[6]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void SelectedItemCode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
