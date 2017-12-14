using Chat.Net;
using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public class ClientTopicsManager : TCPClient, TopicsManager
    {
        #region TopicsManager methods

        public List<string> ListTopics()
        {
            Message message = new Message(Header.LIST_TOPIC);
            List<String> topics = null;
            try
            {
                //Console.WriteLine("nous envoyons un message");
                SendMessage(message);
                //Console.WriteLine("message envoyé, nous attendons une réponse");
                Message answer = GetMessage();
                topics = answer.data;
                Console.WriteLine("liste des topic" + topics);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return topics;
        }

        public Chatroom JoinTopic(string topic)
        {
            Message message = new Message(Header.JOIN_TOPIC, topic);
            try
            {
                Console.WriteLine("test");
                SendMessage(message);
                Console.WriteLine(message.data[0]);
                Message answer = GetMessage();

                Console.WriteLine("test3");
                int port;
                Int32.TryParse(answer.data[0],out port);

                ClientChatRoom chatroom = new ClientChatRoom();
                Console.WriteLine(port);
                chatroom.SetServer(Adr, port);
                chatroom.Connect();
                Thread thread = new Thread(chatroom.Run);
                thread.Start();
                return chatroom;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public void CreateTopic(string topic)
        {
            Message message = new Message(Header.CREATE_TOPIC, topic);
            try
            {
                SendMessage(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion

        #region methods

        public void Login(string login, string password)
        {
            try
            {
                List<string> loginstring = new List<string> { login, password };

                Message m = new Message(Header.CONNECT, loginstring);
                SendMessage(m);
                //user = c;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Register(string login, string password)
        {
            try
            {
                List<string> loginstring = new List<string> { login, password };

                Message m = new Message(Header.REGISTER, loginstring);
                SendMessage(m);
                //user = c;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion
    }
}
