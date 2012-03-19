using System;
using System.Collections.Generic;
using System.Linq;
using Events4ALL.Auxiliares;
using System.Text;
using System.Data.SqlClient;

namespace Events4ALL.CAD
{
    class SalasCAD
    {
        public int SacarIdSala()
        {
            int newID=0;
            BD bd = new BD();
            SqlConnection c = bd.Connect();

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select count(*) from salas", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                newID = Convert.ToInt16(dr[0].ToString())+1;
                dr.Close();
               // return newID;
            }
            catch
            {
                newID = 88;
            }
            finally
            {
                c.Close();
            }
            return newID;
        }
    }
}
