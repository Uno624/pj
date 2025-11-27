namespace pj
{
    partial class FormAddbook
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
            txtNewTitle = new TextBox();
            lstBooks = new ListBox();
            btb_Addbook = new Button();
            btb_removebook = new Button();
            SuspendLayout();
            // 
            // txtNewTitle
            // 
            txtNewTitle.Location = new Point(12, 121);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(377, 23);
            txtNewTitle.TabIndex = 6;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(12, 12);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(776, 94);
            lstBooks.TabIndex = 5;
            // 
            // btb_Addbook
            // 
            btb_Addbook.Location = new Point(125, 360);
            btb_Addbook.Name = "btb_Addbook";
            btb_Addbook.Size = new Size(203, 78);
            btb_Addbook.TabIndex = 7;
            btb_Addbook.Text = "เพิ่มหนังสือ";
            btb_Addbook.UseVisualStyleBackColor = true;
            btb_Addbook.Click += btb_Addbook_Click;
            // 
            // btb_removebook
            // 
            btb_removebook.Location = new Point(480, 360);
            btb_removebook.Name = "btb_removebook";
            btb_removebook.Size = new Size(203, 78);
            btb_removebook.TabIndex = 8;
            btb_removebook.Text = " ลบหนังสือ";
            btb_removebook.UseVisualStyleBackColor = true;
            btb_removebook.Click += btb_removebook_Click;
            // 
            // FormAddbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btb_removebook);
            Controls.Add(btb_Addbook);
            Controls.Add(txtNewTitle);
            Controls.Add(lstBooks);
            Name = "FormAddbook";
            Text = "FormAddbook";
            Load += FormAddbook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewTitle;
        private ListBox lstBooks;
        private Button btb_Addbook;
        private Button btb_removebook;
    }
}