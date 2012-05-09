using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Auxiliares;
using System.Data;

namespace Entities
{
    public class CriticasCAD
    {
        public bool Insertar(string idCliente, string idEspectaculo, string titulo, string texto)
        {
            // Declaramos la conexión,
            SqlConnection conn = null;
            BD bd = new BD();

            // Creamos la query a partir de los datos.
            String comCritica = "INSERT INTO Criticas (idCliente, idEspectaculo, titulo, texto, fecha";
            comCritica += ") values (@idCli, @idEsp, @tit, @text, @fech);";
            
            // Abre la conexión e inserta el espectáculo.
            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlCommand com = new SqlCommand(comCritica, conn);
                com.Parameters.Add("@idCli", SqlDbType.Int).Value = idCliente;
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = idEspectaculo;
                com.Parameters.Add("@tit", SqlDbType.Text).Value = titulo;
                com.Parameters.Add("@text", SqlDbType.Text).Value = texto;
                com.Parameters.Add("@fech", SqlDbType.DateTime).Value = DateTime.Now;
                return com.ExecuteNonQuery() > 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null) conn.Close();
            }  
        }

        public DataSet getCriticasEspectaculo(string idEspectaculo)
        {
            SqlConnection conn = null;
            BD bd = new BD();
            DataSet datosCriticas = null;

            // Creamos la query.
            String query = "SELECT * ";
            query += "FROM Criticas ";
            query += "WHERE idEspectaculo = @idEsp ";

            // Crea la conexión con la BD y recoge los datos.
            try
            {
                conn = bd.Connect();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.Add("@idEsp", SqlDbType.Int).Value = idEspectaculo;

                SqlDataAdapter sqlAdaptader = new SqlDataAdapter();
                sqlAdaptader.SelectCommand = com;

                datosCriticas = new DataSet();
                sqlAdaptader.Fill(datosCriticas);
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
            return datosCriticas;
        }
    }
}
