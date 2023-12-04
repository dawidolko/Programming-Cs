using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK3
{
    public class Osobaa : IOsobaa
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osobaa(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
