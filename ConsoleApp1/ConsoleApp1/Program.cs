using System.Data.SQLite;
using System.Data;

string databasePath = "DB.sqlite";


// Create DB file
if (!File.Exists(databasePath))
{
    SQLiteConnection.CreateFile(databasePath);
    Console.WriteLine("DbCreated");
}

// Establish connection
var connectionString = $"Data Source={databasePath};Version=3";
using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    Console.WriteLine("Connected");
}





// Create table
using (SQLiteConnection connection2 = new SQLiteConnection(connectionString))
{
    connection2.Open();
    string createTableQuery = @"
                   CREATE TABLE IF NOT EXISTS Users(
                   Id INTEGER PRIMARY KEY AUTOINCREMENT,
                   Name TEXT NOT NULL, Age INTEGER NOT NULL 
                                );";
    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection2))
    {
        command.ExecuteNonQuery();
        Console.WriteLine("table created");
    }
}

// Insert data into table

using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    var insertData = @"
                        
                    ";
}

