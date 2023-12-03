internal class Program {
    private static void Main(string[] args) {

        //Ex. 1
        Licz num = new Licz(1.6);
        Console.WriteLine(num.Dodaj(1.1));
        Console.WriteLine(num.Odejmij(4.3));
        num.Show();

        Console.WriteLine();

        //Ex. 2
        double[] tab = {1.1, 2.1, 1.7, 4, 7, 0, 2};
        Sumator sum = new Sumator(tab);
        Console.WriteLine(sum.Suma());
        Console.WriteLine(sum.SumaPodziel2());
        sum.show();
        Console.WriteLine();
        sum.printingByIndexes(1, 4);

        Console.WriteLine();

        //Ex. 3
        Date first = new Date(1992, 3, 26);
        first.print();
        first.AddWeek();
        first.print();

        Date second = new Date(2022, 9, 1);
        second.SubtractWeek();
        second.print();

        Console.WriteLine();

        //Ex. 4
        Liczba number = new("5");
        number.Print();
        number.Factorial();
        number.Multiplication(2);
        number.Print();
        number.Factorial();
    }
}