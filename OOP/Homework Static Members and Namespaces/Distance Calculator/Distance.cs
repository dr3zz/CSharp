using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Calculator
{
    class Distance
    {
        static void Main(string[] args)
        {
            DistanceCalculator p1 = new DistanceCalculator(-7, -4, 3);
            DistanceCalculator p2 = new DistanceCalculator(17, 6, 2.5);
            Console.WriteLine(DistanceCalculator.CalculateDistance(p1,p2));
        }
    }
}
