using LAB4.TASK1;
using LAB4.TASK2;
using LAB4.TASK3;

class Program
{
    static void Main()
    {
        // ZADANIE 1
        Console.WriteLine("\n\nZADANIE: 1\n\n");

        // Deklaracja listy
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(1, 2, 3, 4),
            new Triangle(5, 6, 7, 8),
            new Circle(9, 10, 11, 12)
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        // ZADANIE 2
        Console.WriteLine("\n\nZADANIE: 2\n\n");

        // Utworzenie i konfiguracja uczniów i nauczyciela
        Uczen uczen1 = new Uczen();
        uczen1.SetFirstName("Jan");
        uczen1.SetLastName("Kowalski");
        uczen1.SetPesel("03082803628"); // Pesel dla 18-letniego mężczyzny
        uczen1.SetSchool("Zespół Szkół Nr 1");
        uczen1.SetCanGoHomeAlone(true);

        Uczen uczen2 = new Uczen();
        uczen2.SetFirstName("Anna");
        uczen2.SetLastName("Nowak");
        uczen2.SetPesel("09221305432"); // Pesel dla 15-letniej kobiety
        uczen2.SetSchool("Zespół Szkół Nr 1");
        uczen2.SetCanGoHomeAlone(false);

        Nauczyciel nauczyciel = new Nauczyciel();
        nauczyciel.SetFirstName("Maria");
        nauczyciel.SetLastName("Wisniewska");
        nauczyciel.SetPesel("68090501234"); // Pesel dla 45-letniej kobiety
        nauczyciel.TytulNaukowy = "mgr";
        nauczyciel.PodwladniUczniowie.Add(uczen1);
        nauczyciel.PodwladniUczniowie.Add(uczen2);

        // Wywołanie metod
        Console.WriteLine(uczen1.Info());
        Console.WriteLine(uczen2.Info());

        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);

        // ZADANIE 3
        Console.WriteLine("\n\nZADANIE: 3\n\n");

        var osoby = new List<IOsobaa>
        {
            new Osobaa("Jan", "Nowak"),
            new Osobaa("Anna", "Kowalska"),
            new Osobaa("Piotr", "Zalewski")
        };

        var studenci = new List<StudentWSIiZ>
        {
            new StudentWSIiZ("Michał", "Borowski", "Informatyka", 2020, 2),
            new StudentWSIiZ("Katarzyna", "Wojcik", "Zarządzanie", 2019, 3)
        };

        osoby.WypiszOsoby();
        osoby.PosortujOsobyPoNazwisku();
        osoby.WypiszOsoby();

        foreach (var student in studenci)
        {
            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        }
    }
}