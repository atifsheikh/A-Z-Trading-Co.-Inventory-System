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

        DataSet ItemsDataSet = new DataSet();
        public ItemHistoryView()
        {
            InitializeComponent();
            ItemsDataSet = DatabaseCalls.GetItems();
            PopulateItemNames();
        }

        private void PopulateItemNames()
        {

            //Result1.Tables[0].Columns["Item_Code"].ColumnName = "Item Code";
            if (ItemsDataSet.Tables.Count > 0)
            {
                for (int loop = 0; loop < ItemsDataSet.Tables[0].Rows.Count; loop++)//each (DataRow asdf in Result1.Tables[0].Rows[]["CODE"])
                {
                    ItemName_txt.Items.Add(ItemsDataSet.Tables[0].Rows[loop]["CODE"]);
                }
            }
        }

        private void ItemName_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool exist = false;
                foreach (string item in ItemName_txt.Items)
                {
                    if (StaticClass.Contain(ItemName_txt.Text, item, StringComparison.OrdinalIgnoreCase))
                    {
                        exist = true;
                        break;
                    }
                }
                if (exist == false)
                    return;

                var GetItemSaleHistoryDataSource = DatabaseCalls.GetItemSaleHistory(ItemName_txt.Text);
                if (GetItemSaleHistoryDataSource.Tables.Count > 0)
                {
                    SaleHistoryDataGridView.DataSource = GetItemSaleHistoryDataSource.Tables[0];
                    if (SaleHistoryDataGridView.Columns.Count > 0)
                    {
                        //costumer name / item code / item name / qty per ctn / t qty / price / amount
                        SaleHistoryDataGridView.Columns["ID"].Visible = false;
                        SaleHistoryDataGridView.Columns["QTY"].Visible = false;
                        SaleHistoryDataGridView.Columns["PCS_CTN"].Visible = false;
                        SaleHistoryDataGridView.Columns["BILL_ID"].DisplayIndex = 0;
                        SaleHistoryDataGridView.Columns["BILL_ID"].HeaderText = "BILL #";
                        SaleHistoryDataGridView.Columns["CUSTOMERS_NAME"].DisplayIndex = 1;
                        SaleHistoryDataGridView.Columns["CUSTOMERS_NAME"].HeaderText = "Customer Name";
                        SaleHistoryDataGridView.Columns["ITEM_CODE"].DisplayIndex = 2;
                        SaleHistoryDataGridView.Columns["ITEM_NAME"].DisplayIndex = 3;
                        SaleHistoryDataGridView.Columns["T_QUANTITY"].DisplayIndex = 6;
                        SaleHistoryDataGridView.Columns["UNITPRICE"].DisplayIndex = 7;
                        SaleHistoryDataGridView.Columns["SUBTOTAL"].DisplayIndex = 8;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationStatus = true;
            }
            try
            {
                var GetItemShipmentHistoryDataSource = DatabaseCalls.GetItemShipmentHistory(ItemName_txt.Text);
                if (GetItemShipmentHistoryDataSource.Tables.Count > 0)
                {
                    ShipmentHistoryDataGridView.DataSource = GetItemShipmentHistoryDataSource.Tables[0];
                    if (ShipmentHistoryDataGridView.Columns.Count > 0)
                    {
                        ShipmentHistoryDataGridView.Columns["SHIP_ID"].Visible = false;
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
                }
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
            }

        }

        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ItemName_txt.DroppedDown = false;
            }
        }

        private void ItemHistoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.FormRefresh = this.Name;
                this.Close();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ItemName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Enter && e.KeyValue != 27)
                {
                    if (!string.IsNullOrEmpty(ItemName_txt.Text))
                    {
                        //RandomAlgos.comboKeyPressedNew(ItemName_txt);
                        RandomAlgos.comboKeyPressed(ItemName_txt);
                    }
                    else
                    {
                        ItemName_txt.Items.Clear();
                        PopulateItemNames();
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        private void ItemName_txt_Enter(object sender, EventArgs e)
        {
            ItemName_txt.DroppedDown = true;
        }
    }
}
