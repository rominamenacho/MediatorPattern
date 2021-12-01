using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
   public abstract class Chat
    {
        protected List<Mensaje> _mensajes;

        protected Chat()
        {
            _mensajes = new List<Mensaje>();
        }
        public Mensaje [] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }
        public abstract void Registrar(Usuario u);
        public abstract void Enviar(string msj, Usuario para, Usuario de);
    }
}
