using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQharjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans1 = new List<String>
            {
                "Kalle",
                "Malle",
                "Mari",
                "Elmar",
                "Juku",
            };

            var SorteeritudNimed = (from nimi in humans1
                              orderby nimi ascending
                              select nimi).ToList();

            foreach (var item in SorteeritudNimed)
            {
                Console.WriteLine(item);
            }

            var Pikkused = from nimi in SorteeritudNimed
                           group nimi.Length by nimi.Length into y
                           select y;

            foreach (var item in Pikkused)
            {
                Console.WriteLine("{0} esineb {1} korda", item.Key, item.Count());
            }
            Console.ReadLine();
        }
    }
}
