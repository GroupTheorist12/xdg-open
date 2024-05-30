using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace xdg_open
{
   class Program
   {
      public static void OpenBrowser(string url)
      {
         if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
         {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
         {
            Process.Start("xdg-open", url);
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
         {
            Process.Start("open", url);
         }
         else
         {
            throw new System.Exception("Unsupported operating system.");
         }
      }
      static void Main(string[] args)
      {
         if(args.Length == 1)
         {
            OpenBrowser(args[0]);
         }
         else
         {
            Console.WriteLine("usage is xdg-open url");
         }
      }
   }
}
