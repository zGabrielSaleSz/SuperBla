using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaParser.Model
{
    public class BlaContainer
    {
        public BlaMessagePar _messageHeader { get; private set; }
        private readonly string _message;
        public BlaContainer(string message)
        {
            _message = message;
            _messageHeader = new BlaMessagePar(_message);
        }

        public string Parse()
        {
            return _messageHeader.Parse();
        }

        public string Unparse()
        {
            return _messageHeader.Unparse();
        }
    }
}
