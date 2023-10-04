using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Addapter_pattern
{
    public class WebAdapter : IWebRequester
    {
        private WebService service;
        public void Connect(WebService currentService)
        {
            this.service = currentService;
        }
        public int Request(object request)
        {
            Json result = this.toJson(request);
            Json responce = service.Request(result);
            if (responce != null)
            {
                return 200; //OK status code
            }
            return 500; //Server error status code
        }

        private Json toJson(object input)
        {
            throw new NotImplementedException();
        }
    }
}
