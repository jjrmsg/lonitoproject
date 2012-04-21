using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Events4ALL.Auxiliares;
using Events4ALL.EN;

namespace Events4ALL
{
    public partial class Clientes : UserControl
    {
        #region Variables

        private Validaciones validarCliente;

        string patronNombre = @"^[a-zA-Z]*\w*$";
        //string patronCP = @"^\d{5}$";

        private ClientesEN en_cliente;
        private DataSet muestraCliente;


        #endregion

        public Clientes()
        {
            InitializeComponent();

            //Creamos objeto para validar
            validarCliente = new Validaciones();
   
        }

        private void formCliente_Click(object sender, EventArgs e)
        {
            MuestraClientes();
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


        #region Guardar

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            bool error = false;

            if(ValidaCampos())
            {
                MessageBox.Show("Todo OK");
                //ClientesEN teta;

                error = AltaCliente();
            }

        }

        #endregion

        #region Instrucciones con EN

        private bool AltaCliente()
        {
            en_cliente = new ClientesEN();
            bool introducido = false;

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

            introducido = en_cliente.InsertarCliente();

            if (introducido == true)
            {
                MessageBox.Show("Todo OK. Introducido es TRUE");
            }
            else if (introducido == false)
            {
                MessageBox.Show("FALLO. Introducido es FALSE");
            }

            return introducido;
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

        #endregion

        #region Limpiar

        private void buttonLimpiarCliente_Click(object sender, EventArgs e)
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
            rButom_H_Cliente.Checked = false;
            rButom_M_Cliente.Checked = false;
        }

        #endregion

        



    }
}
