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

namespace Events4ALL
{
    public partial class Clientes : UserControl
    {
        private Validaciones validarCliente;

        string patronNombre = @"^[a-zA-Z]*\w*$";
        string patronCP = @"^\d{5}$";

        public Clientes()
        {
            InitializeComponent();

            //Creamos objeto para validar
            validarCliente = new Validaciones();
   
        }

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
            if (!Regex.Match(textBoxApellidosC.Text, patronNombre).Success)
            {
                errorProvider1.SetError(labelApellidosCliente, "Apellidos incorrectos");
                return false;
            }
            else if (textBoxApellidosC.Text.Length == 0)
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
            if(ValidaCampos())
            {
                MessageBox.Show("Todo OK");
            }

        }

        #endregion



    }
}
