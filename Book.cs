using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj
{
    public class Book
    {
        public int Id { get; set; }                     // รหัสหนังสือ
        public string Title { get; set; } = "";         // ชื่อหนังสือ
        public bool IsBorrowed { get; set; }            // true = ถูกยืมอยู่
        public string? BorrowerName { get; set; }       // ชื่อคนยืม
        public string? BorrowerGmail { get; set; }      // Gmail คนยืม
        public DateTime? BorrowDate { get; set; }       // วันที่ยืม
        public DateTime? ReturnDate { get; set; }       // วันที่ต้องคืน
    }
}
