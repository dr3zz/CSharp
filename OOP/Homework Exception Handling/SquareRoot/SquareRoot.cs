using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        private static double GetSQRT(double number)
        {
            if (number < 0)
            {
                throw new ArithmeticException();
            }
            return Math.Sqrt(number);
        } 
        static void Main(string[] args)
        {
           
             
            Console.Write("Enter a positive integer number: ");
            string input = Console.ReadLine();
            try
            {
                int num =  Int32.Parse(input);
                double result = GetSQRT(num);
                Console.WriteLine("Square root for {0} = {1}",num,result);
               
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number");
                throw fe;
            }
            catch (ArithmeticException ae ) {
                Console.WriteLine("Invalid Number");
                throw ae;
            }
            catch (ArgumentOutOfRangeException ae) {
                Console.WriteLine("Invalid Number");
                throw ae;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
                 
        }
    }
}
