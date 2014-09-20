using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace firebirdtest.UI
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetItems("Name");
            foreach (DataRow asdf in Result1.Tables[0].Rows)
            {
                ItemName_ComboBox.Items.Add(asdf.ItemArray[0]);
            }
        }

        private void EditItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }
    }
}
