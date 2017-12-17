using Chat.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Chatprojet.Chat;
using Chat.Authentification;
using System.IO;

//Created by Timothée LE CORRE and Camille Melo

namespace Server
{
    class ServerTopicsManager : TCPServer
    {
        #region field region

        AuthentificationManager am;
        private TCPTopicsManager tcpTopicsManager = new TCPTopicsManager();

        private List<string> connectedPseudos;// indique les personnes connecté

        #endregion

        public ServerTopicsManager(AuthentificationManager am)
        {
            this.am = am;

            connectedPseudos = new List<string>();
        }

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
                        case Header.LIST_TOPIC:
                            List<String> topics = tcpTopicsManager.ListTopics();

                            Message mListTopic = new Message(Header.LIST_TOPIC, topics);
                            SendMessage(mListTopic);
                            break;

                        case Header.CREATE_TOPIC:
                            tcpTopicsManager.CreateTopic(inputMessage.data[0]);
                            tcpTopicsManager.Save("Topics.txt");

                            Message mCreateTopic = new Message(Header.TOPIC_IS_CREATE);
                            SendMessage(mCreateTopic);
                            break;

                        case Header.JOIN_TOPIC:
                            String topicToJoin = inputMessage.data[0];

                            Message outputMessage3 = new Message(Header.JOIN_TOPIC,
                                tcpTopicsManager.getTopicPort(topicToJoin).ToString());
                            SendMessage(outputMessage3);
                            break;


                        case Header.CONNECT:
                            try
                            {
                                string pseudo = inputMessage.data[0];
                                if (!connectedPseudos.Contains(pseudo))
                                {
                                    am.Authentify(inputMessage.data[0], inputMessage.data[1]);

                                    connectedPseudos.Add(inputMessage.data[0]);
                                    Message mConnect = new Message(Header.ISCONNECTED);
                                    SendMessage(mConnect);
                                }


                                else
                                {
                                    Message alreadyConnect = new Message(Header.ALREADYCONNECTED);
                                    Console.WriteLine("this user is already connected!");
                                }
                            }


                            catch (WrongPasswordException e)
                            {
                                Console.WriteLine(e + " : password or login is incorrect!");

                                Message mUnConnect = new Message(Header.ISUNCONNECTED);
                                SendMessage(mUnConnect);
                            }
                            break;


                        case Header.REGISTER:
                            try
                            {
                                am.AddUser(inputMessage.data[0], inputMessage.data[1]);

                                Message mRegister = new Message(Header.REGISTERED);
                                SendMessage(mRegister);

                                // persistance
                                try
                                {
                                    am.Save("users.txt");
                                }
                                catch (IOException e)
                                {
                                    Console.WriteLine(e);
                                }
                            }


                            catch (UserExistsException e)
                            {
                                Console.WriteLine(e.Login + " has already been added !");

                                Message mErrorExist = new Message(Header.ALREADYEXIST);
                                SendMessage(mErrorExist);
                            }
                            break;
                        case Header.DISCONNECT:
                            String chatterName = inputMessage.data[0];

                            connectedPseudos.Remove(chatterName);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion     
    }
}
