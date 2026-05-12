namespace DatabaseDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboISBN = new ComboBox();
            label1 = new Label();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtType = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboISBN
            // 
            cboISBN.FormattingEnabled = true;
            cboISBN.Location = new Point(108, 12);
            cboISBN.Name = "cboISBN";
            cboISBN.Size = new Size(121, 23);
            cboISBN.TabIndex = 0;
            cboISBN.SelectedIndexChanged += cboISBN_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(51, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(51, 89);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(51, 118);
            txtType.Name = "txtType";
            txtType.Size = new Size(230, 23);
            txtType.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 118);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 63);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 169);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtType);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(cboISBN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboISBN;
        private Label label1;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private TextBox txtType;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
