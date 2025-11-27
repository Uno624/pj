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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // กำหนดค่าเริ่มต้นให้กำหนดคืนวันถัดไปจากวันนี้
            dtpReturnDate.Value = DateTime.Now.AddDays(7);
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBorrowBookId.Text.Trim(), out int id))
            {
                MessageBox.Show("กรุณากรอกรหัสหนังสือเป็นตัวเลข");
                return;
            }

            string name = txtBorrowerName.Text.Trim();
            string gmail = txtBorrowerGmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ยืม");
                return;
            }

            if (string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("กรุณากรอก Gmail ผู้ยืม");
                return;
            }

            DateTime returnDate = dtpReturnDate.Value.Date;

            if (AppData.Library.BorrowBook(id, name, gmail, returnDate, out string message))
            {
                MessageBox.Show(message, "ยืมหนังสือ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // ปิดฟอร์มหลังยืมสำเร็จ
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
