using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK2
{
    class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        private int przebieg;

        public int Przebieg
        {
            get { return przebieg; }
            set { przebieg = value >= 0 ? value : 0; }
        }

        // Konstruktor pobierający dane od użytkownika
        public Samochod()
        {
            Console.Write("Podaj markę: ");
            Marka = Console.ReadLine();

            Console.Write("Podaj model: ");
            Model = Console.ReadLine();

            Console.Write("Podaj typ nadwozia: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji: ");
            RokProdukcji = int.Parse(Console.ReadLine());

            Console.Write("Podaj przebieg: ");
            Przebieg = int.Parse(Console.ReadLine());
        }

        // Przeciążony konstruktor
        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        // Metoda wyświetlająca informacje o samochodzie
        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Nadwozie: {Nadwozie}, Kolor: {Kolor}, Rok produkcji: {RokProdukcji}, Przebieg: {Przebieg}");
        }
    }

}
