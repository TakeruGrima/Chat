using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIHM
{
    public partial class ChatroomIHM : Form
    {
        #region Field

        ClientChatRoom clientChatRoom;

        #endregion

        #region Constructor

        public ChatroomIHM(ClientChatRoom clientChatRoom)
        {
            this.clientChatRoom = clientChatRoom;
            InitializeComponent();
        }

        #endregion

        #region event methods

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            clientChatRoom.Post(UserChatBox.Text, clientChatRoom.User);
        }

        #endregion
    }
}
