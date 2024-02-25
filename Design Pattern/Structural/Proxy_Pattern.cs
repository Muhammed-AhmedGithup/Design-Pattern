using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern.Structural.Proxy_Pattern;

namespace Design_Pattern.Structural
{
    internal class Proxy_Pattern
    {
        public interface IOrder
        {
            public void fulfillOrder(Order order);
        }

        class Warhouse : IOrder
        {
            private Dictionary<string, int> stock;
            private string Address;

            
            public void fulfillOrder(Order order)
            {
                throw new NotImplementedException();
            }
            public int currentInventory(Item item)
            {
                if (stock.ContainsKey(item.sku))
                    return stock[item.sku];
                return 0;
            }

        }

        class OrderFulfillment : IOrder
        {
            private List<Warhouse> warehouses;

            public OrderFulfillment(List<Warhouse> warehouses)
            {
                this.warehouses = warehouses;
            }

            public void fulfillOrder(Order order)
            {
                throw new NotImplementedException();
            }
        }


        public class Order
        {

        }

    }

    
}
