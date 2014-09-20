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
    public partial class ItemHistory : Form
    {
        public static string ItemCode1;

        public ItemHistory(string ItemCode)
        {
            InitializeComponent();
            ItemCode1 = ItemCode;
        }

        private void ItemHistory_Load(object sender, EventArgs e)
        {
            DataSet ItemHistory = new DataSet();
            ItemHistory = DatabaseCalls.GetItemHistory(ItemCode1);
            dataGridView1.DataSource = ItemHistory.Tables[0];
            //dataGridView1.DataSource = ItemHistory;
        }
    }
}
