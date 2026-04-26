using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

using QuizGame.ModelosSocket;

namespace QuizGame
{
    public static class ConexionGlobal
    {
        public static ClienteSocket Cliente = new ClienteSocket();

    }
}