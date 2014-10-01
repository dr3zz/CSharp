namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GenericListTest
    {
        static void Main(string[] args)
        {
            var customAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("This GenericList<T> class's version is {0}", customAttributes);
            GenericList<int> genericListInt = new GenericList<int>();
            genericListInt.Add(1);
            genericListInt.Add(2);
            genericListInt.Add(3);
            genericListInt.Add(4);
            genericListInt.Add(321315);
            genericListInt.Add(6);
            genericListInt.Add(7);
            genericListInt.InsertAt(10, 2);
            genericListInt.InsertAt(10, 2);
            genericListInt.Add(8);
            genericListInt.InsertAt(10, 2);
            if (genericListInt.Contains(321315))
            {
                Console.WriteLine("true");
            }

            Console.WriteLine("genericListInt Count = " + genericListInt.Count);
            GenericList<string> genericListString = new GenericList<string>();
            genericListString.Add("Pesho");
            genericListString.RemoveAt(1);
            genericListString.Add("Angel");
            genericListString.Add("Pesho");
            genericListString.InsertAt("Todor", 2);
            int m = genericListString.Find("Todor");
            Console.WriteLine("Fint at position " + m);
            Console.WriteLine("MIN => " + genericListInt.Min());
            Console.WriteLine("MAX => " + genericListInt.Max());
            Console.WriteLine(genericListString);

            
        }
    }
}
