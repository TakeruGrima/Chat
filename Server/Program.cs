using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatProjet;
using Chatprojet.Chat;
using Chat.Authentification;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthentificationManager am = new Authentification();

            // persistance
            try
            {
                am.Load("users.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            /*AuthentificationServer authentificationServer = new AuthentificationServer(am);

            authentificationServer.StartServer(26763);

            authentificationServer.Run();
            TextChatRoom chatRoom = new TextChatRoom();
            ServerChatRoom server = new ServerChatRoom(chatRoom);
            server.StartServer(26763);

            server.Run();*/

            ServerTopicsManager stm = new ServerTopicsManager(am);
            stm.StartServer(26763);
            stm.Run();
        }
    }
}
