using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManagement.Classes;

namespace InventoryManagement.UI
{
    public partial class ItemHistoryView : Form
    {
        private string p;

        public ItemHistoryView()
        {
            InitializeComponent();
            DataSet Result1 = new DataSet();
            Result1 = DatabaseCalls.GetItems();

            //Result1.Tables[0].Columns["Item_Code"].ColumnName = "Item Code";
            if (Result1.Tables.Count > 0)
            {
                for (int loop = 0; loop < Result1.Tables[0].Rows.Count; loop++)//each (DataRow asdf in Result1.Tables[0].Rows[]["CODE"])
                {
                    ItemName_txt.Items.Add(Result1.Tables[0].Rows[loop]["CODE"]);
                }
            }
        }

        private void ItemName_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    {
                        //if (ItemName_txt.Text != null)
                        //    RandomAlgos.comboKeyPressed(ItemName_txt);
                    }
                }
                catch (Exception ex)
                {
                    Variables.NotificationMessageTitle = this.Name;
                    Variables.NotificationMessageText = ex.Message;
                    Variables.NotificationStatus = true;
                }
            }
            catch (Exception ex)
            { }
            try
            {
                SaleHistoryDataGridView.DataSource = DatabaseCalls.GetItemSaleHistory(ItemName_txt.Text).Tables[0];
                //costumer name / item code / item name / qty per ctn / t qty / price / amount
                SaleHistoryDataGridView.Columns["ID"].Visible = false;
                SaleHistoryDataGridView.Columns["BILL_ID"].DisplayIndex = 0;
                SaleHistoryDataGridView.Columns["BILL_ID"].HeaderText = "BILL #";
                SaleHistoryDataGridView.Columns["NAME"].DisplayIndex = 1;
                SaleHistoryDataGridView.Columns["NAME"].HeaderText = "Customer Name";
                SaleHistoryDataGridView.Columns["ITEM_CODE"].DisplayIndex = 2;
                SaleHistoryDataGridView.Columns["ITEM_NAME"].DisplayIndex = 3;
                SaleHistoryDataGridView.Columns["QTY"].DisplayIndex = 4;
                SaleHistoryDataGridView.Columns["PCS_CTN"].DisplayIndex = 5;
                SaleHistoryDataGridView.Columns["T_QUANTITY"].DisplayIndex = 6;
                SaleHistoryDataGridView.Columns["UNITPRICE"].DisplayIndex = 7;
                SaleHistoryDataGridView.Columns["SUBTOTAL"].DisplayIndex = 8;


            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
            try
            {
                ShipmentHistoryDataGridView.DataSource = DatabaseCalls.GetItemShipmentHistory(ItemName_txt.Text).Tables[0];
                ShipmentHistoryDataGridView.Columns["ID"].Visible = false;
                //ship ID / item code / discreption / ctn / qty per box / t quantity / price / t amount
                ShipmentHistoryDataGridView.Columns["SHIP_ID"].DisplayIndex = 0;
                ShipmentHistoryDataGridView.Columns["ITEM_CODE"].DisplayIndex = 1;
                ShipmentHistoryDataGridView.Columns["MODEL"].DisplayIndex = 2;

                ShipmentHistoryDataGridView.Columns["CTN"].DisplayIndex = 3;

                ShipmentHistoryDataGridView.Columns["QTY_PER_BOX"].DisplayIndex = 4;
                ShipmentHistoryDataGridView.Columns["T_QUANTITY"].DisplayIndex = 5;
                ShipmentHistoryDataGridView.Columns["PRICE"].DisplayIndex = 6;
                ShipmentHistoryDataGridView.Columns["SUBTOTAL"].DisplayIndex = 7;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;

            }

            try
            {
                SaleCtn_txt.Text = "0";
                for (int loop = 0; loop < SaleHistoryDataGridView.Rows.Count; loop++)
                {
                    SaleCtn_txt.Text = (Convert.ToInt32(SaleCtn_txt.Text) + Convert.ToInt32(SaleHistoryDataGridView.Rows[loop].Cells["QTY"].Value)).ToString();
                }

                PurchaseCTN_txt.Text = "0";
                for (int loop = 0; loop < ShipmentHistoryDataGridView.Rows.Count; loop++)
                {
                    PurchaseCTN_txt.Text = (Convert.ToInt32(PurchaseCTN_txt.Text) + Convert.ToInt32(ShipmentHistoryDataGridView.Rows[loop].Cells["CTN"].Value)).ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
        }

        private void ItemHistoryView_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }

        }

        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.AllowDrop = false;
            }

            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Enter && e.KeyValue != 27)
                {
                    if (ItemName_txt.Text != null)
                        RandomAlgos.comboKeyPressed(ItemName_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void ItemHistoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;

        }
    }
}
