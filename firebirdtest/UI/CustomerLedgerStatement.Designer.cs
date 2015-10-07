namespace InventoryManagement.UI
{
    partial class CustomerLedgerStatement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLedgerStatement));
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate_DTPicker = new System.Windows.Forms.DateTimePicker();
            this.EndDate_DTPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Voucher_DTPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerBalance_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.VoucherRemarks_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VoucherAmount_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerName_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.CustomerNameDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.CustomerID_txt = new System.Windows.Forms.TextBox();
            this.LedgerGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            this.label1.Visible = false;
            // 
            // StartDate_DTPicker
            // 
            this.StartDate_DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate_DTPicker.Location = new System.Drawing.Point(111, 7);
            this.StartDate_DTPicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartDate_DTPicker.Name = "StartDate_DTPicker";
            this.StartDate_DTPicker.Size = new System.Drawing.Size(107, 22);
            this.StartDate_DTPicker.TabIndex = 0;
            this.StartDate_DTPicker.Visible = false;
            // 
            // EndDate_DTPicker
            // 
            this.EndDate_DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate_DTPicker.Location = new System.Drawing.Point(304, 7);
            this.EndDate_DTPicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndDate_DTPicker.Name = "EndDate_DTPicker";
            this.EndDate_DTPicker.Size = new System.Drawing.Size(107, 22);
            this.EndDate_DTPicker.TabIndex = 1;
            this.EndDate_DTPicker.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(227, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.StartDate_DTPicker);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EndDate_DTPicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1792, 41);
            this.panel1.TabIndex = 0;
            // 
            // Voucher_DTPicker
            // 
            this.Voucher_DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Voucher_DTPicker.Location = new System.Drawing.Point(96, 23);
            this.Voucher_DTPicker.Margin = new System.Windows.Forms.Padding(4);
            this.Voucher_DTPicker.Name = "Voucher_DTPicker";
            this.Voucher_DTPicker.Size = new System.Drawing.Size(107, 22);
            this.Voucher_DTPicker.TabIndex = 0;
            this.Voucher_DTPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Voucher_DTPicker_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dated";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CustomerBalance_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.VoucherRemarks_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.VoucherAmount_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Voucher_DTPicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 535);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1760, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voucher Payment";
            // 
            // CustomerBalance_txt
            // 
            this.CustomerBalance_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerBalance_txt.Enabled = false;
            this.CustomerBalance_txt.Location = new System.Drawing.Point(1644, 22);
            this.CustomerBalance_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBalance_txt.Name = "CustomerBalance_txt";
            this.CustomerBalance_txt.Size = new System.Drawing.Size(107, 22);
            this.CustomerBalance_txt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1513, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer Balance";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1651, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VoucherRemarks_txt
            // 
            this.VoucherRemarks_txt.Location = new System.Drawing.Point(285, 22);
            this.VoucherRemarks_txt.Margin = new System.Windows.Forms.Padding(4);
            this.VoucherRemarks_txt.Name = "VoucherRemarks_txt";
            this.VoucherRemarks_txt.Size = new System.Drawing.Size(365, 22);
            this.VoucherRemarks_txt.TabIndex = 1;
            this.VoucherRemarks_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VoucherRemarks_txt_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(212, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Remarks";
            // 
            // VoucherAmount_txt
            // 
            this.VoucherAmount_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoucherAmount_txt.Location = new System.Drawing.Point(1644, 54);
            this.VoucherAmount_txt.Margin = new System.Windows.Forms.Padding(4);
            this.VoucherAmount_txt.Name = "VoucherAmount_txt";
            this.VoucherAmount_txt.Size = new System.Drawing.Size(107, 22);
            this.VoucherAmount_txt.TabIndex = 3;
            this.VoucherAmount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VoucherAmount_txt_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1580, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerName_txt.Location = new System.Drawing.Point(13, 7);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Size = new System.Drawing.Size(323, 22);
            this.CustomerName_txt.TabIndex = 0;
            this.CustomerName_txt.TextChanged += new System.EventHandler(this.CustomerName_txt_TextChanged_1);
            this.CustomerName_txt.Enter += new System.EventHandler(this.CustomerName_txt_Enter);
            this.CustomerName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_txt_KeyDown_1);
            this.CustomerName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerName_txt_KeyPress_1);
            this.CustomerName_txt.Leave += new System.EventHandler(this.CustomerName_txt_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.CustomerNameDataGridView);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.CustomerID_txt);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.LedgerGridView);
            this.panel2.Controls.Add(this.CustomerName_txt);
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1792, 779);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(563, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 25);
            this.button5.TabIndex = 41;
            this.button5.Text = "&Show All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CustomerNameDataGridView
            // 
            this.CustomerNameDataGridView.AllowUserToAddRows = false;
            this.CustomerNameDataGridView.AllowUserToDeleteRows = false;
            this.CustomerNameDataGridView.AllowUserToResizeColumns = false;
            this.CustomerNameDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.CustomerNameDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerNameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerNameDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.CustomerNameDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerNameDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.CustomerNameDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerNameDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerNameDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerNameDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerNameDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.CustomerNameDataGridView.Location = new System.Drawing.Point(16, 32);
            this.CustomerNameDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameDataGridView.Name = "CustomerNameDataGridView";
            this.CustomerNameDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerNameDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerNameDataGridView.Size = new System.Drawing.Size(320, 495);
            this.CustomerNameDataGridView.TabIndex = 40;
            this.CustomerNameDataGridView.Visible = false;
            this.CustomerNameDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerNameDataGridView_RowEnter);
            this.CustomerNameDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNameDataGridView_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "Modify Payment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CustomerID_txt
            // 
            this.CustomerID_txt.Location = new System.Drawing.Point(348, 7);
            this.CustomerID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerID_txt.Name = "CustomerID_txt";
            this.CustomerID_txt.Size = new System.Drawing.Size(56, 22);
            this.CustomerID_txt.TabIndex = 1;
            this.CustomerID_txt.TabStop = false;
            this.CustomerID_txt.Text = "None";
            this.CustomerID_txt.TextChanged += new System.EventHandler(this.CustomerID_txt_TextChanged);
            // 
            // LedgerGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LedgerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LedgerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LedgerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LedgerGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.LedgerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LedgerGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LedgerGridView.Location = new System.Drawing.Point(348, 41);
            this.LedgerGridView.Margin = new System.Windows.Forms.Padding(4);
            this.LedgerGridView.Name = "LedgerGridView";
            this.LedgerGridView.Size = new System.Drawing.Size(1428, 487);
            this.LedgerGridView.TabIndex = 9;
            this.LedgerGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LedgerGridView_CellDoubleClick);
            this.LedgerGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LedgerGridView_DataBindingComplete);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(4, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 33);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerLedgerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerLedgerStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Ledger Statement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LedgerStatement_FormClosed);
            this.Shown += new System.EventHandler(this.LedgerStatement_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LedgerStatement_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartDate_DTPicker;
        private System.Windows.Forms.DateTimePicker EndDate_DTPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Voucher_DTPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox VoucherRemarks_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VoucherAmount_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerName_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView LedgerGridView;
        private System.Windows.Forms.TextBox CustomerBalance_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerID_txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView CustomerNameDataGridView;
        private System.Windows.Forms.Button button5;

    }
}