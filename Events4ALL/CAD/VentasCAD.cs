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
                SqlDataAdapter da = new SqlDataAdapter("select * from Ventas v, Espectaculo e, Sala s, ReservaSala r where e.IDEspectaculo=v.IDEspectaculo and e.IDEspectaculo=r.IDEspectaculo and s.NumSala=r.IDSala", c);
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

        public DataSet getEstadisticasCliente(string nif)
        {
            BD bd = new BD();
            DataSet datos = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(Precio) Dinero, count(v.IDEspectaculo) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo and v.IDCliente='"+nif+"'", c);
                da.Fill(datos);
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            return datos;
        }

        public DataSet getEspectaculosCliente(string nif)
        {
            BD bd = new BD();
            DataSet datos = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select count(distinct IDEspectaculo) Espectaculos from Ventas where IDCliente='"+nif+"'", c);
                da.Fill(datos);
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            return datos;
        }

        public DataSet getGeneroTipoCli(string nif)
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Ventas v, Espectaculo e, Sala s, ReservaSala r where e.IDEspectaculo=v.IDEspectaculo and e.IDEspectaculo=r.IDEspectaculo and s.NumSala=r.IDSala and v.IDCliente='"+nif+"'", c);
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
