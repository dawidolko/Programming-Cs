internal class Program {
    private static void Main(string[] args) {
        //Ex. 9
        int number = 0;

        do {
            Console.WriteLine("\nWpisz liczbe od 1 do 8, aby wyswietlic dane zadanie. Wpisz 0, aby przerwac dzialnie programu");
            number = int.Parse(Console.ReadLine());

            switch (number) {
                case 0:
                    break;
                case 1:
                    exercise1();
                    break;
                case 2:
                    exercise2();
                    break;
                case 3:
                    exercise3();
                    break;
                case 4:
                    exercise4();
                    break;
                case 5:
                    exercise5();
                    break;
                case 6:
                    exercise6();
                    break;
                case 7:
                    exercise7();
                    break;
                case 8:
                    exercise8();
                    break;
                default:
                    Console.WriteLine("Nie ma takiego zadania.");
                    break;
            }
        } while (number != 0);

        exercise10();

        Console.WriteLine("\n\nDo zobaczenia ponownie!");
    }

    public static void exercise1() {
        string id = "125148";
        Console.WriteLine(id);
    }

    public static void exercise2() {
        Console.Write("\nWprowadz liczbe: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0) Console.WriteLine(number + " jest parzysta");
        else Console.WriteLine(number + " jest niaparzysta.");
    }

    public static void exercise3() {
        Console.Write("\nWprowadz 1. liczbe: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Wprowadz 2. liczbe: ");
        double number2 = double.Parse(Console.ReadLine());

        if (number1 > number2) Console.WriteLine(number1 + " jest wieksza.");
        else if (number2 > number1) Console.WriteLine(number2 + " jest wieksza");
        else Console.WriteLine("Liczby sa rowne.");
    }

    public static void exercise4() {
        Console.Write("\nWprowadz 1. liczbe: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Wprowadz 2. liczbe: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Wprowadz 3. liczbe: ");
        double number3 = double.Parse(Console.ReadLine());
        Console.Write("Wprowadz 4. liczbe: ");
        double number4 = double.Parse(Console.ReadLine());

        double mean = (number1+number2+number3+number4)/4;

        Console.WriteLine("Srednia tych liczb wynosi: " + mean);
    }

    public static void exercise5() {
        Console.Write("\nWprowadz 1. liczbe: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Wprowadz znak dzialania: ");
        char sign = char.Parse(Console.ReadLine());
        Console.Write("Wprowadz 2. liczbe: ");
        double number2 = double.Parse(Console.ReadLine());
        double result;

        switch(sign) {
            case '+':
                result = number1+number2;
                Console.WriteLine("Wynik: " + result);
                break;
            case '-':
                result = number1-number2;
                Console.WriteLine("Wynik: " + result);

                break;
            case '*':
                result = number1 * number2;
                Console.WriteLine("Wynik: " + result);
                break;
            case '/':
                result = number1/number2;
                Console.WriteLine("Wynik: " + result);
                break;
            default:
                Console.WriteLine("Nie ma takiego dzialania.");
                break;
        }
    }

    public static void exercise6() {
        Console.Write("\nWprowadz liczbe: ");
        int number = int.Parse(Console.ReadLine());

        int i=0;
        for (i=0;i<number;i++) Console.Write(i + " ");

        Console.WriteLine();

        i=0;
        while (i<number) {
            Console.Write(i + " ");
            i++;
        }

        Console.WriteLine();

        i=0;
        do {
            Console.Write(i + " ");
            i++;
        } while (i<number);
    }

    public static void exercise7() {
        Console.Write("\nWprowadz liczbe: ");
        int number = int.Parse(Console.ReadLine());
        Boolean prime = true;

        for (int i=2;i<number;i++) if (number%i==0) prime = false;

        if (prime) Console.WriteLine(number + " to liczba pierwsza.");
        else Console.WriteLine(number + " to nie liczba pierwsza.");
    }

    public static void exercise8() {
        Console.WriteLine("\nTysiac liczb pierwszych: ");
        int counter = 0;
        int i, j;

        for (i=2;counter<1000;i++) {
            Boolean prime = true;

            for (j=2;j<i;j++) {
                if (i%j==0) prime = false;
            }

            if (prime) {
                Console.Write(i + " ");
                counter++;
            }
        }

        Console.WriteLine();   

        i = 2;
        j = 2;
        counter = 0;
        while (counter<1000) {
            Boolean prime = true;

            for (j = 2; j < i; j++)
            {
                if (i % j == 0) prime = false;
            }

            if (prime)
            {
                Console.Write(i + " ");
                counter++;
            }

            i++;
        }

        Console.WriteLine();

        i = 2;
        j = 2;
        counter = 0;
        do {
            Boolean prime = true;

            for (j = 2; j < i; j++)
            {
                if (i % j == 0) prime = false;
            }

            if (prime)
            {
                Console.Write(i + " ");
                counter++;
            }

            i++;
        } while (counter < 1000);
    }

    public static void exercise10() {
        Console.Write("\nWprowadz wielkosc piramidy: ");
        int n = int.Parse(Console.ReadLine());

        for(int i=1;i<=n;i++) {
            int first = (int)Math.Pow(2, i);
            Console.Write(first + ", ");

            for (int j=1;j<=i-1;j++) {
                Console.Write((first+j) + ", ");
            }

            Console.WriteLine();
        }
    }
}