using Encrypt_Me.model;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics; 

namespace Encrypt_Me.services
{
    internal class Database
    {
        string urlDB = "";
        SqliteConnection connection = null;
        public Database()
        {
            getConfig();
        }

        public void getConfig()
        {
            try
            {

                Config config = new Config();
                this.urlDB = config.getConfig();


                if (File.Exists(this.urlDB))
                {
                    CreateConnection();
                }
                else
                {
                    Debug.WriteLine("The file does not exist.");
                    config.getDatabaseFile();
                    getConfig();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }

        public void CreateConnection()
        {
            try
            { 
                string connectionString = $"Data Source={this.urlDB};";  
                connection = new SqliteConnection(connectionString); 
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
        }

        public DataTable getUserData()
        {

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT * FROM user
            "
            ;

            using (var reader = command.ExecuteReader())
            {
                var dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }


        public void deleteUserData(string id)
        {

            connection.Open();

            // Update data in the table
            string tableName = "user";
            string updateQuery = $"DELETE from {tableName} where id = @id";

            // Create a command
            var command = connection.CreateCommand();
            command.CommandText = updateQuery;

            // Add parameters
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            Debug.WriteLine($"{rowsAffected} rows updated.");
            connection.Close();
        }

        public void insertUserData(string nama, string username, string password)
        {
            try
            {

                connection.Open();

                // encrpt password
                EncryptionService encryptionService = new EncryptionService();
                string secretKey = encryptionService.getSecretKeyUserData();
                ResultModel result = encryptionService.encryptToSHA256(password, secretKey);
                string hashedPasssword = result.getResult();

                // Update data in the table
                string tableName = "user";
                string updateQuery = $"INSERT into {tableName} (nama, username, password) values(@nama, @username, @password)";

                // Create a command
                var command = connection.CreateCommand();
                command.CommandText = updateQuery;

                // Add parameters
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPasssword);
                int rowsAffected = command.ExecuteNonQuery();

                Debug.WriteLine($"{rowsAffected} rows updated.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username already used");

            }
        }


        public void updateUserData(string id, string nama, string username, string password)
        {
            try {

                connection.Open();

                // encrpt password
                EncryptionService encryptionService = new EncryptionService();
                string secretKey = encryptionService.getSecretKeyUserData();
                ResultModel result = encryptionService.encryptToSHA256(password, secretKey);
                string hashedPasssword = result.getResult();

                // Update data in the table
                string tableName = "user";
                string updateQuery = $"UPDATE {tableName} set nama=@nama, username=@username, password=@password where id=@id";

                // Create a command
                var command = connection.CreateCommand();
                command.CommandText = updateQuery;

                // Add parameters
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPasssword);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();

                Debug.WriteLine($"{rowsAffected} rows updated.");
                connection.Close();
            }
            catch  ( Exception ex ) {
                MessageBox.Show("Username Already Used");
            }
        }
    }


}
