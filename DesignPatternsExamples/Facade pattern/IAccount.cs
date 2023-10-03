using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Facade_pattern
{
    public interface IAccount
    {
        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
        public void Transfer(IAccount to, decimal amount);
        public int GetAccountNumber();
    }
}
