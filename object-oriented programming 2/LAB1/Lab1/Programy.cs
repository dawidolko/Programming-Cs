using System;
using Lab1.TASK1;
using Lab1.TASK2;
using Lab1.TASK3;
using Lab1.TASK4;
using Lab1.TASK5;
using Lab1.TASK6;
using Lab1.TASK7;

namespace Lab1
{
    class Programy
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWybierz ZADANIE:");
                Console.WriteLine("1: ZADANIE" );
                Console.WriteLine("2: ZADANIE");
                Console.WriteLine("3: ZADANIE");
                Console.WriteLine("4: ZADANIE");
                Console.WriteLine("5: ZADANIE");
                Console.WriteLine("6: ZADANIE");
                Console.WriteLine("7: ZADANIE");
                Console.WriteLine("8: ZAKONCZ");

                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Program1.RunDelta();
                        break;
                    case "2":
                        Program2.RunKalkulator();
                        break;
                    case "3":
                        Program3.Wypisywanie();
                        break;
                    case "4":
                        Program4.Wyszukiwanie();
                        break;
                    case "5":
                        Program5.Wyswietlanie();
                        break;
                    case "6":
                        Program6.Nieskonczonosc();
                        break;
                    case "7":
                        Program7.Sortowanie();
                        break;
                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
