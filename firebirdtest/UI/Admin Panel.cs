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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            global::firebirdtest.Properties.Settings.Default.SC_Server = DBAddress_txt.Text;
            //global::firebirdtest.Properties.Settings.Default.AZ_FireBirdDB = DSN_txt.Text;

            global::firebirdtest.Properties.Settings.Default.Save();
            this.Close();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            DBAddress_txt.Text = global::firebirdtest.Properties.Settings.Default.SC_Server;
        }
    }
}
