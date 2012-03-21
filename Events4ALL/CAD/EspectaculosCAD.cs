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
        BD bd;
        #endregion

        public EspectaculosCAD()
        {
            bd = new BD();
        }

        public decimal getPrecioId(int id)
        {
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
