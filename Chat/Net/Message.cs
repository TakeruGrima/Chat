using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Net
{
    public enum Header { DEBUG, LIST_TOPIC,
        CREATE_TOPIC,TOPIC_IS_CREATE, JOIN_TOPIC,TOPIC_EXIST,
        JOIN, POST, QUIT, GET, JOINED, LEFT,
        CONNECT,REGISTER,ALREADYEXIST,REGISTERED,
        ISCONNECTED,ISUNCONNECTED,ALREADYCONNECTED,DISCONNECT }

    [Serializable]
    public class Message
    {
        #region Field region

        public Header head;
        public List<String> data = new List<string>();

        #endregion

        #region Constructors

        public Message(Header head, String message):this(head)
        {
            data.Add(message);
        }

        public Message(Header head, List<String> message):this(head)
        {
            data = message;
        }

        public Message(Header head)
        {
            this.head = head;
        }

        #endregion

        #region methods

        public void Add(string s)
        {
            data.Add(s);
        }

        #endregion

        #region overide methods

        public override string ToString()
        {
            return head + " " + data.ToString();
        }

        #endregion
    }
}
