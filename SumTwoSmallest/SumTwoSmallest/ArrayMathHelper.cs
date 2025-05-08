using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoSmallest
{
    public class ArrayMathHelper
    {
        public int SumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                throw new ArgumentException("The array must contain at least 2 elements");

            int firstMinVal = int.MaxValue;
            int secondMinVal = int.MaxValue;

            foreach (int n in numbers)
            {

                if (n < firstMinVal)
                {
                    secondMinVal = firstMinVal;
                    firstMinVal = n;
                }
                else if (n < secondMinVal)
                {
                    secondMinVal = n;

                }
            }

            return firstMinVal + secondMinVal;
        }
    }
}
