namespace pj
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;
    using System.Windows.Forms;
    using static System.Windows.Forms.DataFormats;

    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
            RefreshBookList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btb_Return_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())   // ฟอร์มคืน
            {
                f.ShowDialog();
            }
            RefreshBookList();
        }

        private void btb_Borrowe_Click(object sender, EventArgs e)
        {
            using (var f = new Form3())   // ฟอร์มยืม
            {
                f.ShowDialog();
            }
            RefreshBookList();
        }

        private void btb_Addbook_Click(object sender, EventArgs e)
        {
            string title = txtNewTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("กรุณากรอกชื่อหนังสือ");
                return;
            }

            AppData.Library.AddBook(title);
            txtNewTitle.Clear();
            RefreshBookList();
        }
    }
}
