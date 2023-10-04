using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Proxy_pattern
{
    public interface IOrder
    {
        public void FulfillOrder(Order order);
    }
}
