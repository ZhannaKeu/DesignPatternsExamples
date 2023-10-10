using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.State_pattern
{
    public class VendingMachine
    {
        private IState idleState;
        private IState hasOneDollarState;
        private IState outOfStockState;

        private IState currentState;
        private int count;

        public VendingMachine(int count)
        {
            // make the needed states
            idleState = new IdleState();
            hasOneDollarState = new HasOneDollarState();
            outOfStockState = new OutOfStockState();
            if (count > 0)
            {
                currentState = idleState;
                this.count = count;
            }
            else
            {
                currentState = outOfStockState;
                this.count = 0;
            }
           }
        public void DoReleaseProduct()
        {
            throw new NotImplementedException();
        }
        public object GetOutOfStockState()
        {
            return outOfStockState;
        }
        public int GetCount()
        {
            return count;
        }
        public void SetState(IState state)
        {
            currentState = state;
        }
        public object GetIdleState()
        {
            return idleState;
        }
        public object GetHasOneDollarState()
        {
            return hasOneDollarState;
        }
        public void InsertDollar()
        {
                currentState.InsertDollar(this);
        }
        public void EjectMoney()
        {
            currentState.EjectMoney(this);
        }
        public void Dispese()
        {
            currentState.Dispense(this);
        }
        public void DoReturnMoney()
        {
            throw new NotImplementedException();
        }
    }
}
