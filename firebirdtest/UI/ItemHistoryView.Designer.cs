namespace InventoryManagement.UI
{
    partial class ItemHistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemHistoryView));
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaleCtn_txt = new System.Windows.Forms.TextBox();
            this.PurchaseCTN_txt = new System.Windows.Forms.TextBox();
            this.ShipmentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SaleHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName_txt = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(5, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 33);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.SaleCtn_txt);
            this.panel1.Controls.Add(this.PurchaseCTN_txt);
            this.panel1.Controls.Add(this.ShipmentHistoryDataGridView);
            this.panel1.Controls.Add(this.SaleHistoryDataGridView);
            this.panel1.Controls.Add(this.ItemName_txt);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1789, 822);
            this.panel1.TabIndex = 8;
            // 
            // SaleCtn_txt
            // 
            this.SaleCtn_txt.Location = new System.Drawing.Point(61, 187);
            this.SaleCtn_txt.Margin = new System.Windows.Forms.Padding(4);
            this.SaleCtn_txt.Name = "SaleCtn_txt";
            this.SaleCtn_txt.Size = new System.Drawing.Size(132, 22);
            this.SaleCtn_txt.TabIndex = 54;
            // 
            // PurchaseCTN_txt
            // 
            this.PurchaseCTN_txt.Location = new System.Drawing.Point(61, 155);
            this.PurchaseCTN_txt.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseCTN_txt.Name = "PurchaseCTN_txt";
            this.PurchaseCTN_txt.Size = new System.Drawing.Size(132, 22);
            this.PurchaseCTN_txt.TabIndex = 10;
            // 
            // ShipmentHistoryDataGridView
            // 
            this.ShipmentHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipmentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentHistoryDataGridView.Location = new System.Drawing.Point(203, 4);
            this.ShipmentHistoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ShipmentHistoryDataGridView.Name = "ShipmentHistoryDataGridView";
            this.ShipmentHistoryDataGridView.Size = new System.Drawing.Size(1583, 176);
            this.ShipmentHistoryDataGridView.TabIndex = 53;
            // 
            // SaleHistoryDataGridView
            // 
            this.SaleHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleHistoryDataGridView.Location = new System.Drawing.Point(203, 187);
            this.SaleHistoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SaleHistoryDataGridView.Name = "SaleHistoryDataGridView";
            this.SaleHistoryDataGridView.Size = new System.Drawing.Size(1583, 631);
            this.SaleHistoryDataGridView.TabIndex = 52;
            // 
            // ItemName_txt
            // 
            this.ItemName_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemName_txt.FormattingEnabled = true;
            this.ItemName_txt.Location = new System.Drawing.Point(33, 15);
            this.ItemName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ItemName_txt.Name = "ItemName_txt";
            this.ItemName_txt.Size = new System.Drawing.Size(160, 24);
            this.ItemName_txt.TabIndex = 51;
            this.ItemName_txt.TextChanged += new System.EventHandler(this.ItemName_txt_TextChanged);
            this.ItemName_txt.Enter += new System.EventHandler(this.ItemName_txt_Enter);
            this.ItemName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemName_txt_KeyDown);
            this.ItemName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemName_txt_KeyUp);
            // 
            // ItemHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemHistoryView";
            this.Text = "ItemHistoryView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemHistoryView_FormClosed);
            this.Load += new System.EventHandler(this.ItemHistoryView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ItemName_txt;
        private System.Windows.Forms.DataGridView ShipmentHistoryDataGridView;
        private System.Windows.Forms.DataGridView SaleHistoryDataGridView;
        private System.Windows.Forms.TextBox SaleCtn_txt;
        private System.Windows.Forms.TextBox PurchaseCTN_txt;

    }
}