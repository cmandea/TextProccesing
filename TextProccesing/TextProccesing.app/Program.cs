using TextProccesing.lib;

namespace TextProccesing.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sirul Original
            string input = "Random String Creator Online is easy to use tool to generate String based on options such as number of rows of string";

            Console.WriteLine($"Original Text is:\n{input}");

            //Inlocuire in sir
            TextProcessor processorReplaceRule = new TextProcessor(new ReplaceStringProcessingRule("String", "Text"));
            string result = processorReplaceRule.ApplyAllProcessingRule(input);
            Console.WriteLine($"Replace 'String' with 'Text':\n{result}\n");
            
            //Eliminare din sir
            TextProcessor processorRemoveRule = new TextProcessor(new RemoveStringProcessingRule("Online"));
            result = processorRemoveRule.ApplyAllProcessingRule(input);
            Console.WriteLine($"Remove 'Online':\n{result}\n");

            //Inserare in sir
            TextProcessor processorInsertRule = new TextProcessor(new InsertStringProcessingRule("XXxXXxX",11));
            result = processorInsertRule.ApplyAllProcessingRule(input);
            Console.WriteLine($"Insert string 'XXxXXxX':\n{result} \n");

            //Toate
            TextProcessor processorAllRules = new TextProcessor(new ReplaceStringProcessingRule("String", "Text"),
                                                                new RemoveStringProcessingRule("Online"),
                                                                new InsertStringProcessingRule("XXxXXxX",100)
                                                               );

             result = processorAllRules.ApplyAllProcessingRule(input);
             Console.WriteLine($"Replace 'String' with 'Text' and Remove 'Online' and Insert 'XXxXXxX' from position 100:\n{result}");
        }
    }
}  