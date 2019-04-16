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
        double total = 0, chiffresSaisie = 0;
        string affichageChiffres = "", operateur = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void touche1_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            string saisieNumeros = bouton.Text;
            affichageChiffres += saisieNumeros;
            Affichage.Text = affichageChiffres;
            Compteur.Text = total.ToString();
            //MessageBox.Show(numero);
        }

        private void Egal(object sender, EventArgs e)
        {
            if (affichageChiffres == "")
            {
                affichageChiffres = "0";
            }
            chiffresSaisie = double.Parse(affichageChiffres);
            if (operateur == "+")
            {
                total = total + chiffresSaisie;
            }
            if (operateur == "-")
            {
                total = total - chiffresSaisie;
            }
            if (operateur == "×")
            {
                total = total * chiffresSaisie;
            }
            if (operateur == "÷")
            {
                total = total / chiffresSaisie;
            }
            if (operateur == "")
            {
                total = total += 0;
            }
            Affichage.Text = "";
            affichageChiffres = "";
            operateur = "";
            chiffresSaisie = 0;
            Compteur.Text = total.ToString();
        }

        private void SymboleOperatoire(object sender, EventArgs e)
        {
            Button symbole = sender as Button;
            operateur = symbole.Text;
            TextOperateur.Text = operateur;
            if (affichageChiffres == "")
            {
                affichageChiffres = "0";
            }
            chiffresSaisie = double.Parse(affichageChiffres);
            if (operateur == "+")
            {
                total += chiffresSaisie;
            }
            if (operateur == "-")
            {
                total += chiffresSaisie;
            }
            if (operateur == "×")
            {
                total += chiffresSaisie;
            }
            if (operateur == "÷")
            {
                total += chiffresSaisie;
            }
            Affichage.Text = "";
            affichageChiffres = "";
            chiffresSaisie = 0;
            Compteur.Text = total.ToString();
        }

        private void Effacer(object sender, EventArgs e)
        {
            total = 0;
            chiffresSaisie = 0;
            affichageChiffres = "";
            Affichage.Text = "";
            operateur = "";
            TextOperateur.Text = "";
            Compteur.Text = total.ToString();
        }
    }
}
