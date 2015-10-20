using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using InventoryManagement.Classes;
using InventoryManagement.DataSets;
using Newtonsoft.Json;

namespace InventoryManagement.UI
{
    public partial class CreditorSummary : Form
    {
        public CreditorSummary()
        {
            InitializeComponent();
        }

        private void DisplayReport()
        {
            try
            {
                string jsonstring = DatabaseCalls.GET_String("http://" + global::InventoryManagement.Properties.Settings.Default.SC_Server + "/ThePrimeBaby/GetCreditorSummary");
                CreditSummary debitSummary = JsonConvert.DeserializeObject<CreditSummary>(jsonstring);
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.Clear();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CreditSummary", debitSummary.GetCreditorList()));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        static DataSet VendorDataSet = new DataSet();
        private void CreditorSummary_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            try
            {
                DisplayReport();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
            Variables.NotificationMessageTitle = this.Name;
            Variables.NotificationMessageText = ex.Message;
            }

            //Vendors
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

        private void CreditorSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables.FormClosed = true;
        }

        private void VendorNameSearch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.AllowDrop = false;
            }
        }

        private void VendorNameSearch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendorNameSearch_txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode!= Keys.Enter && e.KeyValue != 27)
                {
                    if (VendorNameSearch_txt.Text != null) RandomAlgos.comboKeyPressed(VendorNameSearch_txt);
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = this.Name;
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }

        }

        private void VendorNameSearch_txt_Enter(object sender, EventArgs e)
        {
            VendorNameSearch_txt.DroppedDown = true;
        }
    }
}
