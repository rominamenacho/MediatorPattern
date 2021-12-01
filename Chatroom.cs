using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Chatroom : Chat
    {
        IDictionary<string, Usuario> _participantes;

        public Chatroom()
        {
            _participantes = new Dictionary<string, Usuario>();
        }

        public override void Enviar(string _msj, Usuario _para, Usuario _de)
        {
            Mensaje msj= new Mensaje();
            msj.De = _de;
            msj.Para = _para;
            msj.Texto = _msj;

            if (_participantes.ContainsKey(_para.Nombre))
            {
                _participantes[_para.Nombre].Recibir(msj);
                _mensajes.Add(msj);
            }

        }

        public override void Registrar(Usuario u)
        {
            if (!_participantes.ContainsKey(u.Nombre))
            {
                _participantes.Add(u.Nombre, u);
            }
        }
    }
}
