using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //első feladat
            Console.WriteLine("Add meg a pontszámott (0-100) között: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (0 > szam && 100 < szam)
            {
                Console.WriteLine("Érvénytelen pontszám");
            }
            else if (50 > szam && 0 <= szam)
            {
                Console.WriteLine("Ez a dolgozat Elégtelen");
            }
            else if (60 > szam && 50 <= szam)
            {
                Console.WriteLine("Ez a dolgozat Elégséges");
            }
            else if (80 > szam && 60 <= szam)
            {
                Console.WriteLine("Ez a dolgozat Közepes");
            }
            else if (90 > szam && 80 <= szam)
            {
                Console.WriteLine("Ez a dolgozat Jó");
            }
            else if (101 > szam && 90 <= szam)
            {
                Console.WriteLine("Ez a dolgozat Jeles");
            }
            Console.ReadKey();

        }
    }
}
