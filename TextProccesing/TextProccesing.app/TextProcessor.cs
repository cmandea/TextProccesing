using TextProccesing.lib;

namespace TextProccesing.app
{
    public class TextProcessor
    {
        public TextProcessor(params IProcessingRule[] rules)
        {
            Rules = rules;
        }


        public IProcessingRule[] Rules { get; }
        public string ApplyAllProcessingRule(string input) 
        {
            string result = input;
            foreach (IProcessingRule rule in Rules) 
            {
                result = rule.Processing(result);

            }
            return result;
        }
    }
}
