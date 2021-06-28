using System;
using System.Collections.Generic;
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


            //Console.WriteLine("========================Task5========================");
            //var task5 = new Task5();
            //Console.WriteLine("Expect true... {0}", task5.CheckIfSumOfAnyTwoDifferentNumbersFromListEqualsK(new List<int>() { 2, 3, 4, 5 }, 7));
            //Console.WriteLine("Expect true... {0}", task5.CheckIfSumOfAnyTwoDifferentNumbersFromListEqualsK(new List<int>() { 10, 15, 3, 7 }, 17));
            //Console.WriteLine("Expect false... {0}", task5.CheckIfSumOfAnyTwoDifferentNumbersFromListEqualsK(new List<int>() { 10, 15 }, 17));

            Console.WriteLine("========================Task6========================");

            var task6 = new Task6();

            Console.WriteLine("Should be 1... {0}", task6.TitleToNumber("A")); 
            Console.WriteLine("Should be 26... {0}", task6.TitleToNumber("Z"));
            Console.WriteLine("Should be 27... {0}", task6.TitleToNumber("AA"));
            Console.WriteLine("Should be 702... {0}", task6.TitleToNumber("ZZ"));
            Console.WriteLine("Should be 703... {0}", task6.TitleToNumber("AAA"));
            Console.WriteLine("Should be 729... {0}", task6.TitleToNumber("ABA"));
            Console.WriteLine("Should be 1378... {0}", task6.TitleToNumber("AZZ"));
            Console.WriteLine("Should be 1379... {0}", task6.TitleToNumber("BAA"));
            // Console.WriteLine("Should be error!... {0}", task6.TitleToNumber("Z2"));


            Console.WriteLine("========================Task7========================");
            var task7 = new Task7();
            Console.WriteLine("From 'I' should be 1... {0}", task7.RomanToInt("LVIII"));
            Console.WriteLine("From 'V' should be 1... {0}", task7.RomanToInt("MCMXCIV"));
            Console.WriteLine("From 'X' should be 1... {0}", task7.RomanToInt("X"));
            Console.WriteLine("From 'L' should be 1... {0}", task7.RomanToInt("L"));
            Console.WriteLine("From 'C' should be 1... {0}", task7.RomanToInt("C"));
            Console.WriteLine("From 'D' should be 1... {0}", task7.RomanToInt("D"));
            Console.WriteLine("From 'M' should be 1... {0}", task7.RomanToInt("M"));
            Console.WriteLine("From 'IX' should be 1... {0}", task7.RomanToInt("IX"));
            Console.WriteLine("From 'LVIII' should be 1... {0}", task7.RomanToInt("LVIII"));
            Console.WriteLine("From 'MCMXCIV' should be 1... {0}", task7.RomanToInt("MCMXCIV"));
            Console.ReadKey();
            Console.WriteLine("Error! {0}", task7.RomanToInt("IIII"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("XXXX"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("CCCC"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("MMMM"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("VV"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("LL"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("DD"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("IIX"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("VX"));
            Console.WriteLine("Error! {0}", task7.RomanToInt("DM"));


        }
    }
}
