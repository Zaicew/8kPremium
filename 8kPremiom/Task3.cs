using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _8kPremiom
{
    class Task3
    {
        public bool Panagram(string input)
        {
            if (input.Length > 999)
                throw new ArgumentOutOfRangeException("To many signs! Input should be shorter than 1000 chars!");

            string alphabet = "abcdefghijklmnopqrstuwvxyz";
            int counter = 0;

            foreach (var element in alphabet)
            {
                foreach (var item in input.ToLower())
                {
                    if (element == item)
                    {
                        counter++;
                        break;
                    }
                }
            }
            if (counter == 26)
                return true;
            return false;
        }

        public bool Panagram2(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuwvxyz";
            return input.Count() < 1000 ?
            !alphabet.Where(x => !input.ToLower().Contains(x)).Any() :
            throw new ArgumentOutOfRangeException("To many signs! Input should be shorter than 1000 chars!");
        }

        public bool Panagram3(string input)
        {
                return input.Count() < 1000 ?
                input.ToLower().ToHashSet().Count(x => x>= 'a' && x<='z').Equals(26) : 
                throw new ArgumentOutOfRangeException("To many signs! Input should be shorter than 1000 chars!");
        }
    }
}
