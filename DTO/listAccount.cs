using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class listAccount
    {
        private static listAccount instance;

        public static listAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new listAccount();
                return instance;
            }
            set => instance = value;
        }

        List<account> list;

        public List<account> accounts
        {
            get => list;
            set => list = value;
        }
    }
}
