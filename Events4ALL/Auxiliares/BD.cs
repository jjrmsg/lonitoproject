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
            string s = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|Events4AllDB.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection c = new SqlConnection(s);
            return c;
        }
    }
}
