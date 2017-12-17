using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chatprojet.Chat
{
    public class TextChatRoom : Chatroom
    {
        //Propriétés
        private string _topic; 
        public string Topic { get { return _topic; } set { _topic = value; } }//string contenant le topic de la chatroom

        //Attibuts
        List<Chatter> Chatters;//List contenant les chatters de la chatroom

        //Constructeur
        public TextChatRoom()
        {
            Chatters = new List<Chatter>();
        }

        //Récuperer le Topic de la chatroom
        public string getTopic()
        {
            return Topic;
        }

        //Rejoindre la chatroom
        public void Join(Chatter c)
        {
            Chatters.Add(c);
            foreach(Chatter chatter in Chatters)
            {
                chatter.JoinNotification(c);
            }
        }

        //Post un message
        public void Post(string msg, Chatter c)
        {
            if(Chatters.Count>0)
            {
                foreach (Chatter chatter in Chatters)
                {
                    Console.Write("(At " + chatter.GetAlias() + ") : ");
                    chatter.ReceiveAMessage(msg, c);
                }
            }
        }

        //Quitter la chatroom
        public void Quit(Chatter c)
        {
            if (Chatters.Count > 0)
            {
                foreach (Chatter chatter in Chatters)
                {
                    chatter.QuitNotification(c);
                }
            }
            Console.WriteLine("(Message from Chatroom : " + Topic + ")" + c.GetAlias() + "has left the room.");
            Chatters.Remove(c);
        }
    }
}
