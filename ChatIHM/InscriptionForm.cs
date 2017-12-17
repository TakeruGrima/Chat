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
    public partial class InscriptionForm : Form
    {
        #region field
        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        ClientTopicsManager ctm;

        #endregion

        #region Constructor

        public InscriptionForm(ClientTopicsManager ctm)
        {
            this.ctm = ctm;

            InitializeComponent();
        }

        #endregion

        #region Form events to move and close the form

        //these 3 methodes are event to move the form
        private void InscriptionForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void InscriptionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void InscriptionForm_MouseUp(object sender, MouseEventArgs e)
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

        private void InscriptionButton_Click(object sender, EventArgs e)
        {
            if (ctm.Register(pseudoTextBox.Text, passwordTextBox.Text))
            {
                this.Close();
            }
            else
            {
                ErrorUserExistLabel.Show();
                retryLabel.Show();
            }
        }

        #endregion
    }
}
