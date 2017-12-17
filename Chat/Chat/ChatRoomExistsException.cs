using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Chat
{
    public class ChatRoomExistsException : Exception
    {
        public ChatRoomExistsException(string msg): base(msg)
        {

        }
    }
}
