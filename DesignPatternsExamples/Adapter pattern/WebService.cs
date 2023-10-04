namespace DesignPatternsExamples.Addapter_pattern
{
    public class WebService
    {
        private string webHost;

        public WebService(string webHost)
        {
            this.webHost = webHost;
        }

        internal Json Request(Json result)
        {
            throw new NotImplementedException();
        }
    }
}