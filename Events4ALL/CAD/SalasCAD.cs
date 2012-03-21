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
    }
}
