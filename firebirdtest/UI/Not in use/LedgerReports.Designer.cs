namespace InventoryManagement.UI
{
    partial class LedgerReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedgerReports));
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ledgerReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.ledgerReport_DataSet = new InventoryManagement.DataSets.LedgerReport_DataSet();
            this.Ftom_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerName_txt = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            //this.bILLTableAdapter = new InventoryManagement.DataSets.LedgerReport_DataSetTableAdapters.BILLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerReportDataSetBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.ledgerReport_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.ledgerReportDataSetBindingSource;
            // 
            // ledgerReportDataSetBindingSource
            // 
            //this.ledgerReportDataSetBindingSource.DataSource = this.ledgerReport_DataSet;
            this.ledgerReportDataSetBindingSource.Position = 0;
            // 
            // ledgerReport_DataSet
            // 
            //this.ledgerReport_DataSet.DataSetName = "LedgerReport_DataSet";
            //this.ledgerReport_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ftom_dateTimePicker
            // 
            this.Ftom_dateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.Ftom_dateTimePicker.Name = "Ftom_dateTimePicker";
            this.Ftom_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Ftom_dateTimePicker.TabIndex = 0;
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Location = new System.Drawing.Point(3, 29);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.To_dateTimePicker.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "LedgerReportDataSet1";
            reportDataSource1.Value = this.bILLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryManagement.Reports.LeadgerReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(290, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1053, 664);
            this.reportViewer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.CustomerName_txt);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.Ftom_dateTimePicker);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.To_dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 664);
            this.panel1.TabIndex = 4;
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.FormattingEnabled = true;
            this.CustomerName_txt.Location = new System.Drawing.Point(12, 84);
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Size = new System.Drawing.Size(121, 21);
            this.CustomerName_txt.TabIndex = 4;
            this.CustomerName_txt.TextChanged += new System.EventHandler(this.CustomerName_txt_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bILLTableAdapter
            // 
            //this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // LedgerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1344, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "LedgerReports";
            this.Text = "LedgerReports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LedgerReports_FormClosed);
            this.Shown += new System.EventHandler(this.LedgerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerReportDataSetBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.ledgerReport_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Ftom_dateTimePicker;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private InventoryManagement.DataSets.LedgerReport_DataSet ledgerReport_DataSet;
        private System.Windows.Forms.BindingSource ledgerReportDataSetBindingSource;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        //private InventoryManagement.DataSets.LedgerReport_DataSetTableAdapters.BILLTableAdapter bILLTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CustomerName_txt;
    }
}