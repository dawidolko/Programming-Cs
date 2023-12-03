using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK2
{
    class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int IloscOsob { get; set; }

        // Konstruktor pobierający dane od użytkownika
        public SamochodOsobowy() : base()
        {
            Console.Write("Podaj wagę (2 - 4.5 tony): ");
            Waga = double.Parse(Console.ReadLine());

            Console.Write("Podaj pojemność silnika (0.8 - 3.0): ");
            PojemnoscSilnika = double.Parse(Console.ReadLine());

            Console.Write("Podaj ilość osób: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        // Przesłonięta metoda wyświetlająca informacje
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Ilość osób: {IloscOsob}");
        }
    }
}
