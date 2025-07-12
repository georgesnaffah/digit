using System;
using System.Data.SqlClient;

namespace DigitizingSolution
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateTable()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(
                    "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Documents' and xtype='U') " +
                    "CREATE TABLE Documents (Id INT PRIMARY KEY IDENTITY, FilePath NVARCHAR(255), Category NVARCHAR(255))",
                    connection);
                command.ExecuteNonQuery();
            }
        }

        public void InsertDocument(string filePath, string category)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(
                    "INSERT INTO Documents (FilePath, Category) VALUES (@FilePath, @Category)",
                    connection);
                command.Parameters.AddWithValue("@FilePath", filePath);
                command.Parameters.AddWithValue("@Category", category);
                command.ExecuteNonQuery();
            }
        }
    }
}
