using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3D
    {
        private string x;
        private string y;
        private string z;
        double number;
        private static string sPoint = "{x = 0, y = 0, z = 0}";
        public Point3D(string x, string y, string z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }
        public string X
        {
            get { return this.x; }
            set
            {
                if (!Double.TryParse(value, out number))
                {
                    throw new ArgumentException("Invalid input", "X");
                }
                this.x = value;
            }
        }
        public string Y
        {
            get { return this.y; }
            set
            {
                if (!Double.TryParse(value, out number))
                {
                    throw new ArgumentException("Invalid input", "Y");
                }
               
                this.y = value;
            }
        }
        public string Z
        {
            get { return this.z; }
            set
            {
                if (!Double.TryParse(value, out number))
                {
                    throw new ArgumentException("Invalid input", "Z");
                }
                  this.z = value;
            }
        }
        public static string StartingPoint
        {
            get
            {
                return Point3D.sPoint;
            }
        }

        public override string ToString()
        {
            string point3d = "{x = " + this.X + ", y = " + this.Y + ", z = " + this.Z + "}";
            return point3d;
        }
    }
}
