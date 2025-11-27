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
    public partial class FormAddbook : Form
    {
        public FormAddbook()
        {
            InitializeComponent();
            RefreshBookList();
        }

        private void RefreshBookList()
        {
            lstBooks.Items.Clear();
            var books = AppData.Library.GetAllBooks();

            foreach (var b in books)
            {
                string status = b.IsBorrowed
                    ? $"[ยืมโดย {b.BorrowerName} ({b.BorrowerGmail}) กำหนดคืน {b.ReturnDate:dd/MM/yyyy}]"
                    : "[ว่าง]";

                lstBooks.Items.Add($"{b.Id}. {b.Title} {status}");
            }
        }

        private void FormAddbook_Load(object sender, EventArgs e)
        {

        }

        private void btb_Addbook_Click(object sender, EventArgs e)
        {
            string title = txtNewTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("กรุณาใส่ชื่อหนังสือ");
                return;
            }
            AppData.Library.AddBook(title);
            txtNewTitle.Clear();
            RefreshBookList();
        }

        private void btb_removebook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNewTitle.Text, out int id))
            {
                MessageBox.Show("กรุณาเลือกจากIDหนังสือก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AppData.Library.RemoveBook(id, out string message))
            {
                MessageBox.Show(message, "ลบหนังสือ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewTitle.Clear();
                RefreshBookList();
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
