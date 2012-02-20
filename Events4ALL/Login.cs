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
using System.IO; 

namespace Events4ALL
{
    public partial class Login : Form
    {

        string user;
        string pass;
        string lang;
        const string fic = "user.txt";

        public Login()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");  
            InitializeComponent();

            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("fonts/AGENCYR.TTF");
            System.Drawing.Font font = new Font(privateFonts.Families[0], 20);
            label3.Font = font;


            comboBox1.Text = "Es";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);
            comboBox1.Items.Add(new ComboFlags("Es", 0));
            comboBox1.Items.Add(new ComboFlags("En", 1));

            LoadUser();
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
            if (comboBox1.Text == "Es" || comboBox1.Text == "Es")
            {
                lang = "es";
            }
            else if (comboBox1.Text == "En" || comboBox1.Text == "En")
            {
                lang = "en";
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (textBoxUser.Text != "" && textBoxPass.Text != "" && comboBox1.Text != "")
                {
                    user = textBoxUser.Text;
                    pass = textBoxPass.Text;
                    miIdioma();
                    Recordar();
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los campos usuario, password e idioma no pueden estar vacios");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "" && comboBox1.Text != "")
            {
                user = textBoxUser.Text;
                pass = textBoxPass.Text;
                miIdioma();
                Recordar();
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos usuario, password e idioma no pueden estar vacios");
            }
        }

        private void Recordar()
        {
            if (checkSave.Checked)
            {
                if (File.Exists(fic))
                {
                    File.Delete(fic);
                }

                FileStream stream = new FileStream(fic, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);

                writer.WriteLine(user + "\n");
                writer.WriteLine(pass);
                writer.Close();
            }
            else
            {
                if (File.Exists(fic))
                {
                    File.Delete(fic);
                }
            }
        }

        private void LoadUser()
        {
            if (File.Exists(fic))
            {
                checkSave.Checked = true;
                int i = 0;
                FileStream stream = new FileStream(fic, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    if (i == 0)
                        textBoxUser.Text = reader.ReadLine();
                    else
                        textBoxPass.Text = reader.ReadLine();
                    i++;
                }
                reader.Close();
            }
        }
    }
}
