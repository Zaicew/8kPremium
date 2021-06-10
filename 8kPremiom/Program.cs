using System;
using System.Linq;

namespace _8kPremiom
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task1();
            Console.WriteLine("========================Task1========================");
            Console.WriteLine(task1.BinaryGapRegEx(10000));
            Console.WriteLine(task1.BinaryGapRegEx(1222));
            Console.WriteLine(task1.BinaryGapRegEx(12364));
            Console.WriteLine(task1.BinaryGapRegEx(12558));
            Console.WriteLine(task1.BinaryGapRegEx(339988));

            var task2 = new Task2();
            Console.WriteLine("========================Task2========================");
            Console.WriteLine(task2.CountJewelsInStones("z", "ZZ"));
            Console.WriteLine(task2.CountJewelsInStones("aA", "aAAbbb"));
        }
    }
}
