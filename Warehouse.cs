using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SmartWarehouseSystem
{
    public class Warehouse : IInventorySystem
    {
        private const int MinimumThreshold = 5;
        private Database db = new Database();

        public delegate void LowStockHandler(string sku);
        public event LowStockHandler LowStockEvent;

        public void AddProduct(Product product)
        {
            using var conn = db.GetConnection();
            conn.Open();

            string query = "INSERT INTO products (sku, name, qty) VALUES (@sku, @name, @qty)";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@sku", product.Sku);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@qty", product.Qty);

            cmd.ExecuteNonQuery();
        }

        public Product FindItem(string sku)
        {
            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT sku, name, qty FROM products WHERE sku=@sku";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@sku", sku);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Product(
                    reader.GetString("sku"),
                    reader.GetString("name"),
                    0,
                    reader.GetInt32("qty")
                );
            }

            return null;
        }

        public void AddStock(string sku, int qty)
        {
            Product product = FindItem(sku);

            if (product == null) return;

            using var conn = db.GetConnection();
            conn.Open();

            string query = "UPDATE products SET qty = qty + @qty WHERE sku=@sku";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@sku", sku);

            cmd.ExecuteNonQuery();
        }

        public void ShipOrder(string sku, int qty)
        {
            Product product = FindItem(sku);

            if (product == null) return;

            if (product.Qty >= qty)
            {
                using var conn = db.GetConnection();
                conn.Open();

                string query = "UPDATE products SET qty = qty - @qty WHERE sku=@sku";
                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@sku", sku);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT sku, name, qty FROM products";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product(
                    reader.GetString("sku"),
                    reader.GetString("name"),
                    0,
                    reader.GetInt32("qty")
                ));
            }

            return products;
        }
    }
}