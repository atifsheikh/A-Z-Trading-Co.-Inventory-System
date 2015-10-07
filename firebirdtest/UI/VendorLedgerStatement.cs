using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManagement.Classes;
using System.Threading;

namespace InventoryManagement.UI
{
    public partial class VendorLedgerStatement : Form
    {
        public VendorLedgerStatement()
        {
            InitializeComponent();
        }

        static DataSet Ctn_Voucher_DataSet = new DataSet();
        static DataSet LedgerDataSet = new DataSet();
        static DataSet VendorDataSet = new DataSet();

        public void RefreshVendorData()
        {
            //get vendors
            try
            {
                VendorDataSet = DatabaseCalls.GetVendors();
                VendorNameDataGridView.DataSource = VendorDataSet.Tables[0];
                if (VendorNameDataGridView.Columns.Count > 0)
                {
                    VendorNameDataGridView.Columns["ID"].Visible = false;
                    VendorNameDataGridView.Columns["OPENING_BALANCE"].Visible = false;
                    VendorNameDataGridView.Columns["ADDRESS"].Visible = false;
                    VendorNameDataGridView.Columns["EMAIL"].Visible = false;
                    VendorNameDataGridView.Columns["PHONE"].Visible = false;
                    VendorNameDataGridView.Columns["BALANCE_LIMIT"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        static DataSet ShipmentsDataSet = new DataSet();
        static DataSet VendorVoucherDataSet = new DataSet();
        static DataSet VendorLedgerDataSet = new DataSet();
        private void LedgerStatement_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }

            //get vendors
            RefreshVendorData();
            //Voucher Detail
            try
            {
                ShipmentsDataSet = DatabaseCalls.GetShipments();
                ShipmentsDataSet.Tables[0].TableName = "Ledger";
                VendorVoucherDataSet = DatabaseCalls.GetVendorVoucher();
                VendorVoucherDataSet.Tables[0].TableName = "Ledger"; 
                VendorVoucherDataSet.Merge(ShipmentsDataSet);
                
                try
                {
                    DataView dv = new DataView(VendorVoucherDataSet.Tables[0]);
                    dv.Sort = "DATED";
                    LedgerGridView.DataSource = dv;
                }
                catch (Exception ex)
                { }
                
                LedgerGridView.CurrentCell = null;
                if (LedgerGridView.Columns.Count > 0)
                {
                    LedgerGridView.Columns["ID"].HeaderText = "S.NO";
                    LedgerGridView.Columns["VENDORNAME"].HeaderText = "Vendor";
                    LedgerGridView.Columns["DATED"].HeaderText = "Date";
                    LedgerGridView.Columns["VENDOR_BALANCE"].HeaderText = "Balance";

                    LedgerGridView.Columns["VendorID"].Visible = false;

                    LedgerGridView.Update();
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
            try
            {
                if (VoucherModification == false)
                {
                    VoucherAmount_txt_TextChanged(sender, e);
                    if (VoucherAmount_txt.Text == "0" || VoucherAmount_txt.Text == "")
                    {
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "add amount.";
                        Variables.NotificationStatus = true;
                        return;
                    }
                    //Add Voucher Number
                    String Result1 = DatabaseCalls.AddVendorVoucherPayment(Convert.ToInt32(VendorID_txt.Text), Voucher_DTPicker.Value, Convert.ToDecimal(VoucherAmount_txt.Text), VoucherRemarks_txt.Text);
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
                    String Result1 = DatabaseCalls.UpdateVendorVoucherPayment(Convert.ToInt32(VendorID_txt.Text), Voucher_DTPicker.Value, Convert.ToDecimal(VoucherAmount_txt.Text), VoucherRemarks_txt.Text, ModifyVoucherNumber);
                    if (Result1 != "")
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = Result1;
                        return;
                    }
                }
                RemainingBalance_txt.Text = "0";
                VendorBalance_txt.Text = "0";
                VoucherAmount_txt.Text = "0";
                VoucherRemarks_txt.Text = "0";
                LedgerStatement_Load(sender, e);

                VendorName_txt.Focus();
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
                    RemainingBalance_txt.Text = (Convert.ToDecimal(VendorBalance_txt.Text) - Convert.ToDecimal(VoucherAmount_txt.Text)).ToString();
                else
                    RemainingBalance_txt.Text = VendorBalance_txt.Text;
            }
            catch (Exception ex)
            { }
        }

        private void VendorID_txt_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (VendorID_txt.Text == "")
                    return;
                Int64 calculator = 0;
                for (int loop1 = 0; loop1 < LedgerGridView.Rows.Count-1; loop1++)
                {
                    try
                    {
                        LedgerGridView.CurrentCell = null;
                        if (LedgerGridView.Rows[loop1].Cells["VendorID"].Value.ToString() != (VendorID_txt.Text))
                        {
                            LedgerGridView.Rows[loop1].Visible = false;
                        }
                        else
                        {
                            LedgerGridView.Rows[loop1].Visible = true;
                            
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

                
                DataSet VendorDataSet1 = DatabaseCalls.GetVendor(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["Vendor_id"].Value));
                if (VendorDataSet1.Tables.Count > 0)
                {
                    if (VendorDataSet1.Tables[0].Rows.Count == 0)
                    {
                        Variables.NotificationStatus = true;
                        Variables.NotificationMessageTitle = this.Name;
                        Variables.NotificationMessageText = "No Vendor Found";
                        return;
                    }
                    decimal VendorNewBalance = Convert.ToDecimal(VendorDataSet1.Tables[0].Rows[0]["AMOUNT"]);
                    VendorNewBalance += UpdateAmount;


                    DatabaseCalls.ModifyVoucher(Convert.ToInt32(LedgerGridView.Rows[e.RowIndex].Cells["VoucherNo"].Value), NewAmount, VendorNewBalance);
                    LedgerGridView.Rows[e.RowIndex].Cells["Amount"].Value = NewAmount;
                    RemainingBalance_txt.Text = VendorBalance_txt.Text = VendorNewBalance.ToString();
                    VoucherRemarks_txt.Focus();
                }
                //Voucher Detail
                try
                {
                    LedgerDataSet = DatabaseCalls.GetLedger("All");
                    if (LedgerDataSet.Tables.Count > 0)
                    {
                        LedgerDataSet.Tables[0].Columns["ID"].ColumnName = "VoucherNo";

                        LedgerDataSet.Tables[0].Columns.Add("Vendor");

                        for (int loop = 0; loop < LedgerDataSet.Tables[0].Rows.Count; loop++)
                        {
                            if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Vendor_ID"].ToString()) > -1)
                            {
                                for (int loop1 = 0; loop1 < VendorDataSet.Tables[0].Rows.Count; loop1++)
                                {
                                    if (Convert.ToInt32(LedgerDataSet.Tables[0].Rows[loop]["Vendor_ID"]) == Convert.ToInt32(VendorDataSet.Tables[0].Rows[loop1]["ID"]))
                                    {
                                        if (LedgerDataSet.Tables[0].Rows[loop]["Vendor"].ToString() != VendorDataSet.Tables[0].Rows[loop1]["Name"].ToString())
                                            LedgerDataSet.Tables[0].Rows[loop]["Vendor"] = VendorDataSet.Tables[0].Rows[loop1]["Name"];
                                    }
                                }
                            }
                            else if (Convert.ToInt16(LedgerDataSet.Tables[0].Rows[loop]["Vendor_ID"].ToString()) == -1)
                                LedgerDataSet.Tables[0].Rows[loop]["Vendor"] = "Admin";
                            else
                                LedgerDataSet.Tables[0].Rows[loop]["Vendor"] = "Error";
                        }
                    }
                    LedgerGridView.Columns.Clear();
                    LedgerGridView.DataSource = LedgerDataSet.Tables[0];

                    LedgerGridView.Columns["Vendor_ID"].Visible = false;
                    LedgerGridView.Columns["Vendor"].DisplayIndex = 2;
                    LedgerGridView.Columns["TotalCtn"].DisplayIndex = 4;
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
                    VendorName_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["VENDORNAME"].Value.ToString();
                    Voucher_DTPicker.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["DATED"].Value.ToString();
                    VoucherRemarks_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["REMARKS"].Value.ToString();
                    VoucherAmount_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["AMOUNT"].Value.ToString();
                    VendorID_txt.Text = LedgerGridView.Rows[LedgerGridView.CurrentRow.Index].Cells["VendorID"].Value.ToString();
                    VendorBalance_txt.Text = LedgerGridView.Rows[SelectedRowIndex].Cells["VENDOR_BALANCE"].Value.ToString().Trim();
                    RemainingBalance_txt.Text = (Convert.ToDecimal(VendorBalance_txt.Text) - Convert.ToDecimal(VoucherAmount_txt.Text)).ToString();
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

        private void VendorName_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < VendorNameDataGridView.Rows.Count; loop++)
                {
                        VendorNameDataGridView.Rows[loop].Visible = true;
                }
                
                VendorID_txt.Text = "";
                VendorNameDataGridView.Visible = true;
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

        private void VendorName_txt_KeyDown(object sender, KeyEventArgs e)
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
        private void VendorNameDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    VendorNameDataGridView.Visible = false;
                    VendorName_txt.Text = VendorNameDataGridView.Rows[SelectedRowIndex].Cells["Name"].Value.ToString().Trim();
                    VendorID_txt.Text = VendorNameDataGridView.Rows[SelectedRowIndex].Cells["ID"].Value.ToString().Trim();
                    VendorBalance_txt.Text = VendorNameDataGridView.Rows[SelectedRowIndex].Cells["AMOUNT"].Value.ToString().Trim();


                    Voucher_DTPicker.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    VendorName_txt.Focus();
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
        private void VendorNameDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (VendorNameDataGridView.Visible == true)
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

        private void VendorName_txt_TextChanged_1(object sender, EventArgs e)
        {                        //Vendor Detail
            try
            {
                for (int loop = 0; loop < VendorNameDataGridView.Rows.Count; loop++)
                {
                    if (StaticClass.Contain(VendorNameDataGridView.Rows[loop].Cells["NAME"].Value.ToString(), VendorName_txt.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        VendorNameDataGridView.Rows[loop].Visible = true;
                    }
                    else
                    {
                        VendorNameDataGridView.CurrentCell = null;
                        VendorNameDataGridView.Rows[loop].Visible = false;
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

        private void VendorName_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (VendorNameDataGridView.Focused == false)
                    VendorNameDataGridView.Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
            
        }

        private void VendorName_txt_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void VendorName_txt_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    VendorNameDataGridView.Visible = !VendorNameDataGridView.Visible;
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    VendorNameDataGridView.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (VendorName_txt.Text == "")
                    {
                        return;
                    }
                    if (VendorNameDataGridView.SelectedRows.Count <= 0)
                    {
                        for (int loop = 0; loop < VendorNameDataGridView.Rows.Count; loop++)
                        {
                            if (VendorNameDataGridView.Rows[loop].Visible == true)
                            {
                                VendorName_txt.Text = VendorNameDataGridView.Rows[loop].Cells["Name"].Value.ToString().Trim();
                                VendorID_txt.Text = VendorNameDataGridView.Rows[loop].Cells["ID"].Value.ToString().Trim();
                                VendorBalance_txt.Text = VendorNameDataGridView.Rows[loop].Cells["AMOUNT"].Value.ToString().Trim();
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
