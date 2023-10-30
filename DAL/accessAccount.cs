using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class accessAccount:AccessData
    {
        public string checkLogin (account acc)
        {
            string info = checkLoginDTO(acc);
            return info;
        }
    }
}
