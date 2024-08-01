using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace inventory.test
{
    public class InventoryUnitTest
    {
        [Fact]
        public void AddNewProduct()
        {
            // Arrange
            var inventario = new Inventory();

            // Act
            inventario.AddProduct("Fiat Uno 1.0", 3);

            // Assert
            Assert.Equal(3, inventario.GetAmount("Fiat Uno 1.0"));
        }

        [Fact]
        public void IncreaseAmount()
        {
            // Arrange
            var inventario = new Inventory();
            inventario.AddProduct("Fiat Uno 1.0", 10);

            // Act
            inventario.AddProduct("Fiat Uno 1.0", 5);

            // Assert
            Assert.Equal(15, inventario.GetAmount("Fiat Uno 1.0"));
        }

        [Fact]
        public void GetAmountNull()
        {
            // Arrange
            var inventario = new Inventory();

            // Act
            var quantidade = inventario.GetAmount("Product don't exist...");

            // Assert
            Assert.Equal(0, quantidade);
        }
    }
}
