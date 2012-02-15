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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            listBox1.Items.Add(new listItem("Inicio", 0));
            listBox1.Items.Add(new listItem("Admins", 0));
            listBox1.Items.Add(new listItem("Clientes", 0));
            listBox1.Items.Add(new listItem("Salas", 0));
            listBox1.Items.Add(new listItem("Espectáculos", 0));
            listBox1.Items.Add(new listItem("Promociones", 0));
            listBox1.Items.Add(new listItem("Estadisticas", 0));
            listBox1.Items.Add(new listItem("Logs", 0));
            listBox1.SetSelected(0, true);
            DesactivarMenus();
            inicio1.Visible = true;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
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
                    logs1.Visible = true;
                    break;
                default:
                    inicio1.Visible = true;
                    break;
            }

        }

    }
}
