using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeProiect
{
    class UsernameForm
    {
        static string Username;
        public static string uname
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }
    }
}
