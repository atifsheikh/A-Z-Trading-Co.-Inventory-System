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
    public partial class LedgerStatement : Form
    {
        public LedgerStatement()
        {
            InitializeComponent();
        }

        static DataSet LedgerDataSet = new DataSet();
        static DataSet CustomerDataSet = new DataSet();
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
            try
            {
                CustomerDataSet = DatabaseCalls.GetCustomers();
                CustomerNameDataGridView.DataSource = CustomerDataSet.Tables[0];

                //foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                //{
                //    CustomerName_txt.Items.Add(GridViewColumn.ItemArray[1]);
                //}
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }

            //Bill Detail
            try
            {
                LedgerDataSet = DatabaseCalls.GetLedger("All");
                LedgerDataSet.Tables[0].Columns["ID"].ColumnName = "BillNo";

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

                //for (int loop = 0; loop < LedgerDataSet.Tables[0].Rows.Count; loop++)
                //{
                //    string asdf=DatabaseCalls.GetCustomerName(Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()));
                //    if (LedgerDataSet.Tables[0].Rows[loop]["Customer"] .ToString() != asdf)
                //    {//LedgerDataSet.Tables[0].Rows[loop]["Customer"] = DatabaseCalls.GetCustomerName(Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()));
                //    }
                //}

                LedgerGridView.Visible = false;

                LedgerGridView.Columns.Clear();
                LedgerGridView.DataSource = LedgerDataSet.Tables[0];
                
                LedgerGridView.Columns["Customer_ID"].Visible = false;
                LedgerGridView.Columns["Customer"].DisplayIndex = 2;//.Visible 
                LedgerGridView.Columns["DATED"].SortMode = DataGridViewColumnSortMode.Automatic;
                LedgerGridView.CurrentCell = null;
                foreach (DataGridViewRow DR in LedgerGridView.Rows)
                {
                    try
                    {
                        DR.Visible = false;
                    }
                    catch (Exception ex)
                    {
                    }
                }

                //for (int loop1 = LedgerGridView.Rows.Count - 2; loop1 >= 0; loop1--)
                //{
                    
                //    LedgerGridView.Rows[loop1].Visible = false;
                //}
                LedgerGridView.Visible = true;
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
                VoucherAmount_txt_TextChanged(sender, e);
                if (VoucherAmount_txt.Text == "0" || VoucherAmount_txt.Text == "")
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "add amount.";
                    Variables.NotificationStatus = true;
                    return;
                }
                int CustomerID = -1;
                foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                {
                    if (GridViewColumn.ItemArray[1].ToString() == CustomerName_txt.Text)
                    {
                        CustomerID = Convert.ToInt32(GridViewColumn.ItemArray[0]);
                        break;
                    }
                }
                decimal VoucherAmount = Convert.ToDecimal(VoucherAmount_txt.Text) * (-1);

                //Add Bill Number
                String Result1 = DatabaseCalls.AddVoucherPayment(CustomerID, Voucher_DTPicker.Value, VoucherAmount, VoucherRemarks_txt.Text, Convert.ToDecimal(RemainingBalance_txt.Text));
                if (Result1.StartsWith("Voucher Added with") != true)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = Result1;
                    return;
                }
                //LedgerStatement_Load(sender, e);
                //Variables.FormRefresh = "AddBill/Leadger";
                RemainingBalance_txt.Text = "0";
                CustomerBalance_txt.Text = "0";
                VoucherAmount_txt.Text = "0";
                VoucherRemarks_txt.Text = "0";
                //            CustomerName_txt.Text = "";
                //            CustomerName_txt_Enter(sender, e);
                //            CustomerID_txt.Text = "";
                
                

                CustomerName_txt.Focus();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void VoucherAmount_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (VoucherAmount_txt.Text != "")
                    RemainingBalance_txt.Text = (Convert.ToDecimal(CustomerBalance_txt.Text) - Convert.ToDecimal(VoucherAmount_txt.Text)).ToString();
                else
                    RemainingBalance_txt.Text = CustomerBalance_txt.Text;
            }
            catch (Exception ex)
            { }
        }

        private void CustomerID_txt_TextChanged(object sender, EventArgs e)
        {
            //if (CustomerID_txt.Text != "")
            try
            {
                for (int loop1 = LedgerGridView.Rows.Count -2; loop1 >= 0 ; loop1--)
                {
                    LedgerGridView.CurrentCell = null;
                    if (LedgerGridView.Rows[loop1].Cells["Customer_ID"].Value.ToString() != (CustomerID_txt.Text))
                    {
                        LedgerGridView.Rows[loop1].Visible = false;
                    }
                    else
                        LedgerGridView.Rows[loop1].Visible = true;
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
            if (Convert.ToInt32( LedgerGridView.Rows[e.RowIndex].Cells["BillNo"].Value) > -1)
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

                if (CustomerDataSet1.Tables[0].Rows.Count == 0)
                {
                    Variables.NotificationStatus = true;
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = "No Customer Found";
                    return;
                }
                decimal CustomerNewBalance = Convert.ToDecimal(CustomerDataSet1.Tables[0].Rows[0]["AMOUNT"]);
                CustomerNewBalance += UpdateAmount;

                DatabaseCalls.ModifyCustomer(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Customer_id"].Value), CustomerNewBalance);
                //CustomerDataSet1 = DatabaseCalls.GetCustomers();//.GetCustomer(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Customer_id"].Value));
                DatabaseCalls.ModifyVoucher(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["BillNo"].Value), NewAmount, CustomerNewBalance);
                LedgerGridView.Rows[e.RowIndex].Cells["Amount"].Value = NewAmount;
                //RemainingBalance_txt.Text =  CustomerBalance_txt.Text = CustomerNewBalance.ToString();
                VoucherRemarks_txt.Focus();
                //Bill Detail
                try
                {
                    LedgerDataSet = DatabaseCalls.GetLedger("All");
                    LedgerDataSet.Tables[0].Columns["ID"].ColumnName = "BillNo";

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
                    //for (int loop = 0; loop < LedgerDataSet.Tables[0].Rows.Count - 1; loop++)
                    //{
                    //    LedgerDataSet.Tables[0].Rows[loop]["Customer"] = DatabaseCalls.GetCustomerName(Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Customer_ID"].ToString()));
                    //}
                    LedgerGridView.Columns.Clear();
                    LedgerGridView.DataSource = LedgerDataSet.Tables[0];

                    LedgerGridView.Columns["Customer_ID"].Visible = false;
                    LedgerGridView.Columns["Customer"].DisplayIndex = 2;//.Visible 
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(LedgerGridView.SelectedRows.ToString());

            //LedgerGridView;
        }

        private void LedgerGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int loop = 0; loop < LedgerGridView.Rows.Count - 1; loop++)
            {
                if (LedgerGridView.Rows[loop].Cells["REMARKS"].Value.ToString().Contains("Bill"))
                    LedgerGridView.Rows[loop].DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    LedgerGridView.Rows[loop].DefaultCellStyle.BackColor = Color.SkyBlue;
                //                    LedgerDataSet.Tables[0].Rows[loop]["Customer"] = DatabaseCalls.GetCustomerName(Convert.ToInt16(LedgerGridView.Rows[loop].Cells["Customer_ID"].Value));
                //LedgerGridView.Rows[loop].Cells["Customer"].Value = DatabaseCalls.GetCustomerName(Convert.ToInt16(LedgerGridView.Rows[loop].Cells["Customer_ID"].Value));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void CustomerName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CustomerName_txt_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CustomerName_txt_Enter(object sender, EventArgs e)
        {

            try
            {
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

        string SHIPMENT_ITEM_ID = "";
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
                        CustomerID_txt.Focus();
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
        {
            //Customer Detail
            try
            {
                for (int loop = 0; loop < CustomerNameDataGridView.Rows.Count; loop++)
                {
                    if (CustomerNameDataGridView.Rows[loop].Cells["NAME"].Value.ToString().Contains(CustomerName_txt.Text))//(GridViewColumn.ItemArray[0].ToString()))
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
                        CustomerID_txt.Focus();
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
                                CustomerID_txt.Focus();
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
    }
}
