using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.Auxiliares;
using System.Data;
using System.Data.SqlClient;

namespace Events4ALL.CAD
{
    public class ClientesCAD
    {
        public ClientesCAD()
        {
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
    }
}
