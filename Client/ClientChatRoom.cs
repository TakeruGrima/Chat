using Chat.Net;
using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

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

        public List<Message> Messages
        {
            get
            {
                return messages;
            }
        }


        public string Topic
        {
            get { return topic; }
            set { topic = value; }
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

                new Thread(new ThreadStart(Run)).Start();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Post(string msg, Chatter c)
        {
            Message message = new Message(Header.POST);
            message.Add(c.GetAlias());
            message.Add(msg);
            try
            {
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
            try
            {
                Message message;
                while ((message = GetMessage()) != null)
                {
                    switch (message.head)
                    {
                        case Header.JOINED:
                            pseudos.Add(message.data[0]);
                            messages.Add(message);

                            if (user != null)
                            {
                                user.JoinNotification(new TextChatter(message.data[0]));
                            }
                            break;

                        case Header.GET:
                            messages.Add(message);
                            if (user != null)
                            {
                                user.ReceiveAMessage(message.data[1], new TextChatter(message.data[0]));
                            }
                            break;
                        case Header.LEFT:
                            messages.Add(message);
                            if (user != null && !pseudos.Contains(message.data[0]))
                            {
                                user.QuitNotification(new TextChatter(message.data[0]));
                            }
                            pseudos.Remove(message.data[0]);
                            break;
                    }
                }
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
