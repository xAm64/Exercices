using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static int valdem;

        static void Main(string[] args)
        {
            bool ok;
            
            do
            {
                Console.WriteLine("écrivez un chivvre je vais compter jusqu'au nombre dit !");
                string val = Console.ReadLine();
                ok = int.TryParse(val, out valdem);

            }
            while (!ok);
            int value = 0;

            while (value < valdem)
            {
                value++;
                Console.WriteLine("La valeur est maintenant de {0}", value);
            }
            Console.WriteLine("La boucle est mintenant terminée, la valeur est de {0}", value);
            Console.ReadLine();
        }
    }
}
