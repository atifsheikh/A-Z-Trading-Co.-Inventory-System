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
    public partial class ListCustomers : Form
    {
        public ListCustomers()
        {
            InitializeComponent();
        }

        private void ListCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetCustomers();
                CustomersDataGridView.DataSource = Result1.Tables[0];
                CustomersDataGridView.Columns["ID"].Visible = false;
                CustomersDataGridView.Columns["IMAGE"].Visible = false;
                foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                {
                    CustomerNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            //Customer Detail
            try
            {
                for (int loop = 0; loop < CustomersDataGridView.Rows.Count; loop++)
                {
                    if (CustomersDataGridView.Rows[loop].Cells["NAME"].Value.ToString().Contains(CustomerNameSearch_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
                    {
                        CustomersDataGridView.Rows[loop].Visible = true;
                    }
                    else
                        CustomersDataGridView.Rows[loop].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ListCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ListCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }
    }
}
