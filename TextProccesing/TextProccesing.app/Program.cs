using TextProccesing.lib;

namespace TextProccesing.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Random String Creator Online is easy to use tool to generate String based on options such as number of rows of string";

            Console.WriteLine($"Original Text is:\n{input}");

            TextProcessor processorReplaceRule = new TextProcessor(
                new ReplaceStringProcessingRule("String", "Text"));

            string result = processorReplaceRule.ApplyAllProcessingRule(input);
            Console.WriteLine($"Replace 'String' with 'Text':\n{result}");
            
            TextProcessor processorRemoveRule = new TextProcessor(
                          new RemoveStringProcessingRule("Online"));
            result = processorRemoveRule.ApplyAllProcessingRule(input);
            Console.WriteLine($"Remove 'Online':\n{result}");

            TextProcessor processorAllRules = new TextProcessor(
               new ReplaceStringProcessingRule("String", "Text"),
               new RemoveStringProcessingRule("Online"));

             result = processorAllRules.ApplyAllProcessingRule(input);
            
            Console.WriteLine($"Replace 'String' with 'Text' and Remove 'Online':\n{result}");
        }
    }
}  