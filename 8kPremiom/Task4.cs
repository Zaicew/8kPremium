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
            if (input.Length > 10000 || input.Length < 1) 
                throw new ArgumentOutOfRangeException("Too many arguments! Input quantity should be between 1 and 10000!");
            if (input.Max() > 100 || input.Min() < 0)
                throw new ArgumentOutOfRangeException("One or more inputs are incorrect. Arguments should be between 0 and 100.");

            int counter = RowsQuantity(input.Length);
            int indexStart = IndexOfFirstElementInLastRow(counter);

            int output = 0;
            while(indexStart <= input.Length)
            {
                if (input[indexStart - 1] != null) { output += input[indexStart - 1].Value; }
                indexStart++;
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
    }
}