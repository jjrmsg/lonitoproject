using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.EN;

namespace Events4ALL
{
    public partial class Espectaculos : UserControl
    {
        public Espectaculos()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectGenero = false;
            if (cbTipo.Text != "")
            {
                cbSala.Enabled = true;
                cbSala.Text = "";
                if (cbTipo.Text == "Cine")
                {
                    selectGenero = true;
                }

                lbGenero.Visible = selectGenero;
                cbGenero.Visible = selectGenero;

                SalasEN salasEN = new SalasEN();
                DataSet salasTipo = salasEN.SalasPorTipo(cbTipo.Text);

                cbSala.Items.Clear();
                foreach (DataRow sala in salasTipo.Tables[0].Rows)
                {
                    cbSala.Items.Add("Sala "+sala["NumSala"]);
                }
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEsp_Click(object sender, EventArgs e)
        {
            errPrvEspectaculo.Clear();

            if (tbTitulo.Text == "")
                errPrvEspectaculo.SetError(tbTitulo, "Debe introducir un titulo.");

            if (tbDescripcion.Text == "")
                errPrvEspectaculo.SetError(lbDescripcion, "Debe introducir una descripción.");

            if (cbTipo.Text == "")
                errPrvEspectaculo.SetError(cbTipo, "Debe elegir un tipo de espectaculo.");
            else
            {
                if (cbTipo.Text == "Cine" && cbGenero.Text == "")
                    errPrvEspectaculo.SetError(cbGenero, "Debe elegir un genero.");
            }

            if (cbSala.Text == "")
                errPrvEspectaculo.SetError(cbSala, "Debe elegir una sala.");

            if (numPrecio.Text == "")
                errPrvEspectaculo.SetError(numPrecio, "El valor del precio no es valido.");

            DateTime dtIni = dtFechaIni.Value.Date;
            DateTime dtFin = dtFechaFin.Value.Date;
            if (dtIni > dtFin)
                errPrvEspectaculo.SetError(lbFechas, "La fecha de inicio es posterior a la fecha final.");
         

        }        
    }
}
