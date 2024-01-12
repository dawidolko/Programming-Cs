using CsvHelper;
using System.Globalization;
using ExampleCSV;

string filePath = "sample.csv";

// Zapis danych do pliku CSV
WriteDataToCsv(filePath);

// Odczyt i wyświetlanie danych z pliku CSV
ReadAndDisplayDataFromCsv(filePath);

// Przeszukiwanie danych w pliku CSV
SearchDataInCsv(filePath, "John");

Console.ReadLine();

static void WriteDataToCsv(string filePath)
{
    List<Person> people = new List<Person>
    {
            new Person { FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { FirstName = "Alice", LastName = "Smith", Age = 30 },
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 22 }
        };

    using (var writer = new StreamWriter(filePath))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        csv.WriteRecords(people);
    }

    Console.WriteLine("Dane zapisane do pliku CSV.");
}

static void ReadAndDisplayDataFromCsv(string filePath)
{
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        var records = csv.GetRecords<Person>().ToList();

        Console.WriteLine("\nDane odczytane z pliku CSV:");
        foreach (var person in records)
        {
            Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Wiek: {person.Age}");
        }
    }
}

static void SearchDataInCsv(string filePath, string searchTerm)
{
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        var records = csv.GetRecords<Person>().Where(p => p.FirstName.Contains(searchTerm) || p.LastName.Contains(searchTerm)).ToList();

        Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
        foreach (var person in records)
        {
            Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Wiek: {person.Age}");
        }
    }
}