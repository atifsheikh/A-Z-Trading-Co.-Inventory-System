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
    public partial class ListItems : Form
    {
        public ListItems()
        {
            InitializeComponent();
        }

        private void ListItems_Load(object sender, EventArgs e)
        {
            //TO GET ITEM LIST
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetItems();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;
                Result1.Tables[0].Columns[1].ColumnName = "Item Code";
                foreach (DataRow asdf in Result1.Tables[0].Rows)
                {
                    ItemName_txt.Items.Add(asdf.ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ListItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ListItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }
    }
}
