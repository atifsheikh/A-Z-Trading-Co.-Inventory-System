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
    public partial class SelectCustomerName : Form
    {
        public SelectCustomerName(String CustomerName)
        {
            InitializeComponent();
            textBox1.Text = CustomerName;
//            CustomerName_txt.Text = CustomerName;
        }

        static DataSet CustomerDataSet = new DataSet();
        
        private void SelectCustomerName_Load(object sender, EventArgs e)
        {
            //Customer Detail
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    CustomerName_txt.Items.Add(GridViewColumn.ItemArray[1]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Result = DatabaseCalls.AddCustomer(textBox1.Text,"None","None","None",0,0,"");
            CustomerName_txt.Items.Add(textBox1.Text);
            CustomerName_txt.Text = textBox1.Text;
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedCustomerName = CustomerName_txt.Text;
            this.Close();
        }

        public string SelectedCustomerName { get; set; }

        private void CustomerName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CustomerName_txt.Text == "")
                    SendKeys.Send("{TAB}");
                else
                {
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                }
            }
        }
    }
}
