namespace TextProccesing.lib
{
    public class InsertStringProcessingRule : ProcessingRule
        //pentru un sir dat sa se insereze un alt sir la o anumita pozitie
    {
        public InsertStringProcessingRule(string textInserted, int index)
        { //am nevoie de pozitia(Index) de unde se insereaza noul sir(TextInserted)  si de sirul care se insereaza
            if (textInserted is null) 
            {
            throw new ArgumentNullException(nameof(textInserted));
            }
            if (index<0) 
            {
                throw new ArgumentOutOfRangeException( nameof(index));
            }
            
            TextInserted = textInserted;
            Index = index;
        } 
        public string TextInserted { get; }
        public int Index { get; }

        public override string Processing(string input)
        {
            //trebuie sa testez si input pt null
            if (input is null)
            {
            throw new ArgumentNullException("Sirul in care se insereaza nu poate fi null.",nameof(input));
            }
            //mai trebuie sa validez daca idexul este >lungimea input-ului
            if (Index > input.Length) 
            {
                throw new IndexOutOfRangeException(nameof(Index));
            }
            string result = input.Insert(Index, TextInserted);
            return result;

        }
    }

  
}
