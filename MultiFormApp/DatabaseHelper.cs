using System;
using System.Data;
using System.Data.SQLite;

namespace MultiFormApp
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=UserDatabase.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
                    )";
                
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert default admin user if no users exist
                string checkUsersQuery = "SELECT COUNT(*) FROM Users";
                using (var command = new SQLiteCommand(checkUsersQuery, connection))
                {
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    if (userCount == 0)
                    {
                        string insertAdminQuery = "INSERT INTO Users (Username, Password) VALUES ('admin', 'Admin123!')";
                        using (var insertCommand = new SQLiteCommand(insertAdminQuery, connection))
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPasswordComplex(string password)
        {
            if (password.Length < 8) return false;
            
            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;
            
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            }
            
            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
    }
}
