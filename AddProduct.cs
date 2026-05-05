using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartWarehouseUI_New
{
    public partial class AddProduct : Form
    {
        string connString = "server=127.0.0.1;user=root;password=;database=smartwarehouse;";

        public AddProduct()
        {
            InitializeComponent();

            dateTimePicker1.Enabled = false;
        }

        // ================= SAVE BUTTON =================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sku = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string priceText = textBox3.Text.Trim();
                string qtyText = textBox4.Text.Trim();

                // validation
                if (sku == "" || name == "" || priceText == "" || qtyText == "")
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Invalid price");
                    return;
                }

                if (!int.TryParse(qtyText, out int qty))
                {
                    MessageBox.Show("Invalid quantity");
                    return;
                }

                bool isPerishable = radioButton1.Checked;
                DateTime? expiry = null;

                if (isPerishable)
                    expiry = dateTimePicker1.Value;

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // 🔥 CHECK DUPLICATE SKU
                    MySqlCommand checkCmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM products WHERE sku = @sku", conn);

                    checkCmd.Parameters.AddWithValue("@sku", sku);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("SKU already exists!");
                        return;
                    }

                    // 🔥 INSERT PRODUCT
                    string query = @"INSERT INTO products 
                                    (sku, name, price, qty, is_perishable, expiry_date)
                                    VALUES 
                                    (@sku, @name, @price, @qty, @perishable, @expiry)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@sku", sku);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@perishable", isPerishable ? 1 : 0);
                    cmd.Parameters.AddWithValue("@expiry", isPerishable ? expiry : DBNull.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product saved successfully!");

                // 🔥 NEXT PAGE NAVIGATION (IMPORTANT)
                this.Hide();
                new Supplier().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= YES RADIO =================
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dateTimePicker1.Enabled = true;
        }

        // ================= NO RADIO =================
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                dateTimePicker1.Enabled = false;
        }

        // ================= SAFETY FIX =================
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}