using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.CAD;
using Events4ALL.EN;
using System.Collections;
using Events4ALL.Auxiliares;
using System.IO;
using System.Drawing.Imaging;

namespace Events4ALL
{
    public partial class Promociones : UserControl
    {
        private bool PE_Cantidad;
        private bool MC_Nombre;
        private bool MC_Descripcion;
        private bool MC_Cantidad1;
        private bool MC_Cantidad2;
        private bool MC_Cantidad3;
        private bool MC_Descuento1;
        private bool MC_TipoCondicion1;
        private bool MC_TipoCondicion2;
        private bool MC_TipoCondicion3;
        private bool MC_Comparacion1;
        private bool MC_Comparacion2;
        private bool MC_Comparacion3;
        private bool MC_TipoEvento1;
        private bool MC_TipoEvento2;
        private bool MC_TipoEvento3;
        private PromocionEN proEN;
        private CondicionEN conEN;
        private DataSet promos;
        private DataSet espec;
        private DataTable tCondicion;
        private DataTable tEspec;
        private DataTable tPromocion;
        private DataTable tEspecConPromo;
        private int idEventoSelec;
        private int idEventoValor;
        private bool insertarNueva;

        public Promociones()
        {
            InitializeComponent();
            proEN = new PromocionEN();
            conEN = new CondicionEN();

            espec = new DataSet();
            espec = proEN.ObtenerEspectaculos();
            tEspec = new DataTable();
            tEspec = espec.Tables["Espectaculo"];
            tEspecConPromo = new DataTable();
            tEspecConPromo = espec.Tables["PromocionConEvento"];
            tPromocion = new DataTable();
            tPromocion = espec.Tables["Promocion"];
            

            promos = new DataSet();
            promos = conEN.ObtenerTodas();
            tCondicion = new DataTable();
            tCondicion = promos.Tables["Condicion"];

            insertarNueva = false;
        }

        //Evento para activar los campos de la segunda condicion de promociones por condicion
        private void checkBox_MC_ActivarCond1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond1.Checked == true)
            {
                textBox_MC_VC_Cantidad2.Enabled = true;
                comboBox_MC_VC_Comparacion2.Enabled = true;
                comboBox_MC_VC_Tcondicion2.Enabled = true;
                radioButton_MC_TE2_Cine.Enabled = true;
                radioButton_MC_TE2_Concierto.Enabled = true;
                radioButton_MC_TE2_Teatro.Enabled = true;
                radioButton_MC_TE2_Todos.Enabled = true;
            }
            else
            {
                limpiarErrorProvider(2);
                DesactivarCondicion(1);
                MC_limpiar(2);
            }
        }

        //Evento para activar los campos de la tercera condicion de promociones por condicion
        private void checkBox_MC_ActivarCond2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond2.Checked == true)
            {
                textBox_MC_VC_Cantidad3.Enabled = true;
                comboBox_MC_VC_Comparacion3.Enabled = true;
                comboBox_MC_VC_Tcondicion3.Enabled = true;
                radioButton_MC_TE3_Cine.Enabled = true;
                radioButton_MC_TE3_Concierto.Enabled = true;
                radioButton_MC_TE3_Teatro.Enabled = true;
                radioButton_MC_TE3_Todos.Enabled = true;
            }
            else
            {
                limpiarErrorProvider(3);
                DesactivarCondicion(2);
                MC_limpiar(3);
            }
        }

        //Funcion para comprobar que solo se pongan numeros enteros
        private bool CompruebaCantidad(string num)
        {
            if (!Auxiliares.Validaciones.EsNumeroEntero(num))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Funcion para limpiar y cargar el combobox
        private void CargarComboBox()
        {
            comboBox_PE_espectaculo.Items.Clear();
            try
            {
                foreach (DataRow obj in tEspec.Rows)
                {
                    comboBox_PE_espectaculo.Items.Add(obj["Titulo"].ToString());
                    
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Error al rellenar el combobox "+ ex);
                Console.WriteLine(ex.Message);
            }
        }

        //Fucion para cargar el datagridview
        private void CargarDatagridview()
        {
            try
            {
                //estas 2 lineas tienen que estar si no el VisualStudio se pone a llorar y el FormBase peta. ¿pq? -> Preguntaselo a Microsoft xD
                DataRow nuevafila;
                nuevafila = tCondicion.NewRow();

                dataGridView_MC_ListaPromosCond.DataSource = promos;
                dataGridView_MC_ListaPromosCond.DataMember = "Condicion";
                dataGridView_MC_ListaPromosCond.Columns[0].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[2].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[3].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[4].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[5].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[6].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[7].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[8].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[9].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[10].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[11].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[12].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[13].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[14].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[15].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[17].Visible = false;
                dataGridView_MC_ListaPromosCond.ReadOnly = true;
                dataGridView_MC_ListaPromosCond.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_MC_ListaPromosCond.MultiSelect = false;
                dataGridView_MC_ListaPromosCond.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error al cargar datagriview " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        //Evento que carga los datos en el combobox y datagridview
        private void Promociones_Load(object sender, EventArgs e)
        {
            CargarDatagridview();
            
            CargarComboBox();
        }

        //Evento para guardar los datos modificados de las promociones de los eventos
        private void button_PE_Guardar_Click(object sender, EventArgs e)
        {
            //Si se elige Otro debe estar relleno el campo numerico de Otro
            if (radioButton_PE_otroDesc.Checked)
            {
                if (!CompruebaCantidad(textBox_PE_otroDesc.Text.ToString()))
                {
                    errorProvider_PE_Otro.SetError(textBox_PE_otroDesc, "Debe ser un número entero");
                    PE_Cantidad = false;
                }
                else
                {
                    errorProvider_PE_Otro.Clear();
                    PE_Cantidad = true;
                }
            }

            errorProvider_PE_eligeuno.Clear();

            if (!checkBox_PE_Ninguno.Checked)
            {
                //Comprobamos si esta elegido Otro y la cantidad es un número entero
                if (radioButton_PE_otroDesc.Checked && PE_Cantidad)
                {
                    GuardarPromocionConEvento();
                }
                else if (!radioButton_PE_otroDesc.Checked && (radioButton_PE_5.Checked || radioButton_PE_10.Checked || radioButton_PE_25.Checked || radioButton_PE_50.Checked || radioButton_PE_IVA.Checked))
                {
                    //Si se selecciona otro que no sea Otro también se puede guardar ya que no hay restricción mínima
                    GuardarPromocionConEvento();
                }
                else
                {
                    errorProvider_PE_eligeuno.SetError(checkBox_PE_Ninguno, "Debes elegir una opción, si no deseas usar ninguna, marca Ninguna");
                    errorProvider_PE_eligeuno.RightToLeft = true;
                }
            }
            else 
            {
                GuardarPromocionConEvento();
            }
        }

        //Funcion para borrar una promocion de un espectaculo
        private bool BuscarPromoEspectaculo(int id,int idPromo, ref int fila)
        {
            
            bool salir = false;
            for (int i=0;i<Convert.ToInt32(tEspecConPromo.Rows.Count) && salir==false;i++)
            {
                if(tEspecConPromo.Rows[i].RowState.ToString()!="Deleted")
                {
                    if (Convert.ToInt32(tEspecConPromo.Rows[i][0])==id && Convert.ToInt32(tEspecConPromo.Rows[i][1])==idPromo)
                    {
                        fila = i;
                        salir = true;
                    }
                }
            }
            return salir;
        }

        //Funcion para buscar un evento con una promo
        private void BorrarPromoEspectaculo(int fila)
        {
            tEspecConPromo.Rows[fila].Delete();
        }

        //Funcion para guardar en la tabla PromocionConEvento de la BD
        private void GuardarPromocionConEvento()
        {
            DataRow nuevafila1;
            DataRow nuevafila2;
            DataRow nuevafila3;
            DataRow nuevafila4;
            DataRow nuevafila5;
            DataRow nuevafila6;
            DataRow nuevafila7;
            DataRow nuevafila8;
            DataRow nuevafila9;
            DataRow nuevafila10;
            DataRow nuevafila11;
            DataRow nuevafila12;
            PromocionEN promocionEN;
            int fila=0;

            try
            {
                if (radioButton_PE_5.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 1, ref fila))
                    {
                        nuevafila1 = tEspecConPromo.NewRow();
                        nuevafila1[0] = idEventoValor;
                        nuevafila1[1] = 1;
                        tEspecConPromo.Rows.Add(nuevafila1);
                        //MessageBox.Show("el de 5");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 1, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (radioButton_PE_10.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 2, ref fila))
                    {
                        nuevafila2 = tEspecConPromo.NewRow();
                        nuevafila2[0] = idEventoValor;
                        nuevafila2[1] = 2;
                        tEspecConPromo.Rows.Add(nuevafila2);
                        //MessageBox.Show("el de 10");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 2, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (radioButton_PE_25.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 3, ref fila))
                    {
                        nuevafila3 = tEspecConPromo.NewRow();
                        nuevafila3[0] = idEventoValor;
                        nuevafila3[1] = 3;
                        tEspecConPromo.Rows.Add(nuevafila3);
                        //MessageBox.Show("el de 25");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 3, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }




                if (radioButton_PE_50.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 4, ref fila))
                    {
                        nuevafila4 = tEspecConPromo.NewRow();
                        nuevafila4[0] = idEventoValor;
                        nuevafila4[1] = 4;
                        tEspecConPromo.Rows.Add(nuevafila4);
                        //MessageBox.Show("el de 50");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 4, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (radioButton_PE_IVA.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 5, ref fila))
                    {
                        nuevafila5 = tEspecConPromo.NewRow();
                        nuevafila5[0] = idEventoValor;
                        nuevafila5[1] = 5;
                        tEspecConPromo.Rows.Add(nuevafila5);
                        //MessageBox.Show("el de iva");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 5, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (checkBox_PE_menor25.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 6, ref fila))
                    {
                        nuevafila6 = tEspecConPromo.NewRow();
                        nuevafila6[0] = idEventoValor;
                        nuevafila6[1] = 6;
                        tEspecConPromo.Rows.Add(nuevafila6);
                        //MessageBox.Show("el de menor25");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 6, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }
                



                if (checkBox_PE_mayor65.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 7, ref fila))
                    {
                        nuevafila7 = tEspecConPromo.NewRow();
                        nuevafila7[0] = idEventoValor;
                        nuevafila7[1] = 7;
                        tEspecConPromo.Rows.Add(nuevafila7);
                        //MessageBox.Show("el de mayor65");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 7, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (checkBox_PE_descCliente.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 8, ref fila))
                    {
                        nuevafila8 = tEspecConPromo.NewRow();
                        nuevafila8[0] = idEventoValor;
                        nuevafila8[1] = 8;
                        tEspecConPromo.Rows.Add(nuevafila8);
                        //MessageBox.Show("el de cliente");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 8, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (checkBox_PE_descEstudiante.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 9, ref fila))
                    {
                        nuevafila9 = tEspecConPromo.NewRow();
                        nuevafila9[0] = idEventoValor;
                        nuevafila9[1] = 9;
                        tEspecConPromo.Rows.Add(nuevafila9);
                        //MessageBox.Show("el de estudiante");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 9, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (checkBox_PE_descJubilado.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 10, ref fila))
                    {
                        nuevafila10 = tEspecConPromo.NewRow();
                        nuevafila10[0] = idEventoValor;
                        nuevafila10[1] = 10;
                        tEspecConPromo.Rows.Add(nuevafila10);
                        //MessageBox.Show("el de jubilado");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 10, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }



                if (checkBox_PE_descParado.Checked)
                {
                    //Miramos si no existe ya la relacion, si no esta se crea
                    if (!BuscarPromoEspectaculo(idEventoValor, 11, ref fila))
                    {
                        nuevafila11 = tEspecConPromo.NewRow();
                        nuevafila11[0] = idEventoValor;
                        nuevafila11[1] = 11;
                        tEspecConPromo.Rows.Add(nuevafila11);
                        //MessageBox.Show("el de parado");
                    }
                }
                else
                {
                    if (BuscarPromoEspectaculo(idEventoValor, 11, ref fila))
                    {
                        BorrarPromoEspectaculo(fila);
                    }
                }

                if (radioButton_PE_otroDesc.Checked && !checkBox_PE_Ninguno.Checked)
                {
                    //Agregamos primero la nueva promocion custom si no esta
                    if (IdPromoMedianteCantidad(Convert.ToInt32(textBox_PE_otroDesc.Text)) == -1)
                    {
                        promocionEN = new PromocionEN(NuevaIdPromocion(), "Otra" + textBox_PE_otroDesc.Text.ToString(), Convert.ToInt32(textBox_PE_otroDesc.Text));
                        DataRow fOtro = tPromocion.NewRow();
                        promocionEN.InsertarEnDataRow(ref fOtro);
                        tPromocion.Rows.Add(fOtro);
                    }

                    //Ahora agregamos la relacion de esta promocion con el espectaculo
                    if (!BuscarPromoEspectaculo(idEventoValor, IdPromoMedianteCantidad(Convert.ToInt32(textBox_PE_otroDesc.Text)), ref fila))
                    {
                        nuevafila12 = tEspecConPromo.NewRow();
                        nuevafila12[0] = idEventoValor;
                        nuevafila12[1] = IdPromoMedianteCantidad(Convert.ToInt32(textBox_PE_otroDesc.Text));
                        tEspecConPromo.Rows.Add(nuevafila12);
                    }
                    foreach (DataRow f in tEspecConPromo.Rows)
                    {
                        if (f.RowState.ToString() != "Deleted")
                        {
                            if (Convert.ToInt32(f[0]) == idEventoValor && Convert.ToInt32(f[1]) > 11 && Convert.ToInt32(f[1]) != IdPromoMedianteCantidad(Convert.ToInt32(textBox_PE_otroDesc.Text)))
                            {
                                f.Delete();
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataRow f in tEspecConPromo.Rows)
                    {
                        if (f.RowState.ToString() != "Deleted")
                        {
                            if (Convert.ToInt32(f[0]) == idEventoValor && Convert.ToInt32(f[1]) > 11)
                            {
                                f.Delete();
                            }
                        }
                    }
                }
                    


                proEN.Save();
                MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch(Exception ex)
            {
                // MessageBox.Show("Error al guardar la promocion del evento " + ex);
                Console.WriteLine(ex.Message);
            }

            
        }

        //Funcin para obtener la idPromocion mediante su cantidad
        private int IdPromoMedianteCantidad(int cant)
        {
            int resul = -1;
            foreach (DataRow fila in tPromocion.Rows)
            {
                if (fila.RowState.ToString() != "Deleted")
                {
                    if(Convert.ToInt32(fila[2]) == cant)
                    {
                        resul = Convert.ToInt32(fila[0]);
                        break;
                    }
                }
            }
            return resul;
        }

        //Funcion para comprobar las cantidades numericas de las promociones por condicion
        private void ComproCantCondiciones()
        {
            //Comprobamos la Cantidad1
            if (!CompruebaCantidad(textBox_MC_VC_Cantidad1.Text.ToString()))
            {
                errorProvider_MC_Cant1.SetError(textBox_MC_VC_Cantidad1, "Debe ser un número entero");
                MC_Cantidad1 = false;
            }
            else
            {
                errorProvider_MC_Cant1.Clear();
                MC_Cantidad1 = true;
            }
            //Comprobamos en Descuento1
            if (!CompruebaCantidad(textBox_MC_VC_Descuento1.Text.ToString()))
            {
                errorProvider_MC_Desc1.SetError(textBox_MC_VC_Descuento1, "Debe ser un número entero");
                MC_Descuento1 = false;
            }
            else
            {
                errorProvider_MC_Desc1.Clear();
                MC_Descuento1 = true;
            }
            


            //Si está activada la segunda condición la comprobamos
            if (checkBox_MC_ActivarCond1.Checked)
            {
                //Comprobamos Cantidad2
                if (!CompruebaCantidad(textBox_MC_VC_Cantidad2.Text.ToString()))
                {
                    errorProvider_MC_Cant2.SetError(textBox_MC_VC_Cantidad2, "Debe ser un número entero");
                    MC_Cantidad2 = false;
                }
                else
                {
                    errorProvider_MC_Cant2.Clear();
                    MC_Cantidad2 = true;
                }
            }


            //Si está activada la tercera condición la comprobamos
            if (checkBox_MC_ActivarCond2.Checked)
            {
                //Comprobamos Cantidad3
                if (!CompruebaCantidad(textBox_MC_VC_Cantidad3.Text.ToString()))
                {
                    errorProvider_MC_Cant3.SetError(textBox_MC_VC_Cantidad3, "Debe ser un número entero");
                    MC_Cantidad3 = false;
                }
                else
                {
                    errorProvider_MC_Cant3.Clear();
                    MC_Cantidad3 = true;
                }
            }
        }

        //Funcion para comprobar los combobox y groupbox de condiciones
        private void ComproComboYGroup()
        {
            //Comprobamos el combobox TipoCondicion1
            if (comboBox_MC_VC_Tcondicion1.SelectedIndex != 0 && comboBox_MC_VC_Tcondicion1.SelectedIndex != 1 && comboBox_MC_VC_Tcondicion1.SelectedIndex != 2)
            {
                errorProvider_MC_TipoCondicion1.SetError(comboBox_MC_VC_Tcondicion1, "Debes elegir un Tipo Condición");
                MC_TipoCondicion1 = false;
            }
            else
            {
                errorProvider_MC_TipoCondicion1.Clear();
                MC_TipoCondicion1 = true;
            }

            //Comprobamos el combobox Comparacion1
            if (comboBox_MC_VC_Comparacion1.SelectedIndex != 0 && comboBox_MC_VC_Comparacion1.SelectedIndex != 1 && comboBox_MC_VC_Comparacion1.SelectedIndex != 2)
            {
                errorProvider_MC_Comparacion1.SetError(comboBox_MC_VC_Comparacion1, "Debes elegir una Comparación");
                MC_Comparacion1 = false;
            }
            else
            {
                errorProvider_MC_Comparacion1.Clear();
                MC_Comparacion1 = true;
            }

            //Comprobamos que se ha elegido un Tipo Evento
            if (!radioButton_MC_TE1_Cine.Checked && !radioButton_MC_TE1_Concierto.Checked && !radioButton_MC_TE1_Teatro.Checked && !radioButton_MC_TE1_Todos.Checked)
            {
                errorProvider_MC_TipoEvento1.SetError(groupBox_MC_TipoEvent1, "Debes seleccionar un Tipo Evento");
                MC_TipoEvento1 = false;
            }
            else
            {
                errorProvider_MC_TipoEvento1.Clear();
                MC_TipoEvento1 = true;
            }

            //Si esta activada la segunda condicion la comprobamos
            if (checkBox_MC_ActivarCond1.Checked)
            {
                //Comprobamos el combobox TipoCondicion2
                if (comboBox_MC_VC_Tcondicion2.SelectedIndex != 0 && comboBox_MC_VC_Tcondicion2.SelectedIndex != 1 && comboBox_MC_VC_Tcondicion2.SelectedIndex != 2)
                {
                    errorProvider_MC_TipoCondicion2.SetError(comboBox_MC_VC_Tcondicion2, "Debes elegir un Tipo Condición");
                    MC_TipoCondicion2 = false;
                }
                else
                {
                    errorProvider_MC_TipoCondicion2.Clear();
                    MC_TipoCondicion2 = true;
                }

                //Comprobamos el combobox Comparacion2
                if (comboBox_MC_VC_Comparacion2.SelectedIndex != 0 && comboBox_MC_VC_Comparacion2.SelectedIndex != 1 && comboBox_MC_VC_Comparacion2.SelectedIndex != 2)
                {
                    errorProvider_MC_Comparacion2.SetError(comboBox_MC_VC_Comparacion2, "Debes elegir una Comparación");
                    MC_Comparacion2 = false;
                }
                else
                {
                    errorProvider_MC_Comparacion2.Clear();
                    MC_Comparacion2 = true;
                }

                //Comprobamos que se ha elegido un Tipo Evento
                if (!radioButton_MC_TE2_Cine.Checked && !radioButton_MC_TE2_Concierto.Checked && !radioButton_MC_TE2_Teatro.Checked && !radioButton_MC_TE2_Todos.Checked)
                {
                    errorProvider_MC_TipoEvento2.SetError(groupBox_MC_TipoEvent2, "Debes seleccionar un Tipo Evento");
                    MC_TipoEvento2 = false;
                }
                else
                {
                    errorProvider_MC_TipoEvento2.Clear();
                    MC_TipoEvento2 = true;
                }
            }

            //Si esta activada la tercera condicion la comprobamos
            if (checkBox_MC_ActivarCond2.Checked)
            {
                //Comprobamos el combobox TipoCondicion3
                if (comboBox_MC_VC_Tcondicion3.SelectedIndex != 0 && comboBox_MC_VC_Tcondicion3.SelectedIndex != 1 && comboBox_MC_VC_Tcondicion3.SelectedIndex != 2)
                {
                    errorProvider_MC_TipoCondicion3.SetError(comboBox_MC_VC_Tcondicion3, "Debes elegir un Tipo Condición");
                    MC_TipoCondicion3 = false;
                }
                else
                {
                    errorProvider_MC_TipoCondicion3.Clear();
                    MC_TipoCondicion3 = true;
                }

                //Comprobamos el combobox Comparacion3
                if (comboBox_MC_VC_Comparacion3.SelectedIndex != 0 && comboBox_MC_VC_Comparacion3.SelectedIndex != 1 && comboBox_MC_VC_Comparacion3.SelectedIndex != 2)
                {
                    errorProvider_MC_Comparacion3.SetError(comboBox_MC_VC_Comparacion3, "Debes elegir una Comparación");
                    MC_Comparacion3 = false;
                }
                else
                {
                    errorProvider_MC_Comparacion3.Clear();
                    MC_Comparacion3 = true;
                }

                //Comprobamos que se ha elegido un Tipo Evento
                if (!radioButton_MC_TE3_Cine.Checked && !radioButton_MC_TE3_Concierto.Checked && !radioButton_MC_TE3_Teatro.Checked && !radioButton_MC_TE3_Todos.Checked)
                {
                    errorProvider_MC_TipoEvento3.SetError(groupBox_MC_TipoEvent3, "Debes seleccionar un Tipo Evento");
                    MC_TipoEvento3 = false;
                }
                else
                {
                    errorProvider_MC_TipoEvento3.Clear();
                    MC_TipoEvento3 = true;
                }
            }
        }

        //Funcion para comprobar que has puesto un nombre a la condicion
        private void ComproNombreYDescripcionCondicion()
        {
            if (textBox_MC_NomPromo.Text.ToString()=="")
            {
                errorProvider_MC_Nombre.SetError(label_MC_Nombre, "Debes poner un nombre");
                MC_Nombre = false;
            }
            else
            {
                errorProvider_MC_Nombre.Clear();
                MC_Nombre = true;
            }

            if (textBox_MC_Descripcion.Text.ToString() == "")
            {
                errorProvider_MC_Descripcion.SetError(label_MC_Descripcion, "Debes poner una descripcion");
                MC_Descripcion = false;
            }
            else
            {
                errorProvider_MC_Descripcion.Clear();
                MC_Descripcion = true;
            }
        }

        //Evento para guardar los datos modificados de las promociones por condicion
        private void button_MC_Guardar_Click(object sender, EventArgs e)
        {
            ComproCantCondiciones();
            ComproComboYGroup();
            ComproNombreYDescripcionCondicion();

            //Comprobamos que este todo listo
            if (checkBox_MC_ActivarCond1.Checked && checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que esten las 3 condiciones
                if (MC_Nombre && MC_Descripcion&& MC_Cantidad1 && MC_Cantidad2 && MC_Cantidad3 && 
                    MC_Descuento1 && 
                    MC_TipoCondicion1 && MC_TipoCondicion2 && MC_TipoCondicion3 && 
                    MC_Comparacion1 && MC_Comparacion2 && MC_Comparacion3 &&
                    MC_TipoEvento1 && MC_TipoEvento2 && MC_TipoEvento3)
                {
                    GuardarCondicion();
                }
            }
            else if (checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que la segunda este activada y la tercera no
                if (MC_Nombre && MC_Descripcion && MC_Cantidad1 && MC_Cantidad2 && 
                    MC_Descuento1 && 
                    MC_TipoCondicion1 && MC_TipoCondicion2 && 
                    MC_Comparacion1 && MC_Comparacion2 &&
                    MC_TipoEvento1 && MC_TipoEvento2)
                {
                    GuardarCondicion();
                }
            }
            else if (!checkBox_MC_ActivarCond1.Checked && checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que la segunda no este activada y la tercera si
                if (MC_Nombre && MC_Descripcion && MC_Cantidad1 && MC_Cantidad3 && 
                    MC_Descuento1 && 
                    MC_TipoCondicion1 && MC_TipoCondicion3 &&
                    MC_Comparacion1 && MC_Comparacion3 &&
                    MC_TipoEvento1 && MC_TipoEvento3)
                {
                    GuardarCondicion();
                }
            }
            else if (!checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que sólo este la primera
                if (MC_Nombre && MC_Descripcion && MC_Cantidad1 && MC_Descuento1 && MC_TipoCondicion1 && MC_Comparacion1 && MC_TipoEvento1)
                {
                    GuardarCondicion();
                }
            }
        }

        //Funcion pasa sacar el numero del tipo de evento seleccionado en las condiciones
        private int ObtenerTipoEvento(int numGropuBox)
        {
            int resul=0;

            if (numGropuBox == 1)
            {
                if (radioButton_MC_TE1_Cine.Checked)
                {
                    resul = 0;
                }
                else if (radioButton_MC_TE1_Teatro.Checked)
                {
                    resul = 1;
                }
                else if(radioButton_MC_TE1_Concierto.Checked)
                {
                    resul=2;
                }
                else if (radioButton_MC_TE1_Todos.Checked)
                {
                    resul = 3;
                }
            }
            else if (numGropuBox == 2)
            {
                if (radioButton_MC_TE2_Cine.Checked)
                {
                    resul = 0;
                }
                else if (radioButton_MC_TE2_Teatro.Checked)
                {
                    resul = 1;
                }
                else if (radioButton_MC_TE2_Concierto.Checked)
                {
                    resul = 2;
                }
                else if (radioButton_MC_TE2_Todos.Checked)
                {
                    resul = 3;
                }
            }
            else if (numGropuBox == 3)
            {
                if (radioButton_MC_TE3_Cine.Checked)
                {
                    resul = 0;
                }
                else if (radioButton_MC_TE3_Teatro.Checked)
                {
                    resul = 1;
                }
                else if (radioButton_MC_TE3_Concierto.Checked)
                {
                    resul = 2;
                }
                else if (radioButton_MC_TE3_Todos.Checked)
                {
                    resul = 3;
                }
            }

            return resul;
        }

        //Funcion obtener nueva id para guardar en condiciones
        private int NuevaIdCondicion()
        {
            if (tCondicion.Rows.Count > 0)
            {
                int nuevaID;
                nuevaID = Convert.ToInt32(tCondicion.Rows[0][0]);
                foreach (DataRow row in tCondicion.Rows)
                {
                    if (row.RowState.ToString() != "Deleted")
                    {
                        if (nuevaID < Convert.ToInt32(row[0]))
                        {
                            nuevaID = Convert.ToInt32(row[0]);
                        }
                    }
                }
                return nuevaID + 1;
            }
            else
            {
                return 1;
            }
        }

        //Funcion obtener nueva id para guardar en promociones
        private int NuevaIdPromocion()
        {
            int nuevaID;
            nuevaID = 12;
            foreach (DataRow row in tPromocion.Rows)
            {
                if (row.RowState.ToString() != "Deleted")
                {
                    if (Convert.ToInt32(row[0]) > nuevaID)
                    {
                        nuevaID = Convert.ToInt32(row[0]);
                    }
                }
            }
            return nuevaID + 1;
        }

        //Funcion para guardar los cambios en la condicion seleccionada sobre la BD
        private void GuardarCondicion()
        {
            DataRow fila = tCondicion.NewRow();
            
            CondicionEN condicionEN;

            #region imagen
            MemoryStream imgdefault = new MemoryStream();
            Events4ALL.Properties.Resources.image_default.Save(imgdefault, ImageFormat.Jpeg);
            Byte[] imagen = imgdefault.GetBuffer();
            if (insertarNueva)
            {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_MC_CartelPromo.Image.Save(ms, ImageFormat.Jpeg);
                    imagen = ms.GetBuffer();
            }
            else
            {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_MC_CartelPromo.Image.Save(ms, ImageFormat.Jpeg);
                    imagen = ms.GetBuffer();
            }
            #endregion

            #region crear el EN
            if (!checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //Solo insertar la condicion obliglatoria
                    condicionEN = new CondicionEN(NuevaIdCondicion(), textBox_MC_NomPromo.Text.ToString().Trim(), textBox_MC_Descripcion.Text.ToString(), Convert.ToInt32(comboBox_MC_VC_Tcondicion1.SelectedIndex),
                            Convert.ToInt32(comboBox_MC_VC_Comparacion1.SelectedIndex),
                            Convert.ToInt32(textBox_MC_VC_Cantidad1.Text),
                            Convert.ToInt32(textBox_MC_VC_Descuento1.Text),
                            ObtenerTipoEvento(1),
                            -1, -1, -1, -1, -1, -1, -1, -1, checkBox_MC_ActPromo.Checked, 
                            imagen);

            
            }
            else if(checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //Se inserta la primera y segunda condicion
                    condicionEN = new CondicionEN(NuevaIdCondicion(), textBox_MC_NomPromo.Text.ToString(), textBox_MC_Descripcion.Text.ToString(),
                            Convert.ToInt32(comboBox_MC_VC_Tcondicion1.SelectedIndex),
                            Convert.ToInt32(comboBox_MC_VC_Comparacion1.SelectedIndex),
                            Convert.ToInt32(textBox_MC_VC_Cantidad1.Text),
                            Convert.ToInt32(textBox_MC_VC_Descuento1.Text),
                            ObtenerTipoEvento(1),
                            Convert.ToInt32(comboBox_MC_VC_Tcondicion2.SelectedIndex),
                            Convert.ToInt32(comboBox_MC_VC_Comparacion2.SelectedIndex),
                            Convert.ToInt32(textBox_MC_VC_Cantidad2.Text),
                            ObtenerTipoEvento(2),
                            -1, -1, -1, -1, checkBox_MC_ActPromo.Checked, 
                            imagen);
            }
            else if (!checkBox_MC_ActivarCond1.Checked && checkBox_MC_ActivarCond2.Checked)
            {
                //Se insertan la primera y terecera
                condicionEN = new CondicionEN(NuevaIdCondicion(), textBox_MC_NomPromo.Text.ToString(), textBox_MC_Descripcion.Text.ToString(),
                        Convert.ToInt32(comboBox_MC_VC_Tcondicion1.SelectedIndex),
                        Convert.ToInt32(comboBox_MC_VC_Comparacion1.SelectedIndex),
                        Convert.ToInt32(textBox_MC_VC_Cantidad1.Text),
                        Convert.ToInt32(textBox_MC_VC_Descuento1.Text),
                        ObtenerTipoEvento(1),
                        -1,
                        -1,
                        -1,
                        -1,
                        Convert.ToInt32(comboBox_MC_VC_Tcondicion3.SelectedIndex),
                        Convert.ToInt32(comboBox_MC_VC_Comparacion3.SelectedIndex),
                        Convert.ToInt32(textBox_MC_VC_Cantidad3.Text),
                        ObtenerTipoEvento(3),
                        checkBox_MC_ActPromo.Checked,
                        imagen);
            }
            else
            {
                //Se insertan las tres condiciones
                condicionEN = new CondicionEN(NuevaIdCondicion(), textBox_MC_NomPromo.Text.ToString(), textBox_MC_Descripcion.Text.ToString(),
                        Convert.ToInt32(comboBox_MC_VC_Tcondicion1.SelectedIndex),
                        Convert.ToInt32(comboBox_MC_VC_Comparacion1.SelectedIndex),
                        Convert.ToInt32(textBox_MC_VC_Cantidad1.Text),
                        Convert.ToInt32(textBox_MC_VC_Descuento1.Text),
                        ObtenerTipoEvento(1),
                        Convert.ToInt32(comboBox_MC_VC_Tcondicion2.SelectedIndex),
                        Convert.ToInt32(comboBox_MC_VC_Comparacion2.SelectedIndex),
                        Convert.ToInt32(textBox_MC_VC_Cantidad2.Text),
                        ObtenerTipoEvento(2),
                        Convert.ToInt32(comboBox_MC_VC_Tcondicion3.SelectedIndex),
                        Convert.ToInt32(comboBox_MC_VC_Comparacion3.SelectedIndex),
                        Convert.ToInt32(textBox_MC_VC_Cantidad3.Text),
                        ObtenerTipoEvento(3),
                        checkBox_MC_ActPromo.Checked,
                        imagen);
            }
            #endregion

            #region insertar nueva o modificar existente
            if (insertarNueva)
            {
                condicionEN.InsertarEnDataRow(ref fila);
                tCondicion.Rows.Add(fila);
                conEN.Save();
                insertarNueva = false;
            }
            else
            {
                condicionEN.ModificarFilaDeDataTable(NumFilaTabla(Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[0].Value)),ref tCondicion);
                conEN.Save();
            }
            #endregion
            button_MC_Guardar.Enabled = false;
            MC_limpiar(1);
            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        //Funcion para limpiar campos (1 todos, 0 todos menos los textos de los combobox, 2 solo del segundo bloque de condiciones, 3 solo del tercer bloque de condiciones) de promociones por condicion
        private void MC_limpiar(int todo)
        {
            //true en caso de limpiar todos los campos
            if (todo == 1)
            {
                button_MC_Guardar.Enabled = false;
                textBox_MC_NomPromo.Enabled = false;
                textBox_MC_Descripcion.Enabled = false;
                groupBox_MC_TipoDeCond.Enabled = false;
                checkBox_MC_ActPromo.Enabled = false;
                button_MC_SubirFoto.Enabled = false;

                textBox_MC_NomPromo.Text = "";
                textBox_MC_Descripcion.Text = "";
                comboBox_MC_VC_Tcondicion1.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion1.Text = "Comparación";
                textBox_MC_VC_Cantidad1.Text = "";
                textBox_MC_VC_Descuento1.Text = "";
                radioButton_MC_TE1_Cine.Checked = false;
                radioButton_MC_TE1_Concierto.Checked = false;
                radioButton_MC_TE1_Teatro.Checked = false;
                radioButton_MC_TE1_Todos.Checked = false;
                checkBox_MC_ActivarCond1.Checked = false;
                comboBox_MC_VC_Tcondicion2.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion2.Text = "Comparación";
                textBox_MC_VC_Cantidad2.Text = "";
                radioButton_MC_TE2_Cine.Checked = false;
                radioButton_MC_TE2_Concierto.Checked = false;
                radioButton_MC_TE2_Teatro.Checked = false;
                radioButton_MC_TE2_Todos.Checked = false;
                checkBox_MC_ActivarCond2.Checked = false;
                comboBox_MC_VC_Tcondicion3.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion3.Text = "Comparación";
                textBox_MC_VC_Cantidad3.Text = "";
                radioButton_MC_TE3_Cine.Checked = false;
                radioButton_MC_TE3_Concierto.Checked = false;
                radioButton_MC_TE3_Teatro.Checked = false;
                radioButton_MC_TE3_Todos.Checked = false;
                checkBox_MC_ActPromo.Checked = false;
                pictureBox_MC_CartelPromo.Image = Events4ALL.Properties.Resources.image_default;
            }
            //caso de limipiar todos menos los combobox del primer bloque
            else if (todo == 0)
            {
                textBox_MC_NomPromo.Text = "";
                textBox_MC_Descripcion.Text = "";
                textBox_MC_VC_Cantidad1.Text = "";
                textBox_MC_VC_Descuento1.Text = "";
                radioButton_MC_TE1_Cine.Checked = false;
                radioButton_MC_TE1_Concierto.Checked = false;
                radioButton_MC_TE1_Teatro.Checked = false;
                radioButton_MC_TE1_Todos.Checked = false;
                checkBox_MC_ActivarCond1.Checked = false;
                comboBox_MC_VC_Tcondicion2.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion2.Text = "Comparación";
                textBox_MC_VC_Cantidad2.Text = "";
                radioButton_MC_TE2_Cine.Checked = false;
                radioButton_MC_TE2_Concierto.Checked = false;
                radioButton_MC_TE2_Teatro.Checked = false;
                radioButton_MC_TE2_Todos.Checked = false;
                checkBox_MC_ActivarCond2.Checked = false;
                comboBox_MC_VC_Tcondicion3.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion3.Text = "Comparación";
                textBox_MC_VC_Cantidad3.Text = "";
                radioButton_MC_TE3_Cine.Checked = false;
                radioButton_MC_TE3_Concierto.Checked = false;
                radioButton_MC_TE3_Teatro.Checked = false;
                radioButton_MC_TE3_Todos.Checked = false;
                pictureBox_MC_CartelPromo.Image = Events4ALL.Properties.Resources.image_default;
            }
            //Solo limpiar segundo bloque
            else if (todo == 2)
            {
                comboBox_MC_VC_Tcondicion2.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion2.Text = "Comparación";
                textBox_MC_VC_Cantidad2.Text = "";
                radioButton_MC_TE2_Cine.Checked = false;
                radioButton_MC_TE2_Concierto.Checked = false;
                radioButton_MC_TE2_Teatro.Checked = false;
                radioButton_MC_TE2_Todos.Checked = false;
            }
            //Solo limpiar tercer bloque
            else if (todo == 3)
            {
                comboBox_MC_VC_Tcondicion3.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion3.Text = "Comparación";
                textBox_MC_VC_Cantidad3.Text = "";
                radioButton_MC_TE3_Cine.Checked = false;
                radioButton_MC_TE3_Concierto.Checked = false;
                radioButton_MC_TE3_Teatro.Checked = false;
                radioButton_MC_TE3_Todos.Checked = false;
            }
        }

        //Evento para cargar los datos de la fila seleccionada del datagridview
        private void dataGridView_MC_ListaPromosCond_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarErrorProvider(1);
            limpiarErrorProvider(2);
            limpiarErrorProvider(3);
            button_MC_Guardar.Enabled = true;
            textBox_MC_NomPromo.Enabled = true;
            textBox_MC_Descripcion.Enabled = true;
            groupBox_MC_TipoDeCond.Enabled = true;
            checkBox_MC_ActPromo.Enabled = true;
            button_MC_SubirFoto.Enabled = true;
            if (insertarNueva)
            {
                if (MessageBox.Show("Has pulsado Nueva condición ¿Realmente quieres cancelar la insercion de una nueva condición? ", "Nueva condición", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    insertarNueva = false;
                    
                }
                
            }

            if (!insertarNueva)
            {
                #region Codigo Para rellenar los datos
                try
                {
                    errorProvider_MC_Nombre.Clear();
                    errorProvider_MC_Descripcion.Clear();
                    button_MC_Eliminar.Enabled = true;
                    MC_limpiar(0);
                    //Para el bloque 1 de las condiciones
                    //relleno el nombre de la fila seleccionada
                    textBox_MC_NomPromo.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[1].Value.ToString();
                    //relleno la descipción del a fila seleccionada
                    textBox_MC_Descripcion.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[2].Value.ToString();
                    //eligo la condición de la fila seleccionada
                    comboBox_MC_VC_Tcondicion1.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[3].Value);
                    //eligo la comparación de la fila seleccionada
                    comboBox_MC_VC_Comparacion1.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[4].Value);
                    //relleno la cantidad de la fila seleccionada
                    textBox_MC_VC_Cantidad1.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[5].Value.ToString();
                    //relleno el descuento de la fila seleccionada
                    textBox_MC_VC_Descuento1.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[6].Value.ToString();
                    //marco el tipo evento de la fila seleccionada
                    if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[7].Value) == 0)
                    {
                        radioButton_MC_TE1_Cine.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[7].Value) == 1)
                    {
                        radioButton_MC_TE1_Teatro.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[7].Value) == 2)
                    {
                        radioButton_MC_TE1_Concierto.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[7].Value) == 3)
                    {
                        radioButton_MC_TE1_Todos.Checked = true;
                    }
                    //Marcar si esta activada o no la promocion seleccionada
                    checkBox_MC_ActPromo.Checked = Convert.ToBoolean(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[16].Value);
                    //Cargando la imagen, si tiene, si no, se muesra la de por defecto
                    if (dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value != System.DBNull.Value)
                    {
                        byte[] bImage = (byte[])dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value;
                        MemoryStream ms = new MemoryStream(bImage);
                        pictureBox_MC_CartelPromo.Image = Image.FromStream(ms, true, true);
                    }
                    else
                    {
                        pictureBox_MC_CartelPromo.Image = Events4ALL.Properties.Resources.image_default;
                    }

                    //Para el bloque 2 de las condiciones
                    if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[8].Value) != -1)
                    {
                        //Con esto fuerzo a volver a cargar el SelectedIndex porque si es el mismo no muesra el texto aunque cambie, ya que el SelectedIndex es el mismo
                        comboBox_MC_VC_Tcondicion2.SelectedIndex = -1;
                        comboBox_MC_VC_Comparacion2.SelectedIndex = -1;
                        //eligo la condición de la fila seleccionada
                        comboBox_MC_VC_Tcondicion2.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[8].Value);
                        //eligo la comparación de la fila seleccionada
                        comboBox_MC_VC_Comparacion2.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[9].Value);
                        //relleno la cantidad de la fila seleccionada
                        textBox_MC_VC_Cantidad2.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[10].Value.ToString();
                        //marco el tipo evento de la fila seleccionada
                        if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[11].Value) == 0)
                        {
                            radioButton_MC_TE2_Cine.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[11].Value) == 1)
                        {
                            radioButton_MC_TE2_Teatro.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[11].Value) == 2)
                        {
                            radioButton_MC_TE2_Concierto.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[11].Value) == 3)
                        {
                            radioButton_MC_TE2_Todos.Checked = true;
                        }
                        checkBox_MC_ActivarCond1.Checked = true;
                    }

                    //Para el bloque 3 de las condiciones
                    if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value) != -1)
                    {
                        //Con esto fuerzo a volver a cargar el SelectedIndex porque si es el mismo no muesra el texto aunque cambie, ya que el SelectedIndex es el mismo
                        comboBox_MC_VC_Tcondicion3.SelectedIndex = -1;
                        comboBox_MC_VC_Comparacion3.SelectedIndex = -1;
                        //eligo la condición de la fila seleccionada
                        comboBox_MC_VC_Tcondicion3.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value);
                        //eligo la comparación de la fila seleccionada
                        comboBox_MC_VC_Comparacion3.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[13].Value);
                        //relleno la cantidad de la fila seleccionada
                        textBox_MC_VC_Cantidad3.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[14].Value.ToString();
                        //marco el tipo evento de la fila seleccionada
                        if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[15].Value) == 0)
                        {
                            radioButton_MC_TE3_Cine.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[15].Value) == 1)
                        {
                            radioButton_MC_TE3_Teatro.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[15].Value) == 2)
                        {
                            radioButton_MC_TE3_Concierto.Checked = true;
                        }
                        else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[15].Value) == 3)
                        {
                            radioButton_MC_TE3_Todos.Checked = true;
                        }
                        checkBox_MC_ActivarCond2.Checked = true;
                    }
                }
                catch(System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No has seleccionado ninguna fila", "Seleccionar condición", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    MC_limpiar(1);
                    button_MC_Eliminar.Enabled = false;
                }

                #endregion
            }
        }

        //Evento para quitar el errorprovider del radiobuton Otro si se seleciona otro y acticar/desactivar el textbox asociado
        private void radioButton_PE_otroDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_PE_otroDesc.Checked)
            {
                errorProvider_PE_Otro.Clear();
                textBox_PE_otroDesc.Enabled = false;
            }
            else
            {
                textBox_PE_otroDesc.Enabled = true;
            }
        }

        //Evento para habilitar o deshabilitar las promociones generales
        private void checkBox_PE_Ninguno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PE_Ninguno.Checked)
            {
                radioButton_PE_5.Enabled = false;
                radioButton_PE_10.Enabled = false;
                radioButton_PE_25.Enabled = false;
                radioButton_PE_50.Enabled = false;
                radioButton_PE_IVA.Enabled = false;
                radioButton_PE_otroDesc.Enabled = false;
                textBox_PE_otroDesc.Enabled = false;
            }
            else
            {
                radioButton_PE_5.Enabled = true;
                radioButton_PE_10.Enabled = true;
                radioButton_PE_25.Enabled = true;
                radioButton_PE_50.Enabled = true;
                radioButton_PE_IVA.Enabled = true;
                radioButton_PE_otroDesc.Enabled = true;
                textBox_PE_otroDesc.Enabled = true;
            }
            limpiarErrorProviderEspectaculos();
        }

        //Evento para recargar el combobox de espectaculos
        private void comboBox_PE_espectaculo_Click(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        //Limpiar radiobutons y chebox de pestaña por espectaculo
        private void LimpiarPorEspectaculo()
        {
            radioButton_PE_5.Checked = false;
            radioButton_PE_10.Checked = false;
            radioButton_PE_25.Checked = false;
            radioButton_PE_50.Checked = false;
            radioButton_PE_IVA.Checked = false;
            radioButton_PE_otroDesc.Checked = false;
            textBox_PE_otroDesc.Text = "";
            textBox_PE_otroDesc.Enabled = false;
            checkBox_PE_menor25.Checked = false;
            checkBox_PE_mayor65.Checked = false;
            checkBox_PE_descCliente.Checked = false;
            checkBox_PE_descEstudiante.Checked = false;
            checkBox_PE_descJubilado.Checked = false;
            checkBox_PE_descParado.Checked = false;
        }

        //Funcion para obtener la id de la promcocion mediandte la id del espectaculo en la tabla PromosConEspectaculo
        private int ObtenerIdPromocion(int idEspectaculo)
        {
            int resul = 0;

            foreach (DataRow fila in tEspecConPromo.Rows)
            {
                if (fila.RowState.ToString() != "Deleted")
                {
                    if (Convert.ToInt32(fila[0]) == idEspectaculo)
                    {
                        resul = Convert.ToInt32(fila[1]);
                    }
                }
            }

            return resul;
        }

        //Funcion para obtener la cantidad de descuento del descuento Otro de las promociones para eventos
        private int ObtenerCantidadOtroPromocion(int idPromocion)
        {
            int resul = -1;

            foreach (DataRow fila in tPromocion.Rows)
            {
                if (fila.RowState.ToString() != "Deleted")
                {
                    if (Convert.ToInt32(fila[0]) == idPromocion)
                    {
                        resul = Convert.ToInt32(fila[2]);
                    }
                }
            }
            return resul;
        }

        //Evento para cargar los datos cuando seleccionas un item del combo box
        private void comboBox_PE_espectaculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_PE_Guardar.Enabled = true;
            groupBox_PE_promoEvent.Enabled = true;
            groupBox_PE_promoGen.Enabled = true;
            idEventoSelec = Convert.ToInt32(comboBox_PE_espectaculo.SelectedIndex);
            idEventoValor = Convert.ToInt32(tEspec.Rows[idEventoSelec][0]);
            label_PE_TTitulo.Text = tEspec.Rows[idEventoSelec][1].ToString();
            label_PE_TTipo.Text = tEspec.Rows[idEventoSelec][6].ToString();
            label_PE_TDescripcion.Text = tEspec.Rows[idEventoSelec][2].ToString();
            DateTime fini, ffin;
            fini = (DateTime)tEspec.Rows[idEventoSelec][3];
            ffin =(DateTime)tEspec.Rows[idEventoSelec][4];
            label_PE_TFechaIni.Text = fini.ToShortDateString();
            label_PE_TFechaFin.Text = ffin.ToShortDateString();
            label_PE_TPrecio.Text = Convert.ToInt32(tEspec.Rows[idEventoSelec][5]).ToString("C2");
            //Cargando la imagen, si tiene, si no, se muesra la de por defecto
            if (tEspec.Rows[idEventoSelec][7] != System.DBNull.Value)
            {
                byte[] bImage = (byte[])tEspec.Rows[idEventoSelec][7];
                MemoryStream ms = new MemoryStream(bImage);
                pictureBox_PE_imagEspec.Image = Image.FromStream(ms, true, true);
            }
            else
            {
                pictureBox_PE_imagEspec.Image = Events4ALL.Properties.Resources.image_default;
            }

            LimpiarPorEspectaculo();

            foreach (DataRow obj in tEspecConPromo.Rows)
            {
                if (obj.RowState.ToString() != "Deleted")
                {
                    if (idEventoValor == Convert.ToInt32(obj[0]))
                    {
                        if (Convert.ToInt32(obj[1]) == 1)
                        {
                            radioButton_PE_5.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 2)
                        {
                            radioButton_PE_10.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 3)
                        {
                            radioButton_PE_25.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 4)
                        {
                            radioButton_PE_50.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 5)
                        {
                            radioButton_PE_IVA.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == ObtenerIdPromocion(idEventoValor) && ObtenerIdPromocion(idEventoValor) > 11)
                        {
                            radioButton_PE_otroDesc.Checked = true;
                            textBox_PE_otroDesc.Enabled = true;
                            textBox_PE_otroDesc.Text = ObtenerCantidadOtroPromocion(ObtenerIdPromocion(idEventoValor)).ToString();
                        }

                        if (Convert.ToInt32(obj[1]) == 6)
                        {
                            checkBox_PE_menor25.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 7)
                        {
                            checkBox_PE_mayor65.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 8)
                        {
                            checkBox_PE_descCliente.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 9)
                        {
                            checkBox_PE_descEstudiante.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 10)
                        {
                            checkBox_PE_descJubilado.Checked = true;
                        }

                        if (Convert.ToInt32(obj[1]) == 11)
                        {
                            checkBox_PE_descParado.Checked = true;
                        }
                    }
                }
            }
            if (!radioButton_PE_5.Checked && !radioButton_PE_10.Checked && !radioButton_PE_25.Checked && !radioButton_PE_50.Checked && !radioButton_PE_IVA.Checked && !radioButton_PE_otroDesc.Checked)
            {
                checkBox_PE_Ninguno.Checked = true;
                radioButton_PE_5.Checked = false;
                radioButton_PE_10.Checked = false;
                radioButton_PE_25.Checked = false;
                radioButton_PE_50.Checked = false;
                radioButton_PE_IVA.Checked = false;
            }
            else
            {
                checkBox_PE_Ninguno.Checked = false;
            }
        }

        //Funcion para limpiar los errorProvider de las condiciones
        private void limpiarErrorProvider(int cual)
        {
            if (cual == 1)
            {
                errorProvider_MC_Cant1.Clear();
                errorProvider_MC_Desc1.Clear();
                errorProvider_MC_TipoCondicion1.Clear();
                errorProvider_MC_Comparacion1.Clear();
                errorProvider_MC_TipoEvento1.Clear();
            }
            else if (cual == 2)
            {
                errorProvider_MC_Cant2.Clear();
                errorProvider_MC_TipoCondicion2.Clear();
                errorProvider_MC_Comparacion2.Clear();
                errorProvider_MC_TipoEvento2.Clear();
            }
            else if (cual == 3)
            {
                errorProvider_MC_Cant3.Clear();
                errorProvider_MC_TipoCondicion3.Clear();
                errorProvider_MC_Comparacion3.Clear();
                errorProvider_MC_TipoEvento3.Clear();
            }
        }

        //Funcion para limpiar los errorProvider de las promociones espectaculo
        private void limpiarErrorProviderEspectaculos()
        {
            errorProvider_PE_eligeuno.Clear();
            errorProvider_PE_Otro.Clear();
        }

        //Funcion para desactivar el grupo de condiciones segunda o tercera
        private void DesactivarCondicion(int cual)
        {
            if (cual == 1)
            {
                textBox_MC_VC_Cantidad2.Enabled = false;
                comboBox_MC_VC_Comparacion2.Enabled = false;
                comboBox_MC_VC_Tcondicion2.Enabled = false;
                radioButton_MC_TE2_Cine.Enabled = false;
                radioButton_MC_TE2_Concierto.Enabled = false;
                radioButton_MC_TE2_Teatro.Enabled = false;
                radioButton_MC_TE2_Todos.Enabled = false;
                checkBox_MC_ActivarCond1.Checked = false;
            }
            else if (cual == 2)
            {
                textBox_MC_VC_Cantidad3.Enabled = false;
                comboBox_MC_VC_Comparacion3.Enabled = false;
                comboBox_MC_VC_Tcondicion3.Enabled = false;
                radioButton_MC_TE3_Cine.Enabled = false;
                radioButton_MC_TE3_Concierto.Enabled = false;
                radioButton_MC_TE3_Teatro.Enabled = false;
                radioButton_MC_TE3_Todos.Enabled = false;
                checkBox_MC_ActivarCond2.Checked = false;
            }
        }

        //Evento para introducir una nueva condicion
        private void button_MC_Nueva_Click(object sender, EventArgs e)
        {
            MC_limpiar(1);
            limpiarErrorProvider(1);
            limpiarErrorProvider(2);
            limpiarErrorProvider(3);
            button_MC_Guardar.Enabled = true;
            button_MC_Eliminar.Enabled = false;
            textBox_MC_NomPromo.Enabled = true;
            textBox_MC_Descripcion.Enabled = true;
            groupBox_MC_TipoDeCond.Enabled = true;
            checkBox_MC_ActPromo.Enabled = true;
            button_MC_SubirFoto.Enabled = true;
            checkBox_MC_ActivarCond1.Checked = false;
            checkBox_MC_ActivarCond2.Checked = false;
            insertarNueva = true;
        }

        //Funcion para eliminar una condicion
        private void button_MC_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente quieres eliminar la condicion " + dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[1].Value.ToString() + " ?", "Eliminar condición", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[0].Value));
                    int cual = NumFilaTabla(id);
                    if (Convert.ToInt32(tCondicion.Rows[cual][0]) == id)
                    {
                        tCondicion.Rows[cual].Delete();
                        conEN.Save();
                        MC_limpiar(1);
                        button_MC_Guardar.Enabled=false;
                        button_MC_Eliminar.Enabled = false;
                    }


                }
            }
            catch
            {
                MessageBox.Show("No hay ninguna fila seleccionada","Eliminar condición",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        //Funcion para saber que fila corresponde al DataTable mediante su idCondicion
        private int NumFilaTabla(int id)
        {
            int i;
            bool sal = false;
            for (i = 0; i < tCondicion.Rows.Count && !sal; i++)
            {
                if (Convert.ToInt32(tCondicion.Rows[i][0]) == id)
                {
                    sal = true;
                }
            }
            return i-1;
        }

        //Funcion para poner una imagen
        private void button_MC_SubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.ShowHelp = true;
            
            OFich.Filter = "Archivos de imagen (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";

            pictureBox_MC_CartelPromo.SizeMode = PictureBoxSizeMode.CenterImage;
            if (OFich.ShowDialog() == DialogResult.OK)
            {
                pictureBox_MC_CartelPromo.Image = Image.FromFile(OFich.FileName);
            }  
        }

        //Funcion para eliminar las relaciones de los espectaculos
        public void EliminarEspecConPromo(int id)
        {
            //Borramos de la tabla local Espectaculo, el espectaculo pasado por su id
            //Esto no se refleja en la BD original, solo en la local con la que trabajo
            foreach (DataRow fila in tEspec.Rows)
            {
                if (fila.RowState.ToString() != "Deleted")
                {
                    if (Convert.ToInt32(fila[0]) == id)
                    {
                        fila.Delete();
                        break;
                    }
                }
            }

            //Borramos de la tabla local PromocionesConEspectaculo las relaciones
            foreach (DataRow fila in tEspecConPromo.Rows)
            {
                if (fila.RowState.ToString() != "Deleted")
                {
                    if (Convert.ToInt32(fila[0]) == id)
                    {
                        fila.Delete();
                    }
                }
            }
        }
    }
}
