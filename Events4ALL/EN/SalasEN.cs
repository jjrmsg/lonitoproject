using System;
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
        #endregion

        #region set y get
            public int NumSala
            {
                get { return numSala; }
                set { numSala = value; }
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
            public SalasEN(int numSala_c,string tipoSala_c,int numSecciones_c,string descripcion_c)
            {
                numSala = numSala_c;
                tipoSala = tipoSala_c;
                numSecciones = numSecciones_c;
                descripcion = descripcion_c;
            }
        #endregion
    }
}
