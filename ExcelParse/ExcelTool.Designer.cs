namespace ExcelReader
{
    partial class ExcelTool
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkSheetLabel = new System.Windows.Forms.Label();
            this.SheetNameTextBox = new System.Windows.Forms.TextBox();
            this.RangeStartCellLabel = new System.Windows.Forms.Label();
            this.RangeStartCellTextBox = new System.Windows.Forms.TextBox();
            this.RangeEndCellLabel = new System.Windows.Forms.Label();
            this.RangeEndCellTextBox = new System.Windows.Forms.TextBox();
            this.ExcelRead = new System.Windows.Forms.Button();
            this.ExcelDataTextBox = new System.Windows.Forms.TextBox();
            this.BackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 15);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FileNameLabel.TabIndex = 12;
            this.FileNameLabel.Text = "FileName : ";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(119, 12);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.FileNameTextBox.TabIndex = 0;
            this.FileNameTextBox.TabStop = false;
            // 
            // WorkSheetLabel
            // 
            this.WorkSheetLabel.AutoSize = true;
            this.WorkSheetLabel.Location = new System.Drawing.Point(12, 41);
            this.WorkSheetLabel.Name = "WorkSheetLabel";
            this.WorkSheetLabel.Size = new System.Drawing.Size(101, 13);
            this.WorkSheetLabel.TabIndex = 11;
            this.WorkSheetLabel.Text = "WorkSheet Name : ";
            // 
            // SheetNameTextBox
            // 
            this.SheetNameTextBox.Location = new System.Drawing.Point(119, 38);
            this.SheetNameTextBox.Name = "SheetNameTextBox";
            this.SheetNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.SheetNameTextBox.TabIndex = 1;
            this.SheetNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SheetNameTextBox_KeyDown);
            // 
            // RangeStartCellLabel
            // 
            this.RangeStartCellLabel.AutoSize = true;
            this.RangeStartCellLabel.Location = new System.Drawing.Point(12, 67);
            this.RangeStartCellLabel.Name = "RangeStartCellLabel";
            this.RangeStartCellLabel.Size = new System.Drawing.Size(99, 13);
            this.RangeStartCellLabel.TabIndex = 7;
            this.RangeStartCellLabel.Text = "Range - StartCell  : ";
            this.RangeStartCellLabel.Visible = false;
            // 
            // RangeStartCellTextBox
            // 
            this.RangeStartCellTextBox.Location = new System.Drawing.Point(119, 64);
            this.RangeStartCellTextBox.Name = "RangeStartCellTextBox";
            this.RangeStartCellTextBox.Size = new System.Drawing.Size(179, 20);
            this.RangeStartCellTextBox.TabIndex = 2;
            this.RangeStartCellTextBox.TabStop = false;
            this.RangeStartCellTextBox.Text = "A1";
            this.RangeStartCellTextBox.Visible = false;
            // 
            // RangeEndCellLabel
            // 
            this.RangeEndCellLabel.AutoSize = true;
            this.RangeEndCellLabel.Location = new System.Drawing.Point(12, 93);
            this.RangeEndCellLabel.Name = "RangeEndCellLabel";
            this.RangeEndCellLabel.Size = new System.Drawing.Size(96, 13);
            this.RangeEndCellLabel.TabIndex = 8;
            this.RangeEndCellLabel.Text = "Range - EndCell  : ";
            this.RangeEndCellLabel.Visible = false;
            // 
            // RangeEndCellTextBox
            // 
            this.RangeEndCellTextBox.Location = new System.Drawing.Point(119, 90);
            this.RangeEndCellTextBox.Name = "RangeEndCellTextBox";
            this.RangeEndCellTextBox.Size = new System.Drawing.Size(179, 20);
            this.RangeEndCellTextBox.TabIndex = 3;
            this.RangeEndCellTextBox.TabStop = false;
            this.RangeEndCellTextBox.Text = "ZZ1000";
            this.RangeEndCellTextBox.Visible = false;
            this.RangeEndCellTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RangeEndCellTextBox_KeyPress);
            // 
            // ExcelRead
            // 
            this.ExcelRead.Location = new System.Drawing.Point(224, 116);
            this.ExcelRead.Name = "ExcelRead";
            this.ExcelRead.Size = new System.Drawing.Size(75, 23);
            this.ExcelRead.TabIndex = 4;
            this.ExcelRead.Text = "ExcelRead";
            this.ExcelRead.UseVisualStyleBackColor = true;
            this.ExcelRead.Click += new System.EventHandler(this.ExcelRead_Click);
            // 
            // ExcelDataTextBox
            // 
            this.ExcelDataTextBox.Location = new System.Drawing.Point(119, 12);
            this.ExcelDataTextBox.Name = "ExcelDataTextBox";
            this.ExcelDataTextBox.Size = new System.Drawing.Size(179, 20);
            this.ExcelDataTextBox.TabIndex = 1;
            this.ExcelDataTextBox.Visible = false;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(252, 273);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(47, 13);
            this.BackLabel.TabIndex = 13;
            this.BackLabel.Text = "<-- Back";
            this.BackLabel.Visible = false;
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // ExcelTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 148);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.WorkSheetLabel);
            this.Controls.Add(this.SheetNameTextBox);
            this.Controls.Add(this.RangeStartCellLabel);
            this.Controls.Add(this.RangeStartCellTextBox);
            this.Controls.Add(this.RangeEndCellLabel);
            this.Controls.Add(this.RangeEndCellTextBox);
            this.Controls.Add(this.ExcelRead);
            this.Controls.Add(this.ExcelDataTextBox);
            this.Name = "ExcelTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelTool";
            this.Load += new System.EventHandler(this.ExcelTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
                       
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label WorkSheetLabel;
        private System.Windows.Forms.TextBox SheetNameTextBox;

        private System.Windows.Forms.Label RangeStartCellLabel;
        private System.Windows.Forms.TextBox RangeStartCellTextBox;
        private System.Windows.Forms.Label RangeEndCellLabel;
        private System.Windows.Forms.TextBox RangeEndCellTextBox;

        private System.Windows.Forms.Button ExcelRead;

        private System.Windows.Forms.TextBox ExcelDataTextBox;
        private System.Windows.Forms.Label BackLabel;
    }
}

