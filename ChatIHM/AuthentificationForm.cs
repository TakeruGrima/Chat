using Chatprojet.Chat;
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
    public partial class AuthentificationForm : Form
    {
        #region field

        ClientTopicsManager ctm;

        MainForm mainForm;

        #endregion

        #region Constructor

        public AuthentificationForm()
        {
            ctm = new ClientTopicsManager();
            ctm.SetServer("127.0.0.1", 26763);
            ctm.Connect();
            InitializeComponent();
        }

        #endregion

        #region event methods

        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            ctm.Login(LoginTextBox.Text,PasswordTextBox.Text);

            mainForm = new MainForm(this,ctm, new TextChatter(LoginTextBox.Text));
            mainForm.Activate();
            mainForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ctm.Register(LoginTextBox.Text, PasswordTextBox.Text);
        }

        #endregion

        #region Thread method



        #endregion
    }
}
