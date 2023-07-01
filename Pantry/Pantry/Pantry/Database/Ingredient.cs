using System;
using System.Text;
using System.Data;
using System.Data.SQLite;
namespace Pantry.Database;

internal class Ingredient
{
    internal static void CreateConnection()
    {
        string connectionString = "Data Source=/home/zeref/Desktop/Projects/Pantry/Pantry/Pantry/Ingredients/Ingredient.db";

        
        // Create a new SQLite connection
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Create a table if it doesn't already exist
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Ingredients (Name TEXT PRIMARY KEY)";
            using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }

            // // Insert data into the table
            // string insertQuery = "INSERT INTO TableName (Id, Name) VALUES (1, 'John Doe')";
            // using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
            // {
            //     insertCommand.ExecuteNonQuery();
            // }

            // Close the connection
            connection.Close();
        }
        Console.WriteLine("Connected to the database");
    }
}