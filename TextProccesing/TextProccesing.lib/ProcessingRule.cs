namespace TextProccesing.lib
{
    public abstract class ProcessingRule : IProcessingRule
    {
        //clasa derivata din interfata
        // ...alt cod(in alte cazuri mai complexe) 
        public abstract string Processing(string input);
    }
        
}
