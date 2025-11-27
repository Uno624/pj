using pj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

public class MemberManager
{
    private const string MemberFile = "members.json";

    public List<Member> Members { get; private set; } = new List<Member>();

    public MemberManager()
    {
        Load();
    }

    public void Load()
    {
        if (!File.Exists(MemberFile))
        {
            Members = new List<Member>();
            return;
        }

        try
        {
            string json = File.ReadAllText(MemberFile);
            var list = JsonSerializer.Deserialize<List<Member>>(json);
            Members = list ?? new List<Member>();
        }
        catch
        {
            Members = new List<Member>();
        }
    }

    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(Members, options);
        File.WriteAllText(MemberFile, json);
    }

    public Member? GetMemberById(int id)
    {
        return Members.FirstOrDefault(m => m.Id == id);
    }

    public Member? GetMemberByGmail(string gmail)
    {
        return Members.FirstOrDefault(m => m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase));
    }

    public List<Member> SearchMembers(string keyword)
    {
        keyword = keyword?.Trim() ?? "";
        if (string.IsNullOrEmpty(keyword))
        {
            return Members.ToList();
        }

        return Members
            .Where(m =>
                m.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.Gmail.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public bool AddMember(string name, string gmail, string phone, string address, out string message)
    {
        name = name.Trim();
        gmail = gmail.Trim();
        phone = phone.Trim();
        address = address.Trim();

        if (string.IsNullOrEmpty(name))
        {
            message = "กรุณากรอกชื่อสมาชิก";
            return false;
        }

        if (string.IsNullOrEmpty(gmail))
        {
            message = "กรุณากรอก Gmail";
            return false;
        }

        if (Members.Any(m => m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase)))
        {
            message = "มี Gmail นี้ในระบบแล้ว";
            return false;
        }

        int newId = Members.Count == 0 ? 1 : Members.Max(m => m.Id) + 1;

        var member = new Member
        {
            Id = newId,
            Name = name,
            Gmail = gmail,
            Phone = phone,
            Address = address,
            RegisterDate = DateTime.Now,
            IsActive = true
        };

        Members.Add(member);
        Save();

        message = "เพิ่มสมาชิกเรียบร้อย";
        return true;
    }

    public bool UpdateMember(int id, string name, string gmail, string phone, string address, bool isActive, out string message)
    {
        var member = GetMemberById(id);
        if (member == null)
        {
            message = "ไม่พบสมาชิก";
            return false;
        }

        name = name.Trim();
        gmail = gmail.Trim();
        phone = phone.Trim();
        address = address.Trim();

        if (string.IsNullOrEmpty(name))
        {
            message = "กรุณากรอกชื่อสมาชิก";
            return false;
        }

        if (string.IsNullOrEmpty(gmail))
        {
            message = "กรุณากรอก Gmail";
            return false;
        }

        // เช็ค Gmail ซ้ำกับคนอื่น
        if (Members.Any(m => m.Id != id &&
                             m.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase)))
        {
            message = "Gmail นี้ถูกใช้โดยสมาชิกคนอื่นแล้ว";
            return false;
        }

        member.Name = name;
        member.Gmail = gmail;
        member.Phone = phone;
        member.Address = address;
        member.IsActive = isActive;

        Save();
        message = "แก้ไขข้อมูลสมาชิกเรียบร้อย";
        return true;
    }

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

        member.IsActive = false;
        Save();

        message = "ระงับสมาชิกเรียบร้อย";
        return true;
    }

    public bool DeleteMember(int id, out string message)
    {
        var member = GetMemberById(id);
        if (member == null)
        {
            message = "ไม่พบสมาชิก";
            return false;
        }

        // ถ้าอยากกันไม่ให้ลบสมาชิกที่ยังยืมหนังสืออยู่
        // ตรงนี้สามารถเชื่อมกับ Library เพื่อตรวจสอบได้

        Members.Remove(member);
        Save();

        message = "ลบสมาชิกเรียบร้อย";
        return true;
    }
}