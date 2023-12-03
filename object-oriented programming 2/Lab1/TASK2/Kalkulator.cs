using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.TASK2
{
    public class Program2
    {
        public static void RunKalkulator()
        {
            bool kontynuuj = true;
            while (kontynuuj)
            {
                Console.WriteLine("\nKalkulator:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Potęgowanie");
                Console.WriteLine("6. Pierwiastkowanie");
                Console.WriteLine("7. Funkcje trygonometryczne");
                Console.WriteLine("8. Wyjście");
                Console.Write("Wybierz opcję: ");
                int wybor = Convert.ToInt32(Console.ReadLine());

                double a, b, wynik;

                switch (wybor)
                {
                    case 1:
                        Console.Write("Podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = a + b;
                        Console.WriteLine("Suma: " + wynik);
                        break;

                    case 2:
                        Console.Write("Podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = a - b;
                        Console.WriteLine("Różnica: " + wynik);
                        break;

                    case 3:
                        Console.Write("Podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = a * b;
                        Console.WriteLine("Iloczyn: " + wynik);
                        break;

                    case 4:
                        Console.Write("Podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (b != 0)
                        {
                            wynik = a / b;
                            Console.WriteLine("Iloraz: " + wynik);
                        }
                        else
                        {
                            Console.WriteLine("Nie można dzielić przez zero!");
                        }
                        break;

                    case 5:
                        Console.Write("Podaj podstawę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wykładnik: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = Math.Pow(a, b);
                        Console.WriteLine("Potęga: " + wynik);
                        break;

                    case 6:
                        Console.Write("Podaj liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        if (a >= 0)
                        {
                            wynik = Math.Sqrt(a);
                            Console.WriteLine("Pierwiastek: " + wynik);
                        }
                        else
                        {
                            Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej!");
                        }
                        break;

                    case 7:
                        Console.Write("Podaj kąt w radianach: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sinus: " + Math.Sin(a));
                        Console.WriteLine("Cosinus: " + Math.Cos(a));
                        Console.WriteLine("Tangens: " + Math.Tan(a));
                        break;

                    case 8:
                        kontynuuj = false;
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybór!");
                        break;
                }
            }
        }
    }

}
