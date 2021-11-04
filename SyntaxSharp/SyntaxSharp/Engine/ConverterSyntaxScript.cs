using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSharp.Engine
{
    public class ConverterSyntaxScript
    {
        public static int convertToInt32(string val)
        {
            return Convert.ToInt32(val);
        }

        public static string convertToString(object obj)
        {
            return Convert.ToString(obj);
        }

        public static string convertToBase64(byte[] obj)
        {
            return Convert.ToBase64String(obj);
        }

        public static char convertToChar(object obj)
        {
            return Convert.ToChar(obj);
        }
    }
}
