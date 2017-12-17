using Chatprojet.Chat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Server
{
    class TCPTopicsManager : TextGestTopics
    {
        #region field region

        private static int nextPort = 16000;
        private Dictionary<String, ServerChatRoom> tcpChatrooms = new Dictionary<String, ServerChatRoom>();

        #endregion

        #region Constructor

        public TCPTopicsManager()
        {
            try
            {
                Load("Topics.txt");

                foreach(string topic in Topics)
                {
                    StartServerChatroom(topic);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        #endregion

        #region methods

        public new void CreateTopic(String topic)
        {
            base.CreateTopic(topic);
            StartServerChatroom(topic);
        }

        public void StartServerChatroom(string topic)
        {
            Chatroom chatroom = base.JoinTopic(topic);
            chatroom.Topic = topic;

            ServerChatRoom serverChatRoom = new ServerChatRoom(chatroom);
            tcpChatrooms.Add(topic, serverChatRoom);

            bool started = true;
            do
            {
                try
                {
                    serverChatRoom.StartServer(nextPort);
                    started = true;
                }
                catch (IOException e)
                {
                    started = false;
                    Console.WriteLine(e.ToString());
                }
                nextPort++;
            } while (!started);
        }

        public int getTopicPort(String topic)
        {
            return tcpChatrooms[topic].Port;
        }

        #endregion
    }
}
