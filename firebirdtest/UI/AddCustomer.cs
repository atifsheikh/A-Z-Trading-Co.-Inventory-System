using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;

namespace firebirdtest.UI
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            //MessageBox.Show("init");
            InitializeComponent();
        }

        public AddCustomer(string CustomerName)
        {
            InitializeComponent();
            CustomerName_txt.Text = CustomerName;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustomerName_txt.Text != "" && CustomerNameSearch_txt.Items.Contains(CustomerName_txt.Text) == false)
            {
                try
                {
                    String Result = DatabaseCalls.AddCustomer(CustomerName_txt.Text, CustomerAddress_txt.Text, CustomerPhone_txt.Text, CustomerEmail_txt.Text, 0, Convert.ToInt32(CustomerOpeningBalance_txt.Text));
                    string[] CustomerID = Result.Split('=');
                    DatabaseCalls.AddBill(Convert.ToInt32(DatabaseCalls.GetNewBillNumber()+1), Convert.ToInt32(CustomerID[1].Trim()), DateTime.Now, Convert.ToInt32(CustomerOpeningBalance_txt.Text), Convert.ToInt32(CustomerOpeningBalance_txt.Text), "Opening Balance");
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result;
                    CustomerDataSet = DatabaseCalls.GetCustomers();
                    CustomersDataGridView.DataSource = CustomerDataSet.Tables[0];
                    CustomersDataGridView.Columns["ID"].Visible = false;

                    foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
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
            else
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = "Customer Name already Exists...";
            }
            FormLoading = false;
            //this.Close();
        }

        bool FormLoading = false;
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            //    CustomerName_txt.Text = "";
            CustomerAddress_txt.Text = "None";
            CustomerPhone_txt.Text = "None";
            CustomerEmail_txt.Text = "None";
            CustomerOpeningBalance_txt.Text = "0";
            FormLoading = true;
        }

        private void ItemsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormLoading == false)
                {
                    CustomerName_txt.Text = CustomersDataGridView.CurrentRow.Cells["NAME"].Value.ToString();
                    CustomerAddress_txt.Text = CustomersDataGridView.CurrentRow.Cells["ADDRESS"].Value.ToString();
                    CustomerPhone_txt.Text = CustomersDataGridView.CurrentRow.Cells["PHONE"].Value.ToString();
                    CustomerEmail_txt.Text = CustomersDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                    CustomerOpeningBalance_txt.Text = CustomersDataGridView.CurrentRow.Cells["OPENING_BALANCE"].Value.ToString();
                    CurrentAmount = Convert.ToDecimal(CustomersDataGridView.CurrentRow.Cells["AMOUNT"].Value.ToString()); 
                    PreviousBalance = Convert.ToDecimal(CustomerOpeningBalance_txt.Text);
                    
                }
            }
            catch (Exception ex)
            { }
        }

        public decimal CurrentAmount = 0;
        public decimal PreviousBalance = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            decimal CalculatedAmount= Convert.ToDecimal(CustomerOpeningBalance_txt.Text) - PreviousBalance + CurrentAmount;
            string CustomerModifyResult = DatabaseCalls.ModifyCustomer(CustomersDataGridView.CurrentRow.Cells["ID"].Value.ToString(), CustomerName_txt.Text, CustomerAddress_txt.Text, CustomerPhone_txt.Text, CustomerEmail_txt.Text, Convert.ToInt32(CustomerOpeningBalance_txt.Text), CalculatedAmount);

            DataSet CusomerBillDataSet = DatabaseCalls.GetBillsbyCustomer(CustomersDataGridView.CurrentRow.Cells["ID"].Value.ToString());
            foreach (DataRow Remarks in CusomerBillDataSet.Tables[0].Rows)
            {
                if (Remarks.ItemArray[4].ToString().Contains("Opening Balance") == true)
                {
                    DatabaseCalls.ModifyBillAmmount(Convert.ToInt32(Remarks.ItemArray[0].ToString()), Convert.ToDecimal(CustomerOpeningBalance_txt.Text));
                    break;
                }
            }
            
            if (CustomerModifyResult.StartsWith("Customer modified = ") != true)
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = CustomerModifyResult;

            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetCustomers();
            CustomersDataGridView.DataSource = Result1.Tables[0];
            CustomersDataGridView.Columns[0].Visible = false;
        }

        static DataSet CustomerDataSet = new DataSet();
        private void AddCustomer_Shown(object sender, EventArgs e)
        {
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                CustomersDataGridView.DataSource = CustomerDataSet.Tables[0];
                CustomersDataGridView.Columns["ID"].Visible = false;

                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    CustomerNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                }
                CustomersDataGridView.Columns["NAME"].DisplayIndex = 0;
                CustomersDataGridView.Columns["ADDRESS"].DisplayIndex = 1;
                CustomersDataGridView.Columns["PHONE"].DisplayIndex = 2;
                CustomersDataGridView.Columns["EMAIL"].DisplayIndex = 3;
                CustomersDataGridView.Columns["OPENING_BALANCE"].DisplayIndex = 4;
                CustomersDataGridView.Columns["AMOUNT"].Visible= false;
                CustomersDataGridView.Columns["BALANCE_LIMIT"].Visible= false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
            FormLoading = false;
            CustomerName_txt.Focus();
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

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
Variables.FormClosed = true;
        }

        private void CustomerName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void AddCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerName_txt.Text = "";
            CustomerAddress_txt.Text = "None";
            CustomerPhone_txt.Text = "";
            CustomerEmail_txt.Text = "None";
            CustomerOpeningBalance_txt.Text = "0";
        }

        private void CustomersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CustomersDataGridView.Sort(CustomersDataGridView.Columns["NAME"], ListSortDirection.Ascending);
        }

        private void CustomersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
