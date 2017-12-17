using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Authentification
{
    public class AuthentificationException : Exception
    {
        public string Login { get; set; }

        public AuthentificationException(string msg): base(msg)
        {

        }
    }
}
