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
        public PromocionCAD()
        {
        }

        public DataSet ObtenerEspectaculos()
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Espectaculo", c);
                da.Fill(bdvirtual, "Espectaculo");
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }
            return bdvirtual;
        }
    }
}
