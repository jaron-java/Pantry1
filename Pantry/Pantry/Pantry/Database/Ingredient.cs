using System;
using System.Text;
using System.Data;
using System.Data.SQLite;
namespace Pantry.Database;

internal class Ingredient
{
    internal static void CreateConnection()
    {
        string connectionString = @"Data Source=Ingredient.db";

        using var connection = new SqliteConnection(connectionString)
        connection.Open();
            
        var tableCmd = connection.CreateCommand();

        tableCmd.CommandText =
            @"CREATE TABLE Ingredients (
                    Name TEXT PRIMARY KEY,
                    )";

            tableCmd.ExecuteNonQuery();

            connection.Close();
        }
        Console.WriteLine("Connected to the database");
    }
}