using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class account
    {
        private string id_account;
        private string user_name;
        private string password;
        private int permission;

        public string Id_account { get => id_account; set => id_account = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public int Permission { get => permission; set => permission = value; }
    }
}
