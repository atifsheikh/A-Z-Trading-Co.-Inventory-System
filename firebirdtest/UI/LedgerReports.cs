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
    public partial class LedgerReports : Form
    {
        public LedgerReports()
        {
            InitializeComponent();
        }

        private void LedgerReports_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
                        //Customer Detail
            try
            {
                DataSet CustomerDataSet = DatabaseCalls.GetCustomers();

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

            // TODO: This line of code loads data into the 'ledgerReport_DataSet.BILL' table. You can move, or remove it, as needed.
            if (CustomerName_txt.Text != "" && CustomerName_txt.Items.Contains(CustomerName_txt.Text))
                this.bILLTableAdapter.Fill(this.ledgerReport_DataSet.BILL,CustomerName_txt.Text);
            else
                this.bILLTableAdapter.FillBy(this.ledgerReport_DataSet.BILL);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ledgerReport_DataSet.BILL' table. You can move, or remove it, as needed.
            //this.bILLTableAdapter.Adapter.SelectCommand = @"SELECT ID, CUSTOMER_ID, DATED, AMOUNT, REMARKS, CUSTOMER_BALANCE FROM BILL WHERE (DATED BETWEEN "+Ftom_dateTimePicker.Value+" AND " + To_dateTimePicker.Value+")";

        }

        private void LedgerReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void CustomerName_txt_TextChanged(object sender, EventArgs e)
        {
            if (CustomerName_txt.Text != "" && CustomerName_txt.Items.Contains(CustomerName_txt.Text))
                this.bILLTableAdapter.Fill(this.ledgerReport_DataSet.BILL, CustomerName_txt.Text);
            else
                this.bILLTableAdapter.FillBy(this.ledgerReport_DataSet.BILL);

            this.reportViewer1.RefreshReport();

        }
    }
}
