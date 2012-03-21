using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events4ALL.EN
{
    class CondicionEN
    {
        #region variables
        /*
            Dinero gastado - 0
            Entradas - 1
            Espectaculos - 2

            Mayor - 0
            Menor - 1
            Igual - 2

            Cine - 0
            Teatro - 1
            Concierto - 2
            Todos - 3
        */
        private int idCondicion;
        private string nombre;
        private string descripcion;
        private int tCondicion1;
        private int comparacion1;
        private int cantidad1;
        private int descuento1;
        private int tEvento1;
        private int tCondicion2;
        private int comparacion2;
        private int cantidad2;
        private int descuento2;
        private int tEvento2;
        private int tCondicion3;
        private int comparacion3;
        private int cantidad3;
        private int descuento3;
        private int tEvento3;
        #endregion

        #region gets/sets
        private int IdPromocion
        {
            get { return idCondicion; }
            set { idCondicion = value; }
        }

        private string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string Descipcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int TCondicion1
        {
            get { return tCondicion1; }
            set { tCondicion1 = value; }
        }

        private int Comparacion1
        {
            get { return comparacion1; }
            set { comparacion1 = value; }
        }

        private int Cantidad1
        {
            get { return cantidad1; }
            set { cantidad1 = value; }
        }

        private int Descuento1
        {
            get { return descuento1; }
            set { descuento1 = value; }
        }

        private int TEvento1
        {
            get { return tEvento1; }
            set { tEvento1 = value; }
        }

        private int TCondicion2
        {
            get { return tCondicion2; }
            set { tCondicion2 = value; }
        }

        private int Comparacion2
        {
            get { return comparacion2; }
            set { comparacion2 = value; }
        }

        private int Cantidad2
        {
            get { return cantidad2; }
            set { cantidad2 = value; }
        }

        private int Descuento2
        {
            get { return descuento2; }
            set { descuento2 = value; }
        }

        private int TEvento2
        {
            get { return tEvento2; }
            set { tEvento2 = value; }
        }

        private int TCondicion3
        {
            get { return tCondicion3; }
            set { tCondicion3 = value; }
        }

        private int Comparacion3
        {
            get { return comparacion3; }
            set { comparacion3 = value; }
        }

        private int Cantidad3
        {
            get { return cantidad3; }
            set { cantidad3 = value; }
        }

        private int Descuento3
        {
            get { return descuento3; }
            set { descuento3 = value; }
        }

        private int TEvento3
        {
            get { return tEvento3; }
            set { tEvento3 = value; }
        }
        #endregion
    }
}
