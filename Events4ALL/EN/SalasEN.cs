using System;
using Events4ALL.CAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events4ALL.EN
{
    class SalasEN
    {
        #region variables
            private int numSala;
            private string tipoSala;
            private int numSecciones;
            private string descripcion;
            private int aforo;
            private int estadoSala;
            private int[][] secciones;
        #endregion

        #region set y get
            public int NumSala
            {
                get { return numSala; }
                set { numSala = value; }
            }
            public int[][] Secciones
            {
                get { return secciones; }
                set { secciones = value; }
            }
            public int EstadoSala
            {
                get { return estadoSala; }
                set { estadoSala = value; }
            }
            public int Aforo
            {
                get { return aforo; }
                set {aforo=value;}
            }
            public int NumSecciones
            {
                get { return numSecciones; }
                set { numSecciones = value; }
            }
            public string TipoSala
            {
                get { return tipoSala; }
                set { tipoSala = value; }
            }
            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }
        #endregion

        #region constructor
            public SalasEN(int numSala_c,string tipoSala_c,int numSecciones_c,string descripcion_c,int aforo_c,int[][] secciones_c)
            {
                numSala = numSala_c;
                tipoSala = tipoSala_c;
                numSecciones = numSecciones_c;
                descripcion = descripcion_c;
                aforo = aforo_c;
                estadoSala = 1; //1 quiere decir que la sala esta dada de alta/disponible
                secciones = secciones_c;
            }
        #endregion
    }
}
