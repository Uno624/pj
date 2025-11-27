using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj
{
    internal class AppData
    {
        public static Library Library { get; } = new Library();
        public static MemberManager MemberManager { get; } = new MemberManager();

        static AppData()
        {
            Library.Load();
        }
    }
}
