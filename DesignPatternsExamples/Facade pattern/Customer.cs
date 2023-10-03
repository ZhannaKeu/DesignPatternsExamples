using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Facade_pattern
{
    public class Customer
    {
        public static void Main(string[] args)
        {
            BankService myBankService = new BankService();
            int mySaving = myBankService.CreateNewAccount("saving", new decimal(500.00));
            int myInvestment = myBankService.CreateNewAccount("investment", new decimal(1000.00));
            myBankService.TransferMoney(mySaving, myInvestment, new decimal(300.00));
        }
    }
}
