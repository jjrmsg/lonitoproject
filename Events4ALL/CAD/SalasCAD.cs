using System;
using System.Collections.Generic;
using System.Linq;
using Events4ALL.EN;
using Events4ALL.Auxiliares;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Events4ALL.CAD
{
    class SalasCAD
    {
        public int SacarIdSala()
        {
            int newID=0;
            int atras = 0;
            int delante = 0;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select NumSala from Sala order by NumSala", c);
                SqlDataReader dr = com.ExecuteReader();
                bool encontrado = false;
                dr.Read();
                delante = Convert.ToInt16(dr[0]);
                while (dr.Read() && encontrado==false)
                {
                    atras = delante;
                    delante = Convert.ToInt16(dr[0]);
                    if ((delante - atras) >= 2)
                    {
                        newID = atras + 1;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                    newID = delante + 1; 

                dr.Close();
               // return newID;
            }
            catch
            {
                newID = 888;
            }
            finally
            {
                c.Close();
            }
            return newID;
        }

        public bool InsertarSala(SalasEN sala)
        {
            bool insertado = false;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                string comilla="\',\'";
                string cadena = "insert into Sala (NumSala,Descripcion,tipo,NumSeccion,Aforo,EstadoSala) values (";
                string cadena2 = sala.NumSala.ToString()+",'"+sala.Descripcion+comilla+sala.TipoSala+"\',"+sala.NumSecciones.ToString()+","+sala.Aforo+","+sala.EstadoSala+")";
                
                SqlCommand com = new SqlCommand(cadena+cadena2, c);
                com.ExecuteNonQuery();

                int [][]vector=sala.Secciones;
                string entrada = "";
                foreach (int[] i in vector)
                {
                    int seccion = i[0];
                    int fila = i[1];
                    int col = i[2];
                    entrada = "insert into Seccion (NumSala,NumSeccion,NumFilas,NumColumnas) values (" + sala.NumSala.ToString() + "," + seccion + "," + fila + "," + col + ")";
                    SqlCommand com2 = new SqlCommand(entrada, c);
                    com2.ExecuteNonQuery();
                }

                insertado = true;
                return insertado;
            }
            catch
            {

            }
            finally
            {
                c.Close();
            }
            return insertado;
        }

        public DataSet SalasPorTipo(String tipo)
        {
            SqlConnection conn = null; 
            BD bd = new BD();

            DataSet datosSalas = null;
            String comando = "select * from Sala where tipo = '"+tipo+"'";    

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

        public DataSet SalaSelectCAD(int idSala, String tipo, int aforo_min, int aforo_max, int estado)
        {
            string idSalaBusca="";
            string aforoMax="";
            string aforoMin="";
            SqlConnection conn = null;
            BD bd = new BD();

            DataSet datosSalas = null;
            if (idSala != 0)
                idSalaBusca = idSalaBusca.ToString();
            if (aforo_max != 0)
                aforoMax = aforo_max.ToString();
            if (aforo_min != 0)
                aforoMin = aforo_min.ToString();
                
            String comando = "select s.NumSala,s.tipo,s.Aforo,s.NumSeccion,e.Titulo from Sala s,Espectaculo e,ReservaSala r where r.IDEspectaculo=e.IDEspectaculo and r.IDSala=s.NumSala";

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
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión. 
            }
        }
    }

}
