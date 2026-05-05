namespace SmartWarehouseSystem
{
    public class Product
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; private set; }

        public Product(string sku, string name, decimal price, int qty)
        {
            Sku = sku;
            Name = name;
            Price = price;
            Qty = qty;
        }

        public void UpdateQty(int amount)
        {
            Qty += amount;
        }

        // ✅ FIX: required for console + tests
        public virtual void Display()
        {
            Console.WriteLine($"SKU: {Sku}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock: {Qty}");
        }
    }
}