using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Proxy_pattern
{
    public class Warehouse : IOrder
    {
        private Dictionary<string, int> stock;
        private string address;

        /* Constuctors and others attributes would go here
         ...
         */
        public void FulfillOrder(Order order)
        {
            foreach(Item item in order.itemList)
            {
                this.stock[item.sku] -= 1;
            }
            /* Process the order for shipment and delivery
             * ...
             */
        }
        public int CurrentInventory(Item item)
        {
            if (stock.ContainsKey(item.sku))
                {
                return stock[item.sku];
            }
            return 0;
        }
    }
}
