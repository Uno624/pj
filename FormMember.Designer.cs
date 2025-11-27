namespace pj
{
    partial class chkIsActive
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
            dgvMembers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colGmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colRegisterDate = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewTextBoxColumn();
            txtMemberName = new TextBox();
            txtMemberGmail = new TextBox();
            txtMemberPhone = new TextBox();
            txtMemberAddress = new TextBox();
            ID = new Label();
            name = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMemberId = new TextBox();
            txtSearch1 = new TextBox();
            txtSearch = new Label();
            chkIsActive1 = new CheckBox();
            btnAddMember = new Button();
            btnUpdateMember = new Button();
            btnDeactivate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = SystemColors.ActiveCaption;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colGmail, colPhone, colAddress, colRegisterDate, colIsActive });
            dgvMembers.Location = new Point(12, 12);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.Size = new Size(776, 150);
            dgvMembers.TabIndex = 0;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colGmail
            // 
            colGmail.HeaderText = "Gmail";
            colGmail.Name = "colGmail";
            colGmail.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Numer";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colRegisterDate
            // 
            colRegisterDate.HeaderText = "RegisterDate";
            colRegisterDate.Name = "colRegisterDate";
            colRegisterDate.ReadOnly = true;
            // 
            // colIsActive
            // 
            colIsActive.HeaderText = "สถานะ";
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(152, 209);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(100, 23);
            txtMemberName.TabIndex = 2;
            // 
            // txtMemberGmail
            // 
            txtMemberGmail.Location = new Point(152, 238);
            txtMemberGmail.Name = "txtMemberGmail";
            txtMemberGmail.Size = new Size(100, 23);
            txtMemberGmail.TabIndex = 3;
            // 
            // txtMemberPhone
            // 
            txtMemberPhone.Location = new Point(152, 267);
            txtMemberPhone.Name = "txtMemberPhone";
            txtMemberPhone.Size = new Size(100, 23);
            txtMemberPhone.TabIndex = 4;
            // 
            // txtMemberAddress
            // 
            txtMemberAddress.Location = new Point(152, 296);
            txtMemberAddress.Name = "txtMemberAddress";
            txtMemberAddress.Size = new Size(100, 23);
            txtMemberAddress.TabIndex = 5;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, 191);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 6;
            ID.Text = "ID";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 217);
            name.Name = "name";
            name.Size = new Size(20, 15);
            name.TabIndex = 7;
            name.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Gmail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "เบอร์";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 10;
            label5.Text = "ที่อยู่";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(152, 183);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 11;
            // 
            // txtSearch1
            // 
            txtSearch1.Location = new Point(152, 325);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.Size = new Size(100, 23);
            txtSearch1.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Location = new Point(12, 333);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(33, 15);
            txtSearch.TabIndex = 13;
            txtSearch.Text = "ค้นหา";
            // 
            // chkIsActive1
            // 
            chkIsActive1.AutoSize = true;
            chkIsActive1.Location = new Point(12, 369);
            chkIsActive1.Name = "chkIsActive1";
            chkIsActive1.Size = new Size(59, 19);
            chkIsActive1.TabIndex = 14;
            chkIsActive1.Text = "Active";
            chkIsActive1.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(23, 415);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(75, 23);
            btnAddMember.TabIndex = 15;
            btnAddMember.Text = "เพิ่ม";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnUpdateMember
            // 
            btnUpdateMember.Location = new Point(152, 415);
            btnUpdateMember.Name = "btnUpdateMember";
            btnUpdateMember.Size = new Size(75, 23);
            btnUpdateMember.TabIndex = 16;
            btnUpdateMember.Text = "แก้";
            btnUpdateMember.UseVisualStyleBackColor = true;
            btnUpdateMember.Click += btnUpdateMember_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Location = new Point(275, 415);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(75, 23);
            btnDeactivate.TabIndex = 17;
            btnDeactivate.Text = "ระงับ";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(387, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(503, 415);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "ค้นหา";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // chkIsActive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdateMember);
            Controls.Add(btnAddMember);
            Controls.Add(chkIsActive1);
            Controls.Add(txtSearch);
            Controls.Add(txtSearch1);
            Controls.Add(txtMemberId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(ID);
            Controls.Add(txtMemberAddress);
            Controls.Add(txtMemberPhone);
            Controls.Add(txtMemberGmail);
            Controls.Add(txtMemberName);
            Controls.Add(dgvMembers);
            Name = "chkIsActive";
            Text = "FormMember";
            Load += FormMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMembers;
        private TextBox txtMemberName;
        private TextBox txtMemberGmail;
        private TextBox txtMemberPhone;
        private TextBox txtMemberAddress;
        private Label ID;
        private Label name;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMemberId;
        private TextBox txtSearch1;
        private Label txtSearch;
        private CheckBox chkIsActive1;
        private Button btnAddMember;
        private Button btnUpdateMember;
        private Button btnDeactivate;
        private Button btnDelete;
        private Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colGmail;
        private DataGridViewTextBoxColumn colPhon;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colRegisterDate;
        private DataGridViewTextBoxColumn colIsActive;
        private DataGridViewTextBoxColumn colPhone;
    }
}