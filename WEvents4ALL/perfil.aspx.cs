using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Auxiliares;
using System.Data;
using System.Text.RegularExpressions;

namespace WEvents4ALL
{
    public partial class perfil : System.Web.UI.Page
    {
        public ClientesEN cliente;
        public DataSet perfilCliente = new DataSet();
        public Validaciones valida;
        public string nick;

        protected void Page_Load(object sender, EventArgs e)
        {
            // No marcamos nada en la barra de enlaces
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 0;

            cliente = new ClientesEN();
            
            // obtengo los datos del cliente bastardo
            if (Session["IdUsuario"] != null)
            {
                perfilCliente = cliente.ObtenerUsuarioPorID(Session["IdUsuario"].ToString());
            }
            else
                Response.Redirect("index.aspx");
            System.Diagnostics.Debug.Write("\nPage_Load");

            // Relleno los datos del cliente si es la primera vez que accede, a partir del DataSet recibido.
            if (TextBox_Nombre.Text == "" && TextBox_Apellido.Text == "" && TextBox_NIF.Text == "" && TextBox_FN.Text == "")
                RellenaDatos();
        }

        // Valida los datos :
        // 1 - Si estan correctos, ejecuta la SQL de la actualizacion en la BD
        // 2 - Si es un Fail, ya vere...
        protected void bGuardar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("\nbGuardar " + TextBox_Nombre.Text);

            bool error = false;
            // 0 = Desconocido // 1 = datos // 2 = pass. No coinciden // 3 = La contraseña no es correta // 4 = nose ha almacenado
            int tipoE = 0;
            // se usara para realizar el cambio.
            string contrasena = "";

            if (ValidaCampos())
            {
                // Ahora pasamos a comprobar si la contraseña es correcta
                if (TextBox_PASS_3.Text != "" && TextBox_PASS_2.Text != "" && TextBox_PASS_1.Text != "") 
                {
                    if (TextBox_PASS_2.Text != TextBox_PASS_1.Text)
                    {
                        tipoE = 2;
                        error = true;
                        contrasena = "";
                    }
                    else if (!cliente.VerificaPassCliente(TextBox_PASS_2.Text, Convert.ToInt32(Session["IdUsuario"].ToString())))
                    {
                        tipoE = 3;
                        error = true;
                        contrasena = "";
                    }
                    else
                        contrasena = TextBox_PASS_3.Text;
                }
                    
                // Si no se modifica la contraseña, pasaremos a actualiar el cliente en la BD
                if (!error)
                {
                    ClientesEN nvCliente = new ClientesEN();

                    nvCliente.DNI = TextBox_NIF.Text;
                    nvCliente.Nombre = TextBox_Nombre.Text;
                    nvCliente.Apellidos = TextBox_Apellido.Text;
                    nvCliente.Pais = DropDownList_Pais.Text;
                    nvCliente.Provincia = DropDownList_Prov.Text;
                    nvCliente.Localidad = TextBox_Localidad.Text;
                    nvCliente.Domicilio = TextBox_Domicilio.Text;
                    nvCliente.CP = TextBox_CP.Text;
                    nvCliente.Telefono = TextBox_Telefono.Text;
                    nvCliente.Movil = TextBox_Movil.Text;
                    nvCliente.Mail = TextBox_Mail.Text;
                    nvCliente.Fecha = Convert.ToDateTime(TextBox_FN.Text);
                    nvCliente.Password = contrasena;

                    if (DropDownList_Sexo.Text == "Hombre")
                        nvCliente.Sexo = 0;
                    else if (DropDownList_Sexo.Text == "Mujer")
                        nvCliente.Sexo = 1;
                    else
                        nvCliente.Sexo = -1;

                    //nvCliente.Foto = System.Drawing.Image.FromFile(foto.FileName);


                    if (!nvCliente.ActualizaCliente(nvCliente, Convert.ToInt32(Session["IdUsuario"].ToString())))
                    {
                        error = true;
                        tipoE = 4;
                    }
                    // Si todo va bien....
                    else
                    {
                        MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                        mv.ActiveViewIndex = 1;
                        perfilCliente = cliente.ObtenerUsuarioPorID(Session["IdUsuario"].ToString());
                        RellenaDatos();
                    }
                }
            }
            else
            {
                error = true;
                tipoE = 1; 
            }

            if(error)
            {
                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 0;
                Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                Label lbMsg = (Label)Master.FindControl("errorViewMsg");

                switch (tipoE)
                {
                    case 0:
                        lbTitle.Text = "0 - Ocurrió un Error Inesperado.";
                        lbMsg.Text = "No se han podido realizar los cambios. Intentelo más tarde.";
                        break;
                    case 1:
                        lbTitle.Text = "1 - Ocurrió un Error.";
                        lbMsg.Text = "Se ha localizado un error en los datos. Verifiquelos y vuelva a intentarlo.";
                        break;
                    case 2:
                        lbTitle.Text = "2 - Ocurrió un Error.";
                        lbMsg.Text = "La constraseñas no coinciden.";
                        break;
                    case 3:
                        lbTitle.Text = "3 - Ocurrió un Error.";
                        lbMsg.Text = "La contraseña anterior no es correcta. Vuelva a intentarlo.";
                        break;
                    case 4:
                        lbTitle.Text = "4 - Ocurrió un Error.";
                        lbMsg.Text = "No se han podido almacenar los cambios. Intentelo después.";
                        break;
                }
            }
        }

        // Restaura los datos del Dataset actual.
        protected void bCancelar_Click(object sender, EventArgs e)
        {
            // Restauro los datos a partir del DataSet de la carga.
            RellenaDatos();
        }

        // Rellena los datos a partir del DataSet de la carga.
        // Ojo, me falta la parte de la imagen !!!!!!!!!!!!!!!!!!!!!!!!!!
        protected void RellenaDatos()
        {
            foreach (System.Data.DataRow r in perfilCliente.Tables[0].Rows)
            {
                // Obtencion del NICK
                nick = r["Usuario"].ToString();

                // Grupo de TextBoxes
                TextBox_Nombre.Text = r["Nombre"].ToString();
                TextBox_Apellido.Text = r["Apellidos"].ToString();
                TextBox_CP.Text = r["CP"].ToString();
                TextBox_Domicilio.Text = r["Direccion"].ToString();
                TextBox_Localidad.Text = r["Poblacion"].ToString();
                TextBox_Mail.Text = r["Mail"].ToString();
                TextBox_Movil.Text = r["TfnoMovil"].ToString();
                TextBox_NIF.Text = r["NIF"].ToString();
                TextBox_Telefono.Text = r["TfnoFijo"].ToString();

                // Listas de mierda
                DropDownList_Pais.Text = r["Pais"].ToString();
                DropDownList_Prov.Text = r["Provincia"].ToString();

                if (r["Sexo"].ToString() == "0")
                    DropDownList_Sexo.Text = "Hombre";
                else if (r["Sexo"].ToString() == "1")
                    DropDownList_Sexo.Text = "Mujer";
                else
                    DropDownList_Sexo.Text = "";

                // Fecha Provisional... que ya veremos si cambio.... xD
                string fecha = r["FechaNac"].ToString();
                string dia = fecha[0].ToString() + fecha[1];
                string mes = fecha[3].ToString() + fecha[4];
                string ano = fecha[6].ToString() + fecha[7] + fecha[8] + fecha[9];
                TextBox_FN.Text = dia + '/' + mes + '/' + ano;

                // Carga de la imagen

                // Borro los passwords.
                TextBox_PASS_1.Text = "";
                TextBox_PASS_2.Text = "";
                TextBox_PASS_3.Text = "";
            }
        }

        protected DateTime Fecha()
        {
            string dia, mes, ano;
            string txtFecha = TextBox_FN.Text;

            dia = txtFecha[0].ToString() + txtFecha[1];
            mes = txtFecha[3].ToString() + txtFecha[4];
            ano = txtFecha[6].ToString() + txtFecha[7] + txtFecha[8] + txtFecha[9];

            return Convert.ToDateTime(mes+'/'+dia+'/'+ano);
        }

        #region Validacion de Datos

        string patronNombre = @"[a-zA-Z\s]{3,50}";
        string patronTelefono = @"\d{9}";
        string patronFecha = @"^([0-9]{1,2})\/([0-9]{1,2})\/[0-9][0-9][0-9][0-9]$";
        string patronCP = @"^\d{5}$";
        string patronMail = @"^(.+\@.+\..+)$";
        string patronPass = @"^([a-zA-Z0-9]{3,50})$";

        // Valida los datos y establece los mensajes de error pertinentes en la pagina.
        // Retorna un booleano si son correctos o no.
        private bool ValidaCampos()
        {
            bool error = true;
            // 13 campos
            
            #region Columna Izquierda
                // Nombre
                if (!Regex.Match(TextBox_Nombre.Text, patronNombre).Success)
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail nombre - " + TextBox_Nombre.Text);
                }
                // NIF
                if (!CompruebaNif(TextBox_NIF.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail nif");
                }
                // Pais
                if (DropDownList_Pais.Text == "")
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail pais");
                }
                // Localidad
                if (!Regex.Match(TextBox_Localidad.Text, patronNombre).Success)
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail localidad - " + TextBox_Localidad.Text);
                }
                // Domicilio
                if (!Regex.Match(TextBox_Domicilio.Text, patronNombre).Success)
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail direccion");
                }
                // Telefono
                if (!Regex.Match(TextBox_Telefono.Text, patronTelefono).Success)
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail telefono");
                }
                // Sexo
                if (!CompruebaSexo(DropDownList_Sexo.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail sex");
                }
            #endregion
                
            #region Columna Derecha
                // Apellidos
                if (!Regex.Match(TextBox_Apellido.Text, patronNombre).Success)
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail apellido");
                }
                // Fecha
                if (!CompruebaFecha(TextBox_FN.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail fecha");
                }
                // Provincia
                if (DropDownList_Prov.Text == "")
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail provincia");
                }
                // CP
                if (!CompruebaCP(TextBox_CP.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail CP");
                }
                // Mail
                if (!CompruebaMail(TextBox_Mail.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail mail");
                }
                // Movil
                if (!CompruebaNumero(TextBox_Movil.Text))
                {
                    error = false;
                    System.Diagnostics.Debug.Write("\nFail movil");
                }
            #endregion

            #region Pass

                if (TextBox_PASS_1.Text != "" || TextBox_PASS_2.Text != "" || TextBox_PASS_3.Text != "")
                {
                    if (TextBox_PASS_1.Text != TextBox_PASS_3.Text)
                        error = true;
                    if (!Regex.Match(TextBox_PASS_3.Text, patronPass).Success)
                        error = true;
                }

            #endregion

            return error;
        }

        private bool CompruebaNif(string texto)
        {
            valida = new Validaciones();

            if (!valida.CompruebaNIF(texto))
            {
                return false;
            }

            else if (texto == "")
            {
                return false;
            }

            else
                return true;
        }

        private bool CompruebaMail(string texto)
        {
            if (texto != "" && Regex.Match(texto, patronMail).Success)
                return true;
            else
                return false;
        }

        private bool CompruebaNumero(string texto)
        {
            if (!Regex.Match(texto, patronTelefono).Success)
            {
                //errorProvider1.SetError(labelNombreCliente, "Nombre incorrecto");
                return false;
            }

            else if (texto == "")
            {
                //errorProvider1.SetError(labelNombreCliente, "Debe rellenar el nombre");
                return false;
            }
            else
            {
                //errorProvider1.SetError(labelNombreCliente, String.Empty);
                return true;
            }
        }

        private bool CompruebaSexo(string texto)
        {
            if(texto == "" || texto == "Hombre" || texto == "Mujer")
            {
                return true;
            }
            else
	            return false;
        }

        private bool CompruebaCP(string texto)
        {
            if (texto == "" || Regex.Match(texto, patronCP).Success)
                return true;
            else
                return false;
        }

        private bool CompruebaFecha(string texto) 
        {
            var error = true;

            if (!Regex.Match(texto, patronFecha).Success)
                error = false;
            else
            {
                int d = texto[0] + texto[1];
                int m = texto[3] + texto[4];
                int a = texto[6] + texto[7] + texto[8] + texto[9];

                // meses dias = 31 ( 1 - 3 - 5 - 7 - 8 - 10 - 12)
                // meses dias = 30 ( 4 - 6 - 9  - 11 )

                if (a >= 1900 && (m < 13 && m > 0) && (d > 0 && d < 32))
                {
                    if (d > 28) // Conflicto al ser bisiesto?
                    {
                        if ((m == 4 || m == 6 || m == 9 || m == 11) && d < 31)
                            error = false;
                        else if ((m == 7 || m == 5 || m == 3 || m == 1 || m == 8 || m == 10 || m == 12) && d <= 31)
                            error = false;
                        else if (m == 2 && Bisiesto(a) && d == 29)
                            error = false;
                    }
                    else error = false;
                }
            }
            
            return error;
        }

        private bool Bisiesto(int a) 
        {
            var bisiesto = false;
            if ((a % 4 == 0) && ((a % 100 != 0)) || (a % 400 == 0))
                bisiesto = true;
            return bisiesto;
        }

        #endregion
    }
}