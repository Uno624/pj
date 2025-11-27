using pj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

/// <summary>
/// จัดการข้อมูลสมาชิกทั้งหมดของระบบ
/// - โหลด / เซฟจากไฟล์ JSON
/// - เพิ่ม / แก้ไข / ลบ / ระงับสมาชิก
/// - ค้นหาสมาชิก
/// </summary>
public class MemberManager
{
    // ชื่อไฟล์ที่ใช้เก็บข้อมูลสมาชิกในรูปแบบ JSON
    private const string MemberFile = "members.json";

    /// <summary>
    /// รายการสมาชิกทั้งหมดที่อยู่ในระบบ
    /// </summary>
    public List<Member> Members { get; private set; } = new List<Member>();

    /// <summary>
    /// Constructor หลัก
    /// เมื่อสร้าง MemberManager จะเรียก Load() เพื่ออ่านข้อมูลจากไฟล์เลย
    /// </summary>
    public MemberManager()
    {
        Load();
    }

    /// <summary>
    /// โหลดข้อมูลสมาชิกจากไฟล์ JSON
    /// ถ้าไฟล์ไม่มี หรืออ่านไม่ได้ จะสร้าง List ว่าง ๆ แทน
    /// </summary>
    public void Load()
    {
        // ถ้าไฟล์ยังไม่ถูกสร้าง ให้ใช้ List ว่าง
        if (!File.Exists(MemberFile))
        {
            Members = new List<Member>();
            return;
        }

        try
        {
            // อ่าน JSON ทั้งไฟล์
            string json = File.ReadAllText(MemberFile);

            // แปลง JSON เป็น List<Member>
            var list = JsonSerializer.Deserialize<List<Member>>(json);

            // ถ้าอ่านได้ปกติ ใช้ list นั้น ถ้า null ให้ใช้ List ว่าง
            Members = list ?? new List<Member>();
        }
        catch
        {
            // ถ้ามี error ระหว่างอ่าน/แปลง JSON
            // เพื่อความปลอดภัย ไม่ให้โปรแกรมล้ม ให้เริ่มต้นด้วย List ว่าง
            Members = new List<Member>();
        }
    }

    /// <summary>
    /// บันทึกข้อมูล Members ลงไฟล์ JSON
    /// </summary>
    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true   // จัดรูปแบบ JSON ให้สวย อ่านง่าย
        };

        string json = JsonSerializer.Serialize(Members, options);
        File.WriteAllText(MemberFile, json);
    }

    /// <summary>
    /// คืนค่า Member ตาม Id ที่กำหนด
    /// ถ้าไม่เจอจะคืนค่า null
    /// </summary>
    public Member? GetMemberById(int id)
    {
        // FirstOrDefault จะคืนสมาชิกตัวแรกที่ Id ตรงกัน ถ้าไม่มีจะเป็น null
        return Members.FirstOrDefault(m => m.Id == id);
    }

    /// <summary>
    /// คืนค่า Member ตาม Gmail
    /// เปรียบเทียบแบบไม่สนใจตัวใหญ่/เล็ก
    /// ถ้าไม่เจอจะคืนค่า null
    /// </summary>
    public Member? GetMemberByGmail(string gmail)
    {
        return Members.FirstOrDefault(
            m => m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase)
        );
    }

    /// <summary>
    /// ค้นหาสมาชิกตาม keyword
    /// เช็คทั้ง Name, Gmail และ Phone
    /// ถ้า keyword ว่าง จะคืนสมาชิกทั้งหมด
    /// </summary>
    public List<Member> SearchMembers(string keyword)
    {
        keyword = keyword?.Trim() ?? "";

        // ถ้าไม่กรอก keyword เลย ให้คืนสมาชิกทั้งหมด
        if (string.IsNullOrEmpty(keyword))
        {
            return Members.ToList(); // .ToList() เพื่อคืนสำเนา ไม่ใช่ List เดิมตรง ๆ
        }

        // Where = กรองตามเงื่อนไข
        // Contains แบบไม่สนใจตัวใหญ่เล็ก
        return Members
            .Where(m =>
                m.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.Gmail.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// เพิ่มสมาชิกใหม่
    /// ตรวจสอบ:
    /// - ชื่อห้ามว่าง
    /// - Gmail ห้ามว่าง และห้ามซ้ำกับสมาชิกคนอื่น
    /// ถ้าสำเร็จ: return true และส่งข้อความ "เพิ่มสมาชิกเรียบร้อย"
    /// ถ้าไม่สำเร็จ: return false และส่งข้อความ error
    /// </summary>
    public bool AddMember(
        string name,
        string gmail,
        string phone,
        string address,
        out string message)
    {
        // ตัดช่องว่างหัวท้ายออกก่อน
        name = name.Trim();
        gmail = gmail.Trim();
        phone = phone.Trim();
        address = address.Trim();

        // ตรวจว่าได้กรอกชื่อหรือยัง
        if (string.IsNullOrEmpty(name))
        {
            message = "กรุณากรอกชื่อสมาชิก";
            return false;
        }

        // ตรวจว่าได้กรอก Gmail หรือยัง
        if (string.IsNullOrEmpty(gmail))
        {
            message = "กรุณากรอก Gmail";
            return false;
        }

        // เช็คว่ามี Gmail นี้อยู่แล้วในระบบหรือไม่ (กันสมาชิกซ้ำ)
        if (Members.Any(m => m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase)))
        {
            message = "มี Gmail นี้ในระบบแล้ว";
            return false;
        }

        // สร้าง Id ใหม่ โดยเอา Id สูงสุดเดิม + 1
        int newId = Members.Count == 0 ? 1 : Members.Max(m => m.Id) + 1;

        // สร้าง object Member ใหม่
        var member = new Member
        {
            Id = newId,
            Name = name,
            Gmail = gmail,
            Phone = phone,
            Address = address,
            RegisterDate = DateTime.Now,  // บันทึกวันที่สมัครเป็นเวลาปัจจุบัน
            IsActive = true               // สมาชิกใหม่เป็น Active เสมอ
        };

        // เพิ่มลงใน List และเซฟลงไฟล์
        Members.Add(member);
        Save();

        message = "เพิ่มสมาชิกเรียบร้อย";
        return true;
    }

    /// <summary>
    /// แก้ไขข้อมูลสมาชิกที่มีอยู่แล้ว
    /// - รับ id ของสมาชิกที่จะเปลี่ยน
    /// - รับข้อมูลใหม่ (name, gmail, phone, address, isActive)
    /// - เช็คว่ามี Gmail ซ้ำกับคนอื่นหรือไม่
    /// </summary>
    public bool UpdateMember(
        int id,
        string name,
        string gmail,
        string phone,
        string address,
        bool isActive,
        out string message)
    {
        // หา member ตาม id
        var member = GetMemberById(id);
        if (member == null)
        {
            message = "ไม่พบสมาชิก";
            return false;
        }

        // ตัดช่องว่าง
        name = name.Trim();
        gmail = gmail.Trim();
        phone = phone.Trim();
        address = address.Trim();

        // ตรวจชื่อ
        if (string.IsNullOrEmpty(name))
        {
            message = "กรุณากรอกชื่อสมาชิก";
            return false;
        }

        // ตรวจ Gmail
        if (string.IsNullOrEmpty(gmail))
        {
            message = "กรุณากรอก Gmail";
            return false;
        }

        // เช็ค Gmail ซ้ำกับสมาชิกคนอื่น (ยกเว้นตัวเอง)
        bool gmailUsedByOther = Members.Any(m =>
            m.Id != id &&
            m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase));

        if (gmailUsedByOther)
        {
            message = "Gmail นี้ถูกใช้โดยสมาชิกคนอื่นแล้ว";
            return false;
        }

        // อัปเดตข้อมูลใน object เดิม
        member.Name = name;
        member.Gmail = gmail;
        member.Phone = phone;
        member.Address = address;
        member.IsActive = isActive;

        // เซฟลงไฟล์
        Save();

        message = "แก้ไขข้อมูลสมาชิกเรียบร้อย";
        return true;
    }

    /// <summary>
    /// ระงับสมาชิก (เปลี่ยน IsActive = false)
    /// ใช้ในกรณีที่ไม่ต้องการให้สมาชิกคนนี้ใช้งานต่อ
    /// </summary>
    public bool DeactivateMember(int id, out string message)
    {
        var member = GetMemberById(id);
        if (member == null)
        {
            message = "ไม่พบสมาชิก";
            return false;
        }

        if (!member.IsActive)
        {
            message = "สมาชิกคนนี้ถูกระงับอยู่แล้ว";
            return false;
        }

        // เปลี่ยนสถานะเป็นไม่ Active
        member.IsActive = false;
        Save();

        message = "ระงับสมาชิกเรียบร้อย";
        return true;
    }

    /// <summary>
    /// ลบสมาชิกออกจากระบบโดยตรง
    /// </summary>
    public bool DeleteMember(int id, out string message)
    {
        var member = GetMemberById(id);
        if (member == null)
        {
            message = "ไม่พบสมาชิก";
            return false;
        }

        // จุดนี้สามารถเชื่อมกับ Library เพื่อตรวจว่า member ยังยืมหนังสืออยู่หรือเปล่า
        // ถ้ายังยืมอยู่ อาจจะไม่อนุญาตให้ลบ

        Members.Remove(member);
        Save();

        message = "ลบสมาชิกเรียบร้อย";
        return true;
    }
}