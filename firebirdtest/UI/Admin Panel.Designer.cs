namespace firebirdtest.UI
{
    partial class Admin_Panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.DBAddress_txt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DSN_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Address (With Port number):";
            // 
            // DBAddress_txt
            // 
            this.DBAddress_txt.Location = new System.Drawing.Point(271, 19);
            this.DBAddress_txt.Name = "DBAddress_txt";
            this.DBAddress_txt.Size = new System.Drawing.Size(272, 22);
            this.DBAddress_txt.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(653, 88);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample = \"localhost:8080\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sample = \"Dsn=Firebird DNS;uid=sysdba;pwd=masterkey\"";
            this.label3.Visible = false;
            // 
            // DSN_txt
            // 
            this.DSN_txt.Location = new System.Drawing.Point(271, 47);
            this.DSN_txt.Name = "DSN_txt";
            this.DSN_txt.Size = new System.Drawing.Size(272, 22);
            this.DSN_txt.TabIndex = 5;
            this.DSN_txt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "DSN for Reporting :";
            this.label4.Visible = false;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 123);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DSN_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DBAddress_txt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBAddress_txt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DSN_txt;
        private System.Windows.Forms.Label label4;
    }
}