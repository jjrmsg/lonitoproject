using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;

namespace Entities
{
    public class MensajesEN
    {
        MensajesCAD msgCAD;

        public MensajesEN()
        {
            msgCAD = new MensajesCAD();
        }

        //Obtiene todos los mensajes
        public DataSet getMessages()
        {
            return msgCAD.getMessages();
        }

        //Obtiene un mensaje en concreto en función de su ID
        public DataSet getMessageByID(string id, bool anon)
        {
            return msgCAD.getMessageByID(id, anon);
        }

        //Marca un mensaje como leido
        public void setResponse(string ID)
        {
            msgCAD.setResponse(ID);
        }

        //Elimina un mensaje
        public void deleteMessage(string ID)
        {
            msgCAD.deleteMessage(ID);
        }

        //Obtiene el número de mensajes sin leer
        public int getNumMessages()
        {
            return msgCAD.getNumMessages();
        }

        public void insertMessageEn(string nick,string mail,string asunto,string contenido)
        {
            msgCAD.insertMessage(nick,mail,asunto,contenido);
        }
    }
}
