using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading; 

namespace Events4ALL
{
    public partial class Login : Form
    {

        string user;
        string pass;
        string lang;

        public Login()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");  
            InitializeComponent();
            comboBox1.Text = "Español";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);
            comboBox1.Items.Add(new ComboFlags("Español", 0));
            comboBox1.Items.Add(new ComboFlags("Inglés", 1));
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboFlags item = comboBox1.Items[e.Index] as ComboFlags;
            e.DrawBackground();
            if (item.ImageIndex >= 0 && item.ImageIndex < idiomas.Images.Count)
            {
                e.Graphics.DrawImage(idiomas.Images[item.ImageIndex], new PointF(e.Bounds.Left, e.Bounds.Top));
            }
            e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.Left + idiomas.ImageSize.Width + 1, e.Bounds.Top));
        }

        public void ThreadProc()
        {
            Application.Run(new FormBase(user, pass, lang));
        }

        private void miIdioma()
        {
            if (comboBox1.Text == "Español" || comboBox1.Text == "Spanish")
            {
                lang = "es";
            }
            else if (comboBox1.Text == "Inglés" || comboBox1.Text == "English")
            {
                lang = "en";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "" && comboBox1.Text != "")
            {
                user = textBoxUser.Text;
                pass = textBoxPass.Text;
                miIdioma();
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos usuario, password e idioma no pueden estar vacios");
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }
    }
}
