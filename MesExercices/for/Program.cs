using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Valeur de départ{0}", value);
            Console.WriteLine("Démarrage de for" + Environment.NewLine);
            for(value = 0; value <=10; value++)
            {
                Console.WriteLine("Lavaleur est de {0}", value);
            }
            Console.WriteLine("À la fin de l'algorythme, la valeur est de: {0}", value);
            Console.ReadLine();
        }
    }
}
