using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatProjet;
using Chatprojet.Chat;
using Chat.Authentification;
using System.IO;

//Created by Timothée LE CORRE and Camille Melo

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

            ServerTopicsManager stm = new ServerTopicsManager(am);
            stm.StartServer(26763);
          
        }
    }
}
