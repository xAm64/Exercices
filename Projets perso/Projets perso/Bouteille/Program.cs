using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Programme
    {
        static void Main(string[] args)
        {
            LaBouteille eau = new LaBouteille();
            Console.WriteLine(eau);
            eau.Ouvrir();
            Console.WriteLine(eau);
            eau.Vider();
            Console.WriteLine(eau);
            Console.ReadLine();
        }
    }
}
