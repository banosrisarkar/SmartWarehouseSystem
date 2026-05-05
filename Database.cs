using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SmartWarehouseUI_New
{
    public class Database
    {
        private string connectionString =
            "server=127.0.0.1;port=3306;user=root;password=;database=smartwarehouse;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // 🔥 TEST CONNECTION
        public void TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("SUCCESS: Connected to MySQL!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED: " + ex.Message);
            }
        }

        // 🔐 LOGIN FUNCTION
        public bool ValidateUser(string email, string password)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE email=@e AND password=@p";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}