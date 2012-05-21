using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Auxiliares;
using System.Data;

namespace Entities
{
    public class VentasCAD
    {
        #region members
        #endregion

        public VentasCAD()
        {
        }

        //Obtiene todos los datos de un espectaculo
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

        //Obtiene el importe gastado y el número de entradas que ha comprado un cliente
        public DataSet getEstadisticasCliente(string nif)
        {
            BD bd = new BD();
            DataSet datos = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(Importe) Dinero, count(v.IDEspectaculo) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo and v.IDCliente='"+nif+"'", c);
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

        //Obtiene el número de espectáculos distintos a los que ha asistido un cliente
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

        // Obtiene los datos necesarios para saber que tipo y género de espectáculos son los favoritos de un cliente.
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

        //Obtiene el importe total recaudado por un espectáculo
        public DataSet getVentasEspectaculo(string titulo)
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(v.Importe) Recaudacion, count(*) Entradas from Ventas v, Espectaculo e where e.Titulo='"+titulo+"' and e.IDEspectaculo=v.IDEspectaculo", c);
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

        //Obtiene una lista ordenada por número de ventas en orden ascendente o descendente de los espectáculos 
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
                    da = new SqlDataAdapter("select e.Titulo, e.IDEspectaculo, count(*) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo group by e.Titulo, e.IDEspectaculo order by Entradas DESC;", c);
                }
                else
                {
                    da = new SqlDataAdapter("select e.Titulo, e.IDEspectaculo, count(*) Entradas from Ventas v, Espectaculo e where v.IDEspectaculo=e.IDEspectaculo group by e.Titulo, e.IDEspectaculo order by Entradas asc;", c);
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

        //obtiene una lista ordenada descendente de las ventas segun el tipo de espectaculo
        public DataSet ObtenerRankingTipo(string tipo)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da;
                string cadena = "select e.Titulo, e.IDEspectaculo, count(*) Entradas from Ventas v, Espectaculo e, Sala s, ReservaSala rs where v.IDEspectaculo=e.IDEspectaculo and s.NumSala=rs.IDSala and e.IDEspectaculo=rs.IDEspectaculo and s.tipo='" + tipo;
                cadena=cadena+"' group by e.Titulo, e.IDEspectaculo order by Entradas DESC";
                da = new SqlDataAdapter(cadena,c);
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

        // Busca y devuelve ventas de la bd que cumplen unas restricciones.
        public DataSet BuscarVenta(string nombre, string dni, string titulo, string tipo, string fEsp, string fVenta)
        {
            BD bd = new BD();
            DataSet datosVentas = new DataSet();
            SqlConnection conn = null;
            
            // Creamos la query
            String query = "SELECT Ventas.IDVentas IdVenta, Cliente.Nombre, Cliente.NIF, Espectaculo.Titulo, Sala.tipo Tipo, Ventas.Importe, Ventas.FechaVenta ";
            query += "FROM Cliente RIGHT OUTER JOIN ";
            query += "Ventas ON Cliente.NIF = Ventas.IDCliente LEFT OUTER JOIN ";
            query += "ReservaSala INNER JOIN ";
            query += "Sala ON ReservaSala.IDSala = Sala.NumSala INNER JOIN ";
            query += "Espectaculo ON ReservaSala.IDEspectaculo = Espectaculo.IDEspectaculo ON Ventas.IDEspectaculo = Espectaculo.IDEspectaculo WHERE (''='') ";

            if (nombre != "")
                query += "and Cliente.Nombre like '%'+@nombre+'%' ";
            
            if (dni != "")
                query += "and Cliente.NIF like '%'+@nif+'%' ";
            
            if (titulo != "")
                query += "and Espectaculo.Titulo like '%'+@titulo+'%' ";

            if (tipo != "")
                query += "and Sala.tipo = '" + tipo + "' ";

            if (fEsp != "")
                query += "and Espectaculo.FechaIni <= '" + fEsp + "' and Espectaculo.FechaFin >= '" + fEsp + "' ";

            if (fVenta != "")
                query += "and Ventas.FechaVenta = '" + fVenta + "' ";

            // Abrimos la conexion y recogemos los datos
            try
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor permitiendo que tengan caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                if (nombre != "")
                    com.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                if (dni != "")
                    com.Parameters.Add("@nif", SqlDbType.NChar).Value = dni;
                if (titulo != "")
                    com.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = titulo;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(datosVentas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return datosVentas;
        }

        // Elimina una venta de la BD a partir de una id.
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

        public DataSet getVentasEspectaculoId(string id, string hora, string fecha)
        {
            SqlConnection conn = null;
            BD bd = new BD();
            DataSet datosVentas = null;

            // Creamos la query.
            String query = "SELECT * ";
            query += "FROM Ventas ";
            query += "WHERE IDEspectaculo = @idEsp and Horario = @horario and FechaVenta = @fech";

            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = id;
                com.Parameters.Add("@horario", SqlDbType.NVarChar).Value = hora;
                com.Parameters.Add("@fech", SqlDbType.Date).Value = fecha;

                SqlDataAdapter sqlAdaptader = new SqlDataAdapter();
                sqlAdaptader.SelectCommand = com;

                datosVentas = new DataSet();
                sqlAdaptader.Fill(datosVentas);
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
            return datosVentas;
        }



        public bool Insertar(string idEspectaculo, string idCliente, string fecha, string hora, string numAsiento, string importe)
        {
            // Declaramos la conexión,
            SqlConnection conn = null;
            BD bd = new BD();

            // Creamos la query a partir de los datos.
            String comEspectaculo = "INSERT INTO Ventas (IDEspectaculo, IDCliente, FechaVenta, Horario, NumAsiento, Importe)";
            comEspectaculo += " values (@idEsp, @idCli, @fechVent, @hor, @numAsient, @importe)";

            // Abre la conexión e inserta el espectáculo.
            try
            {
                conn = bd.Connect();
                conn.Open();

                // Creamos el comando SQL sustituyendo los valores de forma segura 
                // escapando carácteres no validos.
                SqlCommand com = new SqlCommand(comEspectaculo, conn);
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = idEspectaculo;
                com.Parameters.Add("@idCli", SqlDbType.NChar).Value = idCliente;
                com.Parameters.Add("@fechVent", SqlDbType.Date).Value = fecha;
                com.Parameters.Add("@hor", SqlDbType.NVarChar).Value = hora;
                com.Parameters.Add("@numAsient", SqlDbType.NVarChar).Value = numAsiento;
                com.Parameters.Add("@importe", SqlDbType.Money).Value = importe;

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

        public bool ExisteVenta(string idEsp, string asiento, string hora, string fecha)
        {
            SqlConnection conn = null;
            BD bd = new BD();
            bool ocupado = true;

            // Creamos la query.
            String query = "SELECT count(*) Num FROM Ventas WHERE NumAsiento = @asiento and Horario = @horario and IDEspectaculo = @idEsp and FechaVenta = @fech";

            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();
                conn.Open();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = idEsp;
                com.Parameters.Add("@asiento", SqlDbType.NVarChar).Value = asiento;
                com.Parameters.Add("@horario", SqlDbType.NVarChar).Value = hora;
                com.Parameters.Add("@fech", SqlDbType.Date).Value = fecha;

                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                int numResults = int.Parse(dr["Num"].ToString());
                dr.Close();

                if (numResults == 0)
                {                
                    ocupado = false;
                }
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
            return ocupado;
        }

        public DataSet Historial(int id)
        {
            SqlConnection conn = null;
            BD bd = new BD();
            DataSet datosVentas = null;

            // Creamos la query.
            String query = "SELECT v.FechaVenta, v.Importe, e.Titulo ";
            query += "FROM Ventas v, Espectaculo e ";
            query += "WHERE v.IDCliente=@idCliente AND v.IDEspectaculo=e.IDEspectaculo";

            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idCliente", SqlDbType.Int).Value = id;

                SqlDataAdapter sqlAdaptader = new SqlDataAdapter();
                sqlAdaptader.SelectCommand = com;

                datosVentas = new DataSet();
                sqlAdaptader.Fill(datosVentas);
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
            return datosVentas;
        }
    }
}