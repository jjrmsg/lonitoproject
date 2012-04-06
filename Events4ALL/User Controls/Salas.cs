using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.EN;
using Events4ALL.CAD;
using System.Collections;

namespace Events4ALL
{
    public partial class Salas : UserControl
    {
        public Salas()
        {
            InitializeComponent();
            SalasEN salaEn=new SalasEN();
            textIdSala.Text = salaEn.acutalizarId().ToString();
            //Aqui hacer una consulta con un count salas y añadir +1
            //Ese valor se le asignara a textIdSala
        }

        private void ocultarTodo()
        {
            labelSeccion1.Visible = false; labelFila1.Visible = false; textFila1.Visible = false; labelColumna1.Visible = false; textColumna1.Visible = false;
            labelSeccion2.Visible = false; labelFila2.Visible = false; textFila2.Visible = false; labelColumna2.Visible = false; textColumna2.Visible = false;
            labelSeccion3.Visible = false; labelFila3.Visible = false; textFila3.Visible = false; labelColumna3.Visible = false; textColumna3.Visible = false;
            labelSeccion4.Visible = false; labelFila4.Visible = false; textFila4.Visible = false; labelColumna4.Visible = false; textColumna4.Visible = false;
            labelSeccion5.Visible = false; labelFila5.Visible = false; textFila5.Visible = false; labelColumna5.Visible = false; textColumna5.Visible = false;
            labelSeccion6.Visible = false; labelFila6.Visible = false; textFila6.Visible = false; labelColumna6.Visible = false; textColumna6.Visible = false;
            labelSeccion7.Visible = false; labelFila7.Visible = false; textFila7.Visible = false; labelColumna7.Visible = false; textColumna7.Visible = false;
            labelSeccion8.Visible = false; labelFila8.Visible = false; textFila8.Visible = false; labelColumna8.Visible = false; textColumna8.Visible = false;
            labelSeccion9.Visible = false; labelFila9.Visible = false; textFila9.Visible = false; labelColumna9.Visible = false; textColumna9.Visible = false;
            labelSeccion10.Visible = false; labelFila10.Visible = false; textFila10.Visible = false; labelColumna10.Visible = false; textColumna10.Visible = false;
        }

        private void comboNumMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNumSeccion.Text == "1")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true;labelFila1.Visible = true;textFila1.Visible = true;labelColumna1.Visible = true;textColumna1.Visible = true;
            }
            if (comboNumSeccion.Text == "2")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true;labelFila1.Visible = true;textFila1.Visible = true;labelColumna1.Visible = true;textColumna1.Visible = true;
                labelSeccion2.Visible = true;labelFila2.Visible = true;textFila2.Visible = true;labelColumna2.Visible = true;textColumna2.Visible = true;

            }
            if (comboNumSeccion.Text == "3")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
            }
            if (comboNumSeccion.Text == "4")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;

            }
            if (comboNumSeccion.Text == "5")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
            }
            if (comboNumSeccion.Text == "6")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
                labelSeccion6.Visible = true; labelFila6.Visible = true; textFila6.Visible = true; labelColumna6.Visible = true; textColumna6.Visible = true;
            }
            if (comboNumSeccion.Text == "7")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
                labelSeccion6.Visible = true; labelFila6.Visible = true; textFila6.Visible = true; labelColumna6.Visible = true; textColumna6.Visible = true;
                labelSeccion7.Visible = true; labelFila7.Visible = true; textFila7.Visible = true; labelColumna7.Visible = true; textColumna7.Visible = true;
            }
            if (comboNumSeccion.Text == "8")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
                labelSeccion6.Visible = true; labelFila6.Visible = true; textFila6.Visible = true; labelColumna6.Visible = true; textColumna6.Visible = true;
                labelSeccion7.Visible = true; labelFila7.Visible = true; textFila7.Visible = true; labelColumna7.Visible = true; textColumna7.Visible = true;
                labelSeccion8.Visible = true; labelFila8.Visible = true; textFila8.Visible = true; labelColumna8.Visible = true; textColumna8.Visible = true;
            }
            if (comboNumSeccion.Text == "9")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
                labelSeccion6.Visible = true; labelFila6.Visible = true; textFila6.Visible = true; labelColumna6.Visible = true; textColumna6.Visible = true;
                labelSeccion7.Visible = true; labelFila7.Visible = true; textFila7.Visible = true; labelColumna7.Visible = true; textColumna7.Visible = true;
                labelSeccion8.Visible = true; labelFila8.Visible = true; textFila8.Visible = true; labelColumna8.Visible = true; textColumna8.Visible = true;
                labelSeccion9.Visible = true; labelFila9.Visible = true; textFila9.Visible = true; labelColumna9.Visible = true; textColumna9.Visible = true;
            }
            if (comboNumSeccion.Text == "10")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true; labelFila1.Visible = true; textFila1.Visible = true; labelColumna1.Visible = true; textColumna1.Visible = true;
                labelSeccion2.Visible = true; labelFila2.Visible = true; textFila2.Visible = true; labelColumna2.Visible = true; textColumna2.Visible = true;
                labelSeccion3.Visible = true; labelFila3.Visible = true; textFila3.Visible = true; labelColumna3.Visible = true; textColumna3.Visible = true;
                labelSeccion4.Visible = true; labelFila4.Visible = true; textFila4.Visible = true; labelColumna4.Visible = true; textColumna4.Visible = true;
                labelSeccion5.Visible = true; labelFila5.Visible = true; textFila5.Visible = true; labelColumna5.Visible = true; textColumna5.Visible = true;
                labelSeccion6.Visible = true; labelFila6.Visible = true; textFila6.Visible = true; labelColumna6.Visible = true; textColumna6.Visible = true;
                labelSeccion7.Visible = true; labelFila7.Visible = true; textFila7.Visible = true; labelColumna7.Visible = true; textColumna7.Visible = true;
                labelSeccion8.Visible = true; labelFila8.Visible = true; textFila8.Visible = true; labelColumna8.Visible = true; textColumna8.Visible = true;
                labelSeccion9.Visible = true; labelFila9.Visible = true; textFila9.Visible = true; labelColumna9.Visible = true; textColumna9.Visible = true;
                labelSeccion10.Visible = true; labelFila10.Visible = true; textFila10.Visible = true; labelColumna10.Visible = true; textColumna10.Visible = true;

            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboTipo.Text=="Cine")
            {
                pictureTipo.Image = Events4ALL.Properties.Resources.claqueta;
            }
            else if(comboTipo.Text=="Teatro")
            {
                pictureTipo.Image = Events4ALL.Properties.Resources.teatro;
            }
            else if (comboTipo.Text == "Concierto")
            {
                pictureTipo.Image = Events4ALL.Properties.Resources.concierto;
            }
            else
            {
                pictureTipo.Image = Events4ALL.Properties.Resources.Events4All;
            }
        }

        private void buttonAñadirSala_Click(object sender, EventArgs e)
        {
            bool validado;
            errorProvider1.Clear();
            errorProvider2.Clear();

            validado=validar();
            if (validado == true)
            {
                if (labelUpdate.Text == "falso")
                    nuevaSala();
                else//caso de update
                    editarSala();
            }
        }

        private void nuevaSala()
        {
            #region Hacer Array de Secciones
            int intSeccion = Convert.ToInt16(comboNumSeccion.Text);
            int[][] secciones;
            secciones = new int[intSeccion][];
            if (labelSeccion1.Visible == true)
            {
                secciones[0] = new int[3];
                secciones[0][0] = 1;
                secciones[0][1] = Convert.ToInt16(textFila1.Text);
                secciones[0][2] = Convert.ToInt16(textColumna1.Text);
            }
            if (labelSeccion2.Visible == true)
            {
                secciones[1] = new int[3];
                secciones[1][0] = 2;
                secciones[1][1] = Convert.ToInt16(textFila2.Text);
                secciones[1][2] = Convert.ToInt16(textColumna2.Text);
            }
            if (labelSeccion3.Visible == true)
            {
                secciones[2] = new int[3];
                secciones[2][0] = 3;
                secciones[2][1] = Convert.ToInt16(textFila3.Text);
                secciones[2][2] = Convert.ToInt16(textColumna3.Text);
            }
            if (labelSeccion4.Visible == true)
            {
                secciones[3] = new int[3];
                secciones[3][0] = 4;
                secciones[3][1] = Convert.ToInt16(textFila4.Text);
                secciones[3][2] = Convert.ToInt16(textColumna4.Text);
            }
            if (labelSeccion5.Visible == true)
            {
                secciones[4] = new int[3];
                secciones[4][0] = 5;
                secciones[4][1] = Convert.ToInt16(textFila5.Text);
                secciones[4][2] = Convert.ToInt16(textColumna5.Text);
            }
            if (labelSeccion6.Visible == true)
            {
                secciones[5] = new int[3];
                secciones[5][0] = 6;
                secciones[5][1] = Convert.ToInt16(textFila6.Text);
                secciones[5][2] = Convert.ToInt16(textColumna6.Text);
            }
            if (labelSeccion7.Visible == true)
            {
                secciones[6] = new int[3];
                secciones[6][0] = 7;
                secciones[6][1] = Convert.ToInt16(textFila7.Text);
                secciones[6][2] = Convert.ToInt16(textColumna7.Text);
            }
            if (labelSeccion8.Visible == true)
            {
                secciones[7] = new int[3];
                secciones[7][0] = 8;
                secciones[7][1] = Convert.ToInt16(textFila8.Text);
                secciones[7][2] = Convert.ToInt16(textColumna8.Text);
            }
            if (labelSeccion9.Visible == true)
            {
                secciones[8] = new int[3];
                secciones[8][0] = 9;
                secciones[8][1] = Convert.ToInt16(textFila9.Text);
                secciones[8][2] = Convert.ToInt16(textColumna9.Text);
            }
            if (labelSeccion10.Visible == true)
            {
                secciones[9] = new int[3];
                secciones[9][0] = 10;
                secciones[9][1] = Convert.ToInt16(textFila10.Text);
                secciones[9][2] = Convert.ToInt16(textColumna10.Text);
            }
            #endregion
            int capacidad = aforo(secciones, intSeccion);
            SalasEN salaEn = new SalasEN(Convert.ToInt16(textIdSala.Text), comboTipo.Text, Convert.ToInt16(comboNumSeccion.Text), textDescripcion.Text, capacidad, secciones);
            if (salaEn.InsertarEn() == true)
            {
                MessageBox.Show("Sala crada correctamente");
                limpiar();
                textIdSala.Text = salaEn.acutalizarId().ToString();
            }
        }

        private void editarSala()
        {

        }

        private bool validar()
        {
            bool validado = true;
            if (comboTipo.Text == "")
            {
                errorProvider1.SetError(comboTipo, "Seleccione un campo");
                validado=false;
            }
            if (comboNumSeccion.Text == "")
            {
                errorProvider2.SetError(comboNumSeccion, "Seleccione un valor");
                validado=false;
            }
            ControlCollection a = textFila1.Parent.Controls;
            foreach(System.Windows.Forms.Control ctrl in a)
            {
                if (ctrl is TextBox && ctrl.Visible==true)
                {
                    if (ctrl.Text == "" || (Convert.ToInt16(ctrl.Text)<1 || Convert.ToInt16(ctrl.Text)>999))
                    {
                        validado = false;
                        errorProvider2.SetError(ctrl,"Formato incorrecto");
                    }
                }
            }

            return validado;
        }

        private int aforo(int [][] seccion,int max)
        {
            int total = 0;
            for (int i = 0; i < max; i++)
            {
                int parcial=seccion[i][1]*seccion[i][2];
                total = total + parcial;
            }
            return total;
        }

        private void limpiar()
        {
            ControlCollection a = textIdSala.Parent.Controls;
            foreach (System.Windows.Forms.Control ctrl in a)
            {
                //MessageBox.Show(ctrl.ToString());
                if ((ctrl is TextBox || ctrl is ComboBox) && ctrl.Name != "textIdSala")
                    ctrl.Text = "";
                else
                {
                    if (ctrl is GroupBox)
                    {
                        ControlCollection b = textFila7.Parent.Controls;
                        foreach (System.Windows.Forms.Control ctrl2 in b)
                        {
                            if (ctrl2 is TextBox)
                                ctrl2.Text = "";
                        }
                    }
                }
            }
            errorProvider1.Clear();
            errorProvider2.Clear();
            groupBoxSecciones.Visible = false;
            SalasEN salaEn = new SalasEN();
            textIdSala.Text = salaEn.acutalizarId().ToString();
            labelUpdate.Text = "falso";

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void buttonLimpiarBusquedaSala_Click(object sender, EventArgs e)
        {
            ControlCollection a = textBox1.Parent.Controls;
            foreach (System.Windows.Forms.Control ctrl in a)
            {
                //MessageBox.Show(ctrl.ToString());
                if (ctrl is TextBox || ctrl is ComboBox)
                    ctrl.Text = "";
            }
            checkLibre.Checked = false;
            dataGridBuscarSala.Rows.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int estado=0;
            int aforoMax = 0;
            int aforoMin = 0;
            int numSala = 0;

            if(checkLibre.Checked==true)
                estado=1;
            if(textAforoBusquedaMax.Text!="")
                aforoMax=Convert.ToInt16(textAforoBusquedaMax.Text);
            if(textAforoBusquedaMin.Text!="")
                aforoMin=Convert.ToInt16(textAforoBusquedaMin.Text);
            if(textBox1.Text!="")
                numSala=Convert.ToInt16(textBox1.Text);

            SalasEN select = new SalasEN();
            DataSet resultado=select.SalaSelect(numSala,comboBuscarTipoSala.Text,aforoMin,aforoMax,estado);

            dataGridBuscarSala.Rows.Clear();
            foreach (DataRow sala in resultado.Tables[0].Rows)
            {
                string[] row = { sala[0].ToString(), 
                                 sala[1].ToString(),
                                 sala[2].ToString(),
                                 sala[3].ToString(),
                                 sala[4].ToString()};
                 dataGridBuscarSala.Rows.Add(row);
            }
         
        }

        private void dataGridBuscarSala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridBuscarSala[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 5)//Caso de updates
            {
                //ver que fila vamos a editar para ello almacenaremos el numero de la sala
                string numeroSala = dataGridBuscarSala[0, e.RowIndex].Value.ToString();
                SalasEN salaEn = new SalasEN();
                DataSet salaRecuperar = new DataSet();
                salaRecuperar=salaEn.RecuperarSala(numeroSala);
                labelUpdate.Text = "verdadero";//aqui ponemos este label a verdadero para saber que si guarda el usuario hay que hacer update
                tabControl1.SelectTab("tabAñadirSala");
                textIdSala.Text=salaRecuperar.Tables[0].Rows[0][0].ToString();
                textDescripcion.Text= salaRecuperar.Tables[0].Rows[0][1].ToString();
                comboTipo.Text=salaRecuperar.Tables[0].Rows[0][2].ToString();
                comboNumSeccion.Text = salaRecuperar.Tables[0].Rows[0][3].ToString();

                #region hacer secciones
                int nSecciones=Convert.ToInt16(comboNumSeccion.Text);
                if (nSecciones >= 1)
                {
                    textFila1.Text = salaRecuperar.Tables[0].Rows[0][6].ToString();
                    textColumna1.Text = salaRecuperar.Tables[0].Rows[0][7].ToString();
                }
                if (nSecciones >= 2)
                {
                    textFila2.Text = salaRecuperar.Tables[0].Rows[1][6].ToString();
                    textColumna2.Text = salaRecuperar.Tables[0].Rows[1][7].ToString();
                }
                if (nSecciones >= 3)
                {
                    textFila3.Text = salaRecuperar.Tables[0].Rows[2][6].ToString();
                    textColumna3.Text = salaRecuperar.Tables[0].Rows[2][7].ToString();
                }
                if (nSecciones >= 4)
                {
                    textFila4.Text = salaRecuperar.Tables[0].Rows[3][6].ToString();
                    textColumna4.Text = salaRecuperar.Tables[0].Rows[3][7].ToString();
                }
                if (nSecciones >= 5)
                {
                    textFila5.Text = salaRecuperar.Tables[0].Rows[4][6].ToString();
                    textColumna5.Text = salaRecuperar.Tables[0].Rows[4][7].ToString();
                }
                if (nSecciones >= 6)
                {
                    textFila6.Text = salaRecuperar.Tables[0].Rows[5][6].ToString();
                    textColumna6.Text = salaRecuperar.Tables[0].Rows[5][7].ToString();
                }
                if (nSecciones >= 7)
                {
                    textFila7.Text = salaRecuperar.Tables[0].Rows[6][6].ToString();
                    textColumna7.Text = salaRecuperar.Tables[0].Rows[6][7].ToString();
                }
                if (nSecciones >= 8)
                {
                    textFila8.Text = salaRecuperar.Tables[0].Rows[7][6].ToString();
                    textColumna8.Text = salaRecuperar.Tables[0].Rows[7][7].ToString();
                }
                if (nSecciones >= 9)
                {
                    textFila9.Text = salaRecuperar.Tables[0].Rows[8][6].ToString();
                    textColumna9.Text = salaRecuperar.Tables[0].Rows[8][7].ToString();
                }
                if (nSecciones >= 10)
                {
                    textFila10.Text = salaRecuperar.Tables[0].Rows[9][6].ToString();
                    textColumna10.Text = salaRecuperar.Tables[0].Rows[9][7].ToString();
                }
                #endregion

            }
        }
    }
}
