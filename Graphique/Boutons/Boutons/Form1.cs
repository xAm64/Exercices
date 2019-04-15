using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PremierClic_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bonjour");
            ClicMouvement.Visible = true;
            ClicMouvement.Text = "Attrappe moi si tu peux";
            timerMouveRight.Start();
        }

        private void timerMouve_Tick(object sender, EventArgs e)
        {
            Point newPosition = new Point(ClicMouvement.Location.X +10,ClicMouvement.Location.Y);
            int longueur = this.Width;
            if (ClicMouvement.Location.X >= longueur - ClicMouvement.Width -50)
            {
                timerMoveDown.Start();
                timerMouveRight.Stop();
            }
            ClicMouvement.Location = newPosition;
        }

        private void timerMoveDown_Tick(object sender, EventArgs e)
        {
            Point newPosition = new Point(ClicMouvement.Location.X, ClicMouvement.Location.Y +10);
            int hauteur = this.Height;
            if (ClicMouvement.Location.Y >= hauteur - ClicMouvement.Height -50)
            {
                timerMoveLeft.Start();
                timerMoveDown.Stop();
            }
            ClicMouvement.Location = newPosition;
        }

        private void timerMoveLeft_Tick(object sender, EventArgs e)
        {
            Point newPosition = new Point(ClicMouvement.Location.X - 10, ClicMouvement.Location.Y);
            if (ClicMouvement.Location.X <= 30)
            {
                timerMoveUp.Start();
                timerMoveLeft.Stop();
            }
            ClicMouvement.Location = newPosition;
        }

        private void timerMoveUp_Tick(object sender, EventArgs e)
        {
            Point newPosition = new Point(ClicMouvement.Location.X, ClicMouvement.Location.Y - 10);
            if (ClicMouvement.Location.Y <= 60)
            {
                timerMoveUp.Stop();
                ClicMouvement.Text = "Je t'ai eu !";
            }
            ClicMouvement.Location = newPosition;
        }
    }
}
