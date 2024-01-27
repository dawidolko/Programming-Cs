using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumA
{
    using System;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    class Program
    {
        static string connectionString = @"Data Source=DAWID\SQLEXPRESS;Initial Catalog=KolokwiumADB;Integrated Security=True";

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Wybierz operację:");
                Console.WriteLine("1 - Wyświetl wszystkie kształty");
                Console.WriteLine("2 - Dodaj nowy kształt");
                Console.WriteLine("3 - Edytuj kształt");
                Console.WriteLine("4 - Usuń kształt");
                Console.WriteLine("5 - Zakończ program");

                string operacja = Console.ReadLine();

                switch (operacja)
                {
                    case "1":
                        WyswietlKsztalty();
                        break;
                    case "2":
                        DodajKsztalt();
                        break;
                    case "3":
                        EdytujKsztalt();
                        break;
                    case "4":
                        UsunKsztalt();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieznana operacja, spróbuj ponownie.");
                        break;
                }
            }
        }

        static void WyswietlKsztalty()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ksztalty";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, Typ: {reader["Typ"]}, Obwód: {reader["Obwod"]}, Pole: {reader["Pole"]}, Informacje: {reader["DodatkoweInformacje"]}");
                    }
                }
            }
        }

        static void DodajKsztalt()
        {
            Console.WriteLine("Podaj typ kształtu (Koło/Prostokąt):");
            string typ = Console.ReadLine();

            double obwod, pole;
            string dodatkoweInformacje;

            if (typ.Equals("Koło", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Podaj promień koła:");
                double promien = Convert.ToDouble(Console.ReadLine());
                obwod = 2 * Math.PI * promien;
                pole = Math.PI * Math.Pow(promien, 2);
                dodatkoweInformacje = $"promien={promien}";
            }
            else if (typ.Equals("Prostokąt", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Podaj długość boku A:");
                double bokA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj długość boku B:");
                double bokB = Convert.ToDouble(Console.ReadLine());
                obwod = 2 * (bokA + bokB);
                pole = bokA * bokB;
                dodatkoweInformacje = $"bokA={bokA}, bokB={bokB}";
            }
            else
            {
                Console.WriteLine("Nieznany typ kształtu. Dozwolone wartości to 'Koło' lub 'Prostokąt'.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Ksztalty (Typ, Obwod, Pole, DodatkoweInformacje) VALUES (@Typ, @Obwod, @Pole, @DodatkoweInformacje)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Typ", typ);
                    command.Parameters.AddWithValue("@Obwod", obwod);
                    command.Parameters.AddWithValue("@Pole", pole);
                    command.Parameters.AddWithValue("@DodatkoweInformacje", dodatkoweInformacje);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Kształt został dodany.");
                    }
                    else
                    {
                        Console.WriteLine("Nie udało się dodać kształtu.");
                    }
                }
            }
        }

        static void EdytujKsztalt()
        {
            Console.WriteLine("Podaj ID kształtu do edycji:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj nowy obwód kształtu:");
            double obwod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj nowe pole kształtu:");
            double pole = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj nowe dodatkowe informacje:");
            string info = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Ksztalty SET Obwod = @Obwod, Pole = @Pole, DodatkoweInformacje = @Info WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Obwod", obwod);
                    command.Parameters.AddWithValue("@Pole", pole);
                    command.Parameters.AddWithValue("@Info", info);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Kształt został zaktualizowany.");
                    }
                    else
                    {
                        Console.WriteLine("Nie udało się zaktualizować kształtu.");
                    }
                }
            }
        }

        static void UsunKsztalt()
        {
            Console.WriteLine("Podaj ID kształtu do usunięcia:");
            int id = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Ksztalty WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Kształt został usunięty.");
                    }
                    else
                    {
                        Console.WriteLine("Nie udało się usunąć kształtu.");
                    }
                }
            }
        }
    }
}
