using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8kPremiom
{
    class Task2
    {
        public int CountJewelsInStones(string jewels, string stones)
        {
            int result = 0;

            foreach (var item in stones)
            {
                foreach (var element in jewels)
                {
                    if (element == item) result++;
                }
            }
            return result;
        }
    }
}
