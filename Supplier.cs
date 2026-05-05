using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartWarehouseUI_New
{
    public partial class Supplier : Form
    {
        string connString = "server=127.0.0.1;user=root;password=;database=smartwarehouse;";

        public Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();

                if (name == "")
                {
                    MessageBox.Show("Enter supplier name");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO supplier (supplier_name) VALUES (@name)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Supplier Saved!");

                // 🔥 MOVE TO ORDER PAGE
                this.Hide();
                new Order().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}