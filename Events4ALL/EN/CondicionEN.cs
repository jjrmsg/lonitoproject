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
using System.IO;
using System.Drawing.Imaging;

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
        //private int descuento2;
        private int tEvento2;
        private int tCondicion3;
        private int comparacion3;
        private int cantidad3;
        //private int descuento3;
        private int tEvento3;
        private bool activado;
        private Byte[] imagen;
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

        /*public int Descuento2
        {
            get { return descuento2; }
            set { descuento2 = value; }
        }*/

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

        /*public int Descuento3
        {
            get { return descuento3; }
            set { descuento3 = value; }
        }*/

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

        public Byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        #endregion

        #region constructor por defecto
        public CondicionEN()
        {
            conCAD = new CondicionCAD();
        }
        #endregion

        #region constructor sobrecargado con todos los paremetros
        public CondicionEN(int id, string nom, string desc, int tcond1, int comp1, int cant1, int descu1, int teven1, int tcond2, int comp2, int cant2, int teven2, int tcond3, int comp3, int cant3, int teven3, bool act, Byte[] img)
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
            //descuento2 = descu2;
            tEvento2 = teven2;

            tCondicion3 = tcond3;
            comparacion3 = comp3;
            cantidad3 = cant3;
            //descuento3 = descu3;
            tEvento3 = teven3;

            activado = act;

            imagen = img;
        }
        #endregion

        #region constructor sobrecargado sin la imagen
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
            //descuento2 = descu2;
            tEvento2 = teven2;

            tCondicion3 = tcond3;
            comparacion3 = comp3;
            cantidad3 = cant3;
            //descuento3 = descu3;
            tEvento3 = teven3;

            activado = act;

        }
        #endregion

        #region Insertar una fila
        public void InsertarEnDataRow(ref DataRow fila)
        {
            fila[0] = idCondicion;
            fila[1] = nombre;
            fila[2] = descripcion;
            fila[3] = tCondicion1;
            fila[4] = comparacion1;
            fila[5] = cantidad1;
            fila[6] = descuento1;
            fila[7] = tEvento1;
            fila[8] = tCondicion2;
            fila[9] = comparacion2;
            fila[10] = cantidad2;
            //fila[11] = descuento2;
            fila[11] = tEvento2;
            fila[12] = tCondicion3;
            fila[13] = comparacion3;
            fila[14] = cantidad3;
            //fila[16] = descuento3;
            fila[15] = tEvento3;
            fila[16] = activado;
            fila[17] = imagen;
        }
        #endregion

        #region Modificar una fila
        public void ModificarFilaDeDataTable(int id, ref DataTable tabla)
        {
            //tabla.Rows[id][0] = idCondicion;
            tabla.Rows[id][1] = nombre;
            tabla.Rows[id][2] = descripcion;
            tabla.Rows[id][3] = tCondicion1;
            tabla.Rows[id][4] = comparacion1;
            tabla.Rows[id][5] = cantidad1;
            tabla.Rows[id][6] = descuento1;
            tabla.Rows[id][7] = tEvento1;
            tabla.Rows[id][8] = tCondicion2;
            tabla.Rows[id][9] = comparacion2;
            tabla.Rows[id][10] = cantidad2;
            //tabla.Rows[id][11] = descuento2;
            tabla.Rows[id][11] = tEvento2;
            tabla.Rows[id][12] = tCondicion3;
            tabla.Rows[id][13] = comparacion3;
            tabla.Rows[id][14] = cantidad3;
            //tabla.Rows[id][16] = descuento3;
            tabla.Rows[id][15] = tEvento3;
            tabla.Rows[id][16] = activado;
            tabla.Rows[id][17] = imagen;
        }
        #endregion

        public DataSet ObtenerTodas()
        {
            return conCAD.ObtenerTodas();
        }

        public void Save()
        {
            conCAD.Save();
        }

        public void InsertarCondicionConCliente(string idCliente, int idCondicion)
        {
            conCAD.InsertarCondicionConCliente(idCliente, idCondicion);
        }

        public DataSet NumeroDeEventosAsistidosClientePorTipo(string nif, string tipoevento)
        {
            return conCAD.NumeroDeEventosAsistidosClientePorTipo(nif, tipoevento);
        }

        public DataSet ObtenerCondicionesConClientes()
        {
            return conCAD.ObtenerCondicionesConClientes();
        }

        public void SaveCondicionesConClientes()
        {
            conCAD.SaveCondicionesConClientes();
        }
    }
}
