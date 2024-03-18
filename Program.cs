using System.Data;
using AdoNetDemo;
using Microsoft.Data.Sqlite;

const string connectionString = "Data Source=demo.db;";
using var db = new SqliteConnection(connectionString);
db.Open();
using var command = new SqliteCommand();
command.Connection = db;
command.CommandText = "SELECT * FROM table_persons";
using var result = command.ExecuteReader();

var persons = new List<Person>();

while (result.Read())
{
    persons.Add(new Person()
    {
        Id = result.GetInt32("id"),
        LastName = result.GetString("last_name"),
        FirstName = result.GetString("first_name"),
        DateOfBirth = result.GetDateTime("date_of_birth")
    });
}

foreach (var person in persons)
{
    Console.WriteLine(person);
}