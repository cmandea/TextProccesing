using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProccesing.lib
{
    public class LowerStringProcessingRule : ProcessingRule
    {
        public LowerStringProcessingRule(string textToLower) 
        {
            if (textToLower is null ) throw new ArgumentNullException();
            TextToLower = textToLower;

        }
        public string TextToLower { get; }
        public override string Processing(string input)
        {
            return TextToLower.ToLower();
        }
    }
}
