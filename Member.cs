using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj
{  public class Member
    {
        public int Id { get; set; }                  // รหัสสมาชิก
        public string Name { get; set; } = "";       // ชื่อสมาชิก
        public string Gmail { get; set; } = "";      // Gmail
        public string Phone { get; set; } = "";      // เบอร์โทร
        public string Address { get; set; } = "";    // ที่อยู่
        public DateTime RegisterDate { get; set; }   // วันที่สมัคร
        public bool IsActive { get; set; }           // ยังใช้งานอยู่ไหม

        public override string ToString()
        {
            return $"{Id}: {Name} ({Gmail})";
        }
    }
}
