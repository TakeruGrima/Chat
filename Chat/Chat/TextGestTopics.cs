using Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chatprojet.Chat
{
    public class TextGestTopics : TopicsManager
    {
        #region field region

        private List<string> _topics;

        #endregion

        #region property 

        //use to get topics without displaying them
        public List<string> Topics
        {
            get
            {
                return _topics;
            }
        }

        #endregion

        #region Constructor

        public TextGestTopics()
        {
            _topics = new List<string>();
        }

        #endregion

        #region methods

        public void CreateTopic(string topic)
        {
            _topics.Add(topic);
        }

        public Chatroom JoinTopic(string topic)
        {
            TextChatRoom c = new TextChatRoom();
            c.Topic = topic;
            return c;
        }

        public List<string> ListTopics()
        {
            Console.WriteLine("The openned topics are: ");
            foreach (string topic in _topics)
            {
                Console.WriteLine(topic);
            }

            return _topics;
        }

        #endregion

        //to save and load topics
        #region save/load methods

        //Charger le fichier des users
        public void Load(String path)
        {
           _topics  = (List<string>)SerialTools.DeserializeBin(path);
        }

        //Sauvegarde les fichiers des users
        public void Save(String path)
        {
            SerialTools.SerializeBin(path,_topics);
        }

        #endregion
    }
}
