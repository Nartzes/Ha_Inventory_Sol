using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha_Inventory
{
    class Shipper
    {
        private List<IShippable> _products = new List<IShippable>(10);
        public string Add(IShippable product)
        {
            _products.Add(product);
            return product.Product;
        }
        public (int, string) ListShipmentItems()
        {
            var itemCounts = new Dictionary<string, int>();
            foreach (var item in _products)
            {
                if (!itemCounts.ContainsKey(item.Product))
                {
                    itemCounts[item.Product] = 0;
                }
                itemCounts[item.Product]++;
            }

            var lastItem = itemCounts.LastOrDefault();
            if (lastItem.Key != null)
            {
                string itemName = lastItem.Key == "Cracker" ? "Crackers" : (lastItem.Value > 1 ? lastItem.Key + "s" : lastItem.Key);
                return (lastItem.Value, itemName);
            }
            else
            {
                return (0, string.Empty);
            }
        }


        public decimal ComputeShippingCharges()
        {
            decimal totalCost = 0;
            foreach (var item in _products)
            {
                totalCost += item.ShipCost;
            }
            return totalCost;
        }
    }
}