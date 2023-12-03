namespace Lekcja15
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            Console.WriteLine(czlowiek.imie);
            Czlowiek czlowiek2 = new Czlowiek();
            czlowiek2.imie = "Bartek";
            Console.WriteLine(czlowiek2.imie);
            czlowiek.PrzedstawSie();
            czlowiek2.nazwisko = "Nowak";
            czlowiek2.PrzedstawSie();
        }
    }

    
}
