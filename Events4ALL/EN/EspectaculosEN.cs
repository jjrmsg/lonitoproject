using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;

namespace Events4ALL.EN
{
    public class EspectaculosEN
    {
        #region members
        private EspectaculosCAD espCAD;
        public int idEspectaculo { get; set; }
        #endregion

        public EspectaculosEN()
        {
            espCAD = new EspectaculosCAD();
        }

        public decimal getPrecioId()
        {
            return espCAD.getPrecioId(idEspectaculo);
        }
    }
}
