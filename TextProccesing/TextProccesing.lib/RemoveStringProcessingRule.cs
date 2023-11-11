namespace TextProccesing.lib
{
    public class RemoveStringProcessingRule : ProcessingRule
        //pentru un sir dat "input" sa se elimine toate aparitiile unui subsir
    {

        public RemoveStringProcessingRule(string textRemoved) 
        {
            //trebuie verificat textRemoved >exceptie pe NULL
            if (textRemoved is null)
            {
                throw new ArgumentNullException(nameof(textRemoved));
            }
            if (string.IsNullOrEmpty(textRemoved))
            { 
            throw new ArgumentException("Sirul eliminat nu poate fi gol.",nameof(textRemoved));
            }

            TextRemoved= textRemoved;
          
              
        }

        public string TextRemoved { get; }
       

        public override string Processing(string input)
        {
            //folosind Remove se elimina caractere de la o pozitie start pana la stop
            //folosim Replace pentru ca daca se da NULL la NewValue se v-a elimina din "input" tot ce am in "TextRemoved"
            string result=input?.Replace(TextRemoved,null) ?? string.Empty;
           return result;
        }
    }
}
