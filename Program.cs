using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat _chat= new Chatroom();
            Usuario u1= new Usuario1("user 1");
            Usuario u2= new Usuario2("user 2");

            _chat.Registrar(u1);
            _chat.Registrar(u2);

            _chat.Enviar("Hola usuario 2: ", u2, u1);
            _chat.Enviar("Hola usuario 1: ", u1, u2);

            Console.WriteLine("Sala de chat");
            MostrarMensajes();
            Console.WriteLine("mensajes del usuario 1");
            MostrarMensajesU1();
            Console.WriteLine("mensajes del usuario 2");
            MostrarMensajesU2();



            Console.ReadKey();

             void MostrarMensajes() {
                foreach (var i in _chat.Mensajes)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            void MostrarMensajesU1()
            {
                foreach (var i in u1.Mensajes)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            void MostrarMensajesU2()
            {
                foreach (var i in u2.Mensajes)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

       
    }
}
