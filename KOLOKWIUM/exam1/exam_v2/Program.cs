using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

        //    try
        //    {
        //        List<Student> students = new List<Student>
        //        {
        //            new Student("Anna ", "Nowak", 5),
        //            new Student("Karol", "Karolczuk", 2),
        //             new Student("Wiktoria", "Sosna", 5),
        //            new Student("Alicja", "Barlewicz", 2),
        //             new Student("Klaudia", "Waw", 5),
        //            new Student("Bob", "Smith", 2),
        //             new Student("Ela", "Ziobro", 5),
        //            new Student("Antonina", "Swiątek", 2),
        //             new Student("Aneta", "Ziobro", 5),
        //            new Student("Klaudia", "Swiątek", 2),

        //        };

        //        List<Worker> workers = new List<Worker>
        //        {
        //              new Worker("Anna ", "Nowak",34, 5),
        //            new Worker("Karol", "Karolczuk",12, 2),
        //             new Worker("Wiktoria", "Sosna",10, 5),
        //            new Worker("Alicja", "Barlewicz",300, 2),
        //             new Worker("Klaudia", "Waw",230, 5),
        //            new Worker("Bob", "Smith", 100,2),
        //             new Worker("Ela", "Ziobro", 200,5),
        //            new Worker("Antonina", "Swiątek",300, 2),
        //             new Worker("Aneta", "Ziobro", 689,5),
        //            new Worker("Klaudia", "Swiątek",300, 2),
        //            new Worker("Bob", "Johnson", 500, 8),
        //            new Worker("Eve", "Williams", 600, 7),
        //            //new Worker("InvalidFirstName", "InvalidLastName", -500, 9), // Przykład błędnych danych
        //        };

        //        // Wykorzystałam compare to 
        //        students.Sort((x, y) => x.Grade.CompareTo(y.Grade));
        //        Console.WriteLine("Studenci:");
        //        foreach (var student in students)
        //        {
        //            student.DisplayInfo();
        //        }

        //        // Sortowanie według stawki za godzzie
        //        workers.Sort((x, y) => y.MoneyPerHour().CompareTo(x.MoneyPerHour()));
        //        Console.WriteLine("\nPracownicy:");
        //        foreach (var worker in workers)
        //        {
        //            worker.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        //    }
        //}
        string connectionString = "Server=PC-108-09\\SQLEXPRESS;Database=KolokwiumDB;Trusted_Connection=True;";
            // tutaj dopasowywać trzeba stringa do wlasnego komputera w moim przypadku pc-108-09 poniewaz bylem na tym komputrze
            //na stanowisku.

            try // tu zacznam
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    while (true)
                    {
                        Console.WriteLine("Wybierz co chcesz zrobić:");
                        Console.WriteLine("1. Wyświetl listę studentów i pracowników");
                        Console.WriteLine("2. Dodaj nowego studenta");
                        Console.WriteLine("3. Dodaj nowego pracownika");
                        Console.WriteLine("4. Wyświetl dane studenta");
                        Console.WriteLine("5. Wyświetl dane pracownika");
                        Console.WriteLine("0. Zakończ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                // wyświetlenie listy studentów i pracowników
                                List<Student> students = new List<Student>();
                                using (SqlCommand command = new SqlCommand("SELECT * FROM Students", connection))
                                {
                                    SqlDataReader reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        string firstName = (string)reader["FirstName"];
                                        string lastName = (string)reader["LastName"];
                                        int grade = (int)reader["Grade"];
                                        students.Add(new Student(firstName, lastName, grade));
                                    }
                                    reader.Close();
                                }

                                List<Worker> workers = new List<Worker>();
                                using (SqlCommand command = new SqlCommand("SELECT * FROM Workers", connection))
                                {
                                    SqlDataReader reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        string firstName = (string)reader["FirstName"];
                                        string lastName = (string)reader["LastName"];
                                        decimal weekSalary = (decimal)reader["WeekSalary"];
                                        int workHoursPerDay = (int)reader["WorkHoursPerDay"];
                                        workers.Add(new Worker(firstName, lastName, weekSalary, workHoursPerDay));
                                    }
                                    reader.Close();
                                }

                                List<Human> combinedList = students.Cast<Human>().Concat(workers.Cast<Human>()).ToList();

                                List<Human> sortedCombinedList = combinedList.OrderBy(human => human.FirstName)
                                                                             .ThenBy(human => human.LastName)
                                                                             .ToList();

                                Console.WriteLine("Studenci i pracownicy:");
                                foreach (var human in sortedCombinedList)
                                {
                                    Console.WriteLine($"{human.FirstName} {human.LastName}");
                                }
                                Console.WriteLine(" ");
                                break;

                            case "2":
                                // dodawanie nowego studenta
                                Console.Write("Imię studenta: ");
                                string studentFirstName = Console.ReadLine();
                                Console.Write("Nazwisko studenta: ");
                                string studentLastName = Console.ReadLine();
                                Console.Write("Ocena studenta: ");
                                if (int.TryParse(Console.ReadLine(), out int studentGrade))
                                {
                                    if (studentGrade >= 0)
                                    {
                                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Students (FirstName, LastName, Grade) VALUES (@FirstName, @LastName, @Grade)", connection))
                                        {
                                            insertCommand.Parameters.AddWithValue("@FirstName", studentFirstName);
                                            insertCommand.Parameters.AddWithValue("@LastName", studentLastName);
                                            insertCommand.Parameters.AddWithValue("@Grade", studentGrade);
                                            insertCommand.ExecuteNonQuery();
                                            Console.WriteLine("Dodano nowego studenta.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ocena studenta nie może być ujemna.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowa ocena studenta.");
                                }
                                break;

                            case "3":
                                // dodawanie nowego pracownika 
                                Console.Write("Imię pracownika: ");
                                string workerFirstName = Console.ReadLine();
                                Console.Write("Nazwisko pracownika: ");
                                string workerLastName = Console.ReadLine();
                                Console.Write("Wynagrodzenie tygodniowe: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal workerWeekSalary))
                                {
                                    if (workerWeekSalary >= 0)
                                    {
                                        Console.Write("Godziny pracy dziennie: ");
                                        if (int.TryParse(Console.ReadLine(), out int workerWorkHoursPerDay))
                                        {
                                            if (workerWorkHoursPerDay >= 0)
                                            {
                                                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Workers (FirstName, LastName, WeekSalary, WorkHoursPerDay) VALUES (@FirstName, @LastName, @WeekSalary, @WorkHoursPerDay)", connection))
                                                {
                                                    insertCommand.Parameters.AddWithValue("@FirstName", workerFirstName);
                                                    insertCommand.Parameters.AddWithValue("@LastName", workerLastName);
                                                    insertCommand.Parameters.AddWithValue("@WeekSalary", workerWeekSalary);
                                                    insertCommand.Parameters.AddWithValue("@WorkHoursPerDay", workerWorkHoursPerDay);
                                                    insertCommand.ExecuteNonQuery();
                                                    Console.WriteLine("Dodano nowego pracownika.");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Godziny pracy dziennie nie mogą być ujemne.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nieprawidłowa ilość godzin pracy dziennie.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wynagrodzenie tygodniowe nie może być ujemne.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowe wynagrodzenie tygodniowe.");
                                }
                                break;

                            case "4":
                                // wyswietlanie danych studenta
                                Console.Write("Podaj numer studenta: ");
                                if (int.TryParse(Console.ReadLine(), out int studentId))
                                {
                                    using (SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE Id = @Id", connection))
                                    {
                                        command.Parameters.AddWithValue("@Id", studentId);
                                        SqlDataReader reader = command.ExecuteReader();
                                        if (reader.Read())
                                        {
                                            string firstName = (string)reader["FirstName"];
                                            string lastName = (string)reader["LastName"];
                                            int grade = (int)reader["Grade"];
                                            Console.WriteLine($"Imię: {firstName}, Nazwisko: {lastName}, Ocena: {grade}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nie znaleziono studenta o podanym numerze.");
                                        }
                                        reader.Close();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowy numer studenta.");
                                }
                                break;

                            case "5":
                                // wyswietlanie danych pracownika
                                Console.Write("Podaj numer pracownika: ");
                                if (int.TryParse(Console.ReadLine(), out int workerId))
                                {
                                    using (SqlCommand command = new SqlCommand("SELECT * FROM Workers WHERE Id = @Id", connection))
                                    {
                                        command.Parameters.AddWithValue("@Id", workerId);
                                        SqlDataReader reader = command.ExecuteReader();
                                        if (reader.Read())
                                        {
                                            string firstName = (string)reader["FirstName"];
                                            string lastName = (string)reader["LastName"];
                                            decimal weekSalary = (decimal)reader["WeekSalary"];
                                            int workHoursPerDay = (int)reader["WorkHoursPerDay"];
                                            Console.WriteLine($"Imię: {firstName}, Nazwisko: {lastName}, Wynagrodzenie tygodniowe: {weekSalary}, Godziny pracy dziennie: {workHoursPerDay}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nie znaleziono pracownika o podanym numerze.");
                                        }
                                        reader.Close();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowy numer pracownika.");
                                }
                                break;

                            case "0":
                                return;

                            default:
                                Console.WriteLine("Nieprawidłowy wybór. Wybierz ponownie.");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}
