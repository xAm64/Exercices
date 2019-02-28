using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversion_nombre_a_et_b
{
    class Program
    {
        static int X;

        static void Main(string[] args)
        {
            Console.WriteLine("Donne moi 2 nombres que je vais retenir et ensuite inverser");
            Console.WriteLine("Commence par me donner le nombre A");
            string bteA = Console.ReadLine();
            Console.WriteLine("Maintenant le nombre B");
            string bteB = Console.ReadLine();
            int A = int.Parse(bteA);
            int B = int.Parse(bteB);
            Console.WriteLine("Pour le moment j'ai le nombre: " + A + " dans A et le nombre: " + B + " dans B");
            Console.WriteLine("Je vais inverser les chiffres");
            X = A;
            A = B;
            B = X;
            Console.ReadLine();
            Console.WriteLine("Voila maintenant j'ai: " + A + " dans A et " + B + " dans B");

            Console.ReadLine();
        }
    }
}
