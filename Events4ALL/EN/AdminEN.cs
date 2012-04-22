using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using System.Data;
using System.Drawing;

namespace Events4ALL.EN
{
    class AdminEN
    {
        #region Variables

        private AdminCAD cad_admin;
        private DataSet data_admin;

        private int id;
        private string dni;
        private string nombre;
        private string apellidos;
        private string pais;
        private string provincia;
        private string localidad;
        private string domicilio;
        private string cp; // codigo postal
        private string telefono;
        private string movil;
        private string mail;
        private string ec; // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
        private Image foto;
        private int sexo; // 0 - hombre // 1 - Mujer
        private DateTime fecha;
        private string pass;
        private string nick;
        
        #endregion

        #region Set's y Get's

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Movil
        {
            get { return movil; }
            set { movil = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string EC
        {
            get { return ec; }
            set { ec = value; }
        }

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Image Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }
      
        #endregion

        #region Constructores

        public AdminEN()
        {
            ec = dni = nick = pass = nombre = apellidos = pais = provincia = localidad = domicilio = cp = telefono = movil = mail = string.Empty;
            sexo = -1;
            Fecha = DateTime.Parse("01/01/2100");
            foto = null;
        }

        public AdminEN(string dni_c, string nombre_c, string apellidos_c, string pais_c, string provincia_c,
                        string localidad_c, string domicilio_c, string cp_c, string telefono_c, string movil_c,
                        string mail_c, string ec_c, Image foto_c, int sexo_c, string nick_c, string pass_c, DateTime fecha_c)
        {
            dni = dni_c;
            nombre = nombre_c;
            apellidos = apellidos_c;
            pais = pais_c;
            provincia = provincia_c;
            localidad = localidad_c;
            domicilio = domicilio_c;
            cp = cp_c;
            telefono = telefono_c;
            movil = movil_c;
            mail = mail_c;
            ec = ec_c;
            foto = foto_c;
            sexo = sexo_c;
            nick = nick_c;
            pass = pass_c;
            fecha = fecha_c;
        }

        public AdminEN (AdminEN anterior)
        {
            DNI = anterior.DNI;
            Nombre = anterior.Nombre;
            Apellidos = anterior.Apellidos;
            Pais = anterior.Pais;
            Provincia = anterior.Provincia;
            Localidad = anterior.Localidad;
            Domicilio = anterior.Domicilio;
            CP = anterior.CP;
            Telefono = anterior.Telefono;
            Movil = anterior.Movil;
            Mail = anterior.Mail;
            EC = anterior.EC;
            Foto = anterior.Foto;
            Sexo = anterior.Sexo;
            Nick = anterior.Nick;
            Pass = anterior.Pass;
            Fecha = anterior.Fecha;
        }

        public AdminEN (DataSet anterior)
        {
            this.DNI = anterior.Tables[0].Rows[0][0].ToString();
            this.Nombre = anterior.Tables[0].Rows[0][1].ToString();
            this.Apellidos = anterior.Tables[0].Rows[0][2].ToString();
            this.Nick = anterior.Tables[0].Rows[0][3].ToString();
            this.Pass = anterior.Tables[0].Rows[0][4].ToString();

            this.Fecha = (DateTime) anterior.Tables[0].Rows[0][5];

            this.Localidad = anterior.Tables[0].Rows[0][6].ToString();
            this.Provincia = anterior.Tables[0].Rows[0][7].ToString();
            this.Pais = anterior.Tables[0].Rows[0][8].ToString();

            this.Domicilio = anterior.Tables[0].Rows[0][9].ToString();

            this.Telefono = anterior.Tables[0].Rows[0][10].ToString();
            this.Movil = anterior.Tables[0].Rows[0][11].ToString();
            this.Mail = anterior.Tables[0].Rows[0][12].ToString();

            this.ID = Convert.ToInt16(anterior.Tables[0].Rows[0][13].ToString());
            
            this.EC = anterior.Tables[0].Rows[0][14].ToString();

            //this.Foto = anterior.Tables[0].Rows[0][15];

            this.CP = anterior.Tables[0].Rows[0][16].ToString();

            this.Sexo = Convert.ToInt16(anterior.Tables[0].Rows[0][17].ToString());
        }

        #endregion

        #region Iteraccion con CAD

        // -1 = No se sabe // 0 = todo Ok // 1 = DNI Existente // 2 = Nick Existente // 3 = Nick y DNI existentes
        public int InsertarAdmin()
        {
            cad_admin = new AdminCAD();

            int error = -1;
            bool dni = false;
            bool nick = false;

            try
            {
                
                //Consultamos NICK
                if (cad_admin.CompruebaExistenciaUsuario(this.Nick))
                {
                    error = 2;
                    nick = true;
                }
                // Consultamos DNI
                if (cad_admin.CompruebaExistenciaDNI(this.DNI))
                {
                    error = 1;
                    dni = true;
                }

                //Ambos Existen
                if (dni && nick)
                    error = 3;
                // Insertamos y esperamos que no se produzca un fallo
                else if (!dni && !nick && cad_admin.InsertarAdmin(this))
                    error = 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return error;
        }

        // 0 = todo OK // 1 = DNI existe // 2 = Nick existe // 3 = DNI y Nick Existen // 4 = No se ha insertado // -1 = tira tu a saber
        public int ActualizarAdmin(int id, string dni_c, string nombre_c, string apellidos_c, string pais_c, string provincia_c,
                                   string localidad_c, string domicilio_c, string cp_c, string telefono_c, string movil_c,
                                   string mail_c, string ec_c, Image foto_c, int sexo_c, string nick_c, string pass_c, string pass2_c,
                                   DateTime fecha_c)
        {
            cad_admin = new AdminCAD();

            int error = -1;

            try
            {
                data_admin = cad_admin.getAdmin(id);
                AdminEN admin_anterior = new AdminEN(data_admin);

                // booleanos que se usan para comprobar que campos han sido modificados
                #region Booleanos
                
                bool updateDNI = false;
                bool updateNombre = false;
                bool updateApellido = false;
                bool updatePais = false;
                bool updateProvincia = false;
                bool updateLocalidad = false;
                bool updateDomicilio = false;
                bool updateCP = false;
                bool updateTelefono = false;
                bool updateMovil = false;
                bool updateMail = false;
                bool updateEC = false;
                bool updateFoto = false;
                bool updateSexo = false;
                bool updateNick = false;
                bool updatePass = false;
                bool updateFecha = false;
               
                #endregion

                bool dni = true;
                bool nick = true;
                bool modificado = false;

                // Compara que campos han sido modificados, y en el caso de que sean el DNI o en Nick, comprueba que 
                // no se dupliquen en la BD
                #region IF's Comparativos

                if (admin_anterior.DNI != dni_c)
                {
                    if (!cad_admin.CompruebaExistenciaDNI(dni_c))
                    {
                        dni = true;
                        updateDNI = true;
                        System.Diagnostics.Debug.Write("DNI.");
                        modificado = true;
                    }
                    else
                    {
                        error = 1;
                        dni = false;
                    }
                }

                if (admin_anterior.Nombre != nombre_c)
                {
                    updateNombre = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Nombre");
                }

                if (admin_anterior.Apellidos != apellidos_c)
                {
                    updateApellido = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Apellido");
                }

                if (admin_anterior.Pais != pais_c)
                {
                    updatePais = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Pais");
                }

                if (admin_anterior.Provincia != provincia_c)
                {
                    updateProvincia = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Provincia");
                }

                if (admin_anterior.Localidad != localidad_c)
                {
                    updateLocalidad = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Localidad");
                }

                if (admin_anterior.Domicilio != domicilio_c)
                {
                    updateDomicilio = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Domicilio");
                }

                if (admin_anterior.CP != cp_c)
                {
                    updateCP = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("CP");
                }

                string tel1 = "";

                if (telefono_c[3] == ' ')
                {
                    for (int i = 0; i < telefono_c.Length; i++)
                    {
                        if (telefono_c[i] != ' ')
                            tel1 = tel1 + telefono_c[i];
                    }
                }
                else
                    tel1 = telefono_c;

                if (admin_anterior.Telefono != tel1)
                {
                    updateTelefono = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Telefono");
                }

                tel1 = "";

                if (movil_c[3] == ' ')
                {
                    for (int i = 0; i < movil_c.Length; i++)
                    {
                        if (movil_c[i] != ' ')
                            tel1 = tel1 + movil_c[i];
                    }
                }
                else
                    tel1 = movil_c;

                if (admin_anterior.Movil != tel1)
                {
                    updateMovil = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Movil");
                }

                if (admin_anterior.Mail != mail_c)
                {
                    updateMail = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Mail");
                }

                if (admin_anterior.EC[0] != ec_c[0])
                {
                    updateEC = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("EC");
                }

                if (foto_c != null)
                {
                    updateFoto = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Foto");
                }

                if (admin_anterior.Sexo != sexo_c)
                {
                    updateSexo = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Sexo");
                }

                if (admin_anterior.Nick != nick_c)
                {
                    if (!cad_admin.CompruebaExistenciaUsuario(nick_c))
                    {
                        nick = true;
                        updateNick = true;
                        modificado = true;
                        System.Diagnostics.Debug.Write("Nick");
                    }
                    else
                    {
                        error = 2;
                        nick = false;
                    }
                }

                if (pass_c != "" && pass_c == pass2_c)
                {
                    if (admin_anterior.Pass != pass_c)
                    {
                        updatePass = true;
                        modificado = true;
                        System.Diagnostics.Debug.Write("Pass");
                    }
                }

                if (!admin_anterior.Fecha.Equals(fecha_c))
                {
                    updateFecha = true;
                    modificado = true;
                    System.Diagnostics.Debug.Write("Fecha");
                }
                
                #endregion

                // si dni y nick existen, error = 3
                if (!dni || !nick)
                    error = 3;
                // si no hay ningun error, error = 0
                else if (dni && nick)
                    error = 0;

                // No hay errores, por lo que pasamos a actualizar el EN del admin, y lo almacenamos
                if (error == 0 && modificado)
                {
                    System.Diagnostics.Debug.Write("Entro en Actualizar");
                    if (!cad_admin.ActualizarAdmin(id, dni_c, nombre_c, apellidos_c, pais_c, provincia_c, localidad_c, domicilio_c, cp_c,
                                              telefono_c, movil_c, mail_c, ec_c, foto_c, sexo_c, nick_c, pass_c, fecha_c,
                                              updateDNI, updateNombre, updateApellido, updatePais, updateProvincia, updateLocalidad,
                                              updateDomicilio, updateCP, updateTelefono, updateMovil, updateMail, updateEC,
                                              updateFoto, updateSexo, updateNick, updatePass, updateFecha))
                    {
                        error = 4;
                        return error;
                    }
                    else
                    {
                        System.Diagnostics.Debug.Write("No Entro en Actualizar");
                        return error;
                    }
                }
                else
                {
                    if (!modificado) error = 5;
                    return error;
                }
            }
            catch 
            { }

            return error;
        }

        public int ObtieneID(string usuario)
        {
            cad_admin = new AdminCAD();
            return cad_admin.ObtieneID(usuario);
        }

        public Image ObtieneImagen(int id)
        {
            cad_admin = new AdminCAD();
            return cad_admin.ObtieneImagen(id);
        }

        public DataSet getAdminByNick(string nick)
        {
            cad_admin = new AdminCAD();
            return cad_admin.getAdminByNick(nick);
        }

        public DataSet getAdmins()
        {
            cad_admin = new AdminCAD();
            return cad_admin.getAdmins();
        }

        public DataSet getAdmin(int id)
        {
            cad_admin = new AdminCAD();
            return cad_admin.getAdmin(id);
        }

        public DataSet Busqueda(string quebusco, string loquebusco)
        {
            cad_admin = new AdminCAD();
            return cad_admin.Busqueda(quebusco,loquebusco);
        }

        // 0 = todo ok // 1 = todo vacio, por lo que ok // 2 = no coinciden pass1 y pass2 // 3 = pass_ant erroneo 
        // 4 = pass1 y pass2 ok, pero el nuevo vacio // 5 = 
        public int CompruebaPass(string pass_ant, string pass1, string pass2, int id)
        {
            cad_admin = new AdminCAD();

            // todo vacio, no va a variar
            if (pass1 == "" && pass2 == "" && pass_ant == "")
                return 1;
            // las contraseñas no son iguales
            else if (pass1 != pass2)
                return 2;
            // no coincide la contraseñas anteriores
            else if (!cad_admin.CompruebaPass(pass_ant, id))
                return 3;
            // contraseñas iguales y no coincide la contraseña anterior
            else if (pass1 == pass2 && cad_admin.CompruebaPass(pass_ant, id))
                return 0;
            // contraseñas iguales, pero no esta la anterior
            else if (pass1 == pass2 && pass_ant == "")
                return 4;
            else
                return -1;
        }

        public bool BorraAdmin(int id)
        {
            cad_admin = new AdminCAD();

            if (id != -1)
            {
                return cad_admin.BorraAdmin(id);
            }
            else
            {
                return false;
            }
        }
             
        #endregion

        #region Metodos Variados

        public void CopiaDatos(AdminEN anterior)
        {
            DNI = anterior.DNI;
            Nombre = anterior.Nombre;
            Apellidos = anterior.Apellidos;
            Pais = anterior.Pais;
            Provincia = anterior.Provincia;
            Localidad = anterior.Localidad;
            Domicilio = anterior.Domicilio;
            CP = anterior.CP;
            Telefono = anterior.Telefono;
            Movil = anterior.Movil;
            Mail = anterior.Mail;
            EC = anterior.EC;
            Foto = anterior.Foto;
            Sexo = anterior.Sexo;
            Nick = anterior.Nick;
            Pass = anterior.Pass;
            Fecha = anterior.Fecha;
        }

        public void LimpiaEN()
        {
            ec = dni = nick = pass = nombre = apellidos = pais = provincia = localidad = domicilio = cp = telefono = movil = mail  = string.Empty;
            sexo = -1;
            foto = null;
            Fecha = DateTime.Parse("01/01/2100");
        }

        #endregion

    }
}
