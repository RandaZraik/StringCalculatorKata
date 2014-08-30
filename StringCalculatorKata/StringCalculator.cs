using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == String.Empty)
                return 0;

            return GetTokens(numbers).Sum(x => int.Parse(x));
        }

        public static IEnumerable<string> GetTokens(string numbers)
        {
            char delimiter = ',';
            numbers = numbers.Replace("\n", delimiter + "");

            if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2];
                numbers = numbers.Substring(4);
            }

            return numbers.Split(delimiter);
        }
    }
}
