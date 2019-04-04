using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pack_de_bouteilles
{
    public class EmbalagePack
    {
        private Pack2Bouteilles pack2Bouteilles;
        enum Embalage
        {
            plastique,
            carton,
            filet,
        };
        bool ouvert;
        private void boutton_Click(object sender, EventArgs e)
        {
            Embalage value = Embalage.carton;
            switch(value)
            {
                case Embalage.carton:
                    Console.WriteLine("L'embalage est en carton");
                    break;
                case Embalage.plastique:
                    Console.WriteLine("L'embalage est en plastique");
                    break;
                case Embalage.filet:
                    Console.WriteLine("L'embalage est un filet");
                    break;
            }
        }

        public EmbalagePack()
        {
            ouvert = false;
        }

        #region Ouvert
        public bool Ouvrir()
        {
            if (ouvert == true)
            {
                Console.WriteLine(" le pack est déjà ouvert");
            }
            return ouvert;
        }
        #endregion

        #region message pack
        public string MessagePack()
        {
            string message;
            if (ouvert == true)
            {
                message = "ouvert";
            }
            else
            {
                message = "fermé";
            }
            return message;
        }

        public override string ToString()
        {
            string message = MessagePack();
            return "Le pack de bouteille est: " +message;
        }
        #endregion
    }
}