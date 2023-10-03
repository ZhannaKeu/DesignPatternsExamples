using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory_method
{
    public class KnifeFactory
    {
        public Knife CreateKnife(string knifeType)
        {
            Knife knife = new Knife();
            if (knifeType.Equals("steak"))
            {
                knife = new SteakKnife();
            }
            else
            if (knifeType.Equals("chefs"))
            {
                knife = new ChefsKnife();
            }
            return knife;
    }
}
