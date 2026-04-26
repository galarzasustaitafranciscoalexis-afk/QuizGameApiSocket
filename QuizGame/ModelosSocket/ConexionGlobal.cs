using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using QuizGame.ServicioSocket;

namespace QuizGame
{
    internal class ConexionGlobal
    {
        public static ClienteSocket Cliente { get; set; } = new ClienteSocket();
    }
}
