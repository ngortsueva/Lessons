using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1_aspose
{
    public class Keypad
    {
        List<NumberTo> keypad;

        public Keypad()
        {
            keypad = new List<NumberTo>()
            {
                new Number0(),
                new Number1(),
                new NumberTo('2', "ABC"),
                new NumberTo('3', "DEF"),
                new NumberTo('4', "GHI"),
                new NumberTo('5', "JKL"),
                new NumberTo('6', "MNO"),
                new NumberTo('7', "PQRS"),
                new NumberTo('8', "TUV"),
                new NumberTo('9', "WXYZ")
            };
        } 

        public string Convert(string input)
        {
            string result = "";
            int pos = 0, j = 0;
            char sym;

            if(input.Length == 1)
            {
                NumberTo numbto = keypad.Where(n => n.Number == input[0]).FirstOrDefault();
                return numbto.GetSymbol(input).ToString();
            }

            for (int i = 0; i < input.Length; i++)
            {
                sym = input[i];

                if (sym == ' ')continue;

                j = 1;

                while (i < input.Length - 1 && input[i] == input[i + 1])
                {
                    i++;
                    j++;
                }
                
                NumberTo numbto = keypad.Where(n => n.Number == sym).FirstOrDefault();

                result += numbto.GetSymbol(input.Substring(pos, j));

                pos = i+1;            
            }
            return result;
        }        
    }
}
