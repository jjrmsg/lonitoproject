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
        public BD bd;
        #endregion

        public VentasCAD()
        {
            bd = new BD();
        }

        public DataSet getAllEspectaculos()
        {
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                datosVentas = new DataSet();
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
