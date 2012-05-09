using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Auxiliares;
using System.Data.SqlClient;

namespace Entities
{
    public class MensajesCAD
    {
        public MensajesCAD()
        {
        }

        //Obtiene una lista de todos los mensajes
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

        //Obtiene los datos de un mensaje concreto sabiendo su ID
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

        //Marca un mensaje como leido
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

        //Elimina un mensaje de la BD
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

        //Obtiene el número de mensajes sin leer
        public int getNumMessages()
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();
            int rows = 0;
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select count(*) from Mensaje where Estado=1", c);
                rows=(int)com.ExecuteScalar();
            }
            catch
            {
            }
            finally
            {
                c.Close();
            }
            return rows;
        }

        public void insertMessage(string nick,string mail,string asunto,string contenido)
        {
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                /*if (asunto != "")
                    asunto = "'" + asunto + "'";*/
                string fecha = DateTime.Now.ToShortDateString();
                c.Open();
                string insert="insert into Mensaje (Cliente,Asunto,Contenido,Estado,Fecha) values ('1111118D','"+asunto;
                insert = insert + "','"+contenido+"','1','"+fecha+"');";
                SqlCommand com = new SqlCommand(insert, c);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            finally
            {
                c.Close();
            }
        }
    }
}
