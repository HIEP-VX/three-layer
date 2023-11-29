using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class user
    {
        public static int id { get; set; }
        public static string user_name { get; set; }   // tên tài khoản
        public static string permission { get; set; }    // quyền hạn
        public static string position { get; set; }    // chức vụ
        public static string account { get; set; }       // tai khoan
        public static string password { get; set; }      // mat khau
        public static string welcome { get; set; }
    }
}
