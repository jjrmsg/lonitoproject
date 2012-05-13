using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Auxiliares;
using System.Data;
using System.Data.SqlClient;
using Entities;
using System.Drawing;
using System.IO;

namespace Entities
{
    public class ClientesCAD
    {
        public ClientesCAD()
        {
        }

        #region Consultas BD

        public DataSet BusquedaCliente(string campo, string datoAbuscar)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();

            //try
            //{
               // string comandoSql = "";
            string sql = "select NIF, Usuario, Nombre, Apellidos, Poblacion, Provincia from Cliente WHERE " + campo + " LIKE '%" + datoAbuscar + "%'";

            System.Diagnostics.Debug.Write(sql);
            SqlDataAdapter dtAdapter = new SqlDataAdapter(sql, c);
            dtAdapter.Fill(bdvirtual, "Cliente");

            c.Close();

            return bdvirtual;


           // }
           //catch
           //{

           //}

        }

        public DataSet getClientes()
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();

            try
            {
                string sql = "select NIF, Usuario, Nombre, Apellidos, Poblacion, Provincia from Cliente";
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sql, c);
                dtAdapter.Fill(bdvirtual, "Cliente");

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

        public DataSet getClienteByNif(string nif)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            DataSet bdvirtual = new DataSet();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Cliente where NIF='" + nif + "'", c);
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

        public Image devuelveImagen(string nif)
        {
            byte[] bImage = new byte[0];
            Image im = null;
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            try
            {
                c.Open();
                SqlCommand comando = new SqlCommand("select * from Cliente where NIF='" + nif + "'", c);
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (dr["Foto"] != DBNull.Value)
                {
                    bImage = (byte[])dr["Foto"];
                }

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

        public bool ExisteCliente(string nif)
        {
            int i=0;
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Cliente where NIF='" + nif + "'", c);
                i = (int)cmd.ExecuteScalar(); 
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            Console.WriteLine("Existe o no el cliente: " + i);
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Devuelve el ID del Cliente

       /* public int devuelveID(string usuario)
        {
            int id = -1;

            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();

                SqlCommand comando = new SqlCommand("select ID from Cliente where Usuario='" + usuario + "'", c);
                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();

                id = Convert.ToInt16(dr[0]);

                dr.Close();


            }
            catch
            {

            }

            finally
            {
                c.Close();

            }

            return id;

        }*/

        #endregion

        #region Iteracción BD

        public bool InsertarCliente(ClientesEN nuevoCl)
        {

            byte[] pic = null;
            if (nuevoCl.Foto != null)
            {
                MemoryStream tmpStream = new MemoryStream();
                nuevoCl.Foto.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                tmpStream.Position = 0;
                pic = new byte[tmpStream.Length];
                tmpStream.Read(pic, 0, System.Convert.ToInt32(tmpStream.Length));
                pic = tmpStream.ToArray();
            }


            bool error = false;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

           try
           {
                c.Open();

                string fecha = nuevoCl.Fecha.ToString();
                string anyo = "" + fecha[6] + fecha[7] + fecha[8] + fecha[9];
                string mes = "" + fecha[3] + fecha[4];
                string dia = "" + fecha[0] + fecha[1];
                fecha = anyo + '/' + mes + '/' + dia;

                string comilla = "', '";

                string tel1 = "";
                string tel2 = "";

                tel1 = nuevoCl.Telefono;
                tel2 = nuevoCl.Movil;


                string sql1 = "INSERT INTO Cliente ";
                string tabla1 = "(Nombre, Apellidos, Usuario, Pass, NIF, ";
                string tabla2 = "FechaNac, Poblacion, Provincia, Pais, ";
                string tabla3 = "Direccion, TfnoFijo, TfnoMovil, Mail, ";
                string tabla4 = "CP, Sexo";

                if (nuevoCl.Foto != null)
                    tabla4 = tabla4 + ", Foto)";
                else
                    tabla4 = tabla4 + ")";


                string sql2 = " VALUES ('";
                string valores1 = nuevoCl.Nombre + comilla + nuevoCl.Apellidos + comilla + nuevoCl.Nick + comilla + SHA1helper.Compute(nuevoCl.Password) + comilla + nuevoCl.DNI + comilla;
                string valores2 = fecha + comilla + nuevoCl.Localidad + comilla + nuevoCl.Provincia + comilla + nuevoCl.Pais + comilla;
                string valores3 = nuevoCl.Domicilio + comilla + tel1 + comilla + tel2 + comilla + nuevoCl.Mail + comilla;
                string valores4 = nuevoCl.CP + "'," + nuevoCl.Sexo;

                if (nuevoCl.Foto != null)
                    valores4 = valores4 + ", @pic";

                string sql3 = ")";

                string sqlFinal = sql1 + tabla1 + tabla2 + tabla3 + tabla4 + sql2 + valores1 + valores2 + valores3 + valores4 + sql3;

                System.Diagnostics.Debug.Write(sqlFinal);

                SqlCommand comando = new SqlCommand(sqlFinal, c);

                if (nuevoCl.Foto != null)
                    comando.Parameters.AddWithValue("@pic", pic);

                comando.ExecuteNonQuery();

                error = true;

                c.Close();
           }

            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                c.Close();
            }

            return error;
        }


        public bool ActualizarCliente(ClientesEN nuevoCL)
        {

            byte[] pic = null;
            if (nuevoCL.Foto != null)
            {
                MemoryStream tmpStream = new MemoryStream();
                nuevoCL.Foto.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                tmpStream.Position = 0;
                pic = new byte[tmpStream.Length];
                tmpStream.Read(pic, 0, System.Convert.ToInt32(tmpStream.Length));
                pic = tmpStream.ToArray();
            }

            bool error = false;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {

                c.Open();

                string fecha = nuevoCL.Fecha.ToString();
                string anyo = "" + fecha[6] + fecha[7] + fecha[8] + fecha[9];
                string mes = "" + fecha[3] + fecha[4];
                string dia = "" + fecha[0] + fecha[1];
                fecha = anyo + '/' + mes + '/' + dia;

                //string comilla = "', '";

                string tel1 = "";
                string tel2 = "";

                tel1 = nuevoCL.Telefono;
                tel2 = nuevoCL.Movil;


                string sql1 = "UPDATE Cliente SET ";
                string set1 = "Nombre = '" + nuevoCL.Nombre + "'";
                string set2 = ", Apellidos = '" + nuevoCL.Apellidos + "'";
                string set3 = ", Usuario = '" + nuevoCL.Nick + "'";
                string set4 = ", Pass = '" + SHA1helper.Compute(nuevoCL.Password) + "'";
                // string set5 = ", NIF = '" + nuevoCL.DNI + "'";
                string set6 = ", FechaNac = '" + fecha + "'";
                string set7 = ", Poblacion = '" + nuevoCL.Localidad + "'";
                string set8 = ", Provincia = '" + nuevoCL.Provincia + "'";
                string set9 = ", Pais = '" + nuevoCL.Pais + "'";
                string set10 = ", Direccion = '" + nuevoCL.Domicilio + "'";
                string set11 = ", TfnoFijo = '" + nuevoCL.Telefono + "'";
                string set12 = ", TfnoMovil = '" + nuevoCL.Movil + "'";
                string set13 = ", Mail = '" + nuevoCL.Mail + "'";
                string set14 = ", Foto = @pic";
                string set15 = ", CP = '" + nuevoCL.CP + "'";
                string set16 = ", Sexo = " + nuevoCL.Sexo;

                string sql2 = "WHERE NIF='" + nuevoCL.DNI + "'";

                string sqlFinal = sql1 + set1 + set2 + set3 + set4 + set6 + set7 + set8 + set9 + set10 + set11 + set12 + set13 + set14 + set15 + set16 + sql2;

                System.Diagnostics.Debug.Write(sqlFinal);

                SqlCommand comando = new SqlCommand(sqlFinal, c);
                if (nuevoCL.Foto != null)
                    comando.Parameters.AddWithValue("@pic", pic);

                comando.ExecuteNonQuery();

                error = true;
            }

            catch (Exception ex)
            {
                //Captura la excepcion
                throw ex;
            }
            finally
            {
                c.Close();
            }

            return error;

        }

        public bool BorraCliente(string nif)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            String sql1 = "DELETE FROM Cliente WHERE NIF = '" + nif + "'";
            bool error = false;


            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand comando = new SqlCommand(sql1, conn);

                comando.ExecuteNonQuery();

                error = true;
            }
            catch (Exception ex)
            {
                //Captura la excepcion
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return error;
        }

        #endregion


        public DataSet ExisteUsuarioNickPass(string nick, string pass)
        {
            // Declaramos la conexion
            BD bd = new BD();
            SqlConnection conn = null;
            DataSet bdvirtual = new DataSet();

            /*string SHA1pass = SHA1helper.Compute(pass);*/
            string SHA1pass = pass;

            // Creamos la query
            String query = "SELECT * ";
            query += "FROM Cliente ";
            query += "WHERE Usuario COLLATE Latin1_General_CS_AS ='" + nick + "' and Pass ='" + SHA1pass + "'";
            
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

        public DataSet ObtenerUsuarioPorID(string id)
        {
            // Declaramos la conexion
            SqlConnection conn = null;
            BD bd = new BD();
            DataSet datosUsuario = null;

            // Creamos la query
            string query = "SELECT * ";
            query += "FROM Cliente ";
            query += "WHERE idCliente = @idCli";

            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idCli", SqlDbType.Int).Value = id;

                SqlDataAdapter sqlAdaptader = new SqlDataAdapter();
                sqlAdaptader.SelectCommand = com;

                datosUsuario = new DataSet();
                sqlAdaptader.Fill(datosUsuario);
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
            return datosUsuario;
        }

        public int getPuntuacionEsp(string cliId, string espId)
        {
            int nota = 0;

            // Declaramos la conexion
            SqlConnection conn = null;
            BD bd = new BD();

            // Creamos la query
            string query = "SELECT nota ";
            query += "FROM Votos ";
            query += "WHERE idUsuario = @idCli AND idEspectaculo = @idEsp";
            
            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();
                conn.Open();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idCli", SqlDbType.Int).Value = cliId;
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = espId;

                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                nota = Convert.ToInt32(dr["nota"]);
            }
            catch (Exception ex)
            {
                // Captura la condición general y la reenvía. 
                /*throw ex;*/
                nota = 0;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }
            return nota;
        }
    }
}
