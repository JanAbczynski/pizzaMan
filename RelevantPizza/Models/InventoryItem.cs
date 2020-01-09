using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    public enum InventoryItemType
    {
        Size,
        Falvor,
        Topping,
        Sause,
        Cheese,
        Dough
    }

    public class InventoryItem
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public InventoryItemType Type { get; set; }
        public int QuantityRemaining { get; set; }
        public decimal PricePerUnit { get; set; }

    }
}
