using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Addapter_pattern
{
    public interface IWebRequester
    {
        public int Request(Object obj);
    }
}
