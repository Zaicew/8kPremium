using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _8kPremiom
{
    class Task8
    {
        public static Dictionary<char, char> Brackets = new Dictionary<char, char>()
        {
            {')','('},
            {']','['},
            {'}','{'}
        };
        public bool CheckBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in input)
            {
                if (item == '{' || item == '(' || item == '[')
                    stack.Push(item);
                else
                {
                    if (item == '}')
                    {
                        if (stack.Pop() != '{') return false;
                    }
                    if (item == ')')
                    {
                        if (stack.Pop() != '(') return false;
                    }
                    if (item == ']')
                    {
                        if (stack.Pop() != '[') return false;
                    }
                }
            }
            return true;
        }
        public bool CheckBracketsUsingDictionary(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in input)
            {
                if (item == '{' || item == '(' || item == '[')
                    stack.Push(item);
                else if (!stack.Pop().Equals(Brackets[item]))
                    return false;
            }
            if (stack.Count != 0)
            return false;

            return true;
        }
        public bool ValidateMathematicalExpression(string input)
        {
            string newString = input;
            string replacement = "";
            Regex r = new Regex(@"[\+\*\/\-]{0,1}\d+[\+\*\/\-]{0,1}");
             foreach (var item in r.Matches(input))
            {
               item.ToString();
               input = input.Replace(item.ToString(), "");
            }
            return CheckBracketsUsingDictionary(input);
        }
    }
}
