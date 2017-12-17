using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Net
{
    public interface MessageConnection
    {
        Message GetMessage();

        void SendMessage(Message m);
    }
}
