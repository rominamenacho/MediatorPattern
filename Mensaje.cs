using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
   public class Mensaje
    {
        private string texto;
        private DateTime fecha;
        private Usuario de;
        private Usuario para;
        public Mensaje()
        {
            fecha = DateTime.Now;
        }

        public string Texto { get => texto; set => texto = value; }
        public DateTime Fecha { get => fecha; }
        public Usuario Para { get => para; set => para = value; }
        public Usuario De { get => de; set => de = value; }

        public override string ToString()
        {
            return $"Mensaje a las {Fecha.ToShortTimeString()} de {De} para {Para} --> {Texto}";
        }

    }
}
