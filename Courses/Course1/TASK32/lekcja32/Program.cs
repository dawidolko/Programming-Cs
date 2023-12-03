using System.ComponentModel;

namespace lekcja32
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D punkt1 = new Punkt2D(5,10);
            //punkt1.x = 5;
            //punkt1.y = 10;
            Console.WriteLine("X: " + punkt1.x + " Y: " + punkt1.y);
            Console.WriteLine(punkt1.OdlegloscOdSodka());
            Punkt2D punkt2;
            punkt2 = punkt1;
            Console.WriteLine(punkt2.x);
            Console.WriteLine(punkt2.y);
            Console.WriteLine(punkt2.OdlegloscOdSodka());
            Punkt2D punkt3 = punkt2 + punkt1;
            Console.WriteLine(punkt3.x + " " + punkt3.y);
        }
    }
    //Struktury mogą dziedziczyć jedynie po interfacach
    struct Punkt2D
    {
        public static Punkt2D operator +(Punkt2D a, Punkt2D b)
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double OdlegloscOdSodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1);
        }
    }

}