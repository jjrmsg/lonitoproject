using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events4ALL.EN
{
    class AdminEN
    {
        #region Variables

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
        private int ec; // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
        private string foto;
        private int sexo; // 0 - hombre // 1 - Mujer

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

        public int EC
        {
            get { return ec; }
            set { ec = value; }
        }

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        #endregion

        #region Constructores

        public AdminEN(int id_c, string dni_c, string nombre_c, string apellidos_c, string pais_c, string provincia_c,
                        string localidad_c, string domicilio_c, string cp_c, string telefono_c, string movil_c,
                        string mail_c,  int ec_c, string foto_c, int sexo_c)
        {
            id = id_c;
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
        }

        // um, no le veo utilidad,asi que ni me molesto XD
        /*public AdminEN()
        { 
        
        }*/

        #endregion
    }
}
