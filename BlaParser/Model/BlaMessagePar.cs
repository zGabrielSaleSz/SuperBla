using BlaParser.Core;
using System.Text;

namespace BlaParser.Model
{
    public class BlaMessagePar
    {
        public string _message;
        public Dictionary<uint, string> wordByIndex;
        public Dictionary<string, string> blaByWord;
        public Dictionary<int, string> _blaByASCII = new Dictionary<int, string>();
        public BlaMessagePar(string message)
        {
            if (message == null)
            {
                throw new Exception("null");
            }
            _message = message;
            blaByWord = new Dictionary<string, string>();
            wordByIndex = new Dictionary<uint, string>();
            BuildLetters();
        }

        private void BuildLetters()
        {
            _blaByASCII = new Dictionary<int, string>();
            for(int i = 0; i < BlaConstants.MAX_LATIN1+1; i++)
            {
                _blaByASCII[i] = BlaHandler.ConcatenateBla(i);
            }
        }

        public string Parse()
        {
            string[] splitResult = GetWords();
            BuildHeaderReferenceToParse(splitResult);
            StringBuilder completedMessage = new StringBuilder();
            BuildMessageHeader(completedMessage);
            BuildMessageBody(completedMessage);
            return completedMessage.ToString();
        }

        private void BuildHeaderReferenceToParse(string[] splitResult)
        {
            for (int i = 0; i < splitResult.Length; i++)
            {
                blaByWord.Add(splitResult[i], BlaHandler.ConcatenateBla(i));
            }
        }

        private void BuildMessageHeader(StringBuilder completedMessage)
        {
            if (blaByWord.ContainsKey(BlaConstants.BLA))
            {
                completedMessage.AppendLine(ParseReal(BlaConstants.BLA, BlaConstants.BLA));
                blaByWord.Remove(BlaConstants.BLA);
            }
            foreach(var bla in blaByWord)
            {
                completedMessage.AppendLine(ParseReal(bla.Key, bla.Value));
            }
            completedMessage.Append("\r\n\r\n");
        }

        private string ParseReal(string key, string blaMean)
        {
            StringBuilder sb = new StringBuilder();
            byte[] asciiBytes = Encoding.Latin1.GetBytes(key);
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                sb.Append(_blaByASCII[asciiBytes[i]]);
                sb.Append(' ');
            }
            sb.Append(blaMean);
            return sb.ToString();
        }

        private void BuildMessageBody(StringBuilder sb)
        {
            string messageBody = _message;
            foreach (var word in blaByWord)
            {
                if (word.Key != string.Empty)
                {
                    messageBody = messageBody.Replace(word.Key, word.Value);
                }
            }
            sb.AppendLine(messageBody);
        }

        internal string Unparse()
        {
            string[] sides = _message.Split("\r\n\r\n\r\n");
            if (sides.Length != 2)
            {
                throw new Exception($"Corrupted text to {nameof(Unparse)}");
            }
            string header = sides[0];
            UnderstandHeaderRow(header.Split("\r\n"));
            string body = sides[1];

            return GetMessage(body);
        }

        private string GetMessage(string body)
        {
            foreach(KeyValuePair<string, string> bla in blaByWord.Reverse())
            {
                body = body.Replace(bla.Value, bla.Key);
            }
            return body;
        }

        private void UnderstandHeaderRow(string[] rows)
        {
            foreach(var row in rows)
            {
                string[] splitResult = row.Split(' ');
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < splitResult.Length - 1; i++)
                {
                    string bla = splitResult[i];
                    int blaAmount = BlaHandler.TakeBlaAmount(bla);
                    char blaAmountAsChar = Convert.ToChar(blaAmount);
                    sb.Append(blaAmountAsChar);
                }
                blaByWord.Add(sb.ToString(), splitResult[splitResult.Length - 1]);
            }
        }

        private string[] GetWords()
        {
            string[]? a = _message.Split(" ")
                .GroupBy(b => b)
                .Select(b => b.Key)
                .ToArray();
            return a;
        }
    }
}
