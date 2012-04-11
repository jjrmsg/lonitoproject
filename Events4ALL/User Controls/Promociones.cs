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

namespace Events4ALL
{
    public partial class Promociones : UserControl
    {
        private bool PE_Cantidad;
        private bool MC_Cantidad1;
        private bool MC_Cantidad2;
        private bool MC_Cantidad3;
        private bool MC_Descuento1;
        private bool MC_Descuento2;
        private bool MC_Descuento3;
        private PromocionEN proEN;
        private CondicionEN conEN;
        private DataSet promos;
        private DataSet espec;
        private DataTable tcon;
        private DataRow nuevafila;

        public Promociones()
        {
            InitializeComponent();
            proEN = new PromocionEN();
            conEN = new CondicionEN();
        }

        private void checkBox_MC_ActivarCond1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond1.Checked == true)
            {
                textBox_MC_VC_Cantidad2.Enabled = true;
                textBox_MC_VC_Descuento2.Enabled = true;
                comboBox_MC_VC_Comparacion2.Enabled = true;
                comboBox_MC_VC_Tcondicion2.Enabled = true;
                radioButton_MC_TE2_Cine.Enabled = true;
                radioButton_MC_TE2_Concierto.Enabled = true;
                radioButton_MC_TE2_Teatro.Enabled = true;
                radioButton_MC_TE2_Todos.Enabled = true;
            }
            else
            {
                textBox_MC_VC_Cantidad2.Enabled = false;
                textBox_MC_VC_Descuento2.Enabled = false;
                comboBox_MC_VC_Comparacion2.Enabled = false;
                comboBox_MC_VC_Tcondicion2.Enabled = false;
                radioButton_MC_TE2_Cine.Enabled = false;
                radioButton_MC_TE2_Concierto.Enabled = false;
                radioButton_MC_TE2_Teatro.Enabled = false;
                radioButton_MC_TE2_Todos.Enabled = false;
                errorProvider_MC_Cant2.Clear();
                errorProvider_MC_Desc2.Clear();
            }
        }

        private void checkBox_MC_ActivarCond2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MC_ActivarCond2.Checked == true)
            {
                textBox_MC_VC_Cantidad3.Enabled = true;
                textBox_MC_VC_Descuento3.Enabled = true;
                comboBox_MC_VC_Comparacion3.Enabled = true;
                comboBox_MC_VC_Tcondicion3.Enabled = true;
                radioButton_MC_TE3_Cine.Enabled = true;
                radioButton_MC_TE3_Concierto.Enabled = true;
                radioButton_MC_TE3_Teatro.Enabled = true;
                radioButton_MC_TE3_Todos.Enabled = true;
            }
            else
            {
                textBox_MC_VC_Cantidad3.Enabled = false;
                textBox_MC_VC_Descuento3.Enabled = false;
                comboBox_MC_VC_Comparacion3.Enabled = false;
                comboBox_MC_VC_Tcondicion3.Enabled = false;
                radioButton_MC_TE3_Cine.Enabled = false;
                radioButton_MC_TE3_Concierto.Enabled = false;
                radioButton_MC_TE3_Teatro.Enabled = false;
                radioButton_MC_TE3_Todos.Enabled = false;
                errorProvider_MC_Cant3.Clear();
                errorProvider_MC_Desc3.Clear();
            }
        }

        /*
        public bool isCaracterValido(Char c)
        {
            if ((c >= '0' && c <= '9') || (Char)Keys.Back==c)
            {
                return true;
            }
            return false;
        }
        
        
        private void textBox_PE_TOtroDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!isCaracterValido (e.KeyChar))
             {
                e.Handled = true;
             }
        }

        private void textBox_MC_VC_Valor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isCaracterValido(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_MC_VC_Valor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isCaracterValido(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_MC_VC_Valor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isCaracterValido(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        */
        
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

        private void Promociones_Load(object sender, EventArgs e)
        {
            #region cargar datagridview
            promos = new DataSet();
            promos = conEN.ObtenerTodas();
            tcon = new DataTable();
            try
            {
                tcon = promos.Tables["Condicion"];
                //añadiendo nueva fila a la tabla, es un ejemplo de forma manual
                //esta linea tiene que estar si no el VisualStudio se pone a llorar y el FormBase peta. ¿pq? -> Preguntaselo a Microsoft xD
                nuevafila = tcon.NewRow();
                //nuevafila[1] = "ejemplo";
                //nuevafila[2] = "Esto se añade a la tabla pero no se guarda en la BD";
                //nuevafila[3] = 1;
                //nuevafila[4] = 1;
                //nuevafila[5] = 1;
                //nuevafila[6] = 1;
                //nuevafila[7] = 1;
                //nuevafila[18] = false;
                //tcon.Rows.Add(nuevafila);
                //conEN.Save();
                
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
                dataGridView_MC_ListaPromosCond.Columns[16].Visible = false;
                dataGridView_MC_ListaPromosCond.Columns[17].Visible = false;
                dataGridView_MC_ListaPromosCond.ReadOnly = true;
                dataGridView_MC_ListaPromosCond.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_MC_ListaPromosCond.MultiSelect = false;
                dataGridView_MC_ListaPromosCond.AllowUserToAddRows = false;
                
            }
            catch
            {
                //MessageBox.Show("error");
            }
            #endregion
            
            #region cargar combobox
            espec = new DataSet();
            espec = proEN.ObtenerEspectaculos();
            DataTable t = new DataTable();
            t = espec.Tables["Espectaculo"];

            try
            {
                foreach (DataRow obj in t.Rows)
                {
                    comboBox_PE_espectaculo.Items.Add(obj["Titulo"].ToString());
                }
            }
            catch
            {
                //MessageBox.Show("error");
            }
            #endregion
        }

        private void button_PE_Guardar_Click(object sender, EventArgs e)
        {
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

            if (!checkBox_PE_Ninguno.Checked)
            {
                //Comprobamos si esta elegido Otro y la cantidad es un número entero
                if (radioButton_PE_otroDesc.Checked && PE_Cantidad)
                {
                    MessageBox.Show("Listo para guardar1");
                }
                else if (!radioButton_PE_otroDesc.Checked && (radioButton_PE_5.Checked || radioButton_PE_10.Checked || radioButton_PE_20.Checked || radioButton_PE_50.Checked || radioButton_PE_IVA.Checked))
                {
                    //Si se selecciona otro que no sea Otro también se puede guardar ya que no hay restricción mínima
                    MessageBox.Show("Listo para guardar2");
                }
            }
            else 
            {
                MessageBox.Show("Listo para guardar3");
            }
        }

        private void button_MC_Guardar_Click(object sender, EventArgs e)
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
                //Comprobamos Descuento2
                if (!CompruebaCantidad(textBox_MC_VC_Descuento2.Text.ToString()))
                {
                    errorProvider_MC_Desc2.SetError(textBox_MC_VC_Descuento2, "Debe ser un número entero");
                    MC_Descuento2 = false;
                }
                else
                {
                    errorProvider_MC_Desc2.Clear();
                    MC_Descuento2 = true;
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
                //Comprobamos Descuento3
                if (!CompruebaCantidad(textBox_MC_VC_Descuento3.Text.ToString()))
                {
                    errorProvider_MC_Desc3.SetError(textBox_MC_VC_Descuento3, "Debe ser un número entero");
                    MC_Descuento3 = false;
                }
                else
                {
                    errorProvider_MC_Desc3.Clear();
                    MC_Descuento3 = true;
                }
            }

            //Comprobamos que este todo listo
            if (checkBox_MC_ActivarCond1.Checked && checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que esten las 3 condiciones
                if (MC_Cantidad1 && MC_Cantidad2 && MC_Cantidad3 && MC_Descuento1 && MC_Descuento2 && MC_Descuento3)
                {
                    MessageBox.Show("Listo para guardar");
                }
            }
            else if (checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que la segunda este activada y la tercera no
                if (MC_Cantidad1 && MC_Cantidad2 && MC_Descuento1 && MC_Descuento2)
                {
                    MessageBox.Show("Listo para guardar");
                }
            }
            else if (!checkBox_MC_ActivarCond1.Checked && checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que la segunda no este activada y la tercera si
                if (MC_Cantidad1 && MC_Cantidad3 && MC_Descuento1 && MC_Descuento3)
                {
                    MessageBox.Show("Listo para guardar");
                }
            }
            else if (!checkBox_MC_ActivarCond1.Checked && !checkBox_MC_ActivarCond2.Checked)
            {
                //En el caso que sólo este la primera
                if (MC_Cantidad1 && MC_Descuento1)
                {
                    MessageBox.Show("Listo para guardar");
                }
            }
        }

        private void MC_limpiar(int todo)
        {
            //true en caso de limpiar todos los campos
            if (todo == 1)
            {
                textBox_MC_NomPromo.Text = "";
                label_MC_Descripcion.Text = "";
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
                textBox_MC_VC_Descuento2.Text = "";
                radioButton_MC_TE2_Cine.Checked = false;
                radioButton_MC_TE2_Concierto.Checked = false;
                radioButton_MC_TE2_Teatro.Checked = false;
                radioButton_MC_TE2_Todos.Checked = false;
                checkBox_MC_ActivarCond2.Checked = false;
                comboBox_MC_VC_Tcondicion3.Text = "Tipo condición";
                comboBox_MC_VC_Comparacion3.Text = "Comparación";
                textBox_MC_VC_Cantidad3.Text = "";
                textBox_MC_VC_Descuento3.Text = "";
                radioButton_MC_TE3_Cine.Checked = false;
                radioButton_MC_TE3_Concierto.Checked = false;
                radioButton_MC_TE3_Teatro.Checked = false;
                radioButton_MC_TE3_Todos.Checked = false;
            }
            //false caso de limipiar todos menos los combobox del primer bloque
            else if (todo == 0)
            {
                textBox_MC_NomPromo.Text = "";
                label_MC_Descripcion.Text = "";
                textBox_MC_VC_Cantidad1.Text = "";
                textBox_MC_VC_Descuento1.Text = "";
                radioButton_MC_TE1_Cine.Checked = false;
                radioButton_MC_TE1_Concierto.Checked = false;
                radioButton_MC_TE1_Teatro.Checked = false;
                radioButton_MC_TE1_Todos.Checked = false;
                checkBox_MC_ActivarCond1.Checked = false;
                //comboBox_MC_VC_Tcondicion2.Text = "Tipo condición";
                //comboBox_MC_VC_Comparacion2.Text = "Comparación";
                textBox_MC_VC_Cantidad2.Text = "";
                textBox_MC_VC_Descuento2.Text = "";
                radioButton_MC_TE2_Cine.Checked = false;
                radioButton_MC_TE2_Concierto.Checked = false;
                radioButton_MC_TE2_Teatro.Checked = false;
                radioButton_MC_TE2_Todos.Checked = false;
                checkBox_MC_ActivarCond2.Checked = false;
                //comboBox_MC_VC_Tcondicion3.Text = "Tipo condición";
                //comboBox_MC_VC_Comparacion3.Text = "Comparación";
                textBox_MC_VC_Cantidad3.Text = "";
                textBox_MC_VC_Descuento3.Text = "";
                radioButton_MC_TE3_Cine.Checked = false;
                radioButton_MC_TE3_Concierto.Checked = false;
                radioButton_MC_TE3_Teatro.Checked = false;
                radioButton_MC_TE3_Todos.Checked = false;
            }
        }

        private void dataGridView_MC_ListaPromosCond_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[0].Value != DBNull.Value)
            {
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
                checkBox_MC_ActPromo.Checked = Convert.ToBoolean(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[18].Value);

                //Para el bloque 2 de las condiciones
                if (dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[8].Value != DBNull.Value)
                {
                    //eligo la condición de la fila seleccionada
                    comboBox_MC_VC_Tcondicion2.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[8].Value);
                    //eligo la comparación de la fila seleccionada
                    comboBox_MC_VC_Comparacion2.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[9].Value);
                    //relleno la cantidad de la fila seleccionada
                    textBox_MC_VC_Cantidad2.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[10].Value.ToString();
                    //relleno el descuento de la fila seleccionada
                    textBox_MC_VC_Descuento2.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[11].Value.ToString();
                    //marco el tipo evento de la fila seleccionada
                    if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value) == 0)
                    {
                        radioButton_MC_TE2_Cine.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value) == 1)
                    {
                        radioButton_MC_TE2_Teatro.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value) == 2)
                    {
                        radioButton_MC_TE2_Concierto.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[12].Value) == 3)
                    {
                        radioButton_MC_TE2_Todos.Checked = true;
                    }
                    checkBox_MC_ActivarCond1.Checked = true;
                }

                //Para el bloque 3 de las condiciones
                if (dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[13].Value != DBNull.Value)
                {
                    //eligo la condición de la fila seleccionada
                    comboBox_MC_VC_Tcondicion3.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[13].Value);
                    //eligo la comparación de la fila seleccionada
                    comboBox_MC_VC_Comparacion3.SelectedIndex = Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[14].Value);
                    //relleno la cantidad de la fila seleccionada
                    textBox_MC_VC_Cantidad3.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[15].Value.ToString();
                    //relleno el descuento de la fila seleccionada
                    textBox_MC_VC_Descuento3.Text = dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[16].Value.ToString();
                    //marco el tipo evento de la fila seleccionada
                    if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value) == 0)
                    {
                        radioButton_MC_TE3_Cine.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value) == 1)
                    {
                        radioButton_MC_TE3_Teatro.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value) == 2)
                    {
                        radioButton_MC_TE3_Concierto.Checked = true;
                    }
                    else if (Convert.ToInt32(dataGridView_MC_ListaPromosCond.SelectedRows[0].Cells[17].Value) == 3)
                    {
                        radioButton_MC_TE3_Todos.Checked = true;
                    }
                    checkBox_MC_ActivarCond2.Checked = true;
                }
            }
        }

        private void radioButton_PE_otroDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_PE_otroDesc.Checked)
            {
                errorProvider_PE_Otro.Clear();
            }
        }

        private void checkBox_PE_Ninguno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PE_Ninguno.Checked)
            {
                radioButton_PE_5.Enabled = false;
                radioButton_PE_10.Enabled = false;
                radioButton_PE_20.Enabled = false;
                radioButton_PE_50.Enabled = false;
                radioButton_PE_IVA.Enabled = false;
                radioButton_PE_otroDesc.Enabled = false;
                textBox_PE_otroDesc.Enabled = false;
            }
            else
            {
                radioButton_PE_5.Enabled = true;
                radioButton_PE_10.Enabled = true;
                radioButton_PE_20.Enabled = true;
                radioButton_PE_50.Enabled = true;
                radioButton_PE_IVA.Enabled = true;
                radioButton_PE_otroDesc.Enabled = true;
                textBox_PE_otroDesc.Enabled = true;
            }
        }
    }
}
