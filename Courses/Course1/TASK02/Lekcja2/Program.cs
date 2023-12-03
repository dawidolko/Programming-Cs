// 1. Kurs C# dla początkujących - Zmienne, stałe oraz podstawowe typy danych - [https://www.youtube.com/watch?v=hSHmbLxtB_Q&list=PL6aekdNhY7DAeU-2LEGBDXls60Yy-Ubbu&index=3]

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //stała musi być zadeklarowana przy deklaracji
            const double Pi = Math.PI;

            int zmienna = int.MaxValue;
            int zmienna2 = int.MinValue;
            string zmienna3 = "Hello World";
            //trzeba dodać F przy przypisywaniu wartości
            float zmienna4 = float.MaxValue;
            float zmienna5 = float.MinValue;
            double zmienna6 = double.MaxValue;
            double zmienna7 = double.MinValue;
            long zmienna8 = long.MaxValue;
            long zmienna9 = long.MinValue;
            short zmienna10 = short.MaxValue;
            short zmienna11 = short.MinValue;
            byte zmienna12 = byte.MaxValue;
            byte zmienna13 = byte.MinValue;
            bool zmienna14 = false;
            bool zmienna15 = true;
            char zmienna16 = char.MaxValue;
            char zmienna17 = char.MinValue;
            //trzeba dodać M przy przypisywaniu wartości
            decimal zmienna18 = decimal.MaxValue;
            decimal zmienna19 = decimal.MinValue;
            

            Console.WriteLine("Maksymalna wartość inta: "+zmienna);
            Console.WriteLine("Minimalna wartość inta: "+zmienna2);
            Console.WriteLine("Maksymalna wartość float: "+zmienna4);
            Console.WriteLine("Minimalna wartość float: "+zmienna5);
            Console.WriteLine("Maksymalna wartość double: "+zmienna6);
            Console.WriteLine("Minimalna wartość double: "+zmienna7);
            Console.WriteLine("Maksymalna wartość long: "+zmienna8);
            Console.WriteLine("Minimalna wartość long: "+zmienna9);
            Console.WriteLine("Maksymalna wartość short: "+zmienna10);
            Console.WriteLine("Minimalna wartość short: "+zmienna11);
            Console.WriteLine("Maksymalna wartość byte: "+zmienna12);
            Console.WriteLine("Minimalna wartość byte: "+zmienna13);
            Console.WriteLine("Maksymalna wartość bool "+zmienna14);
            Console.WriteLine("Minimalna wartość bool: "+zmienna15);
            Console.WriteLine("Maksymalna wartość char: "+zmienna16);
            Console.WriteLine("Minimalna wartość char: "+zmienna17);
            Console.WriteLine("Maksymalna wartość decimal: "+zmienna18);
            Console.WriteLine("Minimalna wartość decimal: "+zmienna19);
            Console.WriteLine("Stała warotść liczby pi: " + Pi);
        }
    }
}
