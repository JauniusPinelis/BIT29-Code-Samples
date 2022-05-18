// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

SqlConnection cnn;
var connetionString = @"Server=.;Database=TestDatabase2;Trusted_Connection=True;";
cnn = new SqlConnection(connetionString);
cnn.Open();

string insertText = @"insert into Persons (PersonID, LastName, FirstName, Address)
    values (1, 'LastName1', 'FirstName', 'Address1')";

// Very Error-likely
//hard to pass data to sql from c#

var command = cnn.CreateCommand();
command.CommandText = insertText;
command.ExecuteNonQuery();

cnn.Close();

cnn.Open();


