﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using firebirdtest.Classes;

namespace firebirdtest.UI
{
    public partial class DebitorSummary : Form
    {
        public DebitorSummary()
        {
            InitializeComponent();
        }

        static DataSet CustomerDataSet = new DataSet();
        private void DebitorSummary_Load(object sender, EventArgs e)
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
                //CustomerDataSet = DatabaseCalls.GetCustomers();
                //foreach (DataRow GridViewColumn in CustomerDataSet.Tables[0].Rows)
                //{
                //    CustomerNameSearch_txt.Items.Add(GridViewColumn.ItemArray[1]);
                //}

                //BillDataGridView.DataSource = CustomerDataSet.Tables[0];
                //BillDataGridView.Columns[0].HeaderText = "Bill #";

                this.CustomerTableAdapter.Fill(this.customerAccountDataSet1.CUSTOMERS);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

            //Customers
            try
            {
                
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
            Variables.FormRefresh = this.Name;
            this.Close();

        }

        private void DebitorSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
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
    }
}
