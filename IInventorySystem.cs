using System.Collections.Generic;

namespace SmartWarehouseSystem
{
    public interface IInventorySystem
    {
        void AddProduct(Product product);
        void AddStock(string sku, int qty);
        void ShipOrder(string sku, int qty);
        Product FindItem(string sku);
        List<Product> GetAllProducts();
    }
}