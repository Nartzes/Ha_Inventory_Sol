using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha_Inventory
{
    internal class Bicycles : IShippable
    {
        public decimal ShipCost { get; } = 9.50M;
        public string Product { get; } = "Bicycle";

    }
}
