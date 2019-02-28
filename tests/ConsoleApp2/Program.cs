using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int value;

        static void Main(string[] args)
        {
            bool ok;
            do
            {
                Console.WriteLine("Je vais compter jusqu'à la valeur que vous écrivez !");
                string val = Console.ReadLine();
                ok = int.TryParse(val, out value);
                if(!ok)
                    {
                    Console.WriteLine("Une erreur à été détecter, je ne compte que avec des chiffres");
                    }
            }
            while (!ok);

            int i;
            for(i = 0; i < value; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Voila je suis arrivé à {0}", i);

            Console.ReadLine();
        }
    }
}
