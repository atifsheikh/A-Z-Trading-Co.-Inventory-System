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
    public partial class SelectVendorName : Form
    {
        public SelectVendorName(String VendorName)
        {
            InitializeComponent();
            textBox1.Text = VendorName;
//            VendorName_txt.Text = VendorName;
        }

        static DataSet VendorDataSet = new DataSet();
        
        private void SelectVendorName_Load(object sender, EventArgs e)
        {
            //Vendor Detail
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                {
                    VendorName_txt.Items.Add(GridViewColumn.ItemArray[1]);
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
            String Result = DatabaseCalls.AddVendor(textBox1.Text,"None","None","None",0,0);
            VendorName_txt.Items.Add(textBox1.Text);
            VendorName_txt.Text = textBox1.Text;
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedVendorName = VendorName_txt.Text;
            this.Close();
        }

        public string SelectedVendorName { get; set; }

        private void VendorName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VendorName_txt.Text == "")
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
