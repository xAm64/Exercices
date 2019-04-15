using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class Form1 : Form
    {
        ulong total = 0, numero = 0;
        bool ok;
        string chiffres = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void touche1_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            string numero = bouton.Text;
            chiffres += numero;
            Affichage.Text = chiffres;
            Compteur.Text = total.ToString();
            //MessageBox.Show(numero);
        }

        private void Addition(object sender, EventArgs e)
        {
            if (chiffres == "")
            {
                MessageBox.Show("Je n'ai rien a calculer");
            }
            else
            {
                ulong calcul = ulong.Parse(chiffres);
                total += calcul;
                Affichage.Text = "";
                chiffres = "";
                numero = 0;
                Compteur.Text = total.ToString();
            }
        }

        private void Egal(object sender, EventArgs e)
        {
            if (chiffres == "")
            {
                MessageBox.Show("Je n'ai rien a calculer");
            }
            else
            {
                ulong calcul = ulong.Parse(chiffres);
                total += calcul;
                Compteur.Text = total.ToString();
            }
        }

        private void Effacer(object sender, EventArgs e)
        {
            total = 0;
            numero = 0;
            chiffres = "";
            Affichage.Text = "";
            Compteur.Text = total.ToString();
        }
    }
}
