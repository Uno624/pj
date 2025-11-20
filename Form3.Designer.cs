namespace pj
{
    partial class Form3
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
            txtBorrowBookId = new TextBox();
            txtBorrowerName = new TextBox();
            txtBorrowerGmail = new TextBox();
            dtpReturnDate = new DateTimePicker();
            btnBorrowBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtBorrowBookId
            // 
            txtBorrowBookId.Location = new Point(12, 12);
            txtBorrowBookId.Name = "txtBorrowBookId";
            txtBorrowBookId.Size = new Size(206, 23);
            txtBorrowBookId.TabIndex = 0;
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Location = new Point(12, 59);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(206, 23);
            txtBorrowerName.TabIndex = 1;
            // 
            // txtBorrowerGmail
            // 
            txtBorrowerGmail.Location = new Point(12, 105);
            txtBorrowerGmail.Name = "txtBorrowerGmail";
            txtBorrowerGmail.Size = new Size(206, 23);
            txtBorrowerGmail.TabIndex = 2;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(12, 145);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(200, 23);
            dtpReturnDate.TabIndex = 3;
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new Point(12, 201);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(75, 23);
            btnBorrowBook.TabIndex = 4;
            btnBorrowBook.Text = "button1";
            btnBorrowBook.UseVisualStyleBackColor = true;
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "รหัสหนังสือ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "ชื่อผู้ยืม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Gmail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 151);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "เลือกวันกำหนดคืน";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBorrowBook);
            Controls.Add(dtpReturnDate);
            Controls.Add(txtBorrowerGmail);
            Controls.Add(txtBorrowerName);
            Controls.Add(txtBorrowBookId);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBorrowBookId;
        private TextBox txtBorrowerName;
        private TextBox txtBorrowerGmail;
        private DateTimePicker dtpReturnDate;
        private Button btnBorrowBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}