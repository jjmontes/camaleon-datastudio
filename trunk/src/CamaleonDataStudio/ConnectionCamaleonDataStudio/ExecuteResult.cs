using System.Collections.Generic;

namespace ConnectionCamaleonDataStudio
{
    public class ExecuteResult
    {
        private IList<string> _messages;

        public ExecuteResult()
        {
            _messages = new List<string>();
        }

        public IEnumerable<string> Messages { get { return _messages; } }

        public dynamic Results { get; set; }
    }
}
