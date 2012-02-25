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

namespace Events4ALL.User_Controls
{

    public partial class Mensajes : UserControl
    {

        string status = "";

        public Mensajes()
        {
            InitializeComponent();

            status = statusLabel.Text;
            CheckForIllegalCrossThreadCalls = false;

            string[] row1 = new string[] { "Problema con los pagos" };
            string[] row2 = new string[] { "No puedo loguearme" };
            string[] row3 = new string[] { "Mi tarjeta de credito no funciona" };
            string[] row4 = new string[] { "No puedo elegir asientos" };
            string[] row5 = new string[] { "Hay descuentos para estudiantes?" };
            string[] row6 = new string[] { "Quiero cancelar una reserva" };
            string[] row7 = new string[] { "No me salen mis compras" };
            string[] row8 = new string[] {"He perdido mis entradas"};
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8 };

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail(responseText.Text, new MailCallback(ResultCallback));
            Thread th1 = new Thread(new ThreadStart(mail.sendMail));
            th1.Start();
            //th1.Join();
            statusLabel.Visible = true;
            statusLabel.Text = "Enviando...";
        }

        public void ResultCallback(string res)
        {
            statusLabel.Text = "Enviado";
        }
    }

    public delegate void MailCallback(string res);

    public class Mail
    {
        string Mensaje = "";
        protected MailCallback callback = null;

        public Mail(string msj, MailCallback callback)
        {
            Mensaje = msj;
            this.callback = callback;
        }

        public void sendMail()
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("shadowfiltro@gmail.com");
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
                callback("Enviado");
            }
        }
    }
}
