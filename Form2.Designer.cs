namespace pj
{
    partial class Form2
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
            txtReturnBookId = new TextBox();
            button1 = new Button();
            lstBorrowed = new ListBox();
            SuspendLayout();
            // 
            // txtReturnBookId
            // 
            txtReturnBookId.Location = new Point(330, 184);
            txtReturnBookId.Name = "txtReturnBookId";
            txtReturnBookId.Size = new Size(155, 23);
            txtReturnBookId.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(330, 318);
            button1.Name = "button1";
            button1.Size = new Size(155, 62);
            button1.TabIndex = 1;
            button1.Text = "คืน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstBorrowed
            // 
            lstBorrowed.FormattingEnabled = true;
            lstBorrowed.ItemHeight = 15;
            lstBorrowed.Location = new Point(103, 12);
            lstBorrowed.Name = "lstBorrowed";
            lstBorrowed.Size = new Size(647, 154);
            lstBorrowed.TabIndex = 2;
            lstBorrowed.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBorrowed);
            Controls.Add(button1);
            Controls.Add(txtReturnBookId);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReturnBookId;
        private Button button1;
        private ListBox lstBorrowed;
    }
}