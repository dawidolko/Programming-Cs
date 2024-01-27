using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumA
{
    public class Kolo : Ksztalt
    {
        private double promien;

        public Kolo() : base("Koło")
        {
            this.promien = 0;
        }

        public override void ObliczObwod()
        {
            obwod = 2 * Math.PI * promien;
        }

        public override void WprowadzDane()
        {
            bool danePoprawne = false;
            while (!danePoprawne)
            {
                try
                {
                    Console.WriteLine("Podaj promień koła:");
                    promien = double.Parse(Console.ReadLine());
                    if (promien <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Promień musi być większy od 0.");
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
            Console.WriteLine($"Promień: {promien}");
        }
    }
}
