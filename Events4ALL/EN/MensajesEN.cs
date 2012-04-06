using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using System.Data;

namespace Events4ALL.EN
{
    public class MensajesEN
    {
        MensajesCAD msgCAD;

        public MensajesEN()
        {
            msgCAD = new MensajesCAD();
        }

        public DataSet getMessages()
        {
            return msgCAD.getMessages();
        }

        public DataSet getMessageByID(string id)
        {
            return msgCAD.getMessageByID(id);
        }

        public void setResponse(string ID)
        {
            msgCAD.setResponse(ID);
        }
    }
}
