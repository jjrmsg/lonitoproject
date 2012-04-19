using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.Auxiliares;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

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

        public bool Insertar(string titulo, string descripcion, string precio, string genero, string fechIni, string fechFin, string salaReserva, Image cartel)
        {
            byte[] pic = null;
            if (cartel != null)
            {
                MemoryStream tmpStream = new MemoryStream();
                cartel.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                tmpStream.Position = 0;
                pic = new byte[tmpStream.Length];
                tmpStream.Read(pic, 0, System.Convert.ToInt32(tmpStream.Length));
                pic = tmpStream.ToArray();
            }

            SqlConnection conn = null;
            BD bd = new BD();

            String comEspectaculo = "INSERT INTO Espectaculo (Titulo, Descripcion, Precio, Genero, FechaIni, FechaFin";
            if (cartel != null)
                comEspectaculo += ", Cartel";
            comEspectaculo += ") values ('" + titulo + "',";
            comEspectaculo += "'" + descripcion + "',";
            comEspectaculo += "'" + precio + "',";
            if (genero != "")
                comEspectaculo += "'" + genero + "',";
            else
                comEspectaculo += "NULL,";
            comEspectaculo += "'" + fechIni + "',";
            comEspectaculo += "'" + fechFin + "'";
            if (cartel != null)
                comEspectaculo += ",@pic";
            comEspectaculo += ");";

            comEspectaculo += "INSERT INTO ReservaSala (IDEspectaculo, IDSala) values (";
            comEspectaculo += "SCOPE_IDENTITY (),";
            comEspectaculo += "'" + salaReserva + "')";

            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand com = new SqlCommand(comEspectaculo, conn);
                if (cartel != null)
                    com.Parameters.AddWithValue("@pic", pic);
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

        public bool Editar(string titulo, string descripcion, string precio, string genero, string fechIni, string fechFin, string salaReserva, Image cartel, int idEspectaculo)
        {
            byte[] pic = null;
            if (cartel != null)
            {
                MemoryStream tmpStream = new MemoryStream();
                cartel.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                tmpStream.Position = 0;
                pic = new byte[tmpStream.Length];
                tmpStream.Read(pic, 0, System.Convert.ToInt32(tmpStream.Length));
                pic = tmpStream.ToArray();
            }

            SqlConnection conn = null;
            BD bd = new BD();

            String query = "UPDATE Espectaculo set ";
            query += "Titulo = '" + titulo + "'";
            query += ", Descripcion = '" + descripcion + "'";
            query += ", Precio = '" + precio + "'";
            query += ", Genero = '" + genero + "'";
            query += ", FechaIni = '" + fechIni + "'";
            query += ", FechaFin = '" + fechFin + "'";
            if (cartel != null)
                query += ", Cartel = @pic ";
            query += "WHERE IDEspectaculo = '" + idEspectaculo + "'";

            query += ";UPDATE ReservaSala set ";
            query += "IDSala = '" + salaReserva + "' ";
            query += "WHERE IDEspectaculo = " + idEspectaculo;

            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand com = new SqlCommand(query, conn);
                if (cartel != null)
                    com.Parameters.AddWithValue("@pic", pic);
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

            String comEspectaculo = "DELETE FROM Espectaculo WHERE IDEspectaculo = '"+idEspectaculo+"';";
            // comEspectaculo += "DELETE FROM Promocion WHERE ID_Promocion IN (SELECT ID_Promocion FROM PromocionConEvento WHERE ID_Evento = '"+idEspectaculo+"');";
            // comEspectaculo += "DELETE FROM PromocionConEvento WHERE ID_Evento = '" + idEspectaculo + "';";
            comEspectaculo += "DELETE FROM Ventas WHERE IDEspectaculo = '" + idEspectaculo + "';";

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
                    comandoCond = " esp.FechaIni <= '" + valFecha + "' and esp.FechaFin >= '" + valFecha + "'";
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

        public DataSet ObtenerEspectaculoPorID(string id)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();

            string query = "SELECT esp.*, tipo Tipo, NumSala IdSala ";
            query += "FROM  Espectaculo AS esp ";
            query += "LEFT OUTER JOIN ReservaSala res ";
            query += "ON res.IDEspectaculo = esp.IDEspectaculo ";
            query += "LEFT OUTER JOIN Sala AS sal ";
            query += "ON res.IDSala = sal.NumSala ";
            query += "WHERE esp.IDEspectaculo = "+id;
            
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, c);
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

        public Image ObtenerImagenEspectaculo(int id)
        {
            byte[] bImage = new byte[0];
            Image im = null;
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("select * from Espectaculo where IDEspectaculo='" + id + "'", c);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                bImage = (byte[])dr["Cartel"];

                if (bImage != null)
                {
                    MemoryStream ms = new MemoryStream(bImage);
                    im = Image.FromStream(ms, true, true);
                }
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }
            return im;
        }
    }
}
