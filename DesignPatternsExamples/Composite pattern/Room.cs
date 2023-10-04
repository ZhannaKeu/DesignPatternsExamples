using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Composite_pattern
{
    public class Room : IStructure
    {
        public string name;
        public Room(string name)
        {
            this.name = name;
        }
        public void Enter()
        {
            Console.WriteLine("You have entered the {0}", this.name);
        }
        public void Exit()
        {
            Console.WriteLine("You have left the {0}", this.name);
        }
        public string GetName()
        {
            return this.name;
        }
        public void Location()
        {
            Console.WriteLine("You are currently in the {0}", this.name);
        }
    }
}
