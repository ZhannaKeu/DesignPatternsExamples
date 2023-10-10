using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Command_pattern
{
    public class Command
    {
        public void Execute()
        {
            Console.WriteLine("Command execute");
        }
        public void Unexecute()
        {
            Console.WriteLine("Command unexecute");
        }        
        public bool IsReversible()
        {
            return false;
        }

    }
}
