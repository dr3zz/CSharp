using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {
            Console.Write("Enter a number in range [{0} ... {1}]: ",start,end);
            int num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
          
            return num;
        }

        static void Main(string[] args)
        {
            
            int startNumber = 1;
            int endNumber = 100;
            int counter = 0;
            while (counter < 10)
            {
                try
                {
                    int curretNum = ReadNumber(startNumber, endNumber);
                    if (curretNum > startNumber-1)
                    {
                        startNumber = curretNum+1;
                        Console.WriteLine("Number " + (counter + 1) + ": " + (startNumber-1) );
                        counter++;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
              
                    
                }
                catch (FormatException )
                {

                    Console.WriteLine("Not a number");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number is out of range [{0}...{1}]",startNumber,endNumber);
                }
            }


        }
    }
}
