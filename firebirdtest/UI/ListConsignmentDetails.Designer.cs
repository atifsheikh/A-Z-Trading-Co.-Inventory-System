namespace firebirdtest.UI
{
    partial class ListConsignmentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListConsignmentDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemSearchName_txt = new System.Windows.Forms.ComboBox();
            this.ItemModel_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Total_SUBTOTAL_txt = new System.Windows.Forms.TextBox();
            this.Total_T_QUANTITY_txt = new System.Windows.Forms.TextBox();
            this.Total_CTN_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.ItemSearchName_txt);
            this.panel1.Controls.Add(this.ItemModel_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ItemsDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1792, 818);
            this.panel1.TabIndex = 3;
            // 
            // ItemSearchName_txt
            // 
            this.ItemSearchName_txt.FormattingEnabled = true;
            this.ItemSearchName_txt.Location = new System.Drawing.Point(167, 41);
            this.ItemSearchName_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemSearchName_txt.Name = "ItemSearchName_txt";
            this.ItemSearchName_txt.Size = new System.Drawing.Size(160, 24);
            this.ItemSearchName_txt.TabIndex = 0;
            this.ItemSearchName_txt.TextChanged += new System.EventHandler(this.ItemSearchName_txt_TextChanged);
            this.ItemSearchName_txt.Enter += new System.EventHandler(this.ItemSearchName_txt_Enter);
            this.ItemSearchName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemSearchName_txt_KeyPress);
            this.ItemSearchName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemSearchName_txt_KeyUp);
            // 
            // ItemModel_txt
            // 
            this.ItemModel_txt.Location = new System.Drawing.Point(167, 74);
            this.ItemModel_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemModel_txt.Name = "ItemModel_txt";
            this.ItemModel_txt.Size = new System.Drawing.Size(163, 22);
            this.ItemModel_txt.TabIndex = 1;
            this.ItemModel_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.ItemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(9, 106);
            this.ItemsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1772, 709);
            this.ItemsDataGridView.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consignment Number";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 33);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total_SUBTOTAL_txt
            // 
            this.Total_SUBTOTAL_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_SUBTOTAL_txt.Enabled = false;
            this.Total_SUBTOTAL_txt.Location = new System.Drawing.Point(1618, 860);
            this.Total_SUBTOTAL_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Total_SUBTOTAL_txt.Name = "Total_SUBTOTAL_txt";
            this.Total_SUBTOTAL_txt.Size = new System.Drawing.Size(163, 22);
            this.Total_SUBTOTAL_txt.TabIndex = 39;
            // 
            // Total_T_QUANTITY_txt
            // 
            this.Total_T_QUANTITY_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_T_QUANTITY_txt.Enabled = false;
            this.Total_T_QUANTITY_txt.Location = new System.Drawing.Point(1255, 860);
            this.Total_T_QUANTITY_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Total_T_QUANTITY_txt.Name = "Total_T_QUANTITY_txt";
            this.Total_T_QUANTITY_txt.Size = new System.Drawing.Size(163, 22);
            this.Total_T_QUANTITY_txt.TabIndex = 40;
            // 
            // Total_CTN_txt
            // 
            this.Total_CTN_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_CTN_txt.Enabled = false;
            this.Total_CTN_txt.Location = new System.Drawing.Point(849, 860);
            this.Total_CTN_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Total_CTN_txt.Name = "Total_CTN_txt";
            this.Total_CTN_txt.Size = new System.Drawing.Size(163, 22);
            this.Total_CTN_txt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 863);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "CTN";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1529, 862);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "SUBTOTAL";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1156, 862);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "T_QUANTITY";
            // 
            // ListConsignmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total_CTN_txt);
            this.Controls.Add(this.Total_T_QUANTITY_txt);
            this.Controls.Add(this.Total_SUBTOTAL_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListConsignmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListConsignmentDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListConsignmentDetails_FormClosed);
            this.Shown += new System.EventHandler(this.ListConsignmentDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListConsignmentDetails_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ItemSearchName_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemModel_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Total_SUBTOTAL_txt;
        private System.Windows.Forms.TextBox Total_T_QUANTITY_txt;
        private System.Windows.Forms.TextBox Total_CTN_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;

    }
}