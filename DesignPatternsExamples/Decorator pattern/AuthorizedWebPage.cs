using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Decorator_pattern
{
    public class AuthorizedWebPage : WebPageDecorator
    {
        public AuthorizedWebPage(IWebPage webPage) : base(webPage)
        {
        }
        public void AuthorizedUser()
        {
            Console.WriteLine("Authorizing user");
        }
        public new void Display()
        {
            base.Display();
            this.AuthorizedUser();
        }
    }
}
