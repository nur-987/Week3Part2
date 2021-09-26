using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HcfLcmEvents
{
    delegate void operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first numbers to check");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second numbers to check");
            int num2 = Int32.Parse(Console.ReadLine());

            HcmLcmChecker myNumber = new HcmLcmChecker();
            myNumber.CalculationHcfComplete += MyNumber_CalculationHcfComplete;
            myNumber.CalculationLcmComplete += MyNumber_CalculationLcmComplete;

            myNumber.FindHcf(num1, num2);
            myNumber.FindLcm(num1, num2);

            Console.ReadLine();
        }

        private static void MyNumber_CalculationLcmComplete(int num)
        {
            Console.WriteLine("HCF of the 2 numbers is: " + num);
        }

        private static void MyNumber_CalculationHcfComplete(int num)
        {
            Console.WriteLine("LCM of the 2 numbers is: " + num);
        }
    }
}
