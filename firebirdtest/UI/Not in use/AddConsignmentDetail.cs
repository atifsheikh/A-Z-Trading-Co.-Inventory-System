using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace firebirdtest.UI
{
    public partial class AddConsignmentDetail : Form
    {
        public AddConsignmentDetail()
        {
            InitializeComponent();
        }

        private void AddConsignmentDetail_Load(object sender, EventArgs e)
        {
            //TO GET ITEM LIST
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetItems();
                
                ItemSearchName_txt.Items.Clear();
                ItemName_txt.Items.Clear();

                foreach (DataRow asdf in Result1.Tables[0].Rows)
                {
                    ItemSearchName_txt.Items.Add(asdf.ItemArray[1]);
                    ItemName_txt.Items.Add(asdf["CODE"]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }


            //TO GET Consingment ID LIST
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignments();

                foreach (DataRow asdf in Result1.Tables[0].Rows)
                {
                    ShipID_txt.Items.Add(asdf.ItemArray[0]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

            //TO GET Consingment Detail LIST
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignmentDetails();
                ItemsDataGridView.DataSource = Result1.Tables[0];
                ItemsDataGridView.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

        }

        private void ItemsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    ItemName_txt.Text = ItemsDataGridView.CurrentRow.Cells["ITEM_CODE"].Value.ToString();
                    ShipID_txt.Text = ItemsDataGridView.CurrentRow.Cells["SHIP_ID"].Value.ToString();
                    ItemQuantity_txt.Text = ItemsDataGridView.CurrentRow.Cells["T_QUANTITY"].Value.ToString();
                    Warehouse_txt.Text = ItemsDataGridView.CurrentRow.Cells["WAREHOUSE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object.") == false)
                    Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message.ToString();
            }
        }

        private int currentRow = 0;

        private void AddConsignmentDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void AddConsignmentDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string Result = "";
        //    try
        //    {
        //        if (ItemsDataGridView.CurrentCell == null || (ItemsDataGridView.CurrentCell != null && currentRow != ItemsDataGridView.CurrentCell.RowIndex))
        //        {
        //            Result = DatabaseCalls.AddConsignmentDetail(ItemName_txt.Text,Convert.ToInt32(ShipID_txt.Text), Convert.ToInt32(ItemQuantity_txt.Text),Qtyperbox Warehouse_txt.Text);
        //            DataSet Result1 = new DataSet();
        //            Result1 = DatabaseCalls.GetConsignmentDetails();
        //            ItemsDataGridView.DataSource = Result1.Tables[0];
        //            ItemsDataGridView.Columns[0].Visible = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //                    Variables.NotificationStatus = true;
            //Variables.NotificationMessageTitle = this.Name;
            //Variables.NotificationMessageText = Result;
        //}
    }
}
