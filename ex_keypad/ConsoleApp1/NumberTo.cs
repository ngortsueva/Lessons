namespace ConsoleApp1_aspose
{
    public class NumberTo : IConvert
    {
        public char Number { get; }
        public string Symbols { get; }

        public NumberTo(char number, string symbols)
        {
            Number = number;
            Symbols = symbols;
        }

        public virtual char GetSymbol(string num)
        {
            if(num.Length <= Symbols.Length )
                return Symbols[num.Length-1];

            return Number;
        }
    }
}
