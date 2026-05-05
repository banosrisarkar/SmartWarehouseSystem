using System;

namespace SmartWarehouseSystem
{
    public class PerishableProduct : Product
    {
        public DateTime ExpiryDate { get; set; }

        public PerishableProduct(string sku, string name, decimal price, int qty, DateTime expiry)
            : base(sku, name, price, qty)
        {
            ExpiryDate = expiry;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
        }
    }
}