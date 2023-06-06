using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha_Inventory
{
    internal interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }

    }
}
