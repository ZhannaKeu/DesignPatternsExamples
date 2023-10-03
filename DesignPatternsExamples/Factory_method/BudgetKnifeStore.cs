using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory_method
{
    public class BudgetKnifeStore : KnifeStore
    {
        //up to any subclass of KnifeStore to define this method
        public override Knife CreateKnife(string knifeType)
        {
            if (knifeType.Equals("steak"))
            {
                return new BudgetSteakKnife();
            }
            else
            if (knifeType.Equals("chefs"))
            {
                return new BudgetChefsKnife();
            }
            else
                return null;
        }
    }
}
