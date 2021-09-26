using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithEvents
{
    class Addition
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Im from 'class'.... ");
            Console.WriteLine("Add answer: " + (a+b)); 
        }
    }

    class Subtraction
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("Im from 'class'.... ");
            if (a > b)
            {
                Console.WriteLine("Sub answer: " + (a - b));
            }
            else
            {
                Console.WriteLine("Your first number is smaller than second");
                Console.WriteLine("Answer will be a negative.");
                Console.WriteLine("Sub answer: " + (a - b));
            }
            
        }
    }
    class Divide
    {
        public void Div(int a, int b)
        {
            Console.WriteLine("Im from 'class'.... ");
            Console.WriteLine("Divide answer: " + (a / b));
        }
    }
}
