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
using Events4ALL.Auxiliares;

namespace Events4ALL
{
    public partial class Estadisticas : UserControl
    {
        public Estadisticas()
        {
            InitializeComponent();
            BD bd = new BD();
            SqlConnection c = bd.Connect();

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
            }
            catch
            {
                prueba.Text = "Error";
            }
            finally
            {
                c.Close();
            }
        }
    }
}
