using System;
using System.Collections.Generic;
using System.Text;

namespace _8kPremiom
{
    class Task1
    {
        public int BinaryGap(int number)
        {
            int result = 0;
            int tmp = 0;
            string binaryNumber = ConvertoBinary(number);

            foreach (var item in binaryNumber)
            {
                if (item != '0') tmp = 0;
                else
                {
                    tmp++;
                    if (result < tmp) result = tmp;
                }
            }
            return result;
        }

        private string ConvertoBinary(int number)
        {
            string result = "";
            int tmp;
            while (number > 0)
            {
                tmp = number % 2;
                number /= 2;
                result = tmp.ToString() + result;
            }
            return result;
        }
    }
}
