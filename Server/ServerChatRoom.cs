using Chat.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Chatprojet.Chat;
using System.IO;
using ChatProjet;

namespace Server
{
    class ServerChatRoom : TCPServer, Chatter   {

        #region field region

        private string pseudo;
        TextChatRoom concretCR;
   
        #endregion

        #region Constructor

        public ServerChatRoom(Chatroom chatroom)
        {
            concretCR = (TextChatRoom)chatroom;
        }

        #endregion

        #region TCPServer methods

        public override void GereClient()
        {
            try
            {
                Message inputMessage;

                while ((inputMessage = GetMessage()) != null)
                {
                    switch (inputMessage.head)
                    {
                        case Header.JOIN:
                            Console.WriteLine("un message JOIN recu");
                            pseudo = inputMessage.data[0];
                            concretCR.Join(new TextChatter(pseudo));
                            break;
                        case Header.POST:
                            Console.WriteLine("un message POST recu");
                            String message = inputMessage.data[1];
                            concretCR.Post(message, (Chatter)this);
                            break;
                        case Header.QUIT:
                            Console.WriteLine("un message QUIT recu");
                            concretCR.Quit((Chatter)this);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        #endregion

        #region Chatter methods

        public string GetAlias()
        {
            return pseudo;
        }

        public void ReceiveAMessage(string msg, Chatter c)
        {
            List<String> data = new List<String>(2);
            data.Add(c.GetAlias());
            data.Add(msg);
            try
            {
                SendMessage(new Message(Header.GET, data));
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public void JoinNotification(Chatter c)
        {
            Console.WriteLine(c.GetAlias() + " join");
        }

        public void QuitNotification(Chatter c)
        {
            Console.WriteLine(c.GetAlias() + " quit");
        }

        #endregion
    }
}
