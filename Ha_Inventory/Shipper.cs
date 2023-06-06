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
        public void Add(IShippable product)
        {
            _products.Add(product);
            Console.WriteLine($"1 {product.Product} has been added");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadLine();
            Console.Clear();
            
        }

        public void ListShipmentItems()
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

            Console.WriteLine("Shipment manifest:");
            foreach (var item in itemCounts)
            {
                Console.WriteLine($"{item.Value} {(item.Key == "Cracker" ? "Crackers" : (item.Value > 1 ? item.Key + "s" : item.Key))}");
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