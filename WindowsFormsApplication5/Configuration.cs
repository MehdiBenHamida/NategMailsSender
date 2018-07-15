using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    static class Config
    {
        static private string _mail { get; set; }
        static private string _password { get; set; }

        public static string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
     
    }
}
