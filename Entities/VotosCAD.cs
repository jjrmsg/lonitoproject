using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Auxiliares;

namespace Entities
{
    public class VotosCAD
    {
        public VotosCAD()
        {

        }

        public bool setVoto(string user, string esp, int nota)
        {
            bool afectadas = false;
            // Declaramos la conexión,
            SqlConnection conn = null;
            BD bd = new BD();

            String queryCons = "SELECT count(*) NumVotos FROM Votos WHERE idUsuario = @usu and idEspectaculo = @esp";
            
            // Abre la conexión e inserta el espectáculo.
            try
            {
                conn = bd.Connect();
                conn.Open();

                // Creamos un SqlCommand y ponemos valor a titulo permitiendo que tenga caracteres
                // extraños como comillas.
                SqlCommand com = new SqlCommand(queryCons, conn);
                com.Parameters.Add("@usu", SqlDbType.Int).Value = user;
                com.Parameters.Add("@esp", SqlDbType.Int).Value = esp;

                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                int numVotos = int.Parse(dr["NumVotos"].ToString());
                dr.Close();

                SqlCommand comVoto = null;
                if (numVotos > 0)
                {
                    // Creamos la query a partir de los datos.
                    string queryVotoUpd = "UPDATE Votos set nota = @not, fechaVoto = @fech ";
                    comVoto = new SqlCommand(queryVotoUpd, conn);
                    comVoto.Parameters.Add("@not", SqlDbType.Int).Value = nota;
                    comVoto.Parameters.Add("@fech", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    // Creamos la query a partir de los datos.
                    String queryVotoIns = "INSERT INTO Votos (idUsuario, idEspectaculo, nota, fechaVoto)";
                    queryVotoIns += " values (@usu, @esp, @not, @fech)";

                    comVoto = new SqlCommand(queryVotoIns, conn);
                    comVoto.Parameters.Add("@usu", SqlDbType.Int).Value = user;
                    comVoto.Parameters.Add("@esp", SqlDbType.Int).Value = esp;
                    comVoto.Parameters.Add("@not", SqlDbType.Int).Value = nota;
                    comVoto.Parameters.Add("@fech", SqlDbType.DateTime).Value = DateTime.Now;
                }
                afectadas = comVoto.ExecuteNonQuery() > 0;
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
            return afectadas;
        }

        public DataSet SacarVotosCAD(String tipo)
        {
            SqlConnection conn = null;
            BD bd = new BD();

            DataSet datos = null;
            String comando = "select e.Titulo,e.IDEspectaculo,count(*),avg(v.nota) nota from Votos v, Espectaculo e,Sala s, ReservaSala x  where ";
            comando = comando + "v.idEspectaculo=e.IDEspectaculo and s.NumSala=x.IDSala and x.IDEspectaculo=e.IDEspectaculo and s.tipo='"+tipo;
            comando = comando + "' group by e.Titulo,e.IDEspectaculo order by nota desc";

            try
            {
                conn = bd.Connect();
                conn.Open();

                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, conn);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión. 

            }
            return datos;
        }
    }
}
