using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace Encrypt_Me.services
{
    internal class Config
    {
        SqliteConnection connection = null;

        public Config() {
            try
            {
                string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.db");
                string connectionString = $"Data Source={databasePath};";
                Debug.WriteLine("-----------------------------------------------------------------------------");
                Debug.WriteLine(connectionString);
                connection = new SqliteConnection(connectionString);
            }
            catch (Exception ex) { 
                Debug.WriteLine(ex);
            
            }
        }
      

        public string getConfig()
        {
            
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT db_url FROM config
            ";
            string url = "";

            using (var reader = command.ExecuteReader())
            { 
                while (reader.Read())
                {
                    url = reader.GetString(0);

                }
            }
            connection.Close();
            return url;
        }

        public void getDatabaseFile()
        {
            string newUrlDb = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Database File";
                openFileDialog.Filter = "Database Files|*.db;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newUrlDb =  openFileDialog.FileName;
                }
            }
            Debug.WriteLine(newUrlDb);
            updateDatabaseUrl(newUrlDb);
        }

        public void updateDatabaseUrl(string urlNew)
        {

            connection.Open();

            // Update data in the table
            string tableName = "config";
            string updateQuery = $"UPDATE {tableName} SET db_url = @NewValue";

            // Create a command
            var command = connection.CreateCommand();
            command.CommandText = updateQuery;

            // Add parameters
            command.Parameters.AddWithValue("@NewValue", urlNew);  
            int rowsAffected = command.ExecuteNonQuery();

            Debug.WriteLine($"{rowsAffected} rows updated.");
            connection.Close(); 
        }

    }
}
