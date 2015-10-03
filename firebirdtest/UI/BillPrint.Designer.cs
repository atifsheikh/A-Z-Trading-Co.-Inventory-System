using firebirdtest.DataSets;
namespace firebirdtest.UI
{
    partial class BillPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPrint));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBatch_CB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillNumberSearch_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "firebirdtest.Reports.CustomerBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(384, 37);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(1407, 820);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.PrintBatch_CB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CustomerNameSearch_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BillNumberSearch_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillDataGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 821);
            this.panel1.TabIndex = 0;
            // 
            // PrintBatch_CB
            // 
            this.PrintBatch_CB.AutoSize = true;
            this.PrintBatch_CB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintBatch_CB.ForeColor = System.Drawing.Color.Indigo;
            this.PrintBatch_CB.Location = new System.Drawing.Point(67, 111);
            this.PrintBatch_CB.Margin = new System.Windows.Forms.Padding(4);
            this.PrintBatch_CB.Name = "PrintBatch_CB";
            this.PrintBatch_CB.Size = new System.Drawing.Size(99, 21);
            this.PrintBatch_CB.TabIndex = 40;
            this.PrintBatch_CB.Text = "Print Batch";
            this.PrintBatch_CB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CustomerNameSearch_txt
            // 
            this.CustomerNameSearch_txt.FormattingEnabled = true;
            this.CustomerNameSearch_txt.Location = new System.Drawing.Point(145, 44);
            this.CustomerNameSearch_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameSearch_txt.Name = "CustomerNameSearch_txt";
            this.CustomerNameSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.CustomerNameSearch_txt.TabIndex = 0;
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
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Customer";
            // 
            // BillNumberSearch_txt
            // 
            this.BillNumberSearch_txt.FormattingEnabled = true;
            this.BillNumberSearch_txt.Location = new System.Drawing.Point(145, 78);
            this.BillNumberSearch_txt.Margin = new System.Windows.Forms.Padding(4);
            this.BillNumberSearch_txt.Name = "BillNumberSearch_txt";
            this.BillNumberSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.BillNumberSearch_txt.TabIndex = 1;
            this.BillNumberSearch_txt.TextChanged += new System.EventHandler(this.BillNumberSearch_txt_TextChanged);
            this.BillNumberSearch_txt.Enter += new System.EventHandler(this.BillNumberSearch_txt_Enter);
            this.BillNumberSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillNumberSearch_txt_KeyPress);
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
            this.BillDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.BillDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Location = new System.Drawing.Point(9, 143);
            this.BillDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            this.BillDataGridView.Size = new System.Drawing.Size(367, 674);
            this.BillDataGridView.TabIndex = 35;
            this.BillDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BillDataGridView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bill #";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 33);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.BillPrint_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillPrint_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CustomerNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BillNumberSearch_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox PrintBatch_CB;
        private System.Windows.Forms.Button button2;

    }
}