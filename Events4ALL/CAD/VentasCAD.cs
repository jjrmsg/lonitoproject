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

        public DataSet getVentasEspectaculo(string titulo)
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(e.Precio) Recaudacion, count(*) Entradas from Ventas v, Espectaculo e where e.Titulo='"+titulo+"' and e.IDEspectaculo=v.IDEspectaculo", c);
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

        public DataSet ObtenerRanking(char orden)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da;
                if (orden == 'd')
                {
                    da = new SqlDataAdapter("select e.Titulo, count(*) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo group by e.Titulo order by Entradas DESC;", c);
                }
                else
                {
                    da = new SqlDataAdapter("select e.Titulo, count(*) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo group by e.Titulo order by Entradas asc;", c);
                }
                da.Fill(bdvirtual);
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

        public DataSet BuscarVenta(string nombre, string dni, string titulo, string tipo, string fEsp, string fVenta)
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();
            
            String query = "SELECT Ventas.IDVentas IdVenta, Cliente.Nombre, Cliente.NIF, Espectaculo.Titulo, Sala.tipo Tipo, Ventas.FechaVenta ";
            query += "FROM Cliente RIGHT OUTER JOIN ";
            query += "Ventas ON Cliente.NIF = Ventas.IDCliente LEFT OUTER JOIN ";
            query += "ReservaSala INNER JOIN ";
            query += "Sala ON ReservaSala.IDSala = Sala.NumSala INNER JOIN ";
            query += "Espectaculo ON ReservaSala.IDEspectaculo = Espectaculo.IDEspectaculo ON Ventas.IDEspectaculo = Espectaculo.IDEspectaculo WHERE (''='') ";

            if (nombre != "")
                query += "and Cliente.Nombre like '%" + nombre + "%' ";
            
            if (dni != "")
                query += "and Cliente.NIF like '%" + dni + "%' ";
            
            if (titulo != "")
                query += "and Espectaculo.Titulo like '%" + titulo + "%' ";

            if (tipo != "")
                query += "and Sala.tipo = '" + tipo + "' ";

            if (fEsp != "")
                query += "and Espectaculo.FechaIni <= '" + fEsp + "' and Espectaculo.FechaFin >= '" + fEsp + "' ";

            if (fVenta != "")
                query += "and Ventas.FechaVenta = '" + fVenta + "' ";

            Console.WriteLine(query);

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, c);
                da.Fill(datosVentas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                c.Close();
            }

            return datosVentas;
        }



        public bool EliminarVenta(string idVenta)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            String comEspectaculo = "DELETE FROM Ventas WHERE IDVentas = '" + idVenta + "'";

            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand com = new SqlCommand(comEspectaculo, conn);
                return com.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                // Captura la condición general y la reenvía. 
                throw ex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }
        }
    }
}
