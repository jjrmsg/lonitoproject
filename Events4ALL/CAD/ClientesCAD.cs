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
    }
}
