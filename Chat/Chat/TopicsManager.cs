using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//Created by Timothée LE CORRE and Camille Melo

namespace Chatprojet.Chat
{
    public interface TopicsManager
    {
        List<string> ListTopics();
        Chatroom JoinTopic(String topic);
        void CreateTopic(String topic);
    }
}
