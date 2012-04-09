using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Events4ALL.EN;

namespace Events4ALL.User_Controls
{

    public partial class Mensajes : UserControl
    {

        string status = "";
        private MensajesEN msgEN = new MensajesEN();
        private string mimail = "";
        private string IDMensaje = "";

        public Mensajes()
        {
            InitializeComponent();

            status = statusLabel.Text;
            CheckForIllegalCrossThreadCalls = false;
            LoadMessages();
        }

        private void LoadMessages()
        {
            DataSet dsmsg = new DataSet();
            dsmsg = msgEN.getMessages();
            msgGridView.Rows.Clear();

            try
            {
                foreach (DataRow row in dsmsg.Tables[0].Rows)
                {
                    DateTime Fecha = (DateTime)row["Fecha"];
                    string anyo = Fecha.Year.ToString();
                    string mes = Fecha.Month.ToString();
                    string dia = Fecha.Day.ToString();

                    int est = int.Parse(row["Estado"].ToString());
                    if (est == 0)
                    {
                        DataGridViewRow r = new DataGridViewRow();
                        r.CreateCells(msgGridView);
                        r.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
                        r.SetValues(row["IDMensaje"], row["Asunto"], dia+"/"+mes+"/"+anyo);
                        r.DefaultCellStyle.BackColor = Color.Lavender;

                        msgGridView.Rows.Add(r);
                    }
                    else
                    {
                        DataGridViewRow r = new DataGridViewRow();
                        r.CreateCells(msgGridView);
                        r.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
                        r.SetValues(row["IDMensaje"], row["Asunto"], dia + "/" + mes + "/" + anyo);
                        msgGridView.Rows.Add(r);
                    }
                }
            }
            catch
            {
            }
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail(responseText.Text, mimail, IDMensaje, new MailCallback(ResultCallback));
            Thread th1 = new Thread(new ThreadStart(mail.sendMail));
            th1.Start();
            statusLabel.Visible = true;
            statusLabel.Text = "Enviando...";
        }

        public void ResultCallback(string ID)
        {
            statusLabel.Text = "Enviado";
            responseText.Clear();
            msgEN.setResponse(ID);
            LoadMessages();
        }

        private void msgGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != msgGridView.Columns["Eliminar"].Index)
            {
                //textBox1.Text = msgGridView.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                foreach (DataGridViewRow r in msgGridView.SelectedRows)
                {
                    DataSet mensaje = new DataSet();
                    mensaje = msgEN.getMessageByID(msgGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    r.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;

                    foreach (DataRow row in mensaje.Tables[0].Rows)
                    {
                        textNombre.Text = row["Nombre"].ToString();
                        textApellidos.Text = row["Apellidos"].ToString();
                        textAsunto.Text = row["Asunto"].ToString();
                        textConsulta.Text = row["Contenido"].ToString();
                        mimail = row["Mail"].ToString();
                        IDMensaje = row["IDMensaje"].ToString();
                    }
                }
            }
            else //Eliminar fila
            {
                foreach (DataGridViewRow r in msgGridView.SelectedRows)
                {
                    msgEN.deleteMessage(msgGridView.Rows[r.Index].Cells["ID"].Value.ToString());
                    msgGridView.Rows.RemoveAt(r.Index);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }

    public delegate void MailCallback(string res);

    public class Mail
    {
        string Mensaje = "";
        string eMail = "";
        string IDMensaje = "";
        protected MailCallback callback = null;

        public Mail(string msj, string mail, string ID, MailCallback callback)
        {
            Mensaje = msj;
            eMail=mail;
            IDMensaje = ID;
            this.callback = callback;
        }

        public void sendMail()
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(eMail);
            message.Subject = "Respuesta Events4ALL";
            message.From = new System.Net.Mail.MailAddress("events4alls@gmail.com");
            message.Body = Mensaje;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("events4alls@gmail.com", "sherlocked"),
                EnableSsl = true
            };
            smtp.Send(message);

            if (callback != null)
            {
                callback(IDMensaje);
            }
        }
    }
}
