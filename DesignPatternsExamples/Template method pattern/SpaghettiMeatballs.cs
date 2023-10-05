using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Template_method_pattern
{
    public class SpaghettiMeatballs : PastaDish
    {
        public override void AddGarnish()
        {
            Console.WriteLine("Add parmesan cheese");
        }

        public override void AddPasta()
        {
            Console.WriteLine("Add spaghetti");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Add meatballs");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Add tomato sauce");
        }
    }
}
