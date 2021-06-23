using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8kPremiom
{
    class Task5
    {
        public bool CheckIfSumOfAnyTwoDifferentNumbersFromListEqualsK(List<int> numbers, int k)
        {
            for (int i = 0; i<numbers.Count; i++)
            {
                for(int j = i+1; i < numbers.Count; j++)
                {
                    if (i == j) break;
                    if (numbers[i] + numbers[j] == k) return true;
                }
            }
            return false;
        }
        //public bool IsSumExist03(List<int> numbers, int k)
        //{
        //    if (k % 2 == 0)
        //    {
        //        var i = numbers.IndexOf(k / 2);
        //        if ((i > -1))
        //        {
        //            if (numbers.IndexOf(k / 2, i + 1) > -1)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    var hashSetNumbers = numbers.ToHashSet().ToList();
        //    for (var i = 0; i < numbers.Count - 1; i++)
        //    {
        //        if (numbers.Contains(k - hashSetNumbers[i]))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

    }
}
