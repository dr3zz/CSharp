namespace InterestCalculator
{
    using System;

    class InteresetCalculatorTest 
    {
        static void Main(string[] args)
        {
            InterestCalculator simple = new InterestCalculator(2500m, 7.2, 15, "simple");
            Console.WriteLine(simple);
            InterestCalculator compound = new InterestCalculator(500m, 5.6, 10, "compound");
            Console.WriteLine(compound);
            InterestCalculator test = new InterestCalculator(500m, 5.6, 10, "test");
            Console.WriteLine(test);
        }
    }
}
