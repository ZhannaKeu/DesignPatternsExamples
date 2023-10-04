using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Composite_pattern
{
    public class Housing : IStructure
    {
        private List<IStructure> structures;
        private string address;

        public Housing(string address)
        {
            this.structures = new List<IStructure>();
            this.address = address;
        }
        public string GetName()
        {
            return this.address;
        }
        public int AddStructure(IStructure component)
        {
            this.structures.Add(component);
            return this.structures.Count - 1;
        }
        public IStructure GetStructure(int componentNumber)
        {
            return this.structures[componentNumber];
        }
        public void Location()
        {
            Console.WriteLine("You are currently in {0}. It has ", this.GetName());
            foreach(IStructure component in this.structures)
                Console.WriteLine(component.GetName());
        }
        public void Enter()
        {
            Console.WriteLine("You have entered the {0}", this.GetName());
        }
        public void Exit()
        {
            Console.WriteLine("You have left the {0}", this.GetName());
        }
    }
}
