using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    public class OrderItemDetail
    {
        public enum OrderItemDetailType
        {
            Size,
            Falvor,
            Topping,
            Sause,
            Cheese,
            Dough
        }
        public int ID { get; set; }
        public OrderItemDetailType Type { get; set; }
        //public InventoryItem Item { get; set; }
    }
}
