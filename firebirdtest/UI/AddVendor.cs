using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;
using Newtonsoft.Json;


namespace firebirdtest.UI
{
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            //MessageBox.Show("init");
            InitializeComponent();
        }

        public AddVendor(string VendorName)
        {
            InitializeComponent();
            VendorName_txt.Text = VendorName;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VendorName_txt.Text != "" && VendorNameSearch_txt.Items.Contains(VendorName_txt.Text) == false)
            {
                try
                {
                    String Result = DatabaseCalls.AddVendor(VendorName_txt.Text, VendorAddress_txt.Text, VendorPhone_txt.Text, VendorEmail_txt.Text, 0, Convert.ToInt32(VendorOpeningBalance_txt.Text));
                    if (Result != "")
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result;
                    }
                    else 
                    {
                        Variables.NotificationStatus = false;
                    }

                    VendorDataSet = DatabaseCalls.GetVendors();
                    RandomAlgos.CleanUpGridView(VendorDataSet, VendorsDataGridView);
                    foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                    {
                        VendorNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
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
                Variables.NotificationMessageText = "Vendor Name already Exists...";
            }
            FormLoading = false;
            //this.Close();
        }

        bool FormLoading = false;
        private void AddVendor_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            //    VendorName_txt.Text = "";
            VendorAddress_txt.Text = "None";
            VendorPhone_txt.Text = "None";
            VendorEmail_txt.Text = "None";
            VendorOpeningBalance_txt.Text = "0";
            FormLoading = true;
        }

        private void ItemsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormLoading == false && VendorsDataGridView.CurrentRow != null)
                {
                    VendorName_txt.Text = VendorsDataGridView.CurrentRow.Cells["NAME"].Value.ToString();
                    VendorAddress_txt.Text = VendorsDataGridView.CurrentRow.Cells["ADDRESS"].Value.ToString();
                    VendorPhone_txt.Text = VendorsDataGridView.CurrentRow.Cells["PHONE"].Value.ToString();
                    VendorEmail_txt.Text = VendorsDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                    VendorOpeningBalance_txt.Text = VendorsDataGridView.CurrentRow.Cells["OPENING_BALANCE"].Value.ToString();
                    CurrentAmount = Convert.ToDecimal(VendorsDataGridView.CurrentRow.Cells["AMOUNT"].Value.ToString()); 
                    PreviousBalance = Convert.ToDecimal(VendorOpeningBalance_txt.Text);
                    
                }
            }
            catch (Exception ex)
            { }
        }

        public decimal CurrentAmount = 0;
        public decimal PreviousBalance = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            decimal CalculatedAmount= Convert.ToDecimal(VendorOpeningBalance_txt.Text) - PreviousBalance + CurrentAmount;
            string VendorModifyResult = DatabaseCalls.ModifyVendor(VendorsDataGridView.CurrentRow.Cells["ID"].Value.ToString(), VendorName_txt.Text, VendorAddress_txt.Text, VendorPhone_txt.Text, VendorEmail_txt.Text, Convert.ToInt32(VendorOpeningBalance_txt.Text), CalculatedAmount);

            if (VendorModifyResult != "")
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = VendorModifyResult;
            }
            DataSet VendorDataSet = new DataSet();
            VendorDataSet = DatabaseCalls.GetVendors();
            RandomAlgos.CleanUpGridView(VendorDataSet, VendorsDataGridView);
        }

        static DataSet VendorDataSet = new DataSet();
        private void AddVendor_Shown(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    VendorDataSet = DatabaseCalls.GetVendors();
                    RandomAlgos.CleanUpGridView(VendorDataSet, VendorsDataGridView);
                    //VendorsDataGridView.DataSource = VendorDataSet.Tables[0];
                    ////after populating dgv, do the follwing:
                    //int cleanCount = VendorDataSet.Tables[0].Rows.Count;
                    //while (VendorsDataGridView.Rows.Count > cleanCount)
                    //{
                    //    VendorsDataGridView.Rows[cleanCount].Visible = false;
                    //    cleanCount++;
                    //}
                    //foreach (DataRow GridViewColumn in VendorDataSet.Tables[0].Rows)
                    //{
                    //    VendorNameSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                    //}
                    //if (VendorsDataGridView.Columns.Count > 0)
                    //{
                    //    VendorsDataGridView.Columns["NAME"].DisplayIndex = 0;
                    //    VendorsDataGridView.Columns["ADDRESS"].DisplayIndex = 1;
                    //    VendorsDataGridView.Columns["PHONE"].DisplayIndex = 2;
                    //    VendorsDataGridView.Columns["EMAIL"].DisplayIndex = 3;
                    //    VendorsDataGridView.Columns["OPENING_BALANCE"].DisplayIndex = 4;
                    //    VendorsDataGridView.Columns["AMOUNT"].Visible = false;
                    //    VendorsDataGridView.Columns["BALANCE_LIMIT"].Visible = false;
                    //}
                }
                catch (Exception ex)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                }
                FormLoading = false;
                VendorName_txt.Focus();
            }
            catch (Exception ex)
            { }
        }

        private void VendorNameSearch_txt_TextChanged(object sender, EventArgs e)
        {
            
            //Vendor Detail
            try
            {
                for (int loop = 0; loop < VendorsDataGridView.Rows.Count; loop++)
                {
                    if (VendorsDataGridView.Rows[loop].Cells["NAME"].Value.ToString().Contains(VendorNameSearch_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
                    {
                        VendorsDataGridView.Rows[loop].Visible = true;
                    }
                    else
                        VendorsDataGridView.Rows[loop].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void AddVendor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void VendorName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void AddVendor_KeyDown(object sender, KeyEventArgs e)
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

        private void VendorNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void VendorNameSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (VendorNameSearch_txt.Text != null) RandomAlgos.comboKeyPressed(VendorNameSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void VendorNameSearch_txt_Enter(object sender, EventArgs e)
        {
            VendorNameSearch_txt.DroppedDown = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VendorName_txt.Text = "";
            VendorAddress_txt.Text = "None";
            VendorPhone_txt.Text = "";
            VendorEmail_txt.Text = "None";
            VendorOpeningBalance_txt.Text = "0";
        }

        private void VendorsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VendorsDataGridView.Sort(VendorsDataGridView.Columns["NAME"], ListSortDirection.Ascending);
        }

        private void VendorsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
