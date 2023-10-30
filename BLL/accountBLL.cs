using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class accountBLL
    {
        accessAccount aac = new accessAccount();
        public string checkLogin(account acc)
        {
            // kiem tra nghiep vu
            if(acc.User_name == "")
            {
                return "required_account";
            }

            if (acc.Password == "")
            {
                return "required_password";
            }

            string info = aac.checkLogin(acc);
            return info;
        }
    }
}
