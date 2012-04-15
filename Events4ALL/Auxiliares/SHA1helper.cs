using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Events4ALL.Auxiliares
{
    public static class SHA1helper
    {
        /// <summary>
        ///     Calcula una cadena SHA1 a partir de una cadena de entrada
        /// </summary>
        public static string Compute(string strSource)
        {
            byte[] arrBytTarget;
            SHA1 objSHA1 = new SHA1CryptoServiceProvider();

            // Codifica la cadena
            arrBytTarget = objSHA1.ComputeHash(ASCIIEncoding.Default.GetBytes(strSource));
            // Convierte los bytes codificados en una cadena legible
            return BitConverter.ToString(arrBytTarget).Replace("-", "");
        }
    }
}
