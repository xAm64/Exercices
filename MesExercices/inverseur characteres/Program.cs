using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverseur_characteres
{
    class Program
    {
        static void inverseur (string _mot)
        {
            for (int i = _mot.Length -1 ; i >= 0; i--)
            {
                Console.Write(_mot[i]);
            }
            
            //string rev = new string(mot.ToCharArray().Reverse().ToArray());
            //mot = rev;
        }

        static void Main(string[] args)
        {
            bool restart;
            do
            {
                Console.WriteLine("Saisir le text de votre choix, je vais l'inverser");
                string monText = Console.ReadLine();
                Console.Write("Le mot {0} écrit à l'envers est: ", monText);
                inverseur(monText);
                Console.ReadLine();
                Console.WriteLine("\n Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);

            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
