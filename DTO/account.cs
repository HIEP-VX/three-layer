using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class account
    {
        private int id_account;
        private string user_name;
        private string password;
        private int typeAccount;

        public int Id_account { get => id_account; set => id_account = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public int TypeAccount { get => typeAccount; set => typeAccount = value; }

        public account(int id_account, string user_name, string password, int typeAccount)
        {
            this.id_account = id_account;
            this.user_name = user_name;
            this.password = password;
            this.typeAccount = typeAccount;
        }

        public account() { }
    }
}
