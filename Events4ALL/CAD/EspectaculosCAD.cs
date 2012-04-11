using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.Auxiliares;
using System.Data.SqlClient;
using System.Data;

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

        public bool Insertar(string titulo, string descripcion, string precio, string genero, string fechIni, string fechFin, string salaReserva)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            String comEspectaculo = "INSERT INTO Espectaculo (Titulo, Descripcion, Cartel, Precio, Genero, FechaIni, FechaFin) values (";
            comEspectaculo += "'" + titulo + "',";
            comEspectaculo += "'" + descripcion + "',";
            comEspectaculo += "'0',";
            comEspectaculo += "'" + precio + "',";
            comEspectaculo += "'" + genero + "',";
            comEspectaculo += "'" + fechIni + "',";
            comEspectaculo += "'" + fechFin + "');";

            comEspectaculo += "INSERT INTO ReservaSala (IDEspectaculo, IDSala) values (";
            comEspectaculo += "SCOPE_IDENTITY (),";
            comEspectaculo += "'" + salaReserva + "')";
            
            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand com = new SqlCommand(comEspectaculo, conn);
                return com.ExecuteNonQuery() > 1;

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

        public bool Eliminar(string idEspectaculo)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            String comEspectaculo = "DELETE FROM Espectaculo WHERE IDEspectaculo = '"+idEspectaculo+"'";

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

        public DataSet Buscar(string tit, string sala, string tipo, string modFecha, string valFecha, string modPrecio, string valPrecio)
        {
            SqlConnection conn = null; 
            BD bd = new BD();

            DataSet datosSalas = null;
            String comando = "SELECT esp.IDEspectaculo Id, esp.Titulo, sal.tipo Tipo, sal.NumSala, esp.Precio, esp.FechaIni, esp.FechaFin ";
            comando += "FROM  Espectaculo AS esp ";
            comando += "LEFT OUTER JOIN ReservaSala resSal ";
            comando += "ON resSal.IDEspectaculo = esp.IDEspectaculo ";
            comando += "LEFT OUTER JOIN Sala AS sal ";
            comando += "ON resSal.IDSala = sal.NumSala ";

            bool condiciones = false;
            string comandoCond = "";
            
            if (tit != "")
            {
                comandoCond += " esp.Titulo like '%" + tit + "%'";
                condiciones = true;
            }
            if (sala != "")
            {
                if (condiciones == true)
                    comandoCond += " and";
                comandoCond += " sal.NumSala = '" + sala + "'";
                condiciones = true;
            }
            if (tipo != "")
            {
                if (condiciones == true)
                    comandoCond += " and";
                comandoCond += " sal.tipo = '" + tipo + "'";
                condiciones = true;
            }
            if (modFecha != "" && valFecha != "" )
            {               
                if (condiciones == true)
                    comandoCond += " and";

                if (modFecha == "igual a")
                    comandoCond = " esp.FechaIni > '" + valFecha + "' and esp.FechaFin < '" + valFecha + "'";
                else if (modFecha == "mayor que")
                    comandoCond = " esp.FechaIni > '" + valFecha + "'";
                else if (modFecha == "menor que")
                    comandoCond = " esp.FechaFin < '" + valFecha + "'";

                condiciones = true;
            }
            if (modPrecio != "" && valPrecio != "")
            {
                if (condiciones == true)
                    comandoCond += " and";

                if (modFecha == "igual a")
                    comandoCond = " esp.Precio = "+valPrecio;
                else if (modFecha == "mayor que")
                    comandoCond = " esp.Precio > " + valPrecio;
                else if (modFecha == "menor que")
                    comandoCond = " esp.Precio < " + valPrecio;

                condiciones = true;
            }
            if (condiciones == true)
            {
                comando = comando + "WHERE" + comandoCond;
            }


            try 
            {
                conn = bd.Connect();
                conn.Open();

                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, conn);
                datosSalas = new DataSet();
                sqlAdaptador.Fill(datosSalas);
                return datosSalas;
            } 
            catch (Exception ex) 
            { 
                // Captura la condición general y la reenvía. 
                throw ex; 
            } 
            finally 
            { 
                if(conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }        
        }

        public DataSet ObtenerEspectaculos()
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Espectaculo e, ReservaSala r, Sala s where e.IDEspectaculo=r.IDEspectaculo and r.IDSala=s.NumSala", c);
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

        public DataSet ObtenerDatosEspectaculo(string titulo)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Espectaculo e, ReservaSala r, Sala s where e.IDEspectaculo=r.IDEspectaculo and r.IDSala=s.NumSala and e.Titulo='"+titulo+"'", c);
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
    }
}
