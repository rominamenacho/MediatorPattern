using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
   public abstract class Usuario
    {
        protected string nombre;
       protected List<Mensaje> _mesajes;
        public string Nombre { get => nombre;  }
        public Chat Chat { get; set; }


        public Usuario(string _nombre)
        {
            nombre = _nombre;
            _mesajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mesajes.ToArray();
            }
        }

        public  void Enviar(string msj, Usuario destinatario)
        {
            Chat.Enviar(msj, destinatario, this);
        }
        public  void Recibir(Mensaje msj) {
            _mesajes.Add(msj);
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
