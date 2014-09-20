using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using firebirdtest.Classes;

namespace firebirdtest.UI
{
    public partial class ListConsignments : Form
    {
        public ListConsignments()
        {
            InitializeComponent();
        }

        private void ListConsignments_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet Result1 = new DataSet();
                Result1 = DatabaseCalls.GetConsignments();
                ItemsDataGridView.DataSource = Result1.Tables[0];
             //   ItemsDataGridView.Columns[0].Visible = false;

                foreach (DataRow GridViewColumn in Result1.Tables[0].Rows)
                {
                    ConsignmentNumberSearch_txt.Items.Add(GridViewColumn.ItemArray[0]);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }
        }

        private void ListConsignments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void ListConsignments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Contains("Control"))
            {
                if (e.KeyData.ToString().Contains("W, Control"))
                    this.Close();
            }
        }

        private void ConsignmentNumberSearch_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Enter)
                {
                    if (ConsignmentNumberSearch_txt.Text != null)
                        RandomAlgos.comboKeyPressed(ConsignmentNumberSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }
    }
}
