using Encrypt_Me.model;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics; 

namespace Encrypt_Me.services
{
    internal class DatabaseEncrypt
    {
        // DATABASE FOR ENCRYPT MODULE

        string urlDB = "";
        SqliteConnection connection = null;
        public DatabaseEncrypt()
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
                Debug.WriteLine(this.urlDB);
                connection = new SqliteConnection(connectionString); 
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
        }

        public DataTable getData()
        {

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT * FROM encrypt_log
            "
            ;

            using (var reader = command.ExecuteReader())
            {
                var dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }
          

        public void insertData(string originalText, ResultModel res)
        {
            try
            {

                connection.Open();

                // get encrypt data
                string txt_bytesOfUtf8 = res.getBinaryBeforeHash();  // in binaries
                string txt_encryptionInBytes = res.getBinaryAfterHash(); // in binaries
                string txt_encrypt = res.getHashedString();
                string txt_result = res.getResult();
                string txt_totalBit = res.getTotalBit(); 

                // Update data in the table
                string tableName = "encrypt_log";
                string updateQuery = $"INSERT into {tableName} (text,total_bit,binary,sha256_binary,sha256_hexadecimal,result) values(@text,@total_bit,@binary,@sha256_binary,@sha256_hexadecimal,@result)";

                // Create a command
                var command = connection.CreateCommand();
                command.CommandText = updateQuery;

                // Add parameters 
                command.Parameters.AddWithValue("@text", originalText);
                command.Parameters.AddWithValue("@total_bit", txt_totalBit);
                command.Parameters.AddWithValue("@binary", txt_bytesOfUtf8);
                command.Parameters.AddWithValue("@sha256_binary", txt_encryptionInBytes);
                command.Parameters.AddWithValue("@sha256_hexadecimal", txt_encrypt);
                command.Parameters.AddWithValue("@result", txt_result);
                int rowsAffected = command.ExecuteNonQuery();

                Debug.WriteLine($"{rowsAffected} rows updated.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
         
    }


}
