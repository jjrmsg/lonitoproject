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
        private BD bd;
        private DataSet bdvirtual;
        private SqlConnection con;
        private SqlDataAdapter da;
        SqlCommandBuilder cbuilder;

        public CondicionCAD()
        {
            bd = new BD();
            bdvirtual = new DataSet();
            con = bd.Connect();
        }

        public DataSet ObtenerTodas()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from Condicion", con);
                da.Fill(bdvirtual, "Condicion");
            }
            catch(Exception ex)
            {
                // MessageBox.Show("PENE error al obtener las condiciones " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
            return bdvirtual;
        }

        public void Save()
        {
            try
            {
                con.Open();
                cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "Condicion");
            }
            catch(Exception ex)
            {
                // MessageBox.Show("PENE error al guardar las condiciones " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
    }
}
