namespace CustomLINQExtensionMethods
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class LinqExtensionsTest
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            var listResult = list.WhereNot(x => x == 2);
            PrintCollection(listResult);
            List<string> listOfString = new List<string>() { "Ivan", "Pesho", "Maria" };
            var listOfStringResult = listOfString.WhereNot(x => x == "Maria");
            PrintCollection(listOfStringResult);
            var testRepeat = listOfString.Repeat(3);
            Console.WriteLine("Test Repeat");
            PrintCollection(testRepeat);
            List<string> firstList = new List<string>() { "Ball", "Goal", "Beer" };
            List<string> suffixList = new List<string>() { "ll", "al" };
            var result = firstList.WhereEndsWith(suffixList);
            PrintCollection(result);
        }

        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
