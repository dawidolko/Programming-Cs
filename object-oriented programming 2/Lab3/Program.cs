using Lab3.TASK1;
using Lab3.TASK2;

class Program
{
    static void Main()
    {
        //ZADANIE 1
        Console.WriteLine("\n\nZadanie 1\n\n");

        List<Person> people = new List<Person>
        {
            new Reader("John", "Doe", 30),
            new Reviewer("Jane", "Doe", 25)
        };

        // Initialize some books
        Book book1 = new Book("Sample Book", new Person("Author", "One", 40), new DateTime(2001, 1, 1));
        AdventureBook book2 = new AdventureBook("Adventure Book", new Person("Author", "Two", 45), new DateTime(2005, 5, 5), "Adventure");
        DocumentaryBook book3 = new DocumentaryBook("Documentary Book", new Person("Author", "Three", 50), new DateTime(2010, 10, 10), "Science");

        // Cast to specific types to access AddBook method
        ((Reader)people[0]).AddBook(book1);
        ((Reader)people[0]).AddBook(book2);
        ((Reviewer)people[1]).AddBook(book3);

        foreach (var person in people)
        {
            person.View();
        }

        //ZADANIE 2
        Console.WriteLine("\n\nZadanie 2\n\n");

        SamochodOsobowy samochodOsobowy = new SamochodOsobowy();
        Samochod samochod1 = new Samochod("Toyota", "Corolla", "Hatchback", "Czerwony", 2010, 120000);
        Samochod samochod2 = new Samochod();

        samochodOsobowy.WyswietlInformacje();
        samochod1.WyswietlInformacje();
        samochod2.WyswietlInformacje();
    }
}