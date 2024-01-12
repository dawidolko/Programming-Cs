using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Lab6.TASK1
{
    class TASK1
    {
        static void Main(string[] args)
        {
            const string filePath = "osoba.csv";
            var manager = new PersonManager(filePath);

            bool running = true;

            Console.WriteLine("\n\nZadanie 1\n\n");

            while (running)
            {
                Console.WriteLine("\nMenu Główne:");
                Console.WriteLine("1. Wyświetl dane");
                Console.WriteLine("2. Dodaj osobę");
                Console.WriteLine("3. Modyfikuj osobę");
                Console.WriteLine("4. Usuń osobę");
                Console.WriteLine("5. Wyjście z programu");

                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.DisplayPeople();
                        break;
                    case "2":
                        manager.AddPerson();
                        break;
                    case "3":
                        manager.ModifyPerson();
                        break;
                    case "4":
                        manager.DeletePerson();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } // Nowe pole, typ Adres powinien zostać zdefiniowany lub zmieniony na string
        public string Pesel { get; set; } // Zmienione z int na string, aby obsługiwać 11 znaków
        public string Email { get; set; }
    }

    public class PersonManager
    {
        private readonly string _filePath;

        public PersonManager(string filePath)
        {
            _filePath = filePath;
        }

        public void DisplayPeople()
        {
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Person>().ToList();
                    Console.WriteLine("\nDane odczytane z pliku CSV:");
                    foreach (var person in records)
                    {
                        Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Adres: {person.Address}, PESEL: {person.Pesel}, Email: {person.Email}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik CSV nie został znaleziony.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas odczytu danych: {ex.Message}");
            }
        }

        public void AddPerson()
        {
            try
            {
                var newPerson = new Person();

                Console.Write("Podaj imię: ");
                newPerson.FirstName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(newPerson.FirstName))
                {
                    throw new ArgumentException("Imię nie może być puste.");
                }

                Console.Write("Podaj nazwisko: ");
                newPerson.LastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(newPerson.LastName))
                {
                    throw new ArgumentException("Nazwisko nie może być puste.");
                }

                Console.Write("Podaj adres: ");
                newPerson.Address = Console.ReadLine();
                // Adres może wymagać bardziej złożonej walidacji w zależności od wymagań

                Console.Write("Podaj PESEL: ");
                newPerson.Pesel = Console.ReadLine();
                if (newPerson.Pesel.Length != 11 || !newPerson.Pesel.All(char.IsDigit))
                {
                    throw new ArgumentException("PESEL musi składać się z 11 cyfr.");
                }

                Console.Write("Podaj adres e-mail: ");
                newPerson.Email = Console.ReadLine();
                if (!newPerson.Email.Contains("@") || !newPerson.Email.Contains("."))
                {
                    throw new ArgumentException("Nieprawidłowy format adresu e-mail.");
                }

                List<Person> people = ReadPeopleFromCsv(); // Wczytanie aktualnej listy osób
                people.Add(newPerson);                     // Dodanie nowej osoby do listy
                WritePeopleToCsv(people);                  // Zapisanie zmodyfikowanej listy osób do pliku CSV

                Console.WriteLine("Osoba została dodana.");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd podczas dodawania osoby: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }

        public void ModifyPerson()
        {
            try
            {
                Console.Write("Podaj PESEL osoby, którą chcesz zmodyfikować: ");
                string pesel = Console.ReadLine();

                // Wczytaj listę osób z pliku CSV
                List<Person> people = ReadPeopleFromCsv();

                // Znajdź osobę z podanym PESELem
                var person = people.FirstOrDefault(p => p.Pesel == pesel);
                if (person == null)
                {
                    throw new ArgumentException("Osoba o podanym PESELU nie istnieje.");
                }

                // Zmodyfikuj dane osoby
                Console.Write("Podaj nowe imię (obecne: {0}): ", person.FirstName);
                string newFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFirstName))
                {
                    person.FirstName = newFirstName;
                }

                // Powtórz dla innych pól, takich jak nazwisko, adres, email...

                // Zapisz zmodyfikowaną listę osób do pliku CSV
                WritePeopleToCsv(people);
                Console.WriteLine("Dane osoby zostały zaktualizowane.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }

        public void DeletePerson()
        {
            try
            {
                Console.Write("Podaj PESEL osoby do usunięcia: ");
                string pesel = Console.ReadLine();

                // Wczytaj listę osób z pliku CSV
                List<Person> people = ReadPeopleFromCsv();

                // Znajdź i usuń osobę z podanym PESELEM
                var personToRemove = people.FirstOrDefault(p => p.Pesel == pesel);
                if (personToRemove == null)
                {
                    throw new ArgumentException("Osoba o podanym PESELU nie istnieje.");
                }

                people.Remove(personToRemove);

                // Zapisz zmodyfikowaną listę osób do pliku CSV
                WritePeopleToCsv(people);
                Console.WriteLine("Osoba została usunięta.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }



        private List<Person> ReadPeopleFromCsv()
        {
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Person>().ToList();
                    return records;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas odczytu pliku CSV: {ex.Message}");
                return new List<Person>();
            }
        }

        private void WritePeopleToCsv(List<Person> people)
        {
            try
            {
                // Sprawdź, czy plik istnieje. Jeśli nie, utwórz go.
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine("Plik CSV nie istnieje. Tworzenie nowego pliku...");
                    File.Create(_filePath).Close(); // Tworzenie pliku i natychmiastowe zamknięcie uchwytu pliku
                }

                using (var writer = new StreamWriter(_filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(people);
                }
                Console.WriteLine("Zapisano dane do pliku CSV.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku CSV: {ex.Message}");
            }
        }


        private void ReadAndDisplayDataFromCsv()
        {
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Person>().ToList();
                    Console.WriteLine("\nDane odczytane z pliku CSV:");
                    foreach (var person in records)
                    {
                        Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Adres: {person.Address}, PESEL: {person.Pesel}, Email: {person.Email}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik CSV nie został znaleziony.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas odczytu danych: {ex.Message}");
            }
        }


        private void SearchDataInCsv(string searchTerm)
        {
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Person>()
                                     .Where(p => p.FirstName.Contains(searchTerm) || p.LastName.Contains(searchTerm))
                                     .ToList();

                    Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                    foreach (var person in records)
                    {
                        Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Adres: {person.Address}, PESEL: {person.Pesel}, Email: {person.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas przeszukiwania danych: {ex.Message}");
            }
        }

    }
}