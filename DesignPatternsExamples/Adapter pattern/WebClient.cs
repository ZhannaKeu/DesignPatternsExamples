using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Addapter_pattern
{
    public class WebClient
    {
        private IWebRequester webRequester;

        public WebClient(IWebRequester webRequester)
        {
            this.webRequester = webRequester;
        }
        private Object MakeObject() 
        { 
            throw new NotImplementedException(); 
        }
        public void DoWork()
        {
            Object obj = MakeObject();
            int status = webRequester.Request(obj);
            if (status == 200)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not OK");
            }
        }
    }
}
