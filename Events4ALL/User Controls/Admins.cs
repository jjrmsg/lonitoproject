using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.Auxiliares;

namespace Events4ALL
{
    public partial class Admins : UserControl
    {
        private Validaciones validar;
        private bool nif;
        
        public Admins()
        {
            InitializeComponent();

            validar = new Validaciones();
            nif = false;
        }

        private void CompruebaNif(object sender, EventArgs e)
        {
            //test1.Text = "" + validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text);
            //test2.Text = "" + validar.DevuelveLetra(Admin_Perfil_txtBox_NIF.Text);
            //test3.Text = "" + validar.ObtieneLetra(validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text));

            // esta vacio
            if (Admin_Perfil_txtBox_NIF.Text.Length == 0)
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "NIF vacio.");
                //errorProviderNif.Clear();
                nif = false;
            }
            // esta mal
            else if (!validar.CompruebaNIF(Admin_Perfil_txtBox_NIF.Text))
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "NIF incorrecto.");
                nif = false;
            }
            // esta bien
            else
            {
                errorProviderNif.Clear();
                nif = true;
            }
        }
    }
}
