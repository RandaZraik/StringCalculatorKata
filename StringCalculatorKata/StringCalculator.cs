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

            if (!numbers.Contains(','))
                return int.Parse(numbers);

            var nums = numbers.Split(',');
            return int.Parse(nums[0]) + int.Parse(nums[1]);
        }
    }
}
