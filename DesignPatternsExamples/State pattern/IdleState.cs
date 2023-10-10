using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.State_pattern
{
    public class IdleState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Dollar inserted");
            vendingMachine.SetState(vendingMachine.GetHasOneDollarState());
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("No money to return");
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Payment required");
        }
    }
}
