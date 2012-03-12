using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Events4ALL
{
    public partial class Estadisticas : UserControl
    {
        public Estadisticas()
        {
            InitializeComponent();
            string dbDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName+@"\Events4ALL\Events4ALL\DB\Events4AllDB.mdf";
            string s="Data Source=.\\SQLEXPRESS;AttachDbFilename="+dbDirectory+";Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection c = new SqlConnection(s);

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select * from Cliente", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    prueba.Text = dr["Nombre"].ToString();
                }

                dr.Close();
                c.Close();
            }
            catch
            {
                prueba.Text = "Error";
            }
            finally
            {
           
            }
        }
    }
}
