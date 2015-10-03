using firebirdtest.DataSets;

namespace firebirdtest.UI
{
    partial class DebitorSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitorSummary));
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAccountDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintBatch_CB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAccountDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.customerAccountDataSet1BindingSource;
            // 
            // customerAccountDataSet1BindingSource
            // 
            this.customerAccountDataSet1BindingSource.Position = 0;
            // 
            // PrintBatch_CB
            // 
            this.PrintBatch_CB.AutoSize = true;
            this.PrintBatch_CB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintBatch_CB.ForeColor = System.Drawing.Color.Indigo;
            this.PrintBatch_CB.Location = new System.Drawing.Point(52, 70);
            this.PrintBatch_CB.Name = "PrintBatch_CB";
            this.PrintBatch_CB.Size = new System.Drawing.Size(78, 17);
            this.PrintBatch_CB.TabIndex = 40;
            this.PrintBatch_CB.Text = "Print Batch";
            this.PrintBatch_CB.UseVisualStyleBackColor = true;
            this.PrintBatch_CB.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // CustomerNameSearch_txt
            // 
            this.CustomerNameSearch_txt.FormattingEnabled = true;
            this.CustomerNameSearch_txt.Location = new System.Drawing.Point(111, 40);
            this.CustomerNameSearch_txt.Name = "CustomerNameSearch_txt";
            this.CustomerNameSearch_txt.Size = new System.Drawing.Size(121, 21);
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
            this.label6.Location = new System.Drawing.Point(14, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Customer";
            this.label6.Visible = false;
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToAddRows = false;
            this.BillDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.BillDataGridView.Location = new System.Drawing.Point(7, 96);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            this.BillDataGridView.Size = new System.Drawing.Size(275, 569);
            this.BillDataGridView.TabIndex = 35;
            this.BillDataGridView.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            this.label4.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "CustomerAccount";
            reportDataSource1.Value = this.cUSTOMERSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "firebirdtest.Reports.CustomerDebitSummeryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(288, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(1056, 668);
            this.reportViewer1.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 668);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DebitorSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1344, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "DebitorSummary";
            this.Text = "DebitorSummary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DebitorSummary_FormClosed);
            this.Shown += new System.EventHandler(this.DebitorSummary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox PrintBatch_CB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CustomerNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private System.Windows.Forms.BindingSource customerAccountDataSet1BindingSource;
        private System.Windows.Forms.Button button2;
    }
}