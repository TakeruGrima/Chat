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
    public class ClientTopicsManager : TCPClient, TopicsManager
    {
        #region TopicsManager methods

        public List<string> ListTopics()
        {
            Message message = new Message(Header.LIST_TOPIC);
            List<String> topics = null;
            try
            {
                SendMessage(message);
         
                Message answer = GetMessage();
                topics = answer.data;
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
                SendMessage(message);

                Message answer = GetMessage();

                int port;
                Int32.TryParse(answer.data[0],out port);

                ClientChatRoom chatroom = new ClientChatRoom();
                chatroom.SetServer(Adr, port);
                chatroom.Connect();

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

        //return true if the login successed
        public bool Login(string login, string password,ref string messageError)
        {
            try
            {
                List<string> loginstring = new List<string> { login, password };

                Message m = new Message(Header.CONNECT, loginstring);
                SendMessage(m);

                Message answer = GetMessage();

                if (answer.head == Header.ISUNCONNECTED)
                {
                    Console.WriteLine("Password or Login is incorrect");
                    messageError = "incorrect";
                    return false;
                }
                else if(answer.head == Header.ALREADYCONNECTED)
                {
                    Console.WriteLine("This user is already connected");
                    messageError = "alreadyConnect";
                    return false;
                }
                else if(answer.head == Header.ISCONNECTED)
                {
                    return true;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public bool Register(string login, string password)
        {
            try
            {
                List<string> loginstring = new List<string> { login, password };

                Message m = new Message(Header.REGISTER, loginstring);
                SendMessage(m);

                Message answer = GetMessage();

                if (answer.head == Header.ALREADYEXIST)
                {
                    Console.WriteLine("This user already exist!");
                    return false;
                }
                else if (answer.head == Header.REGISTERED)
                {
                    Console.WriteLine("REGISTERED!");
                    return true;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public void ChatterDisconnect(Chatter c)
        {
            Message message = new Message(Header.DISCONNECT,c.GetAlias());
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
    }
}
