using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartWarehouseUI_New
{
    public partial class Screen : Form
    {
        string connString = "server=127.0.0.1;user=root;password=;database=smartwarehouse;";

        public Screen()
        {
            InitializeComponent();
        }

        // LOGIN
        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        // REGISTER + GO NEXT
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                if (email == "" || password == "")
                {
                    MessageBox.Show("Fill all fields");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO users (email, password) VALUES (@e, @p)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", password);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registered successfully!");

                // 🔥 THIS WAS MISSING
                this.Hide();
                new Dashboard().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}