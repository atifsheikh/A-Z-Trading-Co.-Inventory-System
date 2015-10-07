namespace InventoryManagement.UI
{
    partial class SelectItemCode
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
            this.button2 = new System.Windows.Forms.Button();
            this.SelectedItemCode_txt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemCode_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectedItemCode_txt
            // 
            this.SelectedItemCode_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SelectedItemCode_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectedItemCode_txt.FormattingEnabled = true;
            this.SelectedItemCode_txt.Location = new System.Drawing.Point(117, 38);
            this.SelectedItemCode_txt.Name = "SelectedItemCode_txt";
            this.SelectedItemCode_txt.Size = new System.Drawing.Size(153, 21);
            this.SelectedItemCode_txt.TabIndex = 1;
            this.SelectedItemCode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectedItemCode_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Code For Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Code in Excel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemCode_txt
            // 
            this.ItemCode_txt.Location = new System.Drawing.Point(117, 12);
            this.ItemCode_txt.Name = "ItemCode_txt";
            this.ItemCode_txt.Size = new System.Drawing.Size(153, 20);
            this.ItemCode_txt.TabIndex = 0;
            this.ItemCode_txt.TabStop = false;
            // 
            // SelectItemCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 95);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SelectedItemCode_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemCode_txt);
            this.Name = "SelectItemCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectItemCode";
            this.Load += new System.EventHandler(this.SelectItemCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox SelectedItemCode_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ItemCode_txt;

    }
}