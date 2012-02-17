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
    public partial class FormBase : Form
    {
        public FormBase(string user, string pass)
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            listBox1.Items.Add(new listItem("Inicio", 0));
            listBox1.Items.Add(new listItem("Admins", 0));
            listBox1.Items.Add(new listItem("Clientes", 0));
            listBox1.Items.Add(new listItem("Salas", 0));
            listBox1.Items.Add(new listItem("Espectáculos", 0));
            listBox1.Items.Add(new listItem("Promociones", 0));
            listBox1.Items.Add(new listItem("Estadísticas", 0));
            listBox1.Items.Add(new listItem("Ventas y reservas", 0));
            listBox1.Items.Add(new listItem("Logs", 0));
            listBox1.SetSelected(0, true);
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
                                          Color.SlateGray);
            e.DrawBackground();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

            //Añadir iconos a los items de la lista
            listItem item = listBox1.Items[e.Index] as listItem;
            e.DrawBackground();

            if (item.ImageIndex >= 0 && item.ImageIndex < imageList1.Images.Count)
            {
                e.Graphics.DrawImage(imageList1.Images[item.ImageIndex],
                                     new PointF(e.Bounds.Left, e.Bounds.Top));
            }

            e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(e.ForeColor),
                                  new PointF(e.Bounds.Left + imageList1.ImageSize.Width + 1,
                                  e.Bounds.Top));

            listBox1_Click(sender, e);
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
                    logs1.Visible = true;
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

    }
}
