using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversion_nombre_a_et_b
{
    class Program
    {
        public static void inverseur (ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }

        static void Main(string[] args)
        {



            Console.WriteLine("Donne moi 2 nombres que je vais retenir et ensuite inverser");
            Console.WriteLine("Commence par me donner le nombre A");
            string bteA = Console.ReadLine();
            Console.WriteLine("Maintenant le nombre B");
            string bteB = Console.ReadLine();
            int a = int.Parse(bteA);
            int b = int.Parse(bteB);
            Console.WriteLine("Pour le moment j'ai le nombre: " + a + " dans A et le nombre: " + b + " dans B");
            Console.WriteLine("Je vais inverser les chiffres");
            inverseur(ref a, ref b);
            Console.ReadLine();
            Console.WriteLine("Voila maintenant j'ai: " + a + " dans A et " + b + " dans B");

            Console.ReadLine();
        }
    }
}
