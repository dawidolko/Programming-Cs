namespace lekcja31
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 500);
            p1.Ruch();
            Console.WriteLine(p1.imie + " " + p1.punktyHP + " " + p1.mana);
            IAtakMagiczny atak = (IAtakMagiczny)p1;
            atak.Atak(25);
            IAtakMagiczny atak2 = (IAtakMagiczny)p1;
            atak2.Atak(100);

        }
    }
}