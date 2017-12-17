using Chatprojet.Chat;
using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Timothée LE CORRE and Camille Melo

namespace ChatIHM
{
    public partial class TopicForm : Form
    {
        #region delegate

        public delegate void UpdateTopics();

        #endregion

        #region Field region

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        ClientTopicsManager ctm;

        AuthentificationForm authentificationForm;//on conserve la form pour pouvoir la fermer
        ChatroomIHM chatroomIHM;

        Chatter chatter;

        Dictionary<string,ChatroomIHM> topicRooms;
        //on sauvegarde les topics ouvert pour vérifier que l'utilisateur 
        //n'ouvre pas le meme topic et activer la chatroom correspondante

        Thread thread;
        int nbtopics = 0;

        #endregion

        #region Constructor

        public TopicForm(AuthentificationForm authentificationForm
            , ClientTopicsManager ctm, Chatter c)
        {
            this.authentificationForm = authentificationForm;
            this.ctm = ctm;

            chatter = c;

            topicRooms = new Dictionary<string, ChatroomIHM>();

            InitializeComponent();
        }

        #endregion

        #region Form events to move and close the form

        //these 3 methodes are event to move the form
        private void TopicForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TopicForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TopicForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        #region Buttons events (close, maximize and reduce)

        //Controls Button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            ctm.Disconnect();
            authentificationForm.Close();
            this.Close();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region methods

        public void RunThread()
        {
            try
            {
                while (true)
                {
                    topicsListView.Invoke(new UpdateTopics(RefreshTopics));
                }
            }
            catch
            {
            }
        }

        public void RefreshTopics()
        {
            List<string> topics = ctm.ListTopics();

            if (topics.Count!= nbtopics)
            {
                nbtopics = topics.Count;

                topicsListView.Items.Clear();
                foreach (string topic in topics)
                {
                    ListViewItem lvi = new ListViewItem(topic);

                    topicsListView.Items.Add(lvi);
                }
            }
        }

        public void JoinTopic(string topic)
        {
            if(!topicRooms.ContainsKey(topic))
            {
                ClientChatRoom chatroom = (ClientChatRoom)ctm.JoinTopic(topic);
                chatroom.Join(chatter);
                chatroom.Topic = topic;

                chatroomIHM = new ChatroomIHM(chatroom,this);

                topicRooms.Add(topic,chatroomIHM);
                chatroomIHM.Show();
            }
            else
            {
                topicRooms[topic].Activate();
            }
        }

        public void CloseTopic(string topic)
        {
            topicRooms.Remove(topic);
        }

        #endregion

        #region events methods

        private void formPanel_Enter(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(RunThread));
            thread.Start();
        }

        private void topicsListView_ItemActivate(object sender, EventArgs e)
        {
            int id = topicsListView.SelectedIndices[0];

            JoinTopic(topicsListView.Items[id].Text);
        }

        private void addTopicButton_Click(object sender, EventArgs e)
        {
            if (addTopicTextBox.Text != "" 
                && !ctm.ListTopics().Contains(addTopicTextBox.Text))
            {
                ctm.CreateTopic(addTopicTextBox.Text);
                JoinTopic(addTopicTextBox.Text);

                RefreshTopics();
                errorTopicExistLabel.Hide();

                addTopicTextBox.Text = "";
            }
            else
            {
                errorTopicExistLabel.Show();
            }
        }

        #endregion
    }
}
