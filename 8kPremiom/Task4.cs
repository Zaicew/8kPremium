using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _8kPremiom
{
    class Task4
    { 

        public int LeafSummary(int?[] input)
        {
            if (input.Length>1000)
                throw new ArgumentOutOfRangeException("Too many arguments! Input should be shorter than 1000 items!");
            if (input.Max() > 100 || input.Min() < 0)
                throw new ArgumentOutOfRangeException("One or more inputs are incorrect. Arguments should between 0 and 100.");

            int counter = RowsQuantity(input.Length);
            int indexStart = IndexOfFirstElementInLastRow(counter);

            int output = 0;
            for (int i = indexStart; i <= input.Length; i++)
            {
                if (input[i - 1] != null)
                    output += input[i - 1].Value;
            }
        return output;
        }

        private int RowsQuantity(int totalElements)
        {
            int output = 0;

            while (totalElements >= 1)
            {
                totalElements = totalElements / 2;
                output++;
            }
            return output;
        }

        private int IndexOfFirstElementInLastRow(int input)
        {
            int output = 1;
            for (int i = 0; i < input - 1; i++)
            {
                output = output * 2;
            }
            return output;

        }

        private bool IsLenghtLowerThanThousand(int input)
        {
            return input < 1000 ?
                true :
                throw new ArgumentOutOfRangeException("Too many arguments! Input should be shorter than 1000 items!");
        }
    }
}