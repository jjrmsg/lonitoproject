using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Events4ALL.Auxiliares;
using System.Data.SqlClient;

namespace Events4ALL.CAD
{
    public class MensajesCAD
    {
        public MensajesCAD()
        {
        }

        public DataSet getMessages()
        {
            BD bd = new BD();
            DataSet mensajes = new DataSet();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Mensaje order by Estado asc", c);
                da.Fill(mensajes);
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            return mensajes;
        }

        public DataSet getMessageByID(string id)
        {
            BD bd = new BD();
            DataSet mensaje = new DataSet();
            SqlConnection c = bd.Connect();
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Mensaje m, Cliente c where m.IDMensaje='"+id+"' and m.Cliente=c.NIF", c);
                da.Fill(mensaje);
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

            return mensaje;
        }

        public void setResponse(string ID)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("update Mensaje set Estado=0 where IDMensaje='"+ID+"'", c);
                com.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }

        }

        public void deleteMessage(string ID)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete Mensaje where IDMensaje='" + ID + "'", c);
                com.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }
        }
    }
}
