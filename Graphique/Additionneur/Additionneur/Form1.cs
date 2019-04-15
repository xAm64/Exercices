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
        public Form1()
        {
            InitializeComponent();
        }

        private void touche1_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            string numero = bouton.Text;
            Affichage.Text = numero;
            //MessageBox.Show(numero);
        }
    }
}
