using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Events4ALL.Auxiliares;
using System.Windows.Forms;
using Events4ALL.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;

namespace Events4ALL.CAD
{
    
    class CondicionCAD
    {

        public DataSet ObtenerTodas()
        {
            BD bd = new BD();
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlConnection con = bd.Connect();
                
                SqlDataAdapter da = new SqlDataAdapter("select * from Condicion", con);
                da.Fill(bdvirtual, "Condicion");

                /*dr.Read();
                while (dr.Read())
                {
                    condicion.IdCondicion = Convert.ToInt32(dr["ID_Condicion"]);
                    condicion.Nombre = dr["Nombre"].ToString();
                    condicion.Descipcion = dr["Descripcion"].ToString();
                    condicion.TCondicion1 = Convert.ToInt32(dr["TCondicion1"]);
                    condicion.Comparacion1 = Convert.ToInt32(dr["Comparacion1"]);
                    condicion.Cantidad1 = Convert.ToInt32(dr["Cantidad1"]);
                    condicion.Descuento1 = Convert.ToInt32(dr["Descuento1"]);
                    condicion.TEvento1 = Convert.ToInt32(dr["TEvento1"]);
                    condicion.TCondicion2 = Convert.ToInt32(dr["TCondicion2"]);
                    condicion.Comparacion2 = Convert.ToInt32(dr["Comparacion2"]);
                    condicion.Cantidad2 = Convert.ToInt32(dr["Cantidad2"]);
                    condicion.Descuento2 = Convert.ToInt32(dr["Descuento2"]);
                    condicion.TEvento2 = Convert.ToInt32(dr["TEvento2"]);
                    condicion.TCondicion3 = Convert.ToInt32(dr["TCondicion3"]);
                    condicion.Comparacion3 = Convert.ToInt32(dr["Comparacion3"]);
                    condicion.Cantidad3 = Convert.ToInt32(dr["Cantidad3"]);
                    condicion.Descuento3 = Convert.ToInt32(dr["Descuento3"]);
                    condicion.TEvento3 = Convert.ToInt32(dr["TEvento3"]);
                    res.Add(condicion);
                }*/
            }
            catch (Exception ex)
            {
               MessageBox.Show("PENE"+ex.Message);
            }
            finally
            {
               // c.Close();
            }

            return bdvirtual;
        }
    }
}
