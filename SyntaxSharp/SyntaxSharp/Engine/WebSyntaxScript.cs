using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSharp.Engine
{
    // Hookup WebSyntaxScript with the other ones, so we can access them
    public class WebSyntaxScript : ConverterSyntaxScript
    {
        public static string downloadString(string url)
        {
            if (url.Contains("https://"))
            {
                return new WebClient().DownloadString(url);
            }
            else
            {
                return "Url is not a valid url";
            }
        }

        public static void openUrl(string url)
        {
            if (url.Contains("https://"))
            {
                Process.Start(url);
            }
            else
            {
                GeneralSyntaxScript.print("Not a valid url.");
            }
        }

        public static void downloadFile(string url, string path)
        {
            new WebClient().DownloadFile(url, path);
        }
        public static void uploadFile(string url, string fileName)
        {
            new WebClient().UploadFile(url, fileName);
        }
    }
}
