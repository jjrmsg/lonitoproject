using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Events4ALL
{
    public partial class Salas : UserControl
    {
        public Salas()
        {
            InitializeComponent();
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
            //ocualtar todos los error provider
            errorProvider1.Clear();
            errorProvider2.Clear();
            validado=validar();
            if (validado == false)
                MessageBox.Show("Datos incorrectos", "Error");
                //Si validado==falso saltara una excepcion
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            ControlCollection a = textIdSala.Parent.Controls;
            foreach (System.Windows.Forms.Control ctrl in a)
            {
               //MessageBox.Show(ctrl.ToString());
                if (ctrl is TextBox || ctrl is ComboBox)
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
            groupBoxSecciones.Visible = false;
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
        }
    }
}
