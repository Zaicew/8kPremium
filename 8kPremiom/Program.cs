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


            var task3 = new Task3();
            Console.WriteLine("========================Task3.1========================");
            Console.WriteLine("Expect false... {0}", task3.Panagram("input"));
            Console.WriteLine("Expect true... {0}", task3.Panagram("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine("========================Task3.2========================");
            Console.WriteLine("Expect false... {0}", task3.Panagram2("input"));
            Console.WriteLine("Expect true... {0}", task3.Panagram2("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine("========================Task3.3========================");
            Console.WriteLine("Expect false... {0}", task3.Panagram3("input"));
            Console.WriteLine("Expect true... {0}", task3.Panagram3("The quick brown fox jumps over the lazy dog"));


            Console.WriteLine("========================Task4========================");
            int?[] tab = new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8 };
            int?[] tab2 = new int?[] { 6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5 };
            var task4 = new Task4();

            Console.WriteLine(task4.LeafSummary(tab));
            Console.WriteLine(task4.LeafSummary(tab2));

        }
    }
}
