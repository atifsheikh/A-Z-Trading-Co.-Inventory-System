﻿namespace firebirdtest.UI
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerAddress_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerPhone_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerEmail_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerOpeningBalance_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(85, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.Location = new System.Drawing.Point(148, 46);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Size = new System.Drawing.Size(153, 22);
            this.CustomerName_txt.TabIndex = 1;
            this.CustomerName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address :";
            // 
            // CustomerAddress_txt
            // 
            this.CustomerAddress_txt.Location = new System.Drawing.Point(148, 78);
            this.CustomerAddress_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerAddress_txt.Name = "CustomerAddress_txt";
            this.CustomerAddress_txt.Size = new System.Drawing.Size(153, 22);
            this.CustomerAddress_txt.TabIndex = 2;
            this.CustomerAddress_txt.Text = "None";
            this.CustomerAddress_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(81, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone :";
            // 
            // CustomerPhone_txt
            // 
            this.CustomerPhone_txt.Location = new System.Drawing.Point(148, 110);
            this.CustomerPhone_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerPhone_txt.Name = "CustomerPhone_txt";
            this.CustomerPhone_txt.Size = new System.Drawing.Size(153, 22);
            this.CustomerPhone_txt.TabIndex = 3;
            this.CustomerPhone_txt.Text = "+92-";
            this.CustomerPhone_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(89, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // CustomerEmail_txt
            // 
            this.CustomerEmail_txt.Location = new System.Drawing.Point(148, 142);
            this.CustomerEmail_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerEmail_txt.Name = "CustomerEmail_txt";
            this.CustomerEmail_txt.Size = new System.Drawing.Size(153, 22);
            this.CustomerEmail_txt.TabIndex = 4;
            this.CustomerEmail_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Opening Balance :";
            // 
            // CustomerOpeningBalance_txt
            // 
            this.CustomerOpeningBalance_txt.Location = new System.Drawing.Point(148, 174);
            this.CustomerOpeningBalance_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerOpeningBalance_txt.Name = "CustomerOpeningBalance_txt";
            this.CustomerOpeningBalance_txt.Size = new System.Drawing.Size(153, 22);
            this.CustomerOpeningBalance_txt.TabIndex = 5;
            this.CustomerOpeningBalance_txt.Text = "0";
            this.CustomerOpeningBalance_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown);
            this.CustomerOpeningBalance_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerOpeningBalance_txt_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.CustomerName_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CustomerAddress_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CustomerOpeningBalance_txt);
            this.panel2.Controls.Add(this.CustomerPhone_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CustomerEmail_txt);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 822);
            this.panel2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(196, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 28);
            this.button6.TabIndex = 50;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(24, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add Customer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.CustomerNameSearch_txt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.CustomersDataGridView);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(317, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 822);
            this.panel1.TabIndex = 1;
            // 
            // CustomerNameSearch_txt
            // 
            this.CustomerNameSearch_txt.DropDownHeight = 1;
            this.CustomerNameSearch_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CustomerNameSearch_txt.DropDownWidth = 1;
            this.CustomerNameSearch_txt.FormattingEnabled = true;
            this.CustomerNameSearch_txt.IntegralHeight = false;
            this.CustomerNameSearch_txt.Location = new System.Drawing.Point(138, 40);
            this.CustomerNameSearch_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerNameSearch_txt.Name = "CustomerNameSearch_txt";
            this.CustomerNameSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.CustomerNameSearch_txt.TabIndex = 0;
            this.CustomerNameSearch_txt.TextChanged += new System.EventHandler(this.CustomerNameSearch_txt_TextChanged);
            this.CustomerNameSearch_txt.Enter += new System.EventHandler(this.CustomerNameSearch_txt_Enter);
            this.CustomerNameSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameSearch_txt_KeyPress);
            this.CustomerNameSearch_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomerNameSearch_txt_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(15, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Search ";
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue;
            this.CustomersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.CustomersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomersDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.GridColor = System.Drawing.Color.LightBlue;
            this.CustomersDataGridView.Location = new System.Drawing.Point(9, 74);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.CustomersDataGridView.Size = new System.Drawing.Size(1455, 745);
            this.CustomersDataGridView.TabIndex = 1;
            this.CustomersDataGridView.TabStop = false;
            this.CustomersDataGridView.CurrentCellChanged += new System.EventHandler(this.ItemsDataGridView_CurrentCellChanged);
            this.CustomersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.CustomersDataGridView_DataError);
            this.CustomersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CustomersDataGridView_RowsAdded);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(16, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Customer Name";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 33);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomer_FormClosed);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.Shown += new System.EventHandler(this.AddCustomer_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomer_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerAddress_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerPhone_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerEmail_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerOpeningBalance_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CustomerNameSearch_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;

    }
}