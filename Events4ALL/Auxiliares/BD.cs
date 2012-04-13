using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Events4ALL.Auxiliares
{
    public class BD
    {
        public BD()
        {

        }

        public SqlConnection Connect()
        {
            /*AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData));
            Console.WriteLine("#########Datadirectory es: "+AppDomain.CurrentDomain.GetData("DataDirectory"));
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Events4AllDB.mdf ;Integrated Security=True;User Instance=True";
            SqlConnection c = new SqlConnection(s);
            return c;*/
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine("#########Datadirectory es: " + AppDomain.CurrentDomain.GetData("DataDirectory"));
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Events4AllDB.mdf ;Integrated Security=True;User Instance=True";
            SqlConnection c = new SqlConnection(s);
            return c;
        }
    }
}
