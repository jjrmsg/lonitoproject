using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Events4ALL.Auxiliares;
using Events4ALL.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Events4ALL.CAD
{
    class PromocionCAD
    {
        private BD bd;
        private DataSet bdvirtual;
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlDataAdapter da2;
        private SqlDataAdapter da3;
        SqlCommandBuilder cbuilder;

        public PromocionCAD()
        {
            bd = new BD();
            bdvirtual = new DataSet();
            //bdvirtual2 = new DataSet();
            con = bd.Connect();
        }

        public DataSet ObtenerEspectaculos()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from Espectaculo", con);
                da.Fill(bdvirtual, "Espectaculo");
                da2 = new SqlDataAdapter("select * from PromocionConEvento", con);
                da2.Fill(bdvirtual, "PromocionConEvento");
                da3 = new SqlDataAdapter("select * from Promocion", con);
                da3.Fill(bdvirtual, "Promocion");
            }
            catch(Exception ex)
            {
                // MessageBox.Show("PENE error al cargar las tablas Espectaculo y PromocionConEvento " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return bdvirtual;
        }

        public void Save()
        {
            try
            {
                cbuilder = new SqlCommandBuilder(da2);
                da2.Update(bdvirtual, "PromocionConEvento");
                cbuilder = new SqlCommandBuilder(da3);
                da3.Update(bdvirtual, "Promocion");
            }
            catch(Exception ex)
            {
                // MessageBox.Show("PENE error al guardar cambios en la tabla PromosConEvento " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
    }
}
