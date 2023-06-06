using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha_Inventory
{
    internal class Crackers : IShippable
    {
        public decimal ShipCost { get; } = 0.57M;
        public string Product { get; } = "Cracker";

    }
}
