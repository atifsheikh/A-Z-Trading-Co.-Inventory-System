namespace InventoryManagement.UI
{
    partial class ListInventory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListInventory));
            this.iTEMINVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemInventoryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.itemInventory_DataSet1 = new InventoryManagement.DataSets.ItemInventory_DataSet1();
            this.PrintBatch_CB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            //this.iTEMINVENTORYTableAdapter = new InventoryManagement.DataSets.ItemInventory_DataSet1TableAdapters.ITEMINVENTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMINVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInventoryDataSet1BindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.itemInventory_DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iTEMINVENTORYBindingSource
            // 
            this.iTEMINVENTORYBindingSource.DataMember = "ITEMINVENTORY";
            this.iTEMINVENTORYBindingSource.DataSource = this.itemInventoryDataSet1BindingSource;
            this.iTEMINVENTORYBindingSource.CurrentChanged += new System.EventHandler(this.iTEMINVENTORYBindingSource_CurrentChanged);
            // 
            // itemInventoryDataSet1BindingSource
            // 
            //this.itemInventoryDataSet1BindingSource.DataSource = this.itemInventory_DataSet1;
            this.itemInventoryDataSet1BindingSource.Position = 0;
            this.itemInventoryDataSet1BindingSource.CurrentChanged += new System.EventHandler(this.itemInventoryDataSet1BindingSource_CurrentChanged);
            // 
            // itemInventory_DataSet1
            // 
            //this.itemInventory_DataSet1.DataSetName = "ItemInventory_DataSet1";
            //this.itemInventory_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrintBatch_CB
            // 
            this.PrintBatch_CB.AutoSize = true;
            this.PrintBatch_CB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintBatch_CB.Enabled = false;
            this.PrintBatch_CB.ForeColor = System.Drawing.Color.Indigo;
            this.PrintBatch_CB.Location = new System.Drawing.Point(69, 86);
            this.PrintBatch_CB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintBatch_CB.Name = "PrintBatch_CB";
            this.PrintBatch_CB.Size = new System.Drawing.Size(99, 21);
            this.PrintBatch_CB.TabIndex = 40;
            this.PrintBatch_CB.Text = "Print Batch";
            this.PrintBatch_CB.UseVisualStyleBackColor = true;
            this.PrintBatch_CB.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.PrintBatch_CB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CustomerNameSearch_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 816);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(184, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // CustomerNameSearch_txt
            // 
            this.CustomerNameSearch_txt.FormattingEnabled = true;
            this.CustomerNameSearch_txt.Location = new System.Drawing.Point(148, 49);
            this.CustomerNameSearch_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerNameSearch_txt.Name = "CustomerNameSearch_txt";
            this.CustomerNameSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.CustomerNameSearch_txt.TabIndex = 1;
            this.CustomerNameSearch_txt.Visible = false;
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
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(19, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Customer";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            this.label4.Visible = false;
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToAddRows = false;
            this.BillDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            this.BillDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.BillDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Location = new System.Drawing.Point(9, 118);
            this.BillDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            this.BillDataGridView.Size = new System.Drawing.Size(367, 694);
            this.BillDataGridView.TabIndex = 35;
            this.BillDataGridView.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ListInventoryDataSet";
            reportDataSource1.Value = this.iTEMINVENTORYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryManagement.Reports.ItemInventoyrReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(384, 37);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PromptAreaCollapsed = true;
            this.reportViewer1.Size = new System.Drawing.Size(1407, 816);
            this.reportViewer1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 33);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iTEMINVENTORYTableAdapter
            // 
            //this.iTEMINVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // ListInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListInventory_FormClosed);
            this.Load += new System.EventHandler(this.ListInventory_Load_1);
            this.Shown += new System.EventHandler(this.ListInventory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListInventory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.iTEMINVENTORYBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.itemInventoryDataSet1BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.itemInventory_DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox PrintBatch_CB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CustomerNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private ItemInventory_DataSet1 itemInventory_DataSet1;
        private System.Windows.Forms.BindingSource itemInventoryDataSet1BindingSource;
        private System.Windows.Forms.BindingSource iTEMINVENTORYBindingSource;
        //private InventoryManagement.DataSets.ItemInventory_DataSet1TableAdapters.ITEMINVENTORYTableAdapter iTEMINVENTORYTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}