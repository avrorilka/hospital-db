using System;
using System.Data.SQLite;

namespace RegistryLib
{
    public class Model
    {
        public static SQLiteDataReader readerData;

        public static SQLiteConnection CreateConnection()
        {
            string path = @"URI=file:.\hospital.db";

            var connection = new SQLiteConnection(path);
            connection.Open();

            return connection;
        }
        public static void Closer(SQLiteDataReader reader)
        {
            if (reader.Read())
            {
                reader.Close();
            }
        }

       public static SQLiteDataReader AllMembers(string statement)
        {
            var connection = CreateConnection();
            var command = new SQLiteCommand(statement, connection);

            readerData = command.ExecuteReader();
            return readerData;
        }

        public static void EditMember(string statement)
        {
            var connection = CreateConnection();

            var command = new SQLiteCommand(statement, connection);
            Closer(readerData);
            command.ExecuteNonQuery();
        }

    }
}
