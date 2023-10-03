using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory_method
{
    public abstract class KnifeStore
    {

        public Knife OrderKnife(string knifeType)
        {
            Knife knife;
            // now creating a knife is a method in the class
            knife = CreateKnife(knifeType);

            // this is still the same as before
            knife.Sharper();
            knife.Polish();
            knife.Package();

            return knife;
        }

       public abstract Knife CreateKnife(string knifeType);
    }
}
