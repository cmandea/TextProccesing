namespace TextProccesing.lib
{
    public class ReplaceStringProcessingRule : ProcessingRule 
        //pentru un string data, sa se inlocuiasca toate aparitiile subsir1 cu un subsir2
        //subsir1>OldValue, subsir2>NewValue
    {
        //input > stringul inlocuit
        //am nevoie de textul CAUTAT  si textul NOU cu care inlocuiiesc CAUTAT
        //folosesc parametrii pentryu a nu strica generalizarea
         
        //cei 2 parametrii se vor initializa prin constructor

        public ReplaceStringProcessingRule(string oldValue,string newValue) 
        { 
            //testez constructorul  
            //testez daca oldValue is null > se arunca exceptia Null
            if (oldValue is null)
            {
                throw new ArgumentNullException(nameof(oldValue));
            }
            //testez daca oldValue is empty >se arunca o alta exceptie decat cea de la null
            if (string.IsNullOrEmpty(oldValue))
            {
                throw new ArgumentException("Valoare nu poate fi sir gol.",nameof(oldValue));
            }

            //pentru Replace> daca newValue e Null > face remove la tot ce-i oldValue
            OldValue = oldValue;
            NewValue = newValue;
        }
        public string OldValue { get; }
        public string NewValue { get; }
        public override string Processing(string input)
        {
            // folosesc Replace
            //Vezi validarea parametrilor
            if (input is null) 
            { 
            throw new ArgumentNullException($"input{nameof(input)}");
            }

            string Result = input?.Replace(OldValue, NewValue)?? string.Empty;
            return Result;
        }
    }
}
