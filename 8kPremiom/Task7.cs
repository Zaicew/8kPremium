using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _8kPremiom
{
    class Task7
    {
        public Dictionary<char, int> RomanNumbers = new Dictionary<char, int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        public int RomanToInt(string input)
        {
            int output = 0;
            int actualBiggestCharacterTaken = 0;
            try
            {
                if (Regex.IsMatch(input, @"[^IVXLCDM]"))
                    throw new FormatException("Be sure you used only allowed letters : (I, V, X, L, C, D, M)");
                if (Regex.IsMatch(input, @"I{4}|C{4}|X{4}|M{4}"))
                    throw new FormatException("Input cannot contain more than 3 same letters next to each other : (I, X, C, M) ");
                if (Regex.IsMatch(input, @"V{2}|L{2}|D{2}"))
                    throw new FormatException("Input cannot contain 2 same characters close to each other : (V, L, D)");
                if (Regex.IsMatch(input, @"V[XLCDM]|L[CDM]|DM"))
                    throw new FormatException("Only characters (I, X, C) can stand before grater ones!");
                if (Regex.IsMatch(input, @"II[VXLCDM]|XX[LCDM]|CC[DM]"))
                    throw new FormatException("We cannot use two lower characters before grater one!");

                foreach (var item in input.Reverse())
                {
                    if (RomanNumbers.GetValueOrDefault(item) < actualBiggestCharacterTaken)
                    {
                        output -= RomanNumbers.GetValueOrDefault(item);
                    }
                    else
                    {
                        actualBiggestCharacterTaken = RomanNumbers.GetValueOrDefault(item);
                        output += actualBiggestCharacterTaken;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return output;
        }
    }
}
