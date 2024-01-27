using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumA
{
    public class Prostokat : Ksztalt
    {
        private double bokA;
        private double bokB;

        public Prostokat() : base("Prostokąt")
        {
            bokA = bokB = 0;
        }

        public override void ObliczObwod()
        {
            obwod = 2 * (bokA + bokB);
        }

        public override void WprowadzDane()
        {
            bool danePoprawne = false;
            while (!danePoprawne)
            {
                try
                {
                    Console.WriteLine("Podaj długość boku A:");
                    bokA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj długość boku B:");
                    bokB = double.Parse(Console.ReadLine());
                    if (bokA <= 0 || bokB <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Długości boków muszą być większe od 0.");
                    }
                    danePoprawne = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niepoprawny format liczby, spróbuj ponownie.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Bok A: {bokA}, Bok B: {bokB}");
        }
    }
}
