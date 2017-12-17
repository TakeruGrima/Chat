using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Timothée LE CORRE and Camille Melo

namespace ChatIHM
{
    public partial class ChatroomIHM : Form
    {
        #region delegate

        public delegate void UpdateText();

        #endregion

        #region Field

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        TopicForm topicForm;// on conserve cette form pour utiliser le méthode
        //close topic

        ClientChatRoom clientChatRoom;
        Thread thread;
        int messageCount;//number of message

        #endregion

        #region Constructor

        public ChatroomIHM(ClientChatRoom clientChatRoom,TopicForm topicForm)
        {
            this.topicForm = topicForm;
            this.clientChatRoom = clientChatRoom;
            InitializeComponent();

            topicNameLabel.Text = clientChatRoom.Topic;
        }

        #endregion

        #region Form events to move and close the form

        //these 3 methodes are event to move the form
        private void ChatroomIHM_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ChatroomIHM_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ChatroomIHM_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        #region Buttons events (close, maximize and reduce)

        //Controls Button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        public void RunThread()
        {
            try
            {
                while (true)
                {
                    ChatTextBox.Invoke(new UpdateText(RefreshTextBox));
                }
            }
            catch
            {

            }
        }

        public void RefreshTextBox()
        {
            int count = clientChatRoom.Messages.Count;
            if (messageCount != count)
            {
                messageCount = count;
                ChatTextBox.Text = "";

                for (int i = 0; i < count; i++)
                {
                    Chat.Net.Message m = clientChatRoom.Messages[i];
                    switch (m.head)
                    {
                        case Chat.Net.Header.GET:
                            ChatTextBox.Text += m.data[0] + " : " +
                                m.data[1] + "\n";
                            break;
                        case Chat.Net.Header.LEFT:
                            ChatTextBox.Text += m.data[0] +
                                " has left the room\n";
                            break;
                        case Chat.Net.Header.JOINED:
                            ChatTextBox.Text += m.data[0] +
                                " has join the room\n";
                            break;
                    }
                }

                ChatTextBox.Refresh();
            }
        }

        #region event methods

        private void formPanel_Enter(object sender, EventArgs e)
        {
            messageCount = 0;

            thread = new Thread(new ThreadStart(RunThread));
            thread.Start();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            clientChatRoom.Post(UserChatBox.Text, clientChatRoom.User);
            UserChatBox.Clear();
        }

        private void ChatroomIHM_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Interrupt();
            try
            {
                topicForm.CloseTopic(clientChatRoom.Topic);
                clientChatRoom.Quit(clientChatRoom.User);

                clientChatRoom.Disconnect();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex + "probleme connexion");
            }
        }

        #endregion
    }
}
