namespace Lekcja18
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.imie = "Adraian";
            czlowiek.Wiek = 20;
            Console.WriteLine($"Jestem {czlowiek.imie} lat {czlowiek.Wiek}");
        }
    }
}
