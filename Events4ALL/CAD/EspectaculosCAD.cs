using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.Auxiliares;
using System.Data.SqlClient;

namespace Events4ALL.CAD
{
    public class EspectaculosCAD
    {
        #region members
        #endregion

        public EspectaculosCAD()
        {
        }

        public decimal getPrecioId(int id)
        {
            BD bd = new BD();
            decimal precio = 0;

            SqlConnection c = bd.Connect();
            c.Open();
            SqlCommand cmd = new SqlCommand("select Precio from Espectaculo where IDEspectaculo='"+id+"'", c);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                precio=(decimal) dr["precio"];
            }

            dr.Close();
            c.Close();
            return precio;
        }
    }
}
