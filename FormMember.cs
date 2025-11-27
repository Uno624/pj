using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj
{
    public partial class chkIsActive : Form
    {

        public chkIsActive()
        {
            InitializeComponent();
            LoadMemberList(AppData.MemberManager.Members);
        }

        private void LoadMemberList(List<Member> list)
        {
            dgvMembers.Rows.Clear();
            foreach (var m in list)
            {
                int index = dgvMembers.Rows.Add();
                dgvMembers.Rows[index].Cells["colId"].Value = m.Id;
                dgvMembers.Rows[index].Cells["colName"].Value = m.Name;
                dgvMembers.Rows[index].Cells["colGmail"].Value = m.Gmail;
                dgvMembers.Rows[index].Cells["colPhone"].Value = m.Phone;
                dgvMembers.Rows[index].Cells["colAddress"].Value = m.Address;
                dgvMembers.Rows[index].Cells["colRegisterDate"].Value = m.RegisterDate.ToString("dd/MM/yyyy");
                dgvMembers.Rows[index].Cells["colIsActive"].Value = m.IsActive ? "ใช้งาน" : "ระงับ";
            }
        }

        private void ClearMemberDetail()
        {
            txtMemberId.Clear();
            txtMemberName.Clear();
            txtMemberGmail.Clear();
            txtMemberPhone.Clear();
            txtMemberAddress.Clear();
            chkIsActive1.Checked = true;
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMembers.Rows[e.RowIndex];
            if (row.Cells["colId"].Value == null) return;

            int id = Convert.ToInt32(row.Cells["colId"].Value);
            var member = AppData.MemberManager.GetMemberById(id);
            if (member == null) return;

            txtMemberId.Text = member.Id.ToString();
            txtMemberName.Text = member.Name;
            txtMemberGmail.Text = member.Gmail;
            txtMemberPhone.Text = member.Phone;
            txtMemberAddress.Text = member.Address;
            chkIsActive1.Checked = member.IsActive;
        }



        private void FormMember_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string name = txtMemberName.Text;
            string gmail = txtMemberGmail.Text;
            string phone = txtMemberPhone.Text;
            string address = txtMemberAddress.Text;

            if (AppData.MemberManager.AddMember(name, gmail, phone, address, out string message))
            {
                MessageBox.Show(message, "เพิ่มสมาชิก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberList(AppData.MemberManager.Members);
                ClearMemberDetail();
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberId.Text, out int id))
            {
                MessageBox.Show("กรุณาเลือกสมาชิกจากตารางก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtMemberName.Text;
            string gmail = txtMemberGmail.Text;
            string phone = txtMemberPhone.Text;
            string address = txtMemberAddress.Text;
            bool isActive = chkIsActive1.Checked;

            if (AppData.MemberManager.UpdateMember(id, name, gmail, phone, address, isActive, out string message))
            {
                MessageBox.Show(message, "แก้ไขสมาชิก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberList(AppData.MemberManager.Members);
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberId.Text, out int id))
            {
                MessageBox.Show("กรุณาเลือกสมาชิกจากตารางก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AppData.MemberManager.DeactivateMember(id, out string message))
            {
                MessageBox.Show(message, "ระงับสมาชิก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberList(AppData.MemberManager.Members);
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberId.Text, out int id))
            {
                MessageBox.Show("กรุณาเลือกสมาชิกจากตารางก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("ต้องการลบสมาชิกคนนี้จริงหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (AppData.MemberManager.DeleteMember(id, out string message))
            {
                MessageBox.Show(message, "ลบสมาชิก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberList(AppData.MemberManager.Members);
                ClearMemberDetail();
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch1.Text;
            var result = AppData.MemberManager.SearchMembers(keyword);
            LoadMemberList(result);
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch1.Clear();
            LoadMemberList(AppData.MemberManager.Members);
        }
    }
}
