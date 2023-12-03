namespace Lekcja16
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.PrzedstawSie();
            Czlowiek czlowiek2 = new Czlowiek("Michał", "Nowak");
            //czlowiek2.PrzedstawSie();
            czlowiek.PrzedstawSie();
            

        }
    }
}
