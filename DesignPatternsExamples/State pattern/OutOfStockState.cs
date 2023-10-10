using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.State_pattern
{
    public class OutOfStockState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }
}
