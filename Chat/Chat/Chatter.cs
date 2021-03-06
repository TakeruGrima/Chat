﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chatprojet.Chat
{
    public interface Chatter
    {
        //méthode recevoir un message
        void ReceiveAMessage(string msg,Chatter c);

        //méthode pour obtenir le nom d'utilisateur du Chatter
        string GetAlias();

        //méthode pour afficher une notification qu'un chatter est arrivé
        void JoinNotification(Chatter c);

        //méthode pour afficher une notification qu'un chatter est parti
        void QuitNotification(Chatter c);
    }
}
