using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Events4ALL.Auxiliares
{
    public class Validaciones
    {
        public Validaciones() 
        { }

        #region Valida NIF

        // Comprueba que el DNI sea correcto
        public bool CompruebaNIF(string nif)
        {
            bool error = false;

            // el NIF debe de tener un tamaño igual a 9
            if( nif.Length == 9 )
            {
                // extraigo el numero del NIF introducido.
                Int32 numeros = DevuelveNumero(nif);

                // si hay una letra en medio del NIF, devuelve 0
                if (numeros != 0)
                {
                    // extraigo la letra del NIF introducido.
                    char letra = DevuelveLetra(nif);

                    // obtengo la letra a partir del numero introducido.
                    // si la letra introducida es igual a la letra generada, esta bien.
                    if (letra == ObtieneLetra(numeros))
                        error = true;
                }
            }
            else
                error = false;
            
            return error;
        }

        // Devuelve los numeros del DNI
        public Int32 DevuelveNumero(string nif)
        {
            Int32 numero = 0;

            Int32.TryParse(nif.Substring(0, 8), out numero);

            return numero;
        }

        // devuelve la letra del DNI
        public char DevuelveLetra(string nif)
        {
            return nif[8];
        }

        // obtiene la letra del numero en base al dni
        public char ObtieneLetra(Int32 numero)
        {
            Int32 indice = numero % 23;
            return "TRWAGMYFPDXBNJZSQVHLCKET"[indice];
        }

        #endregion

        public bool CompruebaTexto(string texto)
        {
            Regex recp = new Regex("^[a-zA-Z_]$");

            return recp.IsMatch(texto);
        }
    
        // Comprueba que el codigo postal tenga 6 digitos
        public bool CompruebaCP(string cp)
        {
            // definicion de la expresion regular
            Regex recp = new Regex("^[0-9]{5}$");

            return recp.IsMatch(cp);
        }

        // Comprueba algunos campos basicos de un correo electronico
        public bool CompruebaMail(string mail)
        {
            Regex ermail = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

            return ermail.IsMatch(mail);
        }

        // comprueba que el telefono introducido sea 000 000000 o 000000000
        public bool CompruebaTelefono(string tel)
        {
            Regex ertel = new Regex("[0-9]{2,3}-? ?[0-9]{6,7}$");

            return ertel.IsMatch(tel);
        }

        // Comprueba que sea un numero
        public static bool EsNumeroEntero(String cadena)
        {
            Regex patronNumerico = new Regex("^[0-9]+$");
            return patronNumerico.IsMatch(cadena);
        }

        // Comprueba una seguridad minima en el Password
        public string CompruebaPass(string pass)
        {
            // longitud 6, me da igual que no tenga numero o si xD
            Regex ex1 = new Regex("^[0-9a-zA-Z]{6,15}$"); // longitud
            Regex ex2 = new Regex("[0-9]+"); // un numero
            Regex ex3 = new Regex("[a-z]+"); // una letra minuscula
            Regex ex4 = new Regex("[A-Z]+"); // una letra mayuscula

            string error = "Fallo Desconocido.";

            if (ex1.IsMatch(pass) && ex2.IsMatch(pass) && ex3.IsMatch(pass) && ex4.IsMatch(pass))
            {
                error = "";
                return error;
            }
            else
            {
                error = "Error : ";

                if (!ex1.IsMatch(pass))
                    error = error + "Longitud erronea, debe ser entre 6 y 15 caracteres. ";
                if (!ex2.IsMatch(pass))
                    error = error + "La contraseña no contiene un número. ";
                if (!ex3.IsMatch(pass))
                    error = error + "La contraseña no contiene una letra minúscula. ";
                if (!ex4.IsMatch(pass))
                    error = error + "La contraseña no contiene una letra mayúscula.";

                return error;
            }
        }
    }
}
