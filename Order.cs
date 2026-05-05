using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartWarehouseUI_New
{
    public partial class Order : Form
    {
        string connString = "server=127.0.0.1;user=root;password=;database=smartwarehouse;";

        public Order()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadProducts();
        }

        // ================= LOAD SUPPLIERS =================
        private void LoadSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT supplier_id, supplier_name FROM supplier", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "supplier_name";
                comboBox1.ValueMember = "supplier_id";
            }
        }

        // ================= LOAD PRODUCTS =================
        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT product_id, name FROM products", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "product_id";
            }
        }

        // ================= SAVE ORDER =================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = Convert.ToInt32(comboBox1.SelectedValue);
                int productId = Convert.ToInt32(comboBox2.SelectedValue);
                int orderQty = Convert.ToInt32(textBox1.Text);

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // GET CURRENT STOCK
                    MySqlCommand stockCmd = new MySqlCommand(
                        "SELECT qty FROM products WHERE product_id = @pid", conn);

                    stockCmd.Parameters.AddWithValue("@pid", productId);

                    int currentStock = Convert.ToInt32(stockCmd.ExecuteScalar());

                    // STOCK WARNING
                    if (orderQty > currentStock)
                    {
                        DialogResult result = MessageBox.Show(
                            $"Only {currentStock} items available.\nDo you want to proceed?",
                            "Stock Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                    // INSERT INTO ORDERS
                    MySqlCommand cmd1 = new MySqlCommand(
                        "INSERT INTO orders (supplier_id) VALUES (@sid)", conn);

                    cmd1.Parameters.AddWithValue("@sid", supplierId);
                    cmd1.ExecuteNonQuery();

                    int orderId = (int)cmd1.LastInsertedId;

                    // ✅ FIXED HERE: quantity → qty
                    MySqlCommand cmd2 = new MySqlCommand(
                        "INSERT INTO order_details (order_id, product_id, qty) VALUES (@oid, @pid, @qty)", conn);

                    cmd2.Parameters.AddWithValue("@oid", orderId);
                    cmd2.Parameters.AddWithValue("@pid", productId);
                    cmd2.Parameters.AddWithValue("@qty", orderQty);

                    cmd2.ExecuteNonQuery();

                    // UPDATE STOCK
                    MySqlCommand updateStock = new MySqlCommand(
                        "UPDATE products SET qty = qty - @q WHERE product_id = @pid", conn);

                    updateStock.Parameters.AddWithValue("@q", orderQty);
                    updateStock.Parameters.AddWithValue("@pid", productId);

                    updateStock.ExecuteNonQuery();

                    MessageBox.Show("Order Saved Successfully!");

                    this.Hide();
                    new StockReport().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
