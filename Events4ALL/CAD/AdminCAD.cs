using System;
using System.Collections.Generic;
using System.Linq;
using Events4ALL.Auxiliares;
using System.Text;
using System.Data.SqlClient;
using Events4ALL.EN;

namespace Events4ALL.CAD
{
    class AdminCAD
    {
        public AdminCAD()
        {   
        }

        #region Variables

        #endregion

        #region Consultas BD

        public bool CompruebaExistenciaUsuario(string nuevo)
        {
            bool existe = false;
            int valor; 
            
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();

                SqlCommand com = new SqlCommand("select count(*) ex from Administrador where Usuario='"+ nuevo +"'" , c);
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();
                
                valor = Convert.ToInt16(dr[0]);

                if (valor != 0)
                    existe = true;

                dr.Close();
            }
            catch
            {}
            finally
            {
                c.Close();
            }
            
            return existe;
        }

        #endregion

        #region Iteraccion BD

        public bool InsertarAdmin(AdminEN nuevo)
        {
            bool error = false;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            c.Open();

            try
            {
                string comilla = "', '";

                string sql1 = "INSERT INTO Administrador ";
                string tabla1 = "(Nombre, Apellidos, Usuario, Pass, NIF, ";
                string tabla2 = "FechaNac, Poblacion, Provincia, Pais, ";
                string tabla3 = "Direccion, TfnoFijo, TfnoMovil, Mail, ";
                string tabla4 = "Foto, Estado, Sexo)";
                string sql2 = " values (";
                string valores1 = nuevo.Nombre + comilla + nuevo.Apellidos + comilla + nuevo.Nick + comilla + nuevo.Pass + nuevo.DNI + comilla;
                string valores2 = nuevo.Fecha + comilla + nuevo.Localidad + comilla + nuevo.Provincia + comilla + nuevo.Pais + comilla;
                string valores3 = nuevo.Domicilio + comilla + nuevo.Telefono + comilla + nuevo.Movil + comilla + nuevo.Mail + comilla;
                string valores4 = nuevo.Foto + comilla + nuevo.EC + comilla + nuevo.Sexo;
                string sql3 = ")";

                string sql = sql1 + tabla1 + tabla2 + tabla3 + tabla4 + sql2 + valores1 + valores2 + valores3 + valores4 + sql3;

                SqlCommand com = new SqlCommand(sql, c);
                com.ExecuteNonQuery();

                error = true;
            }
            catch
            { 
            
            }
            finally
            { 
                c.Close();
            }

            return error;
        }

        #endregion
    }
}
