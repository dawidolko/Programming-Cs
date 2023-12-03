namespace lekcja29
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 500);
            Console.WriteLine(p1.imie+" "+p1.punktyHP+" "+p1.mana);
        }
    }
}