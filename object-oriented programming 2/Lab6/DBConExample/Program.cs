using System;
using System.Data.SqlClient;


//string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SampleDB;Integrated Security=True";
string connectionString = "Data Source=DESKTOP-L0VQAOE;Initial Catalog=SampleDB;Integrated Security=True";

// Przykładowa tabela "People" w bazie danych
string createTableQuery = @"
            CREATE TABLE People
            (
                Id INT PRIMARY KEY IDENTITY(1,1),
                FirstName NVARCHAR(50),
                LastName NVARCHAR(50),
                Age INT
            )";

// Przykładowe dane
string[] names = { "John", "Alice", "Bob" };
string[] lastNames = { "Doe", "Smith", "Johnson" };
int[] ages = { 25, 30, 22 };

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    // Tworzenie tabeli (jeśli nie istnieje)
    using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
    {
        try
        {
            createTableCommand.ExecuteNonQuery();
            Console.WriteLine("Tabela People utworzona.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd przy tworzeniu tabeli: {ex.Message}");
        }
    }

    // Dodawanie danych do tabeli
    for (int i = 0; i < names.Length; i++)
    {
        string insertDataQuery = $"INSERT INTO People (FirstName, LastName, Age) VALUES ('{names[i]}', '{lastNames[i]}', {ages[i]})";

        using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
        {
            try
            {
                insertDataCommand.ExecuteNonQuery();
                Console.WriteLine($"Dodano osobę: {names[i]} {lastNames[i]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd przy dodawaniu danych: {ex.Message}");
            }
        }
    }

    // Odczyt danych z tabeli
    string selectDataQuery = "SELECT * FROM People";

    using (SqlCommand selectDataCommand = new SqlCommand(selectDataQuery, connection))
    {
        using (SqlDataReader reader = selectDataCommand.ExecuteReader())
        {
            Console.WriteLine("\nLista osób w bazie danych:");
            while (reader.Read())
            {
                string firstName = reader["FirstName"].ToString();
                string lastName = reader["LastName"].ToString();
                int age = Convert.ToInt32(reader["Age"]);

                Console.WriteLine($"Imię: {firstName}, Nazwisko: {lastName}, Wiek: {age}");
            }
        }
    }
}
