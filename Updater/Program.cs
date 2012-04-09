using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("update.zip"))
            {
                FastZip fZip = new FastZip();
                fZip.ExtractZip("update.zip", "/", "");
            }
            System.Diagnostics.Process.Start("Events4ALL.exe");
        }
    }
}
