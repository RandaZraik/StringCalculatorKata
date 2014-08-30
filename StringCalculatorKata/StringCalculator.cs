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

            return numbers.Split(',').Sum(x => int.Parse(x));
        }
    }
}
