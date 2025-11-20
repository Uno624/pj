namespace pj
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
            btb_Return = new Button();
            btb_Borrowe = new Button();
            lstBooks = new ListBox();
            btb_Addbook = new Button();
            txtNewTitle = new TextBox();
            SuspendLayout();
            // 
            // btb_Return
            // 
            btb_Return.Location = new Point(308, 66);
            btb_Return.Name = "btb_Return";
            btb_Return.Size = new Size(203, 78);
            btb_Return.TabIndex = 0;
            btb_Return.Text = "การคืน";
            btb_Return.UseVisualStyleBackColor = true;
            btb_Return.Click += btb_Return_Click;
            // 
            // btb_Borrowe
            // 
            btb_Borrowe.Location = new Point(308, 178);
            btb_Borrowe.Name = "btb_Borrowe";
            btb_Borrowe.Size = new Size(203, 78);
            btb_Borrowe.TabIndex = 1;
            btb_Borrowe.Text = "การยืม";
            btb_Borrowe.UseVisualStyleBackColor = true;
            btb_Borrowe.Click += btb_Borrowe_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(12, 12);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(120, 94);
            lstBooks.TabIndex = 2;
            // 
            // btb_Addbook
            // 
            btb_Addbook.Location = new Point(308, 284);
            btb_Addbook.Name = "btb_Addbook";
            btb_Addbook.Size = new Size(203, 78);
            btb_Addbook.TabIndex = 3;
            btb_Addbook.Text = "เพิ่มหนังสือ";
            btb_Addbook.UseVisualStyleBackColor = true;
            btb_Addbook.Click += btb_Addbook_Click;
            // 
            // txtNewTitle
            // 
            txtNewTitle.Location = new Point(12, 121);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(120, 23);
            txtNewTitle.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNewTitle);
            Controls.Add(btb_Addbook);
            Controls.Add(lstBooks);
            Controls.Add(btb_Borrowe);
            Controls.Add(btb_Return);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btb_Return;
        private Button btb_Borrowe;
        private ListBox lstBooks;
        private Button btb_Addbook;
        private TextBox txtNewTitle;
    }
}
