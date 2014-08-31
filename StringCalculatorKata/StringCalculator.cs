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
            IEnumerable<string> tokens = GetTokens(numbers);

            HandleNegativeNumbers(tokens);

            return tokens.Sum(x => int.Parse(x) > 1000 ? 0 : int.Parse(x));
        }

        private static void HandleNegativeNumbers(IEnumerable<string> numbers)
        {
            string[] negNumbers = numbers.Where(x => int.Parse(x) < 0).ToArray();
            if (negNumbers.Length > 0)
                throw new Exception("negatives are not allowed: " + String.Join(",", negNumbers.ToArray()));
        }

        public static IEnumerable<string> GetTokens(string numbers)
        {
            string delimiter = ",";
            numbers = numbers.Replace("\n", delimiter);

            if (numbers.StartsWith("//["))
            {
                string delimiter_;
                bool moreDelimiters = true;

                numbers = numbers.Substring(2);
                while (moreDelimiters)
                {
                    int index = numbers.IndexOf(']');
                    delimiter_ = numbers.Substring(1, index - 1);
                    numbers = numbers.Substring(index + 1);
                    numbers = numbers.Replace(delimiter_, delimiter);

                    if (numbers[0] == ',')
                    {
                        moreDelimiters = false;
                        numbers = numbers.Substring(1);
                    }
                }
            }
            else if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2] + "";
                numbers = numbers.Substring(4);
            }

            return numbers.Split(delimiter.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
