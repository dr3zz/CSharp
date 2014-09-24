using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3D_Program

    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D("5.6","2.2","6.2");
           
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);
           
         
        }
    }
}
