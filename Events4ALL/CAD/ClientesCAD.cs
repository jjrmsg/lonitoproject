using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.Auxiliares;
using System.Data;
using System.Data.SqlClient;
using Events4ALL.EN;

namespace Events4ALL.CAD
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

            //try
            //{
                string sql = "select NIF, Usuario, Nombre, Apellidos, Poblacion, Provincia from Cliente";
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sql, c);
                dtAdapter.Fill(bdvirtual, "Cliente");

            //}

           /* catch
            {

            }*/

            c.Close();

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
            bool error = false;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

           //try
           //{
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
                string tabla4 = "CP, Sexo)";
                string sql2 = " VALUES ('";
                string valores1 = nuevoCl.Nombre + comilla + nuevoCl.Apellidos + comilla + nuevoCl.Nick + comilla + SHA1helper.Compute(nuevoCl.Password) + comilla + nuevoCl.DNI + comilla;
                string valores2 = fecha + comilla + nuevoCl.Localidad + comilla + nuevoCl.Provincia + comilla + nuevoCl.Pais + comilla;
                string valores3 = nuevoCl.Domicilio + comilla + tel1 + comilla + tel2 + comilla + nuevoCl.Mail + comilla;
                string valores4 = nuevoCl.CP + "'," + nuevoCl.Sexo;
                string sql3 = ")";

                string sqlFinal = sql1 + tabla1 + tabla2 + tabla3 + tabla4 + sql2 + valores1 + valores2 + valores3 + valores4 + sql3;

                System.Diagnostics.Debug.Write(sqlFinal);

                SqlCommand comando = new SqlCommand(sqlFinal, c);
                comando.ExecuteNonQuery();

                error = true;

                c.Close();

           /* }

            catch
            {

            }

            finally
            {
                c.Close();
            }*/

            return error;
        }

        #endregion

    }
}
