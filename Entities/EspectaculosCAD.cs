using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Auxiliares;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace Entities
{
    public class EspectaculosCAD
    {
        // Constructor por defecto del CAD de espectáculos.
        public EspectaculosCAD()
        {
        }

        // Obtiene de la BD el precio de un espectáculo a partir de su id y lo devuelve.
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

        // Inserta un espectáculo en la BD a partir de unos datos y devuelve true si la inserción se completa correctamente.
        public bool Insertar(string titulo, string descripcion, string media, string precio, string genero, string fechIni, string fechFin, string salaReserva, string horarios, Image cartel)
        {
            // Tranformamos el cartel del espectáculo a un array de bytes.
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

            // Declaramos la conexión,
            SqlConnection conn = null;
            BD bd = new BD();

            // Creamos la query a partir de los datos.
            String comEspectaculo = "INSERT INTO Espectaculo (Titulo, Descripcion, Media, Precio, Genero, FechaIni, FechaFin, Horarios";
            if (cartel != null)
                comEspectaculo += ", Cartel";
            comEspectaculo += ") values (@titulo, @desc, @media, @precio, @genero, @fechIni, @fechFin, @hor";
            if (cartel != null)
                comEspectaculo += ", @pic";
            comEspectaculo += ");";

            comEspectaculo += "INSERT INTO ReservaSala (IDEspectaculo, IDSala) values (";
            comEspectaculo += "SCOPE_IDENTITY (),";
            comEspectaculo += "'" + salaReserva + "')";

            // Abre la conexión e inserta el espectáculo.
            try
            {
                conn = bd.Connect();
                conn.Open();
                
                // Creamos el comando SQL sustituyendo los valores de forma segura 
                // escapando carácteres no validos.
                SqlCommand com = new SqlCommand(comEspectaculo, conn);
                com.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = titulo;
                com.Parameters.Add("@desc", SqlDbType.NVarChar).Value = descripcion;
                com.Parameters.Add("@media", SqlDbType.Text).Value = media;
                com.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
                if (genero != "")   // Si tiene genero
                    com.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
                else
                    com.Parameters.Add("@genero", SqlDbType.VarChar).Value = System.DBNull.Value;
                com.Parameters.Add("@fechIni", SqlDbType.Date).Value = fechIni;
                com.Parameters.Add("@fechFin", SqlDbType.Date).Value = fechFin;
                com.Parameters.Add("@hor", SqlDbType.NVarChar).Value = horarios;
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

        // Edita un espectáculo en la BD a partir de unos datos y devuelve true si la edición se completa correctamente.
        public bool Editar(string titulo, string descripcion, string media, string precio, string genero, string fechIni, string fechFin, string salaReserva, string horarios, Image cartel, int idEspectaculo)
        {
            // Tranformamos el cartel del espectáculo a un array de bytes.
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

            // Declaramos la conexión
            SqlConnection conn = null;
            BD bd = new BD();

            // Creamos la query a partir de los datos.
            String query = "UPDATE Espectaculo set ";
            query += "Titulo = @titulo, Descripcion = @desc, Media = @media, Precio = @precio, Genero = @genero";
            query += ", FechaIni = @fechIni, FechaFin = @fechFin, Horarios = @hor";
            if (cartel != null)
                query += ", Cartel = @pic ";
            query += " WHERE IDEspectaculo = '" + idEspectaculo + "'";
            // Guardamos también la reserva de la sala
            query += ";UPDATE ReservaSala set IDSala = '" + salaReserva + "' ";
            query += "WHERE IDEspectaculo = " + idEspectaculo;

            // Abre la conexión y ejecuta la query.
            try
            {
                conn = bd.Connect();
                conn.Open();

                // Creamos el comando SQL sustituyendo los valores de forma segura 
                // escapando carácteres no validos.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = titulo;
                com.Parameters.Add("@desc", SqlDbType.NVarChar).Value = descripcion;
                com.Parameters.Add("@media", SqlDbType.Text).Value = media;
                com.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
                if (genero != "")   // Si tiene genero
                    com.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
                else
                    com.Parameters.Add("@genero", SqlDbType.VarChar).Value = System.DBNull.Value;
                com.Parameters.Add("@fechIni", SqlDbType.Date).Value = fechIni;
                com.Parameters.Add("@fechFin", SqlDbType.Date).Value = fechFin;
                com.Parameters.Add("@hor", SqlDbType.NVarChar).Value = horarios;
                if (cartel != null) // Si tiene carterl
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
        
        // Elimina un espectaculo, sus ventas y sus promociones a partir de ua id.
        public bool Eliminar(string idEspectaculo)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            // Declaración de la query.
            String comEspectaculo = "DELETE FROM Espectaculo WHERE IDEspectaculo = '"+idEspectaculo+"';";
            comEspectaculo += "DELETE FROM PromocionConEvento WHERE ID_Evento = '" + idEspectaculo + "';";
            comEspectaculo += "DELETE FROM Ventas WHERE IDEspectaculo = '" + idEspectaculo + "';";

            // Abre la conexión y ejecuta la cadena.
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

        // Busca y devuelve espectáculos de la bd que cumplen unas restricciones.
        public DataSet Buscar(string tit, string sala, string tipo, string modFecha, string valFecha, string modPrecio, string valPrecio)
        {
            SqlConnection conn = null; 
            BD bd = new BD();                        
            DataSet datosSalas = null;

            // Creamos la query.
            String comando = "SELECT esp.IDEspectaculo Id, esp.Titulo, sal.tipo Tipo, sal.NumSala, esp.Precio, esp.FechaIni, esp.FechaFin ";
            comando += "FROM  Espectaculo AS esp ";
            comando += "LEFT OUTER JOIN ReservaSala resSal ";
            comando += "ON resSal.IDEspectaculo = esp.IDEspectaculo ";
            comando += "LEFT OUTER JOIN Sala AS sal ";
            comando += "ON resSal.IDSala = sal.NumSala WHERE (''='') ";
            
            // Decartamos los campos vacios.
            if (tit != "")
                comando += " and esp.Titulo like '%'+@titulo+'%'";
            if (sala != "")
                comando += " and sal.NumSala = '"+sala+"'";
            if (tipo != "")
                comando += " and sal.tipo = '" + tipo + "'";

            if (modFecha != "" && valFecha != "" )
            {               
                if (modFecha == "igual a")
                    comando += " and esp.FechaIni <= '" + valFecha + "' and esp.FechaFin >= '" + valFecha + "'";
                else if (modFecha == "mayor que")
                    comando += " and esp.FechaIni >= '" + valFecha + "'";
                else if (modFecha == "menor que")
                    comando += " and esp.FechaFin <= '" + valFecha + "'";
            }
            if (modPrecio != "" && valPrecio != "")
            {
                if (modPrecio == "igual a")
                    comando += " and esp.Precio = " + valPrecio;
                else if (modPrecio == "mayor que")
                    comando += " and esp.Precio > " + valPrecio;
                else if (modPrecio == "menor que")
                    comando += " and esp.Precio < " + valPrecio;
            }

            // Crea la conexión con la BD y recoge los datos.
            try 
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(comando, conn);
                if (tit != "")
                    com.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = tit;

                SqlDataAdapter sqlAdaptader = new SqlDataAdapter();
                sqlAdaptader.SelectCommand = com;
                                
                datosSalas = new DataSet();
                sqlAdaptader.Fill(datosSalas);                
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
            return datosSalas;
        }

        // Obtiene los datos de un espectáculo de la BD a partir de su id.
        public DataSet ObtenerEspectaculoPorID(string id)
        {
            // Declaramos la conexion
            BD bd = new BD();
            SqlConnection conn = null;
            DataSet bdvirtual = new DataSet();

            // Creamos la query
            string query = "SELECT esp.IDEspectaculo, esp.Titulo, esp.Descripcion, esp.FechaIni, esp.FechaFin, esp.Precio, esp.Genero, esp.Horarios, esp.Cartel, esp.Media, esp.LinkInfo, "; 
            query += "sal.tipo AS Tipo, sal.NumSala AS IdSala, AVG(Votos.nota) AS NotMedia "; 
            query += "FROM Espectaculo AS esp LEFT OUTER JOIN "; 
            query += "Votos ON esp.IDEspectaculo = Votos.idEspectaculo LEFT OUTER JOIN "; 
            query += "ReservaSala AS res ON res.IDEspectaculo = esp.IDEspectaculo LEFT OUTER JOIN "; 
            query += "Sala AS sal ON res.IDSala = sal.NumSala ";
            query += "WHERE esp.IDEspectaculo = " + id;
            query += "GROUP BY esp.IDEspectaculo, esp.Titulo, esp.Descripcion, esp.FechaIni, esp.FechaFin, esp.Precio, esp.Genero, esp.Horarios, esp.Cartel, esp.Media, esp.LinkInfo, sal.tipo, sal.NumSala "; 

            try
            {
                conn = bd.Connect();

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(bdvirtual);
            }
            catch (Exception ex) 
            {
                // Captura la condición general y la reenvía. 
                throw ex; 
            }
            finally
            {
                conn.Close();
            }
            return bdvirtual;
        }

        /* - */
        // Obtiene los espectáculos de la BD.
        public DataSet ObtenerEspectaculos()
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Espectaculo e, ReservaSala r, Sala s where e.IDEspectaculo=r.IDEspectaculo and r.IDSala=s.NumSala order by e.IDEspectaculo desc", c);
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

        // Obtiene los datos de un espectáculo de la BD a partir de su titulo.
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

        // Obtiene los datos de un espectáculo de la BD que tengan una fecha posterior a la indicada.
        public DataSet ObtenerEspectaculosNuevos(string fecha)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Espectaculo e, ReservaSala r, Sala s where e.IDEspectaculo=r.IDEspectaculo and r.IDSala=s.NumSala and e.FechaFin>='"+fecha+"'", c);
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

        // Obtiene el cartel de un espectáculo de la BD a partir de su id.
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

        //obtiene una lista ordenada ascendente de los espectaculos segun el tipo
        public DataSet ObtenerEspectaculoPorTipo(string tipo)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da;
                string cadena = "select e.Titulo, e.IDEspectaculo, e.Descripcion, e.FechaIni, e.FechaFin, e.Horarios from Ventas v, Espectaculo e, Sala s, ReservaSala rs where v.IDEspectaculo=e.IDEspectaculo and s.NumSala=rs.IDSala and e.IDEspectaculo=rs.IDEspectaculo and s.tipo='" + tipo;
                cadena = cadena + "'group by e.Titulo, e.IDEspectaculo, e.Descripcion,e.FechaIni, e.FechaFin, e.Horarios order by e.Titulo ASC";
                da = new SqlDataAdapter(cadena, c);
                da.Fill(bdvirtual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                c.Close();
            }
            return bdvirtual;
        }

        public DataSet ObtenerEspectaculoBusAV(string tipo,string fechaini, string fechafin, string nombre)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet resultado = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da;
                string cadena = "select e.Titulo, e.IDEspectaculo, e.FechaIni, e.FechaFin from Ventas v, Espectaculo e, Sala s, ReservaSala rs where s.NumSala=rs.IDSala and e.IDEspectaculo=rs.IDEspectaculo ";

                if (tipo != "")
                    cadena = cadena + "and s.tipo='"+tipo+"' ";
                if (nombre != "")
                    cadena = cadena + "and e.Titulo LIKE '%"+nombre+"%' ";

                cadena = cadena + " group by e.Titulo, e.IDEspectaculo,e.FechaIni, e.FechaFin order by e.Titulo ASC";
                da = new SqlDataAdapter(cadena, c);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                c.Close();
            }
            return resultado;
        }
    }
}
