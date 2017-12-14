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

namespace Server
{
    class ServerTopicsManager : TCPServer
    {
        #region field region

        AuthentificationManager am;
        private TCPTopicsManager tcpTopicsManager = new TCPTopicsManager();

        #endregion

        public ServerTopicsManager(AuthentificationManager am)
        {
            this.am = am;
        }

        #region TCPServer methods

        public override void GereClient()
        {
            try
            {
                Message inputMessage;
                while ((inputMessage = GetMessage()) != null)
                {
                    //System.out.println("Got Message2" + inputMessage.head);

                    switch (inputMessage.head)
                    {
                        case Header.LIST_TOPIC:
                            //System.out.println("Got Message");
                            List<String> topics = tcpTopicsManager.ListTopics();
                            Message outputMessage1 = new Message(Header.LIST_TOPIC, topics);
                            SendMessage(outputMessage1);
                            break;
                        case Header.CREATE_TOPIC:
                            //System.out.println("Got Message 3");
                            tcpTopicsManager.CreateTopic(inputMessage.data[0]);
                            break;
                        case Header.JOIN_TOPIC:
                            String topicToJoin = inputMessage.data[0];
                            Message outputMessage3 = new Message(Header.JOIN_TOPIC, tcpTopicsManager.getTopicPort(topicToJoin).ToString());
                            SendMessage(outputMessage3);
                            break;
                        case Header.CONNECT:
                            try
                            {
                                am.Authentify(inputMessage.data[0], inputMessage.data[1]);
                                Console.WriteLine("CONNEXION SUCESS");
                            }
                            catch (WrongPasswordException e)
                            {
                                Console.WriteLine(e + " : password or login is incorrect!");
                            }
                            break;
                        case Header.REGISTER:
                            try
                            {
                                am.AddUser(inputMessage.data[0], inputMessage.data[1]);
                                am.Authentify(inputMessage.data[0], inputMessage.data[1]);
                                Console.WriteLine("INSCRIPTION SUCESS");

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
                            }
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
