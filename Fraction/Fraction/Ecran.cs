using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Ecran
    {
        public string Afficher (Fraction _numero)
        {
            string affich = _numero.GetNumerateur() + " / " + _numero.GetDenominateur();
            return affich;
        }
    }
}
