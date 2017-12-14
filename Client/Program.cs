using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AuthentificationClient authentificationClient = new AuthentificationClient();
            authentificationClient.SetServer("127.0.0.1", 26763);
            authentificationClient.Connect();

            Console.WriteLine("CONNEXION?");

            authentificationClient.Login("bob", "123");
//            authentificationClient.Disconnect();

            ClientChatRoom client = new ClientChatRoom();
            client.SetServer("127.0.0.1", 26763);
            client.Connect();

            Console.WriteLine("Create user, type your name");

            string name = Console.ReadLine();
            Chatter c = new TextChatter(name);
            //Chatter camille = new TextChatter("Camille");
            client.Join(c);

            string quit = "no";
            while(quit=="no")
            {
                string msg = Console.ReadLine();

                if (msg == "yes")
                    quit = msg;
                client.Post(msg, c);
            }


            Console.WriteLine("YOLOOOOOOOOOOOOOOO");*/

            ClientTopicsManager ctm = new ClientTopicsManager();
            ctm.SetServer("127.0.0.1", 26763);
            ctm.Connect();
            ctm.Login("bob", "123");
            ctm.CreateTopic("Jeux Vidéo");
            ctm.ListTopics();

            Console.WriteLine("EUH TEST");
            ClientChatRoom clientChatRoom = (ClientChatRoom)ctm.JoinTopic("Jeux Vidéo");
            Console.WriteLine("TEST");
            TextChatter bob = new TextChatter("bob");
            clientChatRoom.Join(bob);
            clientChatRoom.Post("BONSOIR", bob);

            Console.Read();
        }
    }
}
