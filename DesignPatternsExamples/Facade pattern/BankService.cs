using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Facade_pattern
{
    public class BankService
    {
        private Dictionary<int, IAccount> bankAccounts;
        public BankService()
            {
            this.bankAccounts = new Dictionary<int, IAccount>();
        }
        public int CreateNewAccount(string type,decimal initAmout)
        {
            IAccount newAccount = null;
            switch (type)
            {
                case "chequing":
                    newAccount = new Chequing(initAmout); break;
                case "saving":
                    newAccount = new Saving(initAmout); break;
                case "investment":
                    newAccount = new Investment(initAmout); break;
            }
            if (newAccount!= null)
            {
                this.bankAccounts.Add(newAccount.GetAccountNumber(), newAccount);
                return newAccount.GetAccountNumber();
            }
            return -1;
        }
        public void TransferMoney(int to, int from,decimal amount)
        {
            IAccount toAccount = this.bankAccounts.GetValueOrDefault(to);
            IAccount fromAccount = this.bankAccounts.GetValueOrDefault(from);
            fromAccount.transfer(toAccount, amount);
        }
    }
}
