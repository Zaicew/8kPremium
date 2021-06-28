using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _8kPremiom
{
    class Task6
    {
        private Dictionary<char, int> Alphabet = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 },
            { 'D', 4 },
            { 'E', 5 },
            { 'F', 6 },
            { 'G', 7 },
            { 'H', 8 },
            { 'I', 9 },
            { 'J', 10 },
            { 'K', 11 },
            { 'L', 12 },
            { 'M', 13 },
            { 'N', 14 },
            { 'O', 15 },
            { 'P', 16 },
            { 'Q', 17 },
            { 'R', 18 },
            { 'S', 19 },
            { 'T', 20 },
            { 'U', 21 },
            { 'W', 22 },
            { 'V', 23 },
            { 'X', 24 },
            { 'Y', 25 },
            { 'Z', 26 }

        };
        public int TitleToNumber(string columnTitle)
        {
            if (Regex.IsMatch(columnTitle, @"[^a-zA-Z]") || columnTitle.Length > 3)
                throw new FormatException("Wrong Input! Use only 1-3 lenght combination A-Z letters");
            columnTitle.ToUpper();

            if (columnTitle.Length == 3)
                return (Alphabet.GetValueOrDefault(columnTitle[0]) * 676) + (Alphabet.GetValueOrDefault(columnTitle[1]) * 26) + Alphabet.GetValueOrDefault(columnTitle[2]);

            return columnTitle.Length == 2 ?
                Alphabet.GetValueOrDefault(columnTitle[0]) * 26 + Alphabet.GetValueOrDefault(columnTitle[1]) :
                Alphabet.GetValueOrDefault(columnTitle[0]);

        }

        public int TitleToNumber2(string columnTitle)
        {
            if (Regex.IsMatch(columnTitle, @"[^a-zA-Z]"))
                throw new FormatException("Wrong Input! Use only combination A-Z letters");
            columnTitle.ToUpper();
            int output = 0;
            int multiplier = 1;

            for (int i = columnTitle.Length - 1; i > -1; i--)
            {
                output += Alphabet.GetValueOrDefault(columnTitle[i]) * multiplier;
                multiplier *= 26;
            }
            return output;
        }
    }
}
