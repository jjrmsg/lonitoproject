using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Events4ALL.Auxiliares;
using Events4ALL.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;

namespace Events4ALL.CAD
{
    class PromocionCAD
    {
        public struct Lista
        {
            public int id;
            public string titulo;
        }

        public ArrayList ObtenerEspectaculos()
        {
            ArrayList espec = new ArrayList();
            Lista l;

            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {

                c.Open();
                SqlCommand cmd = new SqlCommand("select * from Espectaculo", c);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    l.id = Convert.ToInt32(dr["IDEspectaculo"]);
                    l.titulo = dr["Titulo"].ToString();
                    espec.Add(l);
                }

                dr.Close();
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }
            return espec;
        }
    }
}
