using lekcja28;

namespace Lekcja28
{
    class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.Nazwa = "Mars";
            ziemia.RuchObrotowy();
            ziemia.Atomsfera();
            ziemia.PoraDniaINocy();
        }

    }
}
