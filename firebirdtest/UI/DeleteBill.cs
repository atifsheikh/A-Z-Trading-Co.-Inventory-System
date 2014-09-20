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
    public partial class DeleteBill : Form
    {
        public DeleteBill()
        {
            InitializeComponent();
        }

        static DataSet BillDataSet = new DataSet();
        static DataSet CustomerDataSet = new DataSet();

        private void DeleteBill_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            //Bills
            try
            {
                BillDataSet = DatabaseCalls.GetBills();
                CustomerDataSet = DatabaseCalls.GetCustomers();
                BillDataSet.Tables[0].Columns.Add("Customer");

                for (int loop = 0; loop < BillDataSet.Tables[0].Rows.Count; loop++)
                {
                    for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                    {
                        if (CustomerDataSet.Tables[0].Rows[loop1]["ID"].ToString().Equals(BillDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) == true)
                        {
                            BillDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString();
                        }
                    }
                    if (Convert.ToInt32(BillDataSet.Tables[0].Rows[loop]["ID"]) < 0)
                        BillDataSet.Tables[0].Rows[loop].Delete();
                }
                
                BillDataGridView.DataSource = BillDataSet.Tables[0];
                BillDataGridView.CurrentCell = null;
                BillDataGridView.Columns[0].HeaderText = "Bill Number";
                BillDataGridView.Columns["Customer_ID"].Visible = false;
                BillDataGridView.Columns["Customer"].DisplayIndex = 1;
                BillDataGridView.Update();


                for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                {
                    BillNumberSearch_txt.Items.Add(BillDataGridView.Rows[loop].Cells["ID"].Value);
                }
                //                BillDataGridView.Columns["Customer_ID"].HeaderText = "Customer";
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

        }

        private void BillNumberSearch_txt_TextChanged(object sender, EventArgs e)
        {
            
            if (BillNumberSearch_txt.Text != "")
            {
                for (int loop = 0; loop < BillDataGridView.Rows.Count; loop++)
                {
                    if (BillDataGridView.Rows[loop].Cells["ID"].Value.ToString() == BillNumberSearch_txt.Text)
                    {
                        BillDataGridView.Rows[loop].Selected = true;
                    }
                    else
                    {
                        BillDataGridView.Rows[loop].Selected = false;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BillNumberSearch_txt.Text != "")
            {
                DataSet BillDataSet = new DataSet();
                BillDataSet = DatabaseCalls.GetBill(BillNumberSearch_txt.Text);
                if (BillDataSet.Tables[0].Rows.Count == 0)
                {
                    Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = "No Bill Found";
                    return;
                }

                DataSet CustomerDataSet = new DataSet();
                CustomerDataSet = DatabaseCalls.GetCustomer(Convert.ToInt32(BillDataSet.Tables[0].Rows[0]["CUSTOMER_ID"].ToString()));
                if (CustomerDataSet.Tables[0].Rows.Count == 0)
                {
                    Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = "No Customer Found";
                    return;
                }
                decimal CustomerNewBalance = Convert.ToDecimal(CustomerDataSet.Tables[0].Rows[0]["AMOUNT"]);
                CustomerNewBalance -= Convert.ToDecimal(BillDataSet.Tables[0].Rows[0]["AMOUNT"]);
                DatabaseCalls.ModifyCustomer(Convert.ToInt32(BillDataSet.Tables[0].Rows[0]["Customer_ID"]), CustomerNewBalance);
                DatabaseCalls.DeleteBillDetails(BillNumberSearch_txt.Text);
                DatabaseCalls.DeleteBill(BillNumberSearch_txt.Text);
                BillNumberSearch_txt.Text = "";
                DeleteBill_Load(sender, e);
            }
            BillNumberSearch_txt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void BillNumberSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
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

        private void BillNumberSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (BillNumberSearch_txt.Text != null) RandomAlgos.comboKeyPressed(BillNumberSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

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

        private void BillNumberSearch_txt_Enter(object sender, EventArgs e)
        {
            BillNumberSearch_txt.DroppedDown = true;
        }

        private void CustomerNameSearch_txt_Enter(object sender, EventArgs e)
        {
            CustomerNameSearch_txt.DroppedDown = true;
        }
    }
}
