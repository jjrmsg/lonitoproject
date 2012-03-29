using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Events4ALL.Auxiliares;
using System.Windows.Forms;
using Events4ALL.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Events4ALL.CAD
{
    
    class CondicionCAD
    {
        BD bd;
        SqlDataAdapter da;
        DataSet bdvirtual = new DataSet();
        //DataTable tabla = new DataTable();

        public DataSet ObtenerTodas()
        {
            try
            {
                bd = new BD();
	            SqlConnection con = bd.Connect();
                da = new SqlDataAdapter("select * from Condicion", con);
                da.Fill(bdvirtual, "Condicion");
                //tabla = bdvirtual.Tables["Condicion"];
            }
            catch
            {
            }
            finally
            {
            }
            return bdvirtual;
        }

        public void Save()
        {
            SqlConnection con = bd.Connect();
            try
            {
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "Condicion");
            }
            catch
            {
            }
            finally
            {
            }
        }
    }
}
