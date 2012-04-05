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

            SalasEN salasEN = new SalasEN();
            DataSet salasTipo = new DataSet();
            salasTipo = salasEN.SalasPorTipo("");

            cbSala.Items.Clear();
            try
            {
                foreach (DataRow sala in salasTipo.Tables[0].Rows)
                {
                    cbSalaBuscar.Items.Add(sala["NumSala"]);
                }
            }
            catch
            {
            }
            
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
                    cbSala.Items.Add(sala["NumSala"]);
                }
            }
        }

        private void btCartel_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.Filter = "Archivos de imagen (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";
            pbCartel.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
                pbCartel.Image = Image.FromFile(OFich.FileName); 
        } 

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbTitulo.Text = "";
            tbDescripcion.Text = "";
            cbTipo.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            lbGenero.Visible = false;
            cbGenero.Visible = false;
            cbSala.SelectedIndex = -1;
            cbSala.Enabled = false;
            cbSala.Text = "Debe elegir un tipo";
            numPrecio.Value = 0;
            dtFechaIni.Value = DateTime.Today;
            dtFechaFin.Value = DateTime.Today;
        }

        private void btnGuardarEsp_Click(object sender, EventArgs e)
        {
            bool valido = true;
            errPrvEspectaculo.Clear();

            if (tbTitulo.Text == "")
            {
                errPrvEspectaculo.SetError(tbTitulo, "Debe introducir un titulo.");
                valido = false;
            }

            if (tbDescripcion.Text == "")
            {
                errPrvEspectaculo.SetError(lbDescripcion, "Debe introducir una descripción.");
                valido = false;
            }
            if (cbTipo.Text == "")
            {
                errPrvEspectaculo.SetError(cbTipo, "Debe elegir un tipo de espectaculo.");
                valido = false;
            }
            else
            {
                if (cbTipo.Text == "Cine" && cbGenero.Text == "")
                {
                    errPrvEspectaculo.SetError(cbGenero, "Debe elegir un genero.");
                    valido = false;
                }
            }

            if (cbSala.Text == "")
            {
                errPrvEspectaculo.SetError(cbSala, "Debe elegir una sala.");
                valido = false;
            }

            if (numPrecio.Text == "")
            {
                errPrvEspectaculo.SetError(numPrecio, "El valor del precio no es valido.");
                valido = false;
            }

            DateTime dtIni = dtFechaIni.Value.Date;
            DateTime dtFin = dtFechaFin.Value.Date;
            if (dtIni > dtFin)
            {
                errPrvEspectaculo.SetError(lbFechas, "La fecha de inicio es posterior a la fecha final.");
                valido = false;
            }

            if (valido == true)
            {
                EspectaculosEN espectaculo = new EspectaculosEN(tbTitulo.Text,
                                                                tbDescripcion.Text,
                                                                numPrecio.Value,
                                                                cbGenero.Text,
                                                                dtFechaIni.Text,
                                                                dtFechaFin.Text);
                if (espectaculo.Insertar(cbSala.Text))
                {
                    MessageBox.Show("Espectaculo insertado");
                }                                                                
            }
        }

        private void btLimpBusqueda_Click(object sender, EventArgs e)
        {
            tbTitBuscar.Text = "";
            cbSalaBuscar.SelectedIndex = -1;
            cbTipoBuscar.SelectedIndex = -1;
            cbFechaBuscar.SelectedIndex = -1;
            dtFechaBuscar.Value = DateTime.Today;
            cbPrecioBuscar.SelectedIndex = -1;
            numPrecioBuscar.Value = 0;
            // checkEntradas.Checked = false;
        } 

        private void btBuscar_Click(object sender, EventArgs e)
        {
            EspectaculosEN espectaculoEN = new EspectaculosEN();
            DataSet espectaculos = espectaculoEN.Buscar(tbTitBuscar.Text,
                                                        cbSalaBuscar.Text,
                                                        cbTipoBuscar.Text,
                                                        cbFechaBuscar.Text,
                                                        dtFechaBuscar.Text,
                                                        cbPrecioBuscar.Text,
                                                        numPrecioBuscar.Text);

            dataGridEspectaculos.Rows.Clear();
            foreach (DataRow espectaculo in espectaculos.Tables[0].Rows)
            {
                string[] row = { espectaculo["Id"].ToString(),
                                 espectaculo["Titulo"].ToString(), 
                                 espectaculo["Tipo"].ToString(),
                                 espectaculo["NumSala"].ToString(),
                                 espectaculo["Precio"].ToString(),
                                 Convert.ToDateTime(espectaculo["FechaIni"]).ToShortDateString(),
                                 Convert.ToDateTime(espectaculo["FechaFin"]).ToShortDateString()};
                dataGridEspectaculos.Rows.Add(row);
            }
        }

        private void dataGridEspectaculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridEspectaculos.Columns["Column7"].Index)
                return;

            string espName = dataGridEspectaculos[1, e.RowIndex].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el espectaculo \"" + espName + "\"?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                EspectaculosEN espectaculo = new EspectaculosEN();
                if (espectaculo.Eliminar(dataGridEspectaculos[0, e.RowIndex].Value.ToString()) == true)
                {
                    MessageBox.Show("Eliminado correctamente");
                    dataGridEspectaculos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
              
    }
}
