using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples
{
    public class ExampleSingleton
    {
        // lazy construction 
        // the class variable is null if no instance is instantiated
        private static ExampleSingleton uniqueInstance = null;

        private ExampleSingleton() { }

        // lazy  constraction for the instance
        public static ExampleSingleton GetInstance() { 
            if (uniqueInstance == null)
                uniqueInstance = new ExampleSingleton();
            return uniqueInstance;
        }

    }
}
