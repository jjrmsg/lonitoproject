using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entities;
using Auxiliares;

namespace Events4ALL
{
    public partial class Clientes : UserControl
    {
        #region Variables

        private Validaciones validarCliente;
        private bool edicion;

        string patronNombre = @"^[a-zA-Z]*\w*$";
        //string patronCP = @"^\d{5}$";

        private ClientesEN en_cliente;
        private DataSet muestraCliente;
        private string nif_actual;


        #endregion

        public Clientes()
        {
            InitializeComponent();

            //Creamos objeto para validar
            validarCliente = new Validaciones();
            edicion = false;
            MuestraClientes();
   
        }

        private void formCliente_Click(object sender, EventArgs e)
        {
            MuestraClientes();
            buttonLimpiarCliente.Visible = true;
            buttonNuevoCliente.Visible = false;
        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ir al formulario de insercción y perder los cambios no guardados?", "Los cambios no guardados se perderan",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                LimpiarDatos();
                edicion = false;
                buttonNuevoCliente.Visible = false;
                buttonLimpiarCliente.Visible = true;
            }


        }

        #region WTF

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void datosPersonalesClientes_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Perfil_rButom_Divorciado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Perfil_Label_Mail_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       // private void buttonGuardarCliente_Click(object sender, EventArgs e)
       // {
            //string patronNombre = @"^\w{3,15}$/;
            //if (this.textBoxNombreC.Text == "" || this.textBoxNombreC.Text == " ")
               // MessageBox.Show("Nombre está vacío. Por favor, introduzca un nombre");
                //errorProvider1.SetError(textBoxNombreC,"Por favor, rellene el Nombre");

            //if (this.textBoxApellidosC.Text == "" || this.textBoxApellidosC.Text == " ")
                // MessageBox.Show("Apellidos está vacío. Por favor, introduzca los apellidos");
                //errorProvider1.SetError(textBoxApellidosC, "Por favor, rellene los Apellidos");

        // }

        #endregion

        #region Comprobaciones


        private bool CompruebaNombre()
        {
            if (!Regex.Match(textBoxNombreC.Text, patronNombre).Success)
            {
                errorProvider1.SetError(labelNombreCliente, "Nombre incorrecto");
                return false;
            }

            else if (textBoxNombreC.Text.Length == 0)
            {
                errorProvider1.SetError(labelNombreCliente, "Debe rellenar el nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelNombreCliente, String.Empty);
                return true;
            }

        }

        private bool CompruebaApellidos()
        {
            
            if (textBoxApellidosC.Text.Length == 0)
            {
                errorProvider1.SetError(labelApellidosCliente, "Debe rellenar los apellidos");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelApellidosCliente, String.Empty);
                return true;
            }
        }

        //NIF
        private bool CompruebaNif()
        {
            if (!validarCliente.CompruebaNIF(textBoxNifC.Text))
            {
                errorProvider1.SetError(labelNifCliente, "NIF incorrecto");
                return false;
            }

            else if (textBoxNifC.Text.Length == 0)
            {
                errorProvider1.SetError(labelNifCliente, "Debe rellenar el NIF");
                return false;
            }

            else
                errorProvider1.SetError(labelNifCliente, String.Empty);
                 return true;
        }

        private bool CompruebaMail()
        {
            if (textBoxEmailCli.Text.Length == 0)
            {
                errorProvider1.SetError(emailCli, "Rellene el email");
                return false;
            }
            else if (!validarCliente.CompruebaMail(textBoxEmailCli.Text))
            {
                errorProvider1.SetError(emailCli, "Email incorrecto");
                return false;
            }
            else
            {
                errorProvider1.SetError(emailCli, String.Empty);
                return true;
            }
        }

        private bool CompruebaPais()
        {
            if (comboBoxPaisCli.Text == "" || comboBoxPaisCli.Text == " ")
            {
                errorProvider1.SetError(labelPaisCli, "Por favor, seleccione un País");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelPaisCli, String.Empty);
                return true;
            }
        }

        private bool CompruebaProvincia()
        {
            if (comboBoxProvCli.Text == "" || comboBoxProvCli.Text == " ")
            {
                errorProvider1.SetError(labelClienteProv, "Por favor, selecciona una Provincia");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelClienteProv, String.Empty);
                return true;
            }
        }


        private bool CompruebaLocalidad()
        {
            if (textBoxLocaliCli.Text == "" || textBoxLocaliCli.Text == " ")
            {
                errorProvider1.SetError(labelLocaliCli, "Por favor, rellene el campo Localidad");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelLocaliCli, String.Empty);
                return true;
            }
        }

        private bool CompruebaCP()
        {
            if (textBoxCPCli.Text.Length == 0)
            {
                errorProvider1.SetError(labelCPCli, "Debe rellenar el Código Postal");
                return false;
            }
            else if (!validarCliente.CompruebaCP(textBoxCPCli.Text))
            {
                errorProvider1.SetError(labelCPCli, "Por favor, introduzca un Código Postal");
                return false;
            }
            else
            {
                errorProvider1.SetError(labelCPCli, String.Empty);
                return true;
            }
        }


        // Comprueba todos los booleanos de los campos, y si alguno falla, devuelve error
        private bool ValidaCampos()
        {
            bool error = true;

            if (!CompruebaNombre())
                error = false;
            if (!CompruebaApellidos())
                error = false;
            if (!CompruebaNif())
                error = false;
            if (!CompruebaMail())
                error = false;
            if (!CompruebaPais())
                error = false;
            if (!CompruebaProvincia())
                error = false;
            if (!CompruebaCP())
                error = false;
            if (!CompruebaLocalidad())
                error = false;

            return error;
        }


#endregion

        #region Foto Perfil

        private void buttonFotoCliente_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.ShowHelp = true;

            OFich.Filter = "Archivos de imagen (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";
            cliente_Perfil_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
           // Admin_Perfil_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
            {
                cliente_Perfil_Foto.Image = Image.FromFile(OFich.FileName);
                // imagenCambiada = true;
            }
        }


        #endregion

        #region Guardar

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            bool error = false;


            // NUEVO CLIENTE
            if(ValidaCampos() && !edicion)
            {
                MessageBox.Show("Todo OK");
                //ClientesEN teta;

                error = AltaCliente();
            }
            
            // ACTUALIZAR CLIENTE
            else if (ValidaCampos() && edicion)
            {
                //MessageBox.Show("Preparando para actualizar...");
                error = EditarCliente();

            }

        }

        #endregion

        #region Borrar

        private void boton_eliminar_cliente_Click(object sender, EventArgs e)
        {
            BorrarCliente();
            LimpiarDatos();
        }

        #endregion

        #region Instrucciones con EN

        private bool AltaCliente()
        {
            en_cliente = new ClientesEN();
            bool introducido = false;
           // bool dniRepetido = false;

            if(en_cliente.CompruebaExistenciaNif(textBoxNifC.Text))
            {
                errorProvider1.SetError(labelNifCliente, "El NIF ya existe");
            }

            else
            {
                en_cliente.DNI = textBoxNifC.Text;
                en_cliente.Nombre = textBoxNombreC.Text;
                en_cliente.Apellidos = textBoxApellidosC.Text;
                en_cliente.Domicilio = textBoxDomiciCli.Text;
                en_cliente.CP = textBoxCPCli.Text;
                en_cliente.Pais = comboBoxPaisCli.Text;
                en_cliente.Provincia = comboBoxProvCli.Text;
                en_cliente.Localidad = textBoxLocaliCli.Text;
                en_cliente.Telefono = textBoxTelfCli.Text;
                en_cliente.Movil = textBoxMovilCli.Text;
                en_cliente.Mail = textBoxEmailCli.Text;

                en_cliente.Fecha = dateTimePickerCli.Value;

                if (rButom_H_Cliente.Checked == true)
                {
                    en_cliente.Sexo = 0;
                }
                else if (rButom_M_Cliente.Checked == true)
                {
                    en_cliente.Sexo = 1;
                }

                en_cliente.Nick = textBoxUsuario.Text;
                en_cliente.Password = textBoxPassword.Text;

                en_cliente.Foto = cliente_Perfil_Foto.Image;

                introducido = en_cliente.InsertarCliente();
            }

            if (introducido == true)
            {
                MessageBox.Show("Los datos se han introducido satisfactoriamente.");
            }
            else if (introducido == false)
            {
                MessageBox.Show("Error. Se ha producido un fallo cuando se intentaba insertar el Cliente.");
            }

            LimpiarDatos();
            return introducido;
        }

        private bool EditarCliente()
        {
            en_cliente = new ClientesEN();
            bool introducido = false;
            string aux_nif = textBoxNifC.Text;

            /*if (en_cliente.CompruebaExistenciaNif(textBoxNifC.Text))
            {
                errorProvider1.SetError(labelNifCliente, "El NIF ya existe");
            }*/

            //else
           // {
                en_cliente.DNI = textBoxNifC.Text;
                en_cliente.Nombre = textBoxNombreC.Text;
                en_cliente.Apellidos = textBoxApellidosC.Text;
                en_cliente.Domicilio = textBoxDomiciCli.Text;
                en_cliente.CP = textBoxCPCli.Text;
                en_cliente.Pais = comboBoxPaisCli.Text;
                en_cliente.Provincia = comboBoxProvCli.Text;
                en_cliente.Localidad = textBoxLocaliCli.Text;
                en_cliente.Telefono = textBoxTelfCli.Text;
                en_cliente.Movil = textBoxMovilCli.Text;
                en_cliente.Mail = textBoxEmailCli.Text;

                en_cliente.Fecha = dateTimePickerCli.Value;

                if (rButom_H_Cliente.Checked == true)
                {
                    en_cliente.Sexo = 0;
                }
                else if (rButom_M_Cliente.Checked == true)
                {
                    en_cliente.Sexo = 1;
                }

                en_cliente.Nick = textBoxUsuario.Text;
                en_cliente.Password = textBoxPassword.Text;

                //Imagen de Perfil
                en_cliente.Foto = cliente_Perfil_Foto.Image;

                introducido = en_cliente.ActualizarCliente();
            //}

            if (introducido == true)
                MessageBox.Show("Todo OK. Se ha editado con éxito");
            else if (introducido == false)
                MessageBox.Show("ERROR. No se ha podido editar el Cliente");

            return introducido;
        }

        private void BorrarCliente()
        {
            en_cliente = new ClientesEN();

            if (MessageBox.Show("¿Desea eliminar este Cliente? \n Esta acción se realizará de forma permanente.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                 MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
            {

                en_cliente.BorrarCliente(textBoxNifC.Text);

            }


        }

        private void BorrarClienteBusqueda(string nif)
        {
            en_cliente = new ClientesEN();

            if (MessageBox.Show("¿Desea eliminar este Cliente? \n Esta acción se realizará de forma permanente.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                en_cliente.BorrarCliente(nif);

            }


        }

        #endregion

        #region Funciones Buscar

        public void MuestraClientes()
        {
            en_cliente = new ClientesEN();

            muestraCliente = new DataSet();
            muestraCliente = en_cliente.getClientes();


            Resultado_busqueda_cliente.Rows.Clear();
            foreach (DataRow cliente in muestraCliente.Tables[0].Rows)
            {
                string[] row = { cliente["NIF"].ToString(),
                                  cliente["Usuario"].ToString(),
                                  cliente["Nombre"].ToString(),
                                  cliente["Apellidos"].ToString(),
                                  cliente["Poblacion"].ToString(),
                                  cliente["Provincia"].ToString()};
                Resultado_busqueda_cliente.Rows.Add(row);
            }
        }

        private void MuestraDataSetCliente(DataSet datos)
        {

            Resultado_busqueda_cliente.Rows.Clear();
            foreach (DataRow cliente in datos.Tables[0].Rows)
            {
                string[] row = { cliente["NIF"].ToString(),
                                  cliente["Usuario"].ToString(),
                                  cliente["Nombre"].ToString(),
                                  cliente["Apellidos"].ToString(),
                                  cliente["Poblacion"].ToString(),
                                  cliente["Provincia"].ToString()};
                Resultado_busqueda_cliente.Rows.Add(row);
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            en_cliente = new ClientesEN();

            if (comboBox_filtro_busqueda.Text == "Mostrar Todos")
            {
                MuestraClientes();
            }
            else if (comboBox_filtro_busqueda.Text == "NIF")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("NIF", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Nombre")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Nombre", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Apellido")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Apellidos", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Usuario")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Usuario", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Pais")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Pais", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Provincia")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Provincia", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Localidad")
            {
                MuestraDataSetCliente(en_cliente.BusquedaCliente("Poblacion", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro_busqueda.Text == "Sexo")
            {
                if (textBox_filtro_busqueda.Text == "Hombre")
                {
                    MuestraDataSetCliente(en_cliente.BusquedaCliente("Sexo", "0"));
                }
                else if (textBox_filtro_busqueda.Text == "Mujer")
                {
                    MuestraDataSetCliente(en_cliente.BusquedaCliente("Sexo", "1"));
                }
            }
        }


        private void Resultado_busqueda_clienteCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            en_cliente = new ClientesEN();

            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == Resultado_busqueda_cliente.Columns["Editar"].Index)
                {
                    RellenaDatos_ClienteSeleccionado(sender, e);
                    formCliente.SelectTab("FichaCliente");
                }
                else if (e.ColumnIndex == Resultado_busqueda_cliente.Columns["Borrar"].Index)
                {
                    BorrarClienteBusqueda(Resultado_busqueda_cliente[0, e.RowIndex].Value.ToString());
                    MuestraClientes();
                }



            }

          /*  if(e.RowIndex < 0 || e.ColumnIndex != Resultado_busqueda_cliente.Columns["borrar"].Index)
            {
                // Rellenamos los datos del cliente
                //MessageBox.Show("Rellenamos campos de Cliente");

                RellenaDatos_ClienteSeleccionado(sender, e);
                formCliente.SelectTab("FichaCliente");
            }
            */
        }

        private void RellenaDatos_ClienteSeleccionado(object sender, DataGridViewCellMouseEventArgs e)
        {
            en_cliente = new ClientesEN();

            Image im;

            nif_actual = Resultado_busqueda_cliente[0, e.RowIndex].Value.ToString();

            LimpiarDatos();
            buttonNuevoCliente.Visible = true;
            buttonLimpiarCliente.Visible = false;
            muestraCliente = en_cliente.getClienteByNif(nif_actual);
            im = en_cliente.ObtieneImagen(nif_actual);

            #region Rellenando Los Datos

            textBoxNombreC.Text = muestraCliente.Tables[0].Rows[0][1].ToString();
            textBoxApellidosC.Text = muestraCliente.Tables[0].Rows[0][2].ToString();
            textBoxUsuario.Text = muestraCliente.Tables[0].Rows[0][3].ToString();
            // muestraCliente.Tables[0].Rows[0][4] es el pass. No mostrar
            textBoxNifC.Text = muestraCliente.Tables[0].Rows[0][5].ToString();

            dateTimePickerCli.Value = (DateTime)muestraCliente.Tables[0].Rows[0][6];

            textBoxLocaliCli.Text = muestraCliente.Tables[0].Rows[0][7].ToString();
            comboBoxProvCli.Text = muestraCliente.Tables[0].Rows[0][8].ToString();
            comboBoxPaisCli.Text = muestraCliente.Tables[0].Rows[0][9].ToString();
            textBoxDomiciCli.Text = muestraCliente.Tables[0].Rows[0][10].ToString();

            textBoxTelfCli.Text = muestraCliente.Tables[0].Rows[0][11].ToString();
            textBoxMovilCli.Text = muestraCliente.Tables[0].Rows[0][12].ToString();

            textBoxEmailCli.Text = muestraCliente.Tables[0].Rows[0][13].ToString();

            // Imagen del Perfil

            cliente_Perfil_Foto.Image = im;
            

            textBoxCPCli.Text = muestraCliente.Tables[0].Rows[0][15].ToString();

            if (muestraCliente.Tables[0].Rows[0][16].ToString() == "0")
            {
                rButom_H_Cliente.Checked = true;
                rButom_M_Cliente.Checked = false;
               // MessageBox.Show("Es Hombre");
            }
            else if (muestraCliente.Tables[0].Rows[0][16].ToString() == "1")
            {
                rButom_H_Cliente.Checked = false;
                rButom_M_Cliente.Checked = true;
                //MessageBox.Show("Es Mujer");
            }

            /*else
            {
                MessageBox.Show("FALLO al seleccionar el SEXO");
            }*/

            #endregion

            edicion = true;

        }

        #endregion

        #region Limpiar

        private void LimpiarDatos()
        {
            //Limpiamos los campos
            textBoxNombreC.Text = "";
            textBoxApellidosC.Text = "";
            textBoxNifC.Text = "";
            comboBoxPaisCli.Text = "";
            comboBoxProvCli.Text = "";
            textBoxLocaliCli.Text = "";
            textBoxCPCli.Text = "";
            textBoxDomiciCli.Text = "";
            textBoxTelfCli.Text = "";
            textBoxMovilCli.Text = "";
            textBoxEmailCli.Text = "";
            textBoxUsuario.Text = "";
            textBoxPassword.Text = "";
            cliente_Perfil_Foto.Image = Events4ALL.Properties.Resources.foto_usuario_defectojpg;
            rButom_H_Cliente.Checked = false;
            rButom_M_Cliente.Checked = false;
            edicion = false;

        }

        private void buttonLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        #endregion

        

        
        

        



    }
}
