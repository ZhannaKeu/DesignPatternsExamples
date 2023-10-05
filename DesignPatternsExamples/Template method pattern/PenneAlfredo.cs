using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Template_method_pattern
{
    public class PenneAlfredo : PastaDish
    {
        public override void AddGarnish()
        {
            Console.WriteLine("Add parsley");
        }

        public override void AddPasta()
        {
            Console.WriteLine("Add penne");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Add chicken");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Add Alfredo sauce");
        }
    }
}
