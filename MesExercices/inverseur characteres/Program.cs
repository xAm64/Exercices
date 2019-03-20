using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverseur_characteres
{
    class Program
    {
        #region inverseur de charactères
        static void Inverseur (ref char[] _mot)
        {
            int j = _mot.Length - 1;
            for (int i= 0; i < (_mot.Length /2); i++)
            {
                char x = _mot[i];
                _mot[i] = _mot[j];
                _mot[j] = x;
                j--;
            }
            #region version facile
            //string rev = new string(mot.ToCharArray().Reverse().ToArray());
            //mot = rev;
            #endregion
        }
        #endregion

        static void Main(string[] args)
        {
            bool restart;
            do
            {
                Console.WriteLine("Saisir le text de votre choix, je vais l'inverser");
                string monText = Console.ReadLine();
                char[] textInverse = monText.ToCharArray();
                Inverseur(ref textInverse);
                Console.WriteLine("La saisie {0} fait: {1} en inversé.",monText, new String(textInverse));
                Console.ReadLine();
                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);

            Console.WriteLine("\nAu revoir");
            Console.ReadLine();
        }
    }
}
