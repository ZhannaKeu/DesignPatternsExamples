using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Proxy_pattern
{
    public class OrderFulfillment : IOrder
    {
        private List<Warehouse> warehouses;
        /* Constuctors and others attributes would go here
         ...
         */
        public void FulfillOrder(Order order)
        {
            /* For each item in a customer order, check each warehouse
             * to see if it is in stock.
             * If it is then create a new Order for the warehouse.
             * Else check the next warehouse.
             * Send the all the Orders to the warehouse(s) after you finish
             * iteration over all the item in the original order.   */
            foreach(Item item in order.itemList)
            {
                foreach(Warehouse warehouse in warehouses)
                {
                    // ...
                }
            }
        }
    }
}
