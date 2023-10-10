using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.State_pattern
{
    public interface IState
    {
        public void InsertDollar(VendingMachine vendingMachine);
        public void EjectMoney(VendingMachine vendingMachine);
        public void Dispense(VendingMachine vendingMachine);
    }
}
