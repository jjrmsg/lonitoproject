using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Events4ALL
{
    public partial class Salas : UserControl
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void ocultarTodo()
        {
            groupBoxSecciones.Visible = false;

        }

        private void comboNumMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNumSeccion.Text == "1")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true;
                labelFila1.Visible = true;
                textFila1.Visible = true;
                labelColumna1.Visible = true;
                textColumna1.Visible = true;
                labelSeccion2.Visible = false;
                labelFila2.Visible = false;
                textFila2.Visible = false;
                labelColumna2.Visible = false;
                textColumna2.Visible = false;
            }
            if (comboNumSeccion.Text == "2")
            {
                ocultarTodo();
                groupBoxSecciones.Visible = true;
                labelSeccion1.Visible = true;
                labelFila1.Visible = true;
                textFila1.Visible = true;
                labelColumna1.Visible = true;
                textColumna1.Visible = true;
                labelSeccion2.Visible = true;
                labelFila2.Visible = true;
                textFila2.Visible = true;
                labelColumna2.Visible = true;
                textColumna2.Visible = true;

            }
            if (comboNumSeccion.Text == "3")
            {
                
            }
        }
    }
}
