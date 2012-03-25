using System;
using System.Collections.Generic;
using System.Linq;
using Events4ALL.Auxiliares;
using System.Text;
using System.Data.SqlClient;

namespace Events4ALL.CAD
{
    class AdminCAD
    {
        public bool CompruebaExistenciaUsuario(string nuevo)
        {
            bool existe = false;
            
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("select count(*) ex from Administrador where Usuario='"+ nuevo +"'" , c);
                SqlDataReader dr = com.ExecuteReader();

                while(dr.Read())
                {
                   
                }

                dr.Close();
            }
            catch
            {}
            finally
            {
                c.Close();
            }
            
            return existe;
        }
    }
}
