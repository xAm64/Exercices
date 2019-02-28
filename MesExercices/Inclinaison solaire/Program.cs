using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclinaison_solaire
{
    class Program
    {
        static readonly float angle = 23.27f;
        static float ete;
        static float hiver;

        static void Main(string[] args)
        {
            Console.WriteLine("Quelle est votre latitude, ou celle à calculer ?");
            string latitude = Console.ReadLine();
            int lat = int.Parse(latitude);
            ete = (lat + angle);
            hiver = (lat - angle);
            Console.WriteLine("Sur le lieu calculé le soleil ateint un angle de: " + ete + "°\nEt un angle de: " + hiver +"°");
            Console.ReadLine();
        }
    }
}
