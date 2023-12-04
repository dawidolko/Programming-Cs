using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK3
{
    public static class ListExtensions
    {
        public static void WypiszOsoby(this List<IOsobaa> osoby)
        {
            foreach (var osoba in osoby)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        // Zadanie 3c.
        public static void PosortujOsobyPoNazwisku(this List<IOsobaa> osoby)
        {
            osoby.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
        }
    }
}
