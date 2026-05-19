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
            txtAuthor = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // cboISBN
            // 
            cboISBN.FormattingEnabled = true;
            cboISBN.Location = new Point(201, 26);
            cboISBN.Margin = new Padding(6);
            cboISBN.Name = "cboISBN";
            cboISBN.Size = new Size(221, 40);
            cboISBN.TabIndex = 0;
            cboISBN.SelectedIndexChanged += cboISBN_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(163, 134);
            txtTitle.Margin = new Padding(6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(424, 39);
            txtTitle.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(163, 196);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(424, 39);
            txtPrice.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(163, 258);
            txtType.Margin = new Padding(6);
            txtType.Name = "txtType";
            txtType.Size = new Size(424, 39);
            txtType.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 252);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 190);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 134);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 7;
            label4.Text = "Title";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(163, 316);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(424, 39);
            txtAuthor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 310);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 9;
            label5.Text = "Author";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 361);
            Controls.Add(label5);
            Controls.Add(txtAuthor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtType);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(cboISBN);
            Margin = new Padding(6);
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
        private TextBox txtAuthor;
        private Label label5;
    }
}
