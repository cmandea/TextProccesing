using TextProccesing.lib;

namespace TextProccesing.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sirul Original
            string input = "Random String Creator Online is easy to use tool to generate String based on options such as number of rows of string";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Original Text is:\n{input}\n");

            //Inlocuire in sir
            TextProcessor processorReplaceRule = new TextProcessor(new ReplaceStringProcessingRule("String", "Text"));
            string result = processorReplaceRule.ApplyAllProcessingRule(input);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Replace 'String' with 'Text':\n{result}\n");
            
            //Eliminare din sir
            TextProcessor processorRemoveRule = new TextProcessor(new RemoveStringProcessingRule("Online"));
            result = processorRemoveRule.ApplyAllProcessingRule(input);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Remove 'Online':\n{result}\n");

            //Inserare in sir
            TextProcessor processorInsertRule = new TextProcessor(new InsertStringProcessingRule("XXxXXxX",11));
            result = processorInsertRule.ApplyAllProcessingRule(input);
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($"Insert string 'XXxXXxX':\n{result} \n");

            //Toate
            TextProcessor processorAllRules = new TextProcessor(new ReplaceStringProcessingRule("String", "Text"),
                                                                new RemoveStringProcessingRule("Online"),
                                                                new InsertStringProcessingRule("XXxXXxX",100)
                                                               );
            result = processorAllRules.ApplyAllProcessingRule(input);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Replace 'String' with 'Text' and Remove 'Online' and Insert 'XXxXXxX' from position 100:\n{result}\n");
            
            //string to Uppercase string
            string inputToUpper = "StrinG 123xK to UpperCase string";
            TextProcessor processorUpper = new TextProcessor(new UpperStringProcessingRule(inputToUpper));
            result = processorUpper.ApplyAllProcessingRule(inputToUpper);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Transform string to uppercase string  '{inputToUpper}' :\n{result}\n");

            //string to Lowercase string
            string inputToLower = "StrinG 123xK to UpperCase string";
            TextProcessor processorLower = new TextProcessor(new LowerStringProcessingRule(inputToLower));
            result = processorLower.ApplyAllProcessingRule(inputToLower);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Transform string to lowercase string  '{inputToLower}' :\n{result}");

        }
    }
}  