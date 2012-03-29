using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Events4ALL.Auxiliares;
using System.Data;

namespace Events4ALL.CAD
{
    public class VentasCAD
    {
        #region members
        #endregion

        public VentasCAD()
        {
        }

        public DataSet getAllEspectaculos()
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select IDEspectaculo, FechaVenta from Ventas", c);
                da.Fill(datosVentas);
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            return datosVentas;
        }
    }
}
