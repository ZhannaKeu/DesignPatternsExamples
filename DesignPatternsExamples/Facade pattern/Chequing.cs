using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Facade_pattern
{
    public class Chequing : IAccount
    {
        private decimal initAmout;

        public Chequing(decimal initAmout)
        {
            this.initAmout = initAmout;
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public int GetAccountNumber()
        {
            throw new NotImplementedException();
        }

        public void Transfer(IAccount to, decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
