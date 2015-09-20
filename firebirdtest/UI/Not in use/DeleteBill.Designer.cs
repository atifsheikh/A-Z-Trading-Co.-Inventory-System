namespace firebirdtest.UI
{
    partial class DeleteBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.CustomerNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillNumberSearch_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.CustomerNameSearch_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BillNumberSearch_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 525);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CustomerNameSearch_txt
            // 
            this.CustomerNameSearch_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerNameSearch_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerNameSearch_txt.FormattingEnabled = true;
            this.CustomerNameSearch_txt.Location = new System.Drawing.Point(109, 60);
            this.CustomerNameSearch_txt.Name = "CustomerNameSearch_txt";
            this.CustomerNameSearch_txt.Size = new System.Drawing.Size(121, 21);
            this.CustomerNameSearch_txt.TabIndex = 2;
            this.CustomerNameSearch_txt.TextChanged += new System.EventHandler(this.CustomerNameSearch_txt_TextChanged);
            this.CustomerNameSearch_txt.Enter += new System.EventHandler(this.CustomerNameSearch_txt_Enter);
            this.CustomerNameSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameSearch_txt_KeyPress);
            this.CustomerNameSearch_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomerNameSearch_txt_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Customer";
            // 
            // BillNumberSearch_txt
            // 
            this.BillNumberSearch_txt.FormattingEnabled = true;
            this.BillNumberSearch_txt.Location = new System.Drawing.Point(109, 33);
            this.BillNumberSearch_txt.Name = "BillNumberSearch_txt";
            this.BillNumberSearch_txt.Size = new System.Drawing.Size(121, 21);
            this.BillNumberSearch_txt.TabIndex = 0;
            this.BillNumberSearch_txt.TextChanged += new System.EventHandler(this.BillNumberSearch_txt_TextChanged);
            this.BillNumberSearch_txt.Enter += new System.EventHandler(this.BillNumberSearch_txt_Enter);
            this.BillNumberSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillNumberSearch_txt_KeyPress);
            this.BillNumberSearch_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BillNumberSearch_txt_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToAddRows = false;
            this.BillDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.BillDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillDataGridView.Location = new System.Drawing.Point(7, 116);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BillDataGridView.Size = new System.Drawing.Size(358, 406);
            this.BillDataGridView.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Bill";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 27);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(373, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteBill";
            this.Text = "DeleteBill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.DeleteBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CustomerNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BillNumberSearch_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}