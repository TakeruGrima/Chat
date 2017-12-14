using Chatprojet.Chat;
using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIHM
{
    public partial class MainForm : Form
    {
        #region field

        ClientTopicsManager ctm;

        AuthentificationForm authentificationForm;//on conserve la form pour pouvoir la fermer
        ChatroomIHM chatroomIHM;

        Chatter chatter;

        #endregion

        #region Constructor

        public MainForm(AuthentificationForm authentificationForm
            ,ClientTopicsManager ctm, Chatter c)
        {
            this.authentificationForm = authentificationForm;
            this.ctm = ctm;

            chatter = c;

            InitializeComponent();

            new Thread(Run).Start();
        }

        #endregion

        #region methods event

        private void CreateTopicButton_Click(object sender, EventArgs e)
        {
            if(CreateTopicTextBox.Text!= "")
            {
                ctm.CreateTopic(CreateTopicTextBox.Text);
            }
        }

        #endregion

        public void Run()
        {
            try
            {
                Chat.Net.Message message;
                while ((message = ctm.GetMessage()) != null)
                {
                    
                }
                Console.WriteLine("End of while");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            authentificationForm.Close();
        }

        private void JoinTopicButton_Click(object sender, EventArgs e)
        {
            ClientChatRoom chatroom = (ClientChatRoom)ctm.JoinTopic(CreateTopicTextBox.Text);
            Debug.WriteLine("MARCHE?");
            chatroom.Join(chatter);

            chatroomIHM = new ChatroomIHM(chatroom);
        }
    }
}
