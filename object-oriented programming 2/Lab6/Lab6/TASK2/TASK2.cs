using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Lab6.TASK2
{
    class TASK2
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            var manager = new PersonManager(connectionString);

            bool running = true;

            Console.WriteLine("\n\nZadanie 2\n\n");

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
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT FirstName, LastName, Address, Pesel, Email FROM People";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\nDane odczytane z bazy danych:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Imię: {reader["FirstName"]}, Nazwisko: {reader["LastName"]}, Adres: {reader["Address"]}, PESEL: {reader["Pesel"]}, Email: {reader["Email"]}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
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

                string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO People (FirstName, LastName, Address, Pesel, Email) VALUES (@FirstName, @LastName, @Address, @Pesel, @Email)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", newPerson.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", newPerson.LastName);
                        cmd.Parameters.AddWithValue("@Address", newPerson.Address);
                        cmd.Parameters.AddWithValue("@Pesel", newPerson.Pesel);
                        cmd.Parameters.AddWithValue("@Email", newPerson.Email);

                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Osoba została dodana do bazy danych.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd podczas dodawania osoby: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
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

                string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Sprawdź, czy osoba istnieje
                    string sqlCheck = "SELECT COUNT(1) FROM People WHERE Pesel = @Pesel";
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Pesel", pesel);
                        int exists = (int)cmdCheck.ExecuteScalar();
                        if (exists == 0)
                        {
                            throw new ArgumentException("Osoba o podanym PESELU nie istnieje.");
                        }
                    }

                    // Zaktualizuj dane osoby
                    Console.Write("Podaj nowe imię: ");
                    string newFirstName = Console.ReadLine();
                    Console.Write("Podaj nowe nazwisko: ");
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Podaj nowy adres:");
                    string newAddress = Console.ReadLine();
                    Console.WriteLine("Podaj nowy email:");
                    string newEmail = Console.ReadLine();
                    // Podobnie dla adresu i email...

                    string sqlUpdate = "UPDATE People SET FirstName = @FirstName, LastName = @LastName WHERE Pesel = @Pesel";
                    using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@FirstName", newFirstName);
                        cmdUpdate.Parameters.AddWithValue("@LastName", newLastName);
                        cmdUpdate.Parameters.AddWithValue("@Address", newAddress);
                        cmdUpdate.Parameters.AddWithValue("@Email", newEmail);
                        // Podobnie dla adresu i email...
                        cmdUpdate.Parameters.AddWithValue("@Pesel", pesel);

                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Dane osoby zostały zaktualizowane.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
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

                string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM People WHERE Pesel = @Pesel";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Pesel", pesel);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Osoba została usunięta.");
                        }
                        else
                        {
                            throw new ArgumentException("Osoba o podanym PESELU nie istnieje.");
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }
        private List<Person> ReadPeopleFromDatabase()
        {
            var people = new List<Person>();
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT FirstName, LastName, Address, Pesel, Email FROM People";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var person = new Person
                            {
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Pesel = reader["Pesel"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            people.Add(person);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Wystąpił błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }

            return people;
        }


        private void SavePeopleToDatabase(List<Person> people)
        {
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (var person in people)
                    {
                        string sql = "INSERT INTO People (FirstName, LastName, Address, Pesel, Email) VALUES (@FirstName, @LastName, @Address, @Pesel, @Email)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", person.LastName);
                            cmd.Parameters.AddWithValue("@Address", person.Address);
                            cmd.Parameters.AddWithValue("@Pesel", person.Pesel);
                            cmd.Parameters.AddWithValue("@Email", person.Email);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Wszystkie osoby zostały zapisane do bazy danych.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Wystąpił błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }


        private void ReadAndDisplayDataFromDatabase()
        {
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT FirstName, LastName, Address, Pesel, Email FROM People";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\nDane odczytane z bazy danych:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Imię: {reader["FirstName"]}, Nazwisko: {reader["LastName"]}, Adres: {reader["Address"]}, PESEL: {reader["Pesel"]}, Email: {reader["Email"]}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }



        private void SearchDataInDatabase(string searchTerm)
        {
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT FirstName, LastName, Address, Pesel, Email FROM People WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Imię: {reader["FirstName"]}, Nazwisko: {reader["LastName"]}, Adres: {reader["Address"]}, PESEL: {reader["Pesel"]}, Email: {reader["Email"]}");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void WritePeopleToDatabase(List<Person> people)
        {
            string connectionString = "Server=DAWID\\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (var person in people)
                    {
                        // Przykład zapytania INSERT (można dodać sprawdzenie czy osoba już istnieje i użyć UPDATE)
                        string sql = "INSERT INTO People (FirstName, LastName, Address, Pesel, Email) VALUES (@FirstName, @LastName, @Address, @Pesel, @Email)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", person.LastName);
                            cmd.Parameters.AddWithValue("@Address", person.Address);
                            cmd.Parameters.AddWithValue("@Pesel", person.Pesel);
                            cmd.Parameters.AddWithValue("@Email", person.Email);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Wszystkie osoby zostały zapisane do bazy danych.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Wystąpił błąd SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niespodziewany błąd: {ex.Message}");
            }
        }

    }
}