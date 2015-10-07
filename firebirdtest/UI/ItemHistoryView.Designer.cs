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
            this.ShipmentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SaleHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName_txt = new System.Windows.Forms.ComboBox();
            this.PurchaseCTN_txt = new System.Windows.Forms.TextBox();
            this.SaleCtn_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 668);
            this.panel1.TabIndex = 8;
            // 
            // ShipmentHistoryDataGridView
            // 
            this.ShipmentHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipmentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentHistoryDataGridView.Location = new System.Drawing.Point(152, 3);
            this.ShipmentHistoryDataGridView.Name = "ShipmentHistoryDataGridView";
            this.ShipmentHistoryDataGridView.Size = new System.Drawing.Size(1187, 143);
            this.ShipmentHistoryDataGridView.TabIndex = 53;
            // 
            // SaleHistoryDataGridView
            // 
            this.SaleHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleHistoryDataGridView.Location = new System.Drawing.Point(152, 152);
            this.SaleHistoryDataGridView.Name = "SaleHistoryDataGridView";
            this.SaleHistoryDataGridView.Size = new System.Drawing.Size(1187, 513);
            this.SaleHistoryDataGridView.TabIndex = 52;
            // 
            // ItemName_txt
            // 
            this.ItemName_txt.FormattingEnabled = true;
            this.ItemName_txt.Location = new System.Drawing.Point(25, 12);
            this.ItemName_txt.Name = "ItemName_txt";
            this.ItemName_txt.Size = new System.Drawing.Size(121, 21);
            this.ItemName_txt.TabIndex = 51;
            this.ItemName_txt.TextChanged += new System.EventHandler(this.ItemName_txt_TextChanged);
            this.ItemName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemName_txt_KeyDown);
            // 
            // PurchaseCTN_txt
            // 
            this.PurchaseCTN_txt.Location = new System.Drawing.Point(46, 126);
            this.PurchaseCTN_txt.Name = "PurchaseCTN_txt";
            this.PurchaseCTN_txt.Size = new System.Drawing.Size(100, 20);
            this.PurchaseCTN_txt.TabIndex = 10;
            // 
            // SaleCtn_txt
            // 
            this.SaleCtn_txt.Location = new System.Drawing.Point(46, 152);
            this.SaleCtn_txt.Name = "SaleCtn_txt";
            this.SaleCtn_txt.Size = new System.Drawing.Size(100, 20);
            this.SaleCtn_txt.TabIndex = 54;
            // 
            // ItemHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1344, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
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