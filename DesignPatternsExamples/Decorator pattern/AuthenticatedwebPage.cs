using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Decorator_pattern
{
    public class AuthenticatedWebPage : WebPageDecorator
    {
        public AuthenticatedWebPage(IWebPage webPage) : base(webPage)
        {
        }
        public void AuthenticateUser()
        {
            Console.WriteLine("Authenticating user");
        }
        public new void Display()
        {
            base.Display();
            this.AuthenticateUser();
        }
    }
}
