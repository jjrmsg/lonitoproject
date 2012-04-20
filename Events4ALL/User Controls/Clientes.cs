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
        string patronNombre = @"^\w{3,25}$";
        string patronCP = @"^\d{5}$";

        //private Validaciones validar;

        public Clientes()
        {
            InitializeComponent();

            // Objeto que se encarga de validar
            //validarCliente = new Validaciones();


   
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

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            //string patronNombre = @"^\w{3,15}$/;
            //if (this.textBoxNombreC.Text == "" || this.textBoxNombreC.Text == " ")
               // MessageBox.Show("Nombre está vacío. Por favor, introduzca un nombre");
                //errorProvider1.SetError(textBoxNombreC,"Por favor, rellene el Nombre");

            //if (this.textBoxApellidosC.Text == "" || this.textBoxApellidosC.Text == " ")
                // MessageBox.Show("Apellidos está vacío. Por favor, introduzca los apellidos");
                //errorProvider1.SetError(textBoxApellidosC, "Por favor, rellene los Apellidos");
            
        }

        #region Comprobaciones


        private void textBoxNombreC_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(textBoxNombreC.Text, patronNombre).Success)
                errorProvider1.SetError(labelNombreCliente, "Nombre incorrecto");
            else
                errorProvider1.SetError(labelNombreCliente,String.Empty);

        }

        private void textBoxApellidosC_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(textBoxApellidosC.Text, patronNombre).Success)
                errorProvider1.SetError(labelApellidosCliente, "Apellidos incorrectos");
            else
                errorProvider1.SetError(labelApellidosCliente, String.Empty);
        }

        private void comboBoxPaisCli_Leave(object sender, EventArgs e)
        {
            if (comboBoxPaisCli.Text == "" || comboBoxPaisCli.Text == " ")
                errorProvider1.SetError(labelPaisCli, "Por favor, seleccione un País");
        }

        private void comboBoxProvCli_Leave(object sender, EventArgs e)
        {
            if (comboBoxProvCli.Text == "" || comboBoxProvCli.Text == " ")
                errorProvider1.SetError(labelClienteProv, "Por favor, selecciona una Provincia");
            else
                errorProvider1.SetError(labelClienteProv, String.Empty);
        }


        private void textBoxLocaliCli_Leave(object sender, EventArgs e)
        {
            if (textBoxLocaliCli.Text == "" || textBoxLocaliCli.Text == " ")
                errorProvider1.SetError(labelLocaliCli, "Por favor, rellene el campo Localidad");
            else
                errorProvider1.SetError(labelLocaliCli, String.Empty);
        }

        private void textBoxCPCli_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(textBoxCPCli.Text, patronCP).Success)
                errorProvider1.SetError(labelCPCli, "Por favor, introduzca un Código Postal");
            else
                errorProvider1.SetError(labelCPCli, String.Empty);
        }


#endregion

        

       
        

    }
}
