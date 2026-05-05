using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartWarehouseSystem;
using System;

namespace SmartWarehouseSystem.Tests
{
    [TestClass]
    public class WarehouseSystemTests
    {
        // ================= PRODUCT =================
        [TestMethod]
        public void Product_Should_Create_Correctly()
        {
            var p = new Product("SKU1", "Item1", 10m, 5);

            Assert.AreEqual("SKU1", p.Sku);
            Assert.AreEqual("Item1", p.Name);
            Assert.AreEqual(5, p.Qty);
        }

        [TestMethod]
        public void Product_Should_Update_Quantity()
        {
            var p = new Product("SKU2", "Item2", 10m, 10);

            p.UpdateQty(-3);

            Assert.AreEqual(7, p.Qty);
        }

        // ================= SUPPLIER =================
        [TestMethod]
        public void Supplier_Should_Create_Correctly()
        {
            var s = new Supplier(1, "SupplierA");

            Assert.AreEqual(1, s.SupplierID);
            Assert.AreEqual("SupplierA", s.Name);
        }

        // ================= ORDER =================
        [TestMethod]
        public void Order_Should_Create_With_Date()
        {
            var o = new Order(100);

            Assert.AreEqual(100, o.OrderID);
            Assert.IsTrue(o.Date <= DateTime.Now);
        }

        // ================= PERISHABLE =================
        [TestMethod]
        public void PerishableProduct_Should_Have_Valid_Expiry()
        {
            var p = new PerishableProduct(
                "SKU10",
                "Milk",
                5m,
                2,
                DateTime.Now.AddDays(5)
            );

            Assert.IsTrue(p.ExpiryDate > DateTime.Now);
        }

        // ================= STOCK LOGIC =================
        [TestMethod]
        public void Stock_Should_Be_Reduced_Correctly()
        {
            var p = new Product("SKU3", "Item3", 10m, 10);

            p.UpdateQty(-4);

            Assert.AreEqual(6, p.Qty);
        }
    }
}