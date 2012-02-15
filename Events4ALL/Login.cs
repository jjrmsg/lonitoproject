using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Events4ALL
{
    public partial class Login : Form
    {

        string user;
        string pass;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void ThreadProc()
        {
            Application.Run(new FormBase(user, pass));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                user = textBoxUser.Text;
                pass = textBoxPass.Text;
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos usuario y password no pueden estar vacios");
            }
        }
    }
}
