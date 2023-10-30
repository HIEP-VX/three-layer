using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class permission
    {
        private int id_permission;
        private string permission_name;

        public int Id_permission { get => id_permission; set => id_permission = value; }
        public string Permission_name { get => permission_name; set => permission_name = value; }
    }
}
