using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSharp.Engine
{
    // Hookup GeneralSyntaxScript with the other ones, so we can access them
    public class GeneralSyntaxScript : IOSyntaxScript
    {
        public static void print(string text)
        {
            Console.WriteLine(text);
        }
        public static void pause()
        {
            Console.ReadLine();
        }

        public static void setColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static bool getKey(ConsoleKey key)
        {
            ConsoleKeyInfo ki = Console.ReadKey();
            if (ki.Key == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string readcurrLine()
        {
            var input = Console.ReadLine();
            return input;
        }

        public static object ret(object obj)
        {
            return obj;
        }
    }
}
