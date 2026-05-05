using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartWarehouseUI_New
{
    public partial class StockReport : Form
    {
        string connString = "server=127.0.0.1;user=root;password=;database=smartwarehouse;";

        public StockReport()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string q = @"SELECT 
                    sku,
                    name,
                    price,
                    qty,
                    CASE WHEN is_perishable=1 THEN 'Yes' ELSE 'No' END AS perishable
                    FROM products";

                MySqlDataAdapter da = new MySqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}