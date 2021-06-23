using System;
using System.Collections.Generic;
using System.Text;

namespace _8kPremiom
{
    class Task5
    {
        public bool CheckIfSumOfAnyTwoDifferentNumbersFromListEqualsK(List<int> numbers, int k)
        {
            for (int i = 0; i<numbers.Count; i++)
            {
                for(int j = 0; i < numbers.Count; j++)
                {
                    if (i == j) break;
                    if (numbers[i] + numbers[j] == k) return true;
                }
            }
            return false;
        }

    }
}
