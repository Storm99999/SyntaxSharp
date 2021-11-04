using SyntaxSharp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program : GeneralSyntaxScript
    { 
        static void Main(string[] args)
        {
            print("test");
            if (getKey(ConsoleKey.C) == true)
            {
                print("Cool!");
            }
            pause();
        }

        public static string str()
        {
            // ret is a return function currently being worked on
            ret("");
            return "N/A";
        }
    }
}
