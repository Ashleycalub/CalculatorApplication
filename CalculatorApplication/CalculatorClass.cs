using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg, T arg1);

    internal class CalculatorClass
    {
        public Formula<double> total;
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the delegate");
                total += value;
            }
            remove
            {
                Console.WriteLine("Remove the delegeate");
                total -= value;
            }
        }
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;

        }
        public double GetQoutient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
