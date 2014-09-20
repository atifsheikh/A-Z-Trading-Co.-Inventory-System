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
    public partial class VoucherPaymentModification : Form
    {
        public string NewAmount = "";
        public VoucherPaymentModification(object dataGridViewCell)
        {
            InitializeComponent();
            textBox1.Text = dataGridViewCell.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NewAmount = textBox1.Text;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
