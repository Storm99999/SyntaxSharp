using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSharp.Engine
{
    // Hookup IOSyntaxScript with the other ones, so we can access them
    public class IOSyntaxScript : WebSyntaxScript
    {
        public static void writeBytes(string file, byte[] bytes, long offset, SeekOrigin origin)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite));
            writer.BaseStream.Seek(offset, origin);
            writer.Write(bytes);
            writer.Close();
        }

        public static string readAllText(string file)
        {
            return File.ReadAllText(file);
        }
        public static byte[] readAllBytes(string file)
        {
            return File.ReadAllBytes(file);
        }

        public static void writeAllText(string file, string content)
        {
            File.WriteAllText(file, content);
        }
        public static void writeAllBytes(string file, byte[] bytes)
        {
            File.WriteAllBytes(file, bytes);
        }
    }
}
