using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.State_pattern
{
    public class HasOneDollarState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Releasing product");
            if (vendingMachine.GetCount() > 1)
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetIdleState());
            }
            else
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetOutOfStockState());
            }
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Returning money");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(vendingMachine.GetIdleState());
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Alreade have one dollar");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(vendingMachine.GetIdleState());
        }
    }
}
