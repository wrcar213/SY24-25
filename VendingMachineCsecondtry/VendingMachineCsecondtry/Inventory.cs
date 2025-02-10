using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCsecondtry
{
    internal class Inventory
    {
        private Dictionary<string, (decimal Price, int Stock)> products;

        public Inventory()
        {
            products = new Dictionary<string, (decimal Price, int Stock)>
            {
                { "Vending Machine 1", (2.25m, 5) },
                { "Vending Machine 2", (1.50m, 5) },
                { "Vending Machine 3", (0.75m, 5) },
                { "Vending Machine 4", (2.25m, 5) },
                { "Vending Machine 5", (0.25m, 5) },
                { "Vending Machine 6", (3.50m, 5) },
                { "Vending Machine 7", (1.25m, 5) },
                { "Vending Machine 8", (1.75m, 5) },
                { "Vending Machine 9", (1.00m, 5) },
                { "Vending Machine 10", (3.00m, 5) },
                { "Vending Machine 11", (2.75m, 5) },
                { "Vending Machine 12", (3.75m, 5) }
            };
        }
        

        public (decimal Price, int Stock) GetProductInfo(string productName)
        {
            if (products.TryGetValue(productName, out var productInfo))
            {
                return productInfo;
            }
            return (0, 0);
        }

        public bool PurchaseProduct(string productName)
        {
            if (products.ContainsKey(productName) && products[productName].Stock > 0)
            {
                products[productName] = (products[productName].Price, products[productName].Stock - 1);
                return true;
            }
            return false;
        }

        public bool IsProductAvailable(string productName)
        {
            return products.ContainsKey(productName) && products[productName].Stock > 0;
        }
    }
}
