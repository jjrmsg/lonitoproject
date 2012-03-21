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
        #endregion

        public EspectaculosEN()
        {
            espCAD = new EspectaculosCAD();
        }

        public decimal getPrecioId(int id)
        {
            return espCAD.getPrecioId(id);
        }
    }
}
