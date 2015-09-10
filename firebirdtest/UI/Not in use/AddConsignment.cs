using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace firebirdtest.UI
{
    public partial class AddConsignment : Form
    {
        public AddConsignment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result = "";
            try
            {
                Result = DatabaseCalls.AddConsignment(ConsignmentNumber_txt.Text, Convert.ToDateTime(ConsignmentDate_txt.Text));
                if (Result.StartsWith("Consignment Added with ID") != true)
                {
                    Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = Result;
                    return;
                }
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignments();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddConsignment_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignments();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;

                foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                {
                    ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                }
