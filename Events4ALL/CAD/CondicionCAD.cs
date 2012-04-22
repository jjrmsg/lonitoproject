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
        private DataSet bdvirtual2;
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlDataAdapter da2;
        SqlCommandBuilder cbuilder;
        SqlCommandBuilder cbuilder2;

        public CondicionCAD()
        {
            bd = new BD();
            bdvirtual = new DataSet();
            bdvirtual2 = new DataSet();
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

        public DataSet ObtenerCondicionesConClientes()
        {
            try
            {
                con.Open();
                da2 = new SqlDataAdapter("select * from CondicionConCliente", con);
                da2.Fill(bdvirtual2, "CondicionConCliente");
            }
            catch (Exception ex)
            {
                // MessageBox.Show("PENE error al obtener las condiciones " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
            return bdvirtual2;
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

        public void SaveCondicionesConClientes()
        {
            try
            {
                con.Open();
                cbuilder2 = new SqlCommandBuilder(da2);
                da2.Update(bdvirtual2, "CondicionConCliente");
            }
            catch (Exception ex)
            {
                // MessageBox.Show("PENE error al guardar las condiciones " + ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void InsertarCondicionConCliente(string idCliente, int idCondicion)
        {


            String comEspectaculo = "INSERT INTO CondicionConCliente (ID_Cliente,ID_Condicion) VALUES('" + idCliente + "','" + idCondicion + "')";

            try
            {
                con = bd.Connect();
                con.Open();

                SqlCommand com = new SqlCommand(comEspectaculo, con);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Captura la condición general y la reenvía. 
                throw ex;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión. 
            }
        }

        public DataSet NumeroDeEventosAsistidosClientePorTipo(string nif, string tipoevento)
        {
            DataSet datos = new DataSet();

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select count (v.IDCliente) espectaculos, sum (v.Importe) importe from Ventas v, ReservaSala r, Sala s where v.IDEspectaculo=r.IDEspectaculo and s.NumSala=r.IDSala and v.IDCliente='" + nif + "' and s.tipo='" + tipoevento + "'", con);
                da.Fill(datos);
            }
            catch
            {
                MessageBox.Show("fail");
            }
            finally
            {
                con.Close();
            }

            return datos;
        }
    }
}
