using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Decorator_pattern
{
    public class BasicWebPage : IWebPage
    {
        private string html = "html";
        private string styleSheet = "styleSheet";
        private string scripts = "scripts";
        public void Display()
        {
            /* Renders the HTML to the stylesheet, and run any embedded scripts. */
            Console.WriteLine("Basic web page");
        }
    }
}
