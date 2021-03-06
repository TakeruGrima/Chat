﻿using Chatprojet.Chat;
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


//Created by Timothée LE CORRE and Camille Melo

namespace ChatIHM
{
    public partial class AuthentificationForm : Form
    {
        #region field
        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        ClientTopicsManager ctm;

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

        #region Form events to move and close the form

        //these 3 methodes are event to move the form
        private void AuthentificationForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void AuthentificationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AuthentificationForm_MouseUp(object sender, MouseEventArgs e)
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

        #region event methods

        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            string errorMessage= "";
            //Console.WriteLine(loginTextBox.Text + "  " + passwordTextBox.Text);
            if(ctm.Login(loginTextBox.Text,passwordTextBox.Text,ref errorMessage))
            {
                this.Hide();

                TopicForm topicForm = new TopicForm(this, ctm, new TextChatter(loginTextBox.Text));
                topicForm.Show();
            }
            else
            {
                if(errorMessage == "incorrect")
                {
                    ErrorLoginLabel.Show();
                }
                else
                {
                    ErrorConnexionLabel.Show();
                }
                retryLabel.Show();
            }
        }

        private void inscriptionButton_Click(object sender, EventArgs e)
        {
            ErrorLoginLabel.Hide();
            ErrorConnexionLabel.Hide();
            InscriptionForm inscription = new InscriptionForm(ctm);
            inscription.Show();
        }

        #endregion
    }
}
