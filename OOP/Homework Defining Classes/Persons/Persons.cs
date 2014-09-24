using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            Person Gosho = new Person("Gosho", 15);
            Console.WriteLine(Gosho);
            Person Pencho = new Person("Pencho", 25, "email@");
            Console.WriteLine(Pencho);
        }
    }
}
