//using InventoryManagement.DataSets;

namespace InventoryManagement.UI
{
    partial class CreditorSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditorSummary));
            this.PrintBatch_CB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VendorNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintBatch_CB
            // 
            this.PrintBatch_CB.AutoSize = true;
            this.PrintBatch_CB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // VendorNameSearch_txt
            // 
            this.VendorNameSearch_txt.FormattingEnabled = true;
            this.VendorNameSearch_txt.Location = new System.Drawing.Point(148, 49);
            this.VendorNameSearch_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VendorNameSearch_txt.Name = "VendorNameSearch_txt";
            this.VendorNameSearch_txt.Size = new System.Drawing.Size(160, 24);
            this.VendorNameSearch_txt.TabIndex = 1;
            this.VendorNameSearch_txt.Visible = false;
            this.VendorNameSearch_txt.TextChanged += new System.EventHandler(this.VendorNameSearch_txt_TextChanged);
            this.VendorNameSearch_txt.Enter += new System.EventHandler(this.VendorNameSearch_txt_Enter);
            this.VendorNameSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendorNameSearch_txt_KeyPress);
            this.VendorNameSearch_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VendorNameSearch_txt_KeyUp);
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
            this.label6.Text = "Vendor";
            this.label6.Visible = false;
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.AllowUserToAddRows = false;
            this.ShipmentDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ShipmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShipmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ShipmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ShipmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ShipmentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShipmentDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Location = new System.Drawing.Point(9, 118);
            this.ShipmentDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.ReadOnly = true;
            this.ShipmentDataGridView.Size = new System.Drawing.Size(367, 700);
            this.ShipmentDataGridView.TabIndex = 35;
            this.ShipmentDataGridView.Visible = false;
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "VendorAccount";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryManagement.Reports.VendorCreditSummaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(384, 37);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(1407, 822);
            this.reportViewer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.PrintBatch_CB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.VendorNameSearch_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ShipmentDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 822);
            this.panel1.TabIndex = 2;
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
            // CreditorSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1792, 891);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreditorSummary";
            this.Text = "CreditorSummary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreditorSummary_FormClosed);
            this.Shown += new System.EventHandler(this.CreditorSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox PrintBatch_CB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox VendorNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ShipmentDataGridView;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}