using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NumberUtility
{
    public class NumberCruncher
    {
        //public List<int> nums = new List<int>();

        public static int SumOfEvens(List<int> nums)
        {
            int result = 0;

            foreach (int num in nums)
                if (num % 2 == 0)
            {
                  
                  result += num;  
            }
               
            return result;
        }
    }
}
