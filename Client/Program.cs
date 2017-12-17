using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientTopicsManager ctm = new ClientTopicsManager();
            ctm.SetServer("127.0.0.1", 26763);
            ctm.Connect();
            Console.WriteLine("Create user, Connect with a name and password");

            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string error = "";
            if(ctm.Login(name,password,ref error))
            {
                List<string> topics = ctm.ListTopics();

                if (!topics.Contains("Jeux Vidéo"))
                {
                    ctm.CreateTopic("Jeux Vidéo");
                }


                ClientChatRoom clientChatRoom = (ClientChatRoom)ctm.JoinTopic("Jeux Vidéo");
                TextChatter c = new TextChatter(name);
                clientChatRoom.Join(c);
                string quit = "no";
                while (quit == "no")
                {
                    string msg = Console.ReadLine();

                    if (msg == "yes")
                        quit = msg;
                    clientChatRoom.Post(msg, c);
                }
                clientChatRoom.Disconnect();
                ctm.Disconnect();
            }
            

            Console.Read();
        }
    }
}
