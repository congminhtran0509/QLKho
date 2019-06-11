using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        string name;
        string password;

        public string Name { get { return name; } set { name = value; } }
        public string Passwd { get { return password; } set { password = value; } }

        public TaiKhoan() { }
        public TaiKhoan(string ten, string mk)
        {
            Name = ten;
            Passwd = mk;
        }
    }
}
