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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RefreshBorrowedList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshBorrowedList()
        {
            lstBorrowed.Items.Clear();
            var borrowed = AppData.Library.GetBorrowedBooks();

            foreach (var b in borrowed)
            {
                lstBorrowed.Items.Add(
                    $"{b.Id}. {b.Title} [ยืมโดย {b.BorrowerName} ({b.BorrowerGmail}) กำหนดคืน {b.ReturnDate:dd/MM/yyyy}]"
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtReturnBookId.Text.Trim(), out int id))
            {
                MessageBox.Show("กรุณากรอกรหัสหนังสือเป็นตัวเลข");
                return;
            }

            if (AppData.Library.ReturnBook(id, out string message))
            {
                MessageBox.Show(message, "คืนหนังสือ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshBorrowedList();
            }
            else
            {
                MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
