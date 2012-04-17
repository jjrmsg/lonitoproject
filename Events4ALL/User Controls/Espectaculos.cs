using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.EN;
using System.IO;
using System.Drawing.Imaging;


namespace Events4ALL
{
    public partial class Espectaculos : UserControl
    {
        private bool imagenCambiada = false;    // Indica si se seleccionó una imagen o se dejó la de por defecto.
        private int idEspectaculo = 0;  // Id del espectáculo del formulario (0 en caso de nuevo espectáculo)
        public Espectaculos()
        {
            InitializeComponent();
        }

        /* #### BÚSQUEDA #### */

        // Al cargar se recogen las salas en las que se pueden buscar espectáculos.
        private void Espectaculos_Load(object sender, EventArgs e)
        {
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
            catch (Exception ex)
            {
                Console.WriteLine("No se pudieron obtener las salas: " + ex.Message);
            }
        }

        // Elimina el contendido de los campos del formulario de búsqueda.
        private void btLimpBusqueda_Click(object sender, EventArgs e)
        {
            tbTitBuscar.Text = "";
            cbSalaBuscar.SelectedIndex = -1;
            cbTipoBuscar.SelectedIndex = -1;
            cbFechaBuscar.SelectedIndex = -1;
            dtFechaBuscar.Value = DateTime.Today;
            cbPrecioBuscar.SelectedIndex = -1;
            numPrecioBuscar.Value = 0;
        }

        // Recoge los datos del formulario, realiza la búqueda y muestra los resultados.
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

        // Al pulsar en una fila de la búsqueda se comprueba si se hizo en los botones
        // editar o borrar espectáculo.
        private void dataGridEspectaculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Si se ha pulsado en el boton de editar
                if (e.ColumnIndex == dataGridEspectaculos.Columns["Column8"].Index)
                {
                    Editar_espectaculo(dataGridEspectaculos[0, e.RowIndex].Value.ToString());
                }
                // Si se ha pulsado en el boton de borrar
                else if (e.ColumnIndex == dataGridEspectaculos.Columns["Column7"].Index)
                {
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

        // Al pulsar el botón de edición de un espectáculo se limpian los datos
        // que tuviese el formulario y se rellenan con los del espectáculo seleccionado.
        private void Editar_espectaculo(string id)
        {
            LimpiarFormEntrada();
            btFormNuevo.Visible = true;
            btnGuardarEsp.Visible = true;

            btLimpiar.Visible = false;
            btInsertar.Visible = false;
            imagenCambiada = false;
            tabControl1.SelectedIndex = 1;

            DataSet ds = null;
            EspectaculosEN espEN = new EspectaculosEN();
            ds = espEN.ObtenerEspectaculoPorID(id);

            try
            {
                DataRow espectaculo = ds.Tables[0].Rows[0];

                tbTitulo.Text = espectaculo["Titulo"].ToString();
                tbDescripcion.Text = espectaculo["Descripcion"].ToString();
                cbTipo.Text = espectaculo["Tipo"].ToString();
                if (espectaculo["Tipo"].ToString() == "Cine")
                    cbGenero.Text = espectaculo["Genero"].ToString();
                cbSala.Text = espectaculo["IdSala"].ToString();
                numPrecio.Value = Convert.ToInt32(espectaculo["Precio"]);
                dtFechaIni.Value = (DateTime)espectaculo["FechaIni"];
                dtFechaFin.Value = (DateTime)espectaculo["FechaFin"];
                idEspectaculo = Convert.ToInt32(espectaculo["IDEspectaculo"].ToString());

                if (espectaculo["Cartel"] != System.DBNull.Value)
                {
                    byte[] bImage = (byte[])espectaculo["Cartel"];
                    MemoryStream ms = new MemoryStream(bImage);
                    pbCartel.Image = Image.FromStream(ms, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al recuperar los datos del espectáculo.\n\nInformación del error:\n  " + ex.Message, "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /* ### FORMULARIO ### */
                
        // Al Cambiar el tipo de espectáculo se muestran las salas en las que se pueden insertar.
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

        // Muestra el dialogo de elección de imagen para el cartel del espectáculo.
        private void btCartel_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.ShowHelp = true;
           
            OFich.Filter = "Archivos de imagen (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";
            pbCartel.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
            {
                pbCartel.Image = Image.FromFile(OFich.FileName);
                imagenCambiada = true;
            }            
        } 

        // Al pulsar el botón se limpia el contenido del formulario.
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormEntrada();
        }

        // Elimina el contendido de los campos del formulario, el errorProvider y la imagen.
        private void LimpiarFormEntrada()
        {
            errPrvEspectaculo.Clear();
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
            pbCartel.Image = Events4ALL.Properties.Resources.image_default;
            imagenCambiada = false;
        }

        // Al pulsar el botón de nuevo espectáculo, se pide confirmación y se prepara
        // un formulario vacío de inserción de espectáculo.
        private void btFormNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ir al formulario de inserción y perder los cambios no guardados?", "Los cambios no guardados se perderan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                LimpiarFormEntrada();
                btFormNuevo.Visible = false;
                btnGuardarEsp.Visible = false;

                btLimpiar.Visible = true;
                btInsertar.Visible = true;
                imagenCambiada = false;
                idEspectaculo = 0;
            }
        }

        // Al pulsar el botón de insertar se validan los datos y la imagen y se
        // procede a la inserción en la base de datos.
        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                Image cartel = null;
                if (imagenCambiada == true)
                    cartel = pbCartel.Image;

                EspectaculosEN espectaculo = new EspectaculosEN(tbTitulo.Text,
                                                                tbDescripcion.Text,
                                                                numPrecio.Value,
                                                                cbGenero.Text,
                                                                dtFechaIni.Text,
                                                                dtFechaFin.Text,
                                                                cartel);
                if (espectaculo.Insertar(cbSala.Text))
                {
                    MessageBox.Show("Espectaculo insertado");
                    LimpiarFormEntrada();
                }
            }
        }

        // Al pulsar el botón de guardar se validan los datos y la imagen y se
        // procede a la edición en la base de datos.
        private void btnGuardarEsp_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                Image cartel = null;
                if (imagenCambiada == true)
                    cartel = pbCartel.Image;

                EspectaculosEN espectaculo = new EspectaculosEN(tbTitulo.Text,
                                                                tbDescripcion.Text,
                                                                numPrecio.Value,
                                                                cbGenero.Text,
                                                                dtFechaIni.Text,
                                                                dtFechaFin.Text,
                                                                cartel);

                if (espectaculo.Editar(cbSala.Text, idEspectaculo))
                {
                    MessageBox.Show("Espectaculo modificado");
                    LimpiarFormEntrada();
                    btFormNuevo.Visible = false;
                    btnGuardarEsp.Visible = false;

                    btLimpiar.Visible = true;
                    btInsertar.Visible = true;
                    imagenCambiada = false;
                    idEspectaculo = 0;
                }
            }
        }

        // Comprueba que los campos del formulario contengan datos válidos informando
        // del problema en aquellos que no lo tengan.
        private bool Validar()
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

            return valido;
        }
    }
}
