using Chat.Net;
using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientChatRoom : TCPClient,Chatroom
    {
        #region field region

        private Chatter user;
        private string topic;

        private List<Message> messages = new List<Message>();
        private List<String> pseudos = new List<String>();

        #endregion

        #region Property

        public Chatter User
        {
            get
            {
                return user;
            }
        }

        #endregion

        #region ChatRoom methods

        public string getTopic()
        {
            Message message;
            String topic = "";
            try
            {
                message = GetMessage();
                topic = message.data[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return topic;
        }

        public void Join(Chatter c)
        {
            try
            {
                Message m = new Message(Header.JOIN,c.GetAlias());
                SendMessage(m);
                user = c;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Post(string msg, Chatter c)
        {
            //Console.WriteLine("nous envoyons un message");
            Message message = new Message(Header.POST);
            message.Add(c.GetAlias());
            message.Add(msg);
            try
            {
                //Console.WriteLine("message en cours d'envoi");
                SendMessage(message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Quit(Chatter c)
        {
            try
            {
                SendMessage(new Message(Header.QUIT, c.GetAlias()));
                this.Disconnect();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion

        #region methods

        public void Run()
        {
            Console.WriteLine("?????");
            try
            {
                Message message;
                while ((message = GetMessage()) != null)
                {
                    switch (message.head)
                    {
                        case Header.JOINED:
                            pseudos.Add(message.data[0]);
                            if (user != null)
                            {
                                user.JoinNotification(new TextChatter(message.data[0]));
                                Console.WriteLine("huh");
                            }
                            Console.WriteLine(pseudos);
                            break;
                        case Header.GET:
                            messages.Add(message);
                            if (user != null)
                            {
                                user.ReceiveAMessage(message.data[1], new TextChatter(message.data[0]));
                            }
                            Console.WriteLine("get message" + messages);
                            break;
                        case Header.LEFT:
                            pseudos.Remove(message.data[0]);
                            if (user != null)
                            {
                                user.QuitNotification(new TextChatter(message.data[0]));
                            }
                            Console.WriteLine(pseudos);
                            break;
                    }
                }
                Console.WriteLine("End of while");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion
    }
}
