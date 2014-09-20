namespace firebirdtest.UI
{
    partial class ItemHistoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemHistoryReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ITEMHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemHistoryDataSource = new firebirdtest.DataSets.ItemHistoryDataSource();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemName_txt = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iTEMHISTORYTableAdapter = new firebirdtest.DataSets.ItemHistoryDataSourceTableAdapters.ITEMHISTORYTableAdapter();
            this.tableAdapterManager = new firebirdtest.DataSets.ItemHistoryDataSourceTableAdapters.TableAdapterManager();
            this.itemHistoryDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ITEMHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemHistoryDataSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemHistoryDataSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ITEMHISTORYBindingSource
            // 
            this.ITEMHISTORYBindingSource.DataMember = "ITEMHISTORY";
            this.ITEMHISTORYBindingSource.DataSource = this.itemHistoryDataSource;
            // 
            // itemHistoryDataSource
            // 
            this.itemHistoryDataSource.DataSetName = "ItemHistoryDataSource";
            this.itemHistoryDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.ItemName_txt);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 297);
            this.panel1.TabIndex = 6;
            // 
            // ItemName_txt
            // 
            this.ItemName_txt.FormattingEnabled = true;
            this.ItemName_txt.Location = new System.Drawing.Point(25, 12);
            this.ItemName_txt.Name = "ItemName_txt";
            this.ItemName_txt.Size = new System.Drawing.Size(121, 21);
            this.ItemName_txt.TabIndex = 51;
            this.ItemName_txt.SelectedIndexChanged += new System.EventHandler(this.ItemName_txt_SelectedIndexChanged);
            this.ItemName_txt.TextChanged += new System.EventHandler(this.ItemName_txt_TextChanged);
            this.ItemName_txt.Enter += new System.EventHandler(this.ItemName_txt_Enter);
            this.ItemName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemName_txt_KeyPress);
            this.ItemName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemName_txt_KeyUp);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ItemHistoryDataSet";
            reportDataSource1.Value = this.ITEMHISTORYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "firebirdtest.Reports.ItemHistory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(287, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 297);
            this.reportViewer1.TabIndex = 8;
            // 
            // iTEMHISTORYTableAdapter
            // 
            this.iTEMHISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = firebirdtest.DataSets.ItemHistoryDataSourceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemHistoryDataSourceBindingSource
            // 
            this.itemHistoryDataSourceBindingSource.DataSource = this.itemHistoryDataSource;
            this.itemHistoryDataSourceBindingSource.Position = 0;
            // 
            // ItemHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(994, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemHistoryReport";
            this.Text = "ItemHistoryReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemHistoryReport_FormClosed);
            this.Load += new System.EventHandler(this.ItemHistoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITEMHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemHistoryDataSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemHistoryDataSourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ITEMHISTORYBindingSource;
        private DataSets.ItemHistoryDataSource itemHistoryDataSource;
        private System.Windows.Forms.BindingSource itemHistoryDataSourceBindingSource;
        private DataSets.ItemHistoryDataSourceTableAdapters.ITEMHISTORYTableAdapter iTEMHISTORYTableAdapter;
        private DataSets.ItemHistoryDataSourceTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ItemName_txt;
    }
}