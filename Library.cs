using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace pj
{
    public class Library
    {
        private const string DataFile = "library.json";

        public List<Book> Books { get; set; } = new List<Book>();

        public void Load()
        {
            if (!File.Exists(DataFile))
            {
                Books = new List<Book>();
                return;
            }

            string json = File.ReadAllText(DataFile);
            var books = JsonSerializer.Deserialize<List<Book>>(json);
            if (books != null)
            {
                Books = books;
            }
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Books, options);
            File.WriteAllText(DataFile, json);
        }

        // เพิ่มหนังสือใหม่
        public void AddBook(string title)
        {
            int newId = Books.Count == 0 ? 1 : Books.Max(b => b.Id) + 1;

            Books.Add(new Book
            {
                Id = newId,
                Title = title,
                IsBorrowed = false
            });

            Save();
        }

        public List<Book> GetAllBooks()
        {
            return Books.ToList();
        }

        public List<Book> GetBorrowedBooks()
        {
            return Books.Where(b => b.IsBorrowed).ToList();
        }

        public bool BorrowBook(int id, string borrowerName, string borrowerGmail, DateTime returnDate, out string message)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                message = "ไม่พบหนังสือรหัสนี้";
                return false;
            }

            if (book.IsBorrowed)
            {
                message = "หนังสือเล่มนี้ถูกยืมอยู่แล้ว";
                return false;
            }

            book.IsBorrowed = true;
            book.BorrowerName = borrowerName;
            book.BorrowerGmail = borrowerGmail;
            book.BorrowDate = DateTime.Now;
            book.ReturnDate = returnDate;

            Save();
            message = "ยืมหนังสือเรียบร้อย";
            return true;
        }

        public bool ReturnBook(int id, out string message)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                message = "ไม่พบหนังสือรหัสนี้";
                return false;
            }

            if (!book.IsBorrowed)
            {
                message = "หนังสือเล่มนี้ไม่ได้ถูกยืมอยู่";
                return false;
            }

            // เช็คว่าคืนช้าไหม (ถ้าต้องการ)
            if (book.ReturnDate.HasValue && DateTime.Now.Date > book.ReturnDate.Value.Date)
            {
                int lateDays = (DateTime.Now.Date - book.ReturnDate.Value.Date).Days;
                message = $"คืนหนังสือเรียบร้อย (คืนช้า {lateDays} วัน)";
            }
            else
            {
                message = "คืนหนังสือเรียบร้อย";
            }

            book.IsBorrowed = false;
            book.BorrowerName = null;
            book.BorrowerGmail = null;
            book.BorrowDate = null;
            book.ReturnDate = null;

            Save();
            return true;
        }
    }
}
