namespace Lekcja17
{
    class Porgam
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            Czlowiek czlowiek = new Czlowiek();
            CzlowiekStatic.liczbaLudnosci = 2;
            Console.WriteLine(czlowiek.imie);
            czlowiek.Wyswietl();
            //klasy statycznej się nie tworzy i zapamiętuje ona wartości przypisane do niej

        }
    }
}
