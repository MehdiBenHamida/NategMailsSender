using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NategMailsSender
{
    static class Config
    {
        static private string _mail { get; set; } = "mail@example.com";
        static private string _password { get; set; } = "12345";
        static private char _delimiter { get; set; } = ',';
        static private string _receiversFilePath { get; set; }

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
        public static char Delimiter
        {
            get { return _delimiter; }
            set { _delimiter = value; }
        }
        public static string ReceiversFilePath
        {
            get { return _receiversFilePath; }
            set { _receiversFilePath = value; }
        }
     
    }
}
