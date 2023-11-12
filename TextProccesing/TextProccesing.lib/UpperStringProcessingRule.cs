namespace TextProccesing.lib
{
    public class UpperStringProcessingRule : ProcessingRule
    {

        public UpperStringProcessingRule(string textToUpper) 
        {
            if (textToUpper is null)
            {
                throw new ArgumentNullException(nameof(textToUpper));
            }
            TextToUpper = textToUpper;
        }

        public string TextToUpper { get; }

      

        public override string Processing(string input)
        {
           /* if (TextToUpper.Length>0)
            { 
                return TextToUpper.ToUpper();
            }*/
            return TextToUpper.ToUpper();

        }
    }
}
