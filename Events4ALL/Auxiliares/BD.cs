using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace Events4ALL.Auxiliares
{
    public class BD
    {
        public BD()
        {

        }

        public SqlConnection Connect()
        {
            string dbDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\Events4ALL\Events4ALL\Events4AllDB.mdf";
            string s = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + dbDirectory + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection c = new SqlConnection(s);
            return c;
        }
    }
}
