using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Calculator
{
    class DistanceCalculator
    {
        private double x;
        private double y;
        private double z;
        public double X
        {
            get
            {
                return this.x;
            }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get { return this.z; }
            set
            {
                
                this.z = value;
            }
        }
        public DistanceCalculator(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static string CalculateDistance(DistanceCalculator p1, DistanceCalculator p2)
        {
            double result = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.Z - p1.Z) * (p2.Z - p1.Z));
            return "Distance between p1 and p2 = " + result.ToString();
        }
    }
}
