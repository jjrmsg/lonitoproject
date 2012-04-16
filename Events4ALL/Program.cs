using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Events4ALL
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*string sourcePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string targetPath =  System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string sourceFile = System.IO.Path.Combine(sourcePath, "Events4AllDB.mdf");
            string destFile = System.IO.Path.Combine(targetPath, "Events4AllDB.mdf");
            System.IO.File.Copy(sourceFile, destFile, true);*/

            // Guardamos en DataDirectory la ruta de la BD a la que debe apuntar la cadena de conexion
            var dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
            var absoluteDataDirectory = Path.GetFullPath(dataDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
