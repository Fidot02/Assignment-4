using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class delegate_methods
    {
     
        public void LogInputs(double a, double b)
        {
            Console.WriteLine($"You entered: {a} and {b}");
        }

        public void DisplayResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            if  (x < y)
            {
                throw new InvalidOperationException("Error! The first number is smaller than the second");
            }
            else
            {
                return x - y;
            }
        }

        public  bool IsPositive(double number)
        {
            return number >= 0;
        }




    }

}
