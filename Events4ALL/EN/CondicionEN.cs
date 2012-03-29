using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using Events4ALL.Auxiliares;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Events4ALL.EN
{
    class CondicionEN
    {
        #region variables
        /*
            Dinero gastado - 1
            Entradas - 2
            Espectaculos - 3

            Mayor - 1
            Menor - 2
            Igual - 3

            Cine - 1
            Teatro - 2
            Concierto - 3
            Todos - 4
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
        private bool activado;
        CondicionCAD conCAD;
        #endregion

        #region gets/sets
        public int IdCondicion
        {
            get { return idCondicion; }
            set { idCondicion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descipcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int TCondicion1
        {
            get { return tCondicion1; }
            set { tCondicion1 = value; }
        }

        public int Comparacion1
        {
            get { return comparacion1; }
            set { comparacion1 = value; }
        }

        public int Cantidad1
        {
            get { return cantidad1; }
            set { cantidad1 = value; }
        }

        public int Descuento1
        {
            get { return descuento1; }
            set { descuento1 = value; }
        }

        public int TEvento1
        {
            get { return tEvento1; }
            set { tEvento1 = value; }
        }

        public int TCondicion2
        {
            get { return tCondicion2; }
            set { tCondicion2 = value; }
        }

        public int Comparacion2
        {
            get { return comparacion2; }
            set { comparacion2 = value; }
        }

        public int Cantidad2
        {
            get { return cantidad2; }
            set { cantidad2 = value; }
        }

        public int Descuento2
        {
            get { return descuento2; }
            set { descuento2 = value; }
        }

        public int TEvento2
        {
            get { return tEvento2; }
            set { tEvento2 = value; }
        }

        public int TCondicion3
        {
            get { return tCondicion3; }
            set { tCondicion3 = value; }
        }

        public int Comparacion3
        {
            get { return comparacion3; }
            set { comparacion3 = value; }
        }

        public int Cantidad3
        {
            get { return cantidad3; }
            set { cantidad3 = value; }
        }

        public int Descuento3
        {
            get { return descuento3; }
            set { descuento3 = value; }
        }

        public int TEvento3
        {
            get { return tEvento3; }
            set { tEvento3 = value; }
        }

        public bool Activado
        {
            get { return activado; }
            set { activado = value; }
        }
        #endregion

        #region constructor por defecto
        public CondicionEN()
        {
            conCAD = new CondicionCAD();
        }
        #endregion

        #region constructor sobrecargador
        public CondicionEN(int id, string nom, string desc, int tcond1, int comp1, int cant1, int descu1, int teven1, int tcond2, int comp2, int cant2, int descu2, int teven2, int tcond3, int comp3, int cant3, int descu3, int teven3, bool act)
        {
            idCondicion = id;
            nombre = nom;
            descripcion = desc;
            
            tCondicion1 = tcond1;
            comparacion1 = comp1;
            cantidad1 = cant1;
            descuento1 = descu1;
            tEvento1 = teven1;

            tCondicion2 = tcond2;
            comparacion2 = comp2;
            cantidad2 = cant2;
            descuento2 = descu2;
            tEvento2 = teven2;

            tCondicion3 = tcond3;
            comparacion3 = comp3;
            cantidad3 = cant3;
            descuento3 = descu3;
            tEvento3 = teven3;

            activado = act;
        }
        #endregion
        
        public DataSet ObtenerTodas()
        {
            /*DataTable dsPromo;
            dsPromo = conCAD.ObtenerTodas();
            return dsPromo;*/
            return conCAD.ObtenerTodas();
        }

        public void Save()
        {
            conCAD.Save();
        }
    }
}
