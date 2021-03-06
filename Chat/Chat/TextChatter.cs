﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chatprojet.Chat
{
    public class TextChatter : Chatter
    {
        string Alias;//le nom d'utilisateur du Chatter

        //Constructeur
        public TextChatter(string alias)
        {
            Alias = alias;
        }

        //méthode pour obtenir le nom d'utilisateur du Chatter
        public string GetAlias()
        {
            return Alias;
        }

        //méthode recevoir un message
        public void ReceiveAMessage(string msg, Chatter c)
        {
            //Console.WriteLine("(At " + Alias + ") : " + c.GetAlias() + " $> " + msg);
            Console.Write(c.GetAlias() + " $> " + msg+"\n");
        }

        public void JoinNotification(Chatter c)
        {
            Console.WriteLine(c.GetAlias() + " has join the room");
        }

        public void QuitNotification(Chatter c)
        {
            Console.WriteLine(c.GetAlias() + " has quit the room");
        }
    }
}
