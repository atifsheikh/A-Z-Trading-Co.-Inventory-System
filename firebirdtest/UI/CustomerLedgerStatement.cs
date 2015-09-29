using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;
using System.Threading;

namespace firebirdtest.UI
{
    public partial class CustomerLedgerStatement : Form
    {
        public CustomerLedgerStatement()
        {
            InitializeComponent();
        }

        static DataSet Ctn_Voucher_DataSet = new DataSet();
        static DataSet LedgerDataSet = new DataSet();
        static DataSet CustomerDataSet = new DataSet();

        public void RefreshCustomerData()
        {
            //get customers
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                CustomerNameDataGridView.DataSource = CustomerDataSet.Tables[0];
                if (CustomerNameDataGridView.Columns.Count > 0)
                {
                    CustomerNameDataGridView.Columns["ID"].Visible = false;
                    CustomerNameDataGridView.Columns["OPENING_BALANCE"].Visible = false;
                    CustomerNameDataGridView.Columns["ADDRESS"].Visible = false;
                    CustomerNameDataGridView.Columns["EMAIL"].Visible = false;
                    CustomerNameDataGridView.Columns["PHONE"].Visible = false;
                    CustomerNameDataGridView.Columns["BALANCE_LIMIT"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        static DataSet BillsDataSet = new DataSet();
        static DataSet CustomerVoucherDataSet = new DataSet();
        static DataSet CustomerLedgerDataSet = new DataSet();
        private void LedgerStatement_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }

            //get customers
            RefreshCustomerData();
            //Voucher Detail
            try
            {
                BillsDataSet = DatabaseCalls.GetBills();
                //BillsDataSet.Tables[0].Columns.Remove("TOTAL_CTN");
                BillsDataSet.Tables[0].TableName = "Ledger";
                CustomerVoucherDataSet = DatabaseCalls.GetCustomerVoucher();
                //CustomerVoucherDataSet.Tables[0].Columns.Remove("REMARKS");
                BillsDataSet.Tables[0].Columns.Remove("NAME");
                BillsDataSet.Tables[0].Columns["CUSTOMERID"].ColumnName = "CustomerID";
                BillsDataSet.Tables[0].Columns["CUSTOMERNAME"].ColumnName = "CustomerNAME";


                CustomerVoucherDataSet.Tables[0].TableName = "Ledger"; 
                CustomerVoucherDataSet.Merge(BillsDataSet);
                
                try
                {
                    //LedgerGridView.DataSource = CustomerVoucherDataSet.Tables["0"];
                    DataView dv = new DataView(CustomerVoucherDataSet.Tables[0]);
                    dv.Sort = "DATED";
                    LedgerGridView.DataSource = dv;
                }
                catch (Exception ex)
                { }
                //LedgerGridView.Columns["DATED"].DefaultCellStyle.Format = "HH MM/dd/yyyy";
                //LedgerGridView.Columns["DATED"].SortMode = DataGridViewColumnSortMode.Automatic;
                LedgerGridView.CurrentCell = null;
                if (LedgerGridView.Columns.Count > 0)
                {
                    LedgerGridView.Columns["ID"].HeaderText = "S.NO";
                    LedgerGridView.Columns["CUSTOMERNAME"].HeaderText = "Customer";
                    LedgerGridView.Columns["DATED"].HeaderText = "Date";
                    LedgerGridView.Columns["CUSTOMER_BALANCE"].HeaderText = "Balance";

                    LedgerGridView.Columns["CUSTOMERID"].Visible = false;
                    //LedgerGridView.Columns["Customer"].DisplayIndex = 2;//.Visible 
                    //LedgerGridView.Columns["TotalCtn"].DisplayIndex = 4;//.Visible 
                    LedgerGridView.Columns["DATED"].SortMode = DataGridViewColumnSortMode.Automatic;

                    LedgerGridView.Update();
                }

                /*              Ctn_Voucher_DataSet = DatabaseCalls.Get_Ctn_Voucher();
                                LedgerDataSet = DatabaseCalls.GetLedger("All");
                                if (LedgerDataSet.Tables[0].Columns.Count > 0)
                                {
                                    LedgerDataSet.Tables[0].Columns["ID"].ColumnName = "VoucherNo";

                                    LedgerDataSet.Tables[0].Columns.Add("Customer");
                                    LedgerDataSet.Tables[0].Columns.Add("TotalCtn");
                                    LedgerDataSet.Tables[0].Columns.Add("Calculator");

                                    for (int loop = 0; LedgerDataSet.Tables.Count > 0 && loop < LedgerDataSet.Tables[0].Rows.Count; loop++)
                                    {
                                        if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) > -1)
                                        {
                                            for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                                            {
                                                if (Convert.ToInt32(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"]) == Convert.ToInt32(CustomerDataSet.Tables[0].Rows[loop1]["ID"]))
                                                {
                                                    if (LedgerDataSet.Tables[0].Rows[loop]["Customer"].ToString() != CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString())
                                                        LedgerDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"];
                                                }
                                            }

                                            for (int loop1 = 0; Ctn_Voucher_DataSet.Tables.Count > 0 && loop1 < Ctn_Voucher_DataSet.Tables[0].Rows.Count; loop1++)
                                            {
                                                if (Convert.ToInt32(LedgerDataSet.Tables[0].Rows[loop]["VoucherNo"]) == Convert.ToInt32(Ctn_Voucher_DataSet.Tables[0].Rows[loop1]["BILL_ID"]))
                                                {
                                                    if (LedgerDataSet.Tables[0].Rows[loop]["TotalCtn"].ToString() != Ctn_Voucher_DataSet.Tables[0].Rows[loop1]["QTY"].ToString())
                                                        LedgerDataSet.Tables[0].Rows[loop]["TotalCtn"] = Ctn_Voucher_DataSet.Tables[0].Rows[loop1]["QTY"];
                                                }
                                            }
                                        }
                                        else if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) == -1)
                                            LedgerDataSet.Tables[0].Rows[loop]["Customer"] = "Admin";
                                        else
                                            LedgerDataSet.Tables[0].Rows[loop]["Customer"] = "Error";
                                    }


                                    LedgerGridView.Visible = false;

                                    LedgerGridView.Columns.Clear();
                                    LedgerGridView.DataSource = LedgerDataSet.Tables[0];
                                    LedgerGridView.Columns["Customer_ID"].Visible = false;
                                    LedgerGridView.Columns["CUSTOMER_BALANCE"].Visible = false;
                                    LedgerGridView.Columns["Customer"].DisplayIndex = 2;//.Visible 
                                    LedgerGridView.Columns["TotalCtn"].DisplayIndex = 4;//.Visible 
                                    LedgerGridView.Columns["DATED"].SortMode = DataGridViewColumnSortMode.Automatic;

                                    LedgerGridView.Visible = true;
                                }*/
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
            try
            {
                if (VoucherModification == false)
                {
                    if (VoucherAmount_txt.Text == "0" || VoucherAmount_txt.Text == "")
                    {
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "add amount.";
                        Variables.NotificationStatus = true;
                        return;
                    }
                    //Add Voucher Number
                    String Result1 = DatabaseCalls.AddCustomerVoucherPayment(Convert.ToInt32(CustomerID_txt.Text), Voucher_DTPicker.Value, Convert.ToDecimal(VoucherAmount_txt.Text), VoucherRemarks_txt.Text);
                    if (Result1 != "")
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result1;
                        return;
                    }
                }
                else
                {
                    //LedgerGridView.Rows[SelectedRowIndex].Cells["ID"].Value.ToString()
                    String Result1 = DatabaseCalls.UpdateCustomerVoucherPayment(Convert.ToInt32(CustomerID_txt.Text), Voucher_DTPicker.Value, Convert.ToDecimal(VoucherAmount_txt.Text), VoucherRemarks_txt.Text, ModifyVoucherNumber);
                    if (Result1 != "")
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result1;
                        return;
                    }
                }
                CustomerBalance_txt.Text = "0";
                VoucherAmount_txt.Text = "0";
                VoucherRemarks_txt.Text = "0";
                LedgerStatement_Load(sender, e);

                CustomerName_txt.Focus();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void CustomerID_txt_TextChanged(object sender, EventArgs e)
        {
            //if (CustomerID_txt.Text != "")
            try
            {
                if (CustomerID_txt.Text == "")
                    return;
                Int64 calculator = 0;
                for (int loop1 = 0; loop1 < LedgerGridView.Rows.Count-1; loop1++)
                {
                    try
                    {
                        LedgerGridView.CurrentCell = null;
                        if (LedgerGridView.Rows[loop1].Cells["CustomerID"].Value.ToString() != (CustomerID_txt.Text))
                        {
                            LedgerGridView.Rows[loop1].Visible = false;
                        }
                        else
                        {
                            LedgerGridView.Rows[loop1].Visible = true;
                            //calculator += Convert.ToInt64(LedgerGridView.Rows[loop1].Cells["AMOUNT"].Value);
                            //LedgerGridView.Rows[loop1].Cells["Calculator"].Value = calculator;
                        }
                    }
                    catch (Exception ex)
                    { }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void LedgerStatement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void LedgerStatement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }

        private void LedgerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32( LedgerGridView.Rows[e.RowIndex].Cells["VoucherNo"].Value) > -1)
                return;
            VoucherPaymentModification _VoucherPaymentModification = new VoucherPaymentModification(LedgerGridView.Rows[e.RowIndex].Cells["AMOUNT"].Value);
            _VoucherPaymentModification.StartPosition = FormStartPosition.CenterScreen; 
            _VoucherPaymentModification.ShowDialog();

            if (_VoucherPaymentModification.NewAmount != "" && LedgerGridView.Rows[e.RowIndex].Cells["AMOUNT"].Value != _VoucherPaymentModification.NewAmount)
            {

                decimal NewAmount = Convert.ToDecimal(_VoucherPaymentModification.NewAmount);
                decimal OldAmount = Convert.ToDecimal(LedgerGridView.Rows[e.RowIndex].Cells["AMOUNT"].Value);
                decimal UpdateAmount = NewAmount - OldAmount;

                
                DataSet CustomerDataSet1 = DatabaseCalls.GetCustomer(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Customer_id"].Value));
                if (CustomerDataSet1.Tables.Count > 0)
                {
                    if (CustomerDataSet1.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Customer Found";
                        return;
                    }
                    decimal CustomerNewBalance = Convert.ToDecimal(CustomerDataSet1.Tables[0].Rows[0]["AMOUNT"]);
                    CustomerNewBalance += UpdateAmount;


                    //atif work here
                    //DatabaseCalls.ModifyCustomer(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Customer_id"].Value), CustomerNewBalance);
                    //CustomerDataSet1 = DatabaseCalls.GetCustomers();//.GetCustomer(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Customer_id"].Value));
                    DatabaseCalls.ModifyVoucher(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["VoucherNo"].Value), NewAmount, CustomerNewBalance);
                    LedgerGridView.Rows[e.RowIndex].Cells["Amount"].Value = NewAmount;
                    VoucherRemarks_txt.Focus();
                }
                //Voucher Detail
                try
                {
                    LedgerDataSet = DatabaseCalls.GetLedger("All");
                    if (LedgerDataSet.Tables.Count > 0)
                    {
                        LedgerDataSet.Tables[0].Columns["ID"].ColumnName = "VoucherNo";

                        LedgerDataSet.Tables[0].Columns.Add("Customer");

                        for (int loop = 0; loop < LedgerDataSet.Tables[0].Rows.Count; loop++)
                        {
                            if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) > -1)
                            {
                                for (int loop1 = 0; loop1 < CustomerDataSet.Tables[0].Rows.Count; loop1++)
                                {
                                    if (Convert.ToInt32(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"]) == Convert.ToInt32(CustomerDataSet.Tables[0].Rows[loop1]["ID"]))
                                    {
                                        if (LedgerDataSet.Tables[0].Rows[loop]["Customer"].ToString() != CustomerDataSet.Tables[0].Rows[loop1]["Name"].ToString())
                                            LedgerDataSet.Tables[0].Rows[loop]["Customer"] = CustomerDataSet.Tables[0].Rows[loop1]["Name"];
                                    }
                                }
                            }
                            else if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()) == -1)
                                LedgerDataSet.Tables[0].Rows[loop]["Customer"] = "Admin";
                            else
                                LedgerDataSet.Tables[0].Rows[loop]["Customer"] = "Error";
                        }
                    }
                    LedgerGridView.Columns.Clear();
                    LedgerGridView.DataSource = LedgerDataSet.Tables[0];

                    LedgerGridView.Columns["Customer_ID"].Visible = false;
                    LedgerGridView.Columns["Customer"].DisplayIndex = 2;//.Visible 
                    LedgerGridView.Columns["TotalCtn"].DisplayIndex = 4;//.Visible 
                    LedgerGridView.Columns["DATED"].SortMode = DataGridViewColumnSortMode.Automatic;
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
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = "Same Amount Entered";
                Variables.NotificationStatus = true;
            }
        }
        bool VoucherModification = false;
        string ModifyVoucherNumber = "";
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VoucherModification = true;
                if (LedgerGridView.CurrentRow.Index >= 0)
                {
                    ModifyVoucherNumber = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["ID"].Value.ToString();
                    CustomerName_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["CUSTOMERNAME"].Value.ToString();
                    Voucher_DTPicker.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["DATED"].Value.ToString();
                    VoucherRemarks_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["REMARKS"].Value.ToString();
                    VoucherAmount_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["AMOUNT"].Value.ToString();
                    CustomerID_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["CustomerID"].Value.ToString();
                    CustomerBalance_txt.Text = LedgerGridView.Rows[SelectedRowIndex].Cells["CUSTOMER_BALANCE"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            { }
        }

        private void LedgerGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int loop = 0; loop < LedgerGridView.Rows.Count - 1; loop++)
            {
                if (LedgerGridView.Rows[loop].Cells["REMARKS"].Value.ToString().Contains("Voucher"))
                    LedgerGridView.Rows[loop].DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    LedgerGridView.Rows[loop].DefaultCellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();
        }

        private void CustomerName_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < CustomerNameDataGridView.Rows.Count; loop++)
                {
                        CustomerNameDataGridView.Rows[loop].Visible = true;
                }
                
                CustomerID_txt.Text = "";
                CustomerNameDataGridView.Visible = true;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
        }

        private void VoucherRemarks_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VoucherAmount_txt.Focus();
            }
        }

        private void VoucherAmount_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void CustomerName_txt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Voucher_DTPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VoucherRemarks_txt.Focus();
            }
        }

        string BILL_ITEM_ID = "";
        private void CustomerNameDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //if (Convert.ToInt32(CustomerNameDataGridView.Rows[SelectedRowIndex].Cells["Quantity"].Value.ToString()) > 0)
                    {
                        CustomerNameDataGridView.Visible = false;
                        CustomerName_txt.Text = CustomerNameDataGridView.Rows[SelectedRowIndex].Cells["Name"].Value.ToString().Trim();
                        CustomerID_txt.Text = CustomerNameDataGridView.Rows[SelectedRowIndex].Cells["ID"].Value.ToString().Trim();
                        CustomerBalance_txt.Text = CustomerNameDataGridView.Rows[SelectedRowIndex].Cells["AMOUNT"].Value.ToString().Trim();


                        Voucher_DTPicker.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    CustomerName_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        int SelectedRowIndex = 0;
        private void CustomerNameDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CustomerNameDataGridView.Visible == true)
                {
                    SelectedRowIndex = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void CustomerName_txt_TextChanged_1(object sender, EventArgs e)
        {                        //Customer Detail
            try
            {
                for (int loop = 0; loop < CustomerNameDataGridView.Rows.Count; loop++)
                {
                    if (StaticClass.Contain(CustomerNameDataGridView.Rows[loop].Cells["NAME"].Value.ToString(), CustomerName_txt.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        CustomerNameDataGridView.Rows[loop].Visible = true;
                    }
                    else
                    {
                        CustomerNameDataGridView.CurrentCell = null;
                        CustomerNameDataGridView.Rows[loop].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerName_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CustomerNameDataGridView.Focused == false)
                    CustomerNameDataGridView.Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            
        }

        private void CustomerName_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    this.AllowDrop = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void CustomerName_txt_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    CustomerNameDataGridView.Visible = !CustomerNameDataGridView.Visible;
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    CustomerNameDataGridView.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (CustomerName_txt.Text == "")
                    {
                        //CustomerID_txt.Focus();
                        return;
                    }
                    if (CustomerNameDataGridView.SelectedRows.Count <= 0)
                    {
                        for (int loop = 0; loop < CustomerNameDataGridView.Rows.Count; loop++)
                        {
                            if (CustomerNameDataGridView.Rows[loop].Visible == true)// && ItemsDataGridView.Rows[loop].Cells["CODE"].Value.ToString() == ItemCode_txt.Text)
                            {
                                CustomerName_txt.Text = CustomerNameDataGridView.Rows[loop].Cells["Name"].Value.ToString().Trim();
                                CustomerID_txt.Text = CustomerNameDataGridView.Rows[loop].Cells["ID"].Value.ToString().Trim();
                                CustomerBalance_txt.Text = CustomerNameDataGridView.Rows[loop].Cells["AMOUNT"].Value.ToString().Trim();
                                Voucher_DTPicker.Focus();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LedgerGridView.CurrentCell = null;
            foreach (DataGridViewRow DR in LedgerGridView.Rows)
            {
                try
                {
                    DR.Visible = true;
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
