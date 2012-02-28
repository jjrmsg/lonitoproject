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
    public partial class FormBase : Form
    {
        public FormBase(string user, string pass, string lang)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if(lang=="en")
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            InitializeComponent();


            /*System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("fonts/AGENCYR.TTF");
            System.Drawing.Font font = new Font(privateFonts.Families[0], 20);
            label4.Font = font;

            System.Drawing.Font font2 = new Font(privateFonts.Families[0], 10);
            label5.Font = font2;*/

            if(lang=="es" || lang==" ")
            {
                listBox1.Items.Add(new listItem("Inicio", 0));
                listBox1.Items.Add(new listItem("Admins", 1));
                listBox1.Items.Add(new listItem("Clientes", 2));
                listBox1.Items.Add(new listItem("Salas", 3));
                listBox1.Items.Add(new listItem("Espectáculos", 4));
                listBox1.Items.Add(new listItem("Promociones", 5));
                listBox1.Items.Add(new listItem("Estadísticas", 6));
                listBox1.Items.Add(new listItem("Ventas y reservas", 7));
                listBox1.Items.Add(new listItem("Mensajes", 8));
                //listBox1.Items.Add(new listItem("Logs", 8));
                listBox1.SetSelected(0, true);
            }
            else if (lang == "en")
            { 
                listBox1.Items.Add(new listItem("Main", 0));
                listBox1.Items.Add(new listItem("Admins", 1));
                listBox1.Items.Add(new listItem("Customers", 2));
                listBox1.Items.Add(new listItem("Halls", 3));
                listBox1.Items.Add(new listItem("Shows", 4));
                listBox1.Items.Add(new listItem("Promotions", 5));
                listBox1.Items.Add(new listItem("Statistics", 6));
                listBox1.Items.Add(new listItem("Sales and reservations", 7));
                listBox1.Items.Add(new listItem("Messages", 8));
                listBox1.SetSelected(0, true);
            }

            DesactivarMenus();
            inicio1.Visible = true;

            
        }

        public void ThreadProc()
        {
            Application.Run(new Login());
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Cambiar el color de la selección de items
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Gainsboro);
            e.DrawBackground();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

            //Añadir iconos a los items de la lista
            listItem item = listBox1.Items[e.Index] as listItem;
            e.DrawBackground();

            if (item.ImageIndex >= 0 && item.ImageIndex < imageList1.Images.Count)
            {
                e.Graphics.DrawImage(imageList1.Images[item.ImageIndex],
                                     new PointF(e.Bounds.Left+8, e.Bounds.Top+5));
            }

            e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(Color.Black),
                                  new PointF(e.Bounds.Left + imageList1.ImageSize.Width + 20,
                                  e.Bounds.Top+5));

            //listBox1_Click(sender, e);
        }


        private void DesactivarMenus()
        {
            inicio1.Visible = false;
            admins1.Visible = false;
            clientes1.Visible = false;
            espectaculos1.Visible = false;
            logs1.Visible = false;
            estadisticas1.Visible = false;
            promociones1.Visible = false;
            salas1.Visible = false;
            ventas1.Visible = false;
            mensajes1.Visible = false;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int optionMenu = listBox1.SelectedIndex;
            DesactivarMenus();
            switch (optionMenu)
            {
                case 0:
                    inicio1.Visible = true;
                    break;
                case 1:
                    admins1.Visible = true;
                    break;
                case 2:
                    clientes1.Visible = true;
                    break;
                case 3:
                    salas1.Visible = true;
                    break;
                case 4:
                    espectaculos1.Visible = true;
                    break;
                case 5:
                    promociones1.Visible = true;
                    break;
                case 6:
                    estadisticas1.Visible = true;
                    break;
                case 7:
                    ventas1.Visible = true;
                    break;
                case 8:
                    mensajes1.Visible = true;
                    break;
                default:
                    inicio1.Visible = true;
                    break;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void messagePicture_Click(object sender, EventArgs e)
        {
            DesactivarMenus();
            mensajes1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
