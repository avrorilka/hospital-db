using System;
using System.Data.SQLite;

namespace RegistryLib
{
    public class Model
    {
        public static SQLiteDataReader AllMembers(string statement)
        {
            string path = @"URI=file:.\hospital.db";

            var connection = new SQLiteConnection(path);
            connection.Open();

            var command = new SQLiteCommand(statement, connection);

            SQLiteDataReader readerData = command.ExecuteReader();

            return readerData;
        }
    }
}
