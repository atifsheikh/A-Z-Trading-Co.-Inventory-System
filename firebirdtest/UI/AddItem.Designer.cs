namespace firebirdtest.UI
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemPrice_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemQuantity_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ItemCodeSearch_txt = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.RetailPrice_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ItemCostPrice_txt = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ItemCategory_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ItemCode_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(39, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sale Price :";
            // 
            // ItemPrice_txt
            // 
            this.ItemPrice_txt.Location = new System.Drawing.Point(127, 170);
            this.ItemPrice_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPrice_txt.Name = "ItemPrice_txt";
            this.ItemPrice_txt.Size = new System.Drawing.Size(157, 22);
            this.ItemPrice_txt.TabIndex = 4;
            this.ItemPrice_txt.Text = "0";
            this.ItemPrice_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TQUANTITY_txt_KeyDown);
            this.ItemPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemPrice_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantity";
            // 
            // ItemQuantity_txt
            // 
            this.ItemQuantity_txt.Location = new System.Drawing.Point(127, 108);
            this.ItemQuantity_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemQuantity_txt.Name = "ItemQuantity_txt";
            this.ItemQuantity_txt.Size = new System.Drawing.Size(157, 22);
            this.ItemQuantity_txt.TabIndex = 2;
            this.ItemQuantity_txt.Text = "0";
            this.ItemQuantity_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TQUANTITY_txt_KeyDown);
            this.ItemQuantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemQuantity_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Add Item";
            // 
            // ItemName_txt
            // 
            this.ItemName_txt.Location = new System.Drawing.Point(127, 76);
            this.ItemName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemName_txt.Name = "ItemName_txt";
            this.ItemName_txt.Size = new System.Drawing.Size(157, 22);
            this.ItemName_txt.TabIndex = 1;
            this.ItemName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TQUANTITY_txt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item Code ";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.ItemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.ItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDataGridView.Location = new System.Drawing.Point(9, 106);
            this.ItemsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1427, 703);
            this.ItemsDataGridView.TabIndex = 35;
            this.ItemsDataGridView.CurrentCellChanged += new System.EventHandler(this.ItemsDataGridView_CurrentCellChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.ItemCodeSearch_txt);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ItemsDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(345, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 812);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(315, 41);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 28);
            this.button7.TabIndex = 2;
            this.button7.Text = "History";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ItemCodeSearch_txt
            // 
            this.ItemCodeSearch_txt.FormattingEnabled = true;
            this.ItemCodeSearch_txt.Location = new System.Drawing.Point(145, 41);
            this.ItemCodeSearch_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCodeSearch_txt.Name = "ItemCodeSearch_txt";
            this.ItemCodeSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.ItemCodeSearch_txt.TabIndex = 0;
            this.ItemCodeSearch_txt.TextChanged += new System.EventHandler(this.ItemName_txt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.RetailPrice_txt);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ItemCostPrice_txt);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.ItemCategory_txt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ItemCode_txt);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ItemName_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ItemQuantity_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ItemPrice_txt);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 812);
            this.panel2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(36, 204);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "Retail Price :";
            // 
            // RetailPrice_txt
            // 
            this.RetailPrice_txt.Location = new System.Drawing.Point(127, 200);
            this.RetailPrice_txt.Margin = new System.Windows.Forms.Padding(4);
            this.RetailPrice_txt.Name = "RetailPrice_txt";
            this.RetailPrice_txt.Size = new System.Drawing.Size(157, 22);
            this.RetailPrice_txt.TabIndex = 5;
            this.RetailPrice_txt.Text = "0";
            this.RetailPrice_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailPrice_txt_KeyDown);
            this.RetailPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RetailPrice_txt_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(41, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Cost Price :";
            // 
            // ItemCostPrice_txt
            // 
            this.ItemCostPrice_txt.Location = new System.Drawing.Point(127, 138);
            this.ItemCostPrice_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCostPrice_txt.Name = "ItemCostPrice_txt";
            this.ItemCostPrice_txt.Size = new System.Drawing.Size(157, 22);
            this.ItemCostPrice_txt.TabIndex = 3;
            this.ItemCostPrice_txt.Text = "0";
            this.ItemCostPrice_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemCostPrice_txt_KeyDown);
            this.ItemCostPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCostPrice_txt_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 28);
            this.button6.TabIndex = 49;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 229);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 28);
            this.button5.TabIndex = 7;
            this.button5.TabStop = false;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ItemCategory_txt
            // 
            this.ItemCategory_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemCategory_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemCategory_txt.FormattingEnabled = true;
            this.ItemCategory_txt.Location = new System.Drawing.Point(127, 230);
            this.ItemCategory_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCategory_txt.Name = "ItemCategory_txt";
            this.ItemCategory_txt.Size = new System.Drawing.Size(160, 24);
            this.ItemCategory_txt.TabIndex = 6;
            this.ItemCategory_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TQUANTITY_txt_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(41, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(41, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Item Code";
            // 
            // ItemCode_txt
            // 
            this.ItemCode_txt.Location = new System.Drawing.Point(127, 44);
            this.ItemCode_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCode_txt.Name = "ItemCode_txt";
            this.ItemCode_txt.Size = new System.Drawing.Size(157, 22);
            this.ItemCode_txt.TabIndex = 0;
            this.ItemCode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TQUANTITY_txt_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(41, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Description";
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(4, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 33);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddItem_FormClosed);
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.Shown += new System.EventHandler(this.AddItem_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemPrice_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemQuantity_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ItemCodeSearch_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ItemCode_txt;
        private System.Windows.Forms.ComboBox ItemCategory_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ItemCostPrice_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RetailPrice_txt;

    }
}