using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Decorator_pattern
{
    public class WebPageDecorator : IWebPage
    {
        protected IWebPage page;

        protected WebPageDecorator(IWebPage webPage)
        {
            this.page = webPage;
        }

        public void Display()
        {
            this.page.Display();
        }
    }
}
