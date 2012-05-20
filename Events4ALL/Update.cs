using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace Events4ALL
{
    public partial class Update : Form
    {
        int numImages;
        private String urlLog = "http://dl.dropbox.com/u/166027/Events4All/changelog.txt";
        private String urlProgram = "http://dl.dropbox.com/u/166027/Events4All/Events4AllUpdate.zip";
        private String urlVersion = "http://dl.dropbox.com/u/166027/Events4All/version.txt";
        private String versionNET = "";
        private String versionLocal = "";
        private string[] lines;
        private BackgroundWorker versionWork = new BackgroundWorker();

        public Update()
        {
            InitializeComponent();
            numImages = imageList1.Images.Count;

            versionWork.WorkerReportsProgress = true;
            versionWork.WorkerSupportsCancellation = true;
            versionWork.DoWork += new DoWorkEventHandler(versionWork_DoWork);
            versionWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(versionWork_RunWorkerCompleted);

            LoadVersion();
        }



        private void ChangeView()
        {
            //Ocultar
            pictureBox1.Visible = false;
            msgLabel.Visible = false;

            //Mostrar
            pictureBox2.Visible = true;
            updateList.Visible = true;
            updateBar.Visible = true;
            updateButton.Visible = true;
        }

        private void LoadVersion()
        {
            if (!File.Exists("version.txt"))
            {
                WebClient wc1 = new WebClient();
                wc1.Proxy = null;
                wc1.DownloadFileAsync(new Uri(urlVersion), "version.txt");
                //wc1.DownloadFileAsync(new Uri(urlProgram), "update.zip");
            }
            else
            {
                //Comparamos las versiones de forma asíncrona
                if (!versionWork.IsBusy)
                {
                    versionWork.RunWorkerAsync();
                }
            }
        }

        private void updateList_VisibleChanged(object sender, EventArgs e)
        {
            lines = File.ReadAllLines("changelog.txt");
            foreach (string line in lines)
            {
                updateList.Items.Add(new listItem(line, 0));
            }
        }

        private void versionWork_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc1 = new WebClient();
            wc1.Proxy = null;
            versionNET = wc1.DownloadString(urlVersion);
            StreamReader streamReader = new StreamReader("version.txt");
            versionLocal = streamReader.ReadToEnd();
            streamReader.Close();
            wc1.DownloadFile(new Uri(urlLog), "changelog.txt");
        }

        private void versionWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (versionNET != versionLocal)
            {
                //Cambiamos la vista
                ChangeView();
            }
            else
            {
                pictureBox1.Visible = false;
                msgLabel.Text = "No hay actualizaciones disponibles";
            }
        }

        private void updateList_DrawItem(object sender, DrawItemEventArgs e)
        {
            updateList.DrawMode = DrawMode.OwnerDrawFixed;
            //Cambiar el color de la selección de items
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor,
                                          Color.White);
            }

            //Añadir iconos a los items de la lista
            listItem item = updateList.Items[e.Index] as listItem;
            e.DrawBackground();

            if (item.ImageIndex >= 0 && item.ImageIndex < numImages)
            {
                e.Graphics.DrawImage(imageList1.Images[item.ImageIndex], new PointF(e.Bounds.Left + 8, e.Bounds.Top + 5));
            }

            e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(Color.Black),
                      new PointF(e.Bounds.Left + imageList1.ImageSize.Width + 20, e.Bounds.Top + 5));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Proxy = null;

            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(updateCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            wc.DownloadFileAsync(new Uri(urlProgram), "update.zip");
            updateButton.Visible = false;
            progressLabel.Visible = true;
        }

        private void updateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            File.Delete("version.txt");
            WebClient wc = new WebClient();
            wc.Proxy = null;
            wc.DownloadFile(new Uri(urlVersion), "version.txt");
            //MessageBox.Show("El programa se reiniciará para aplicar los cambios");
            Process proceso = new Process();
            proceso.StartInfo.UseShellExecute = false;
            proceso.StartInfo.RedirectStandardOutput = true;
            proceso.StartInfo.RedirectStandardError = false;
            proceso.StartInfo.CreateNoWindow = false;
            proceso.StartInfo.FileName = "Updater.exe";
            Application.Exit();
            proceso.Start();
          
            
            
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            updateBar.Value = e.ProgressPercentage;
            progressLabel.Text = e.ProgressPercentage + "%";
        }
    }
}
