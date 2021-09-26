using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithEvents
{
    /// <summary>
    /// Do a calculator program  to perform different arrithematic operations 
    /// using delegate concept
    /// use the Anonymous method.
    /// use multicast Delegate
    /// </summary>

    delegate void MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you first number.");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter you second number.");
            int num2 = Int32.Parse(Console.ReadLine());

            Addition myAdd = new Addition();
            Subtraction mySub = new Subtraction();
            Divide myDiv = new Divide();


            MyDelegate myDelegate = new MyDelegate(myAdd.Add);
            MyDelegate myDelegate2 = new MyDelegate(mySub.Sub);
            MyDelegate myDelegate3 = (x, y) => 
                    { Console.WriteLine("Multiplication in Anonymous Func. Answ: " + (num1 * num2)); };

            #region METHOD 2
            //MyDelegate myDelegate2;
            //myDelegate2 = mySub.Sub;
            #endregion 

            Operations myOp = new Operations();
            myOp.performOperations(num1, num2, myDelegate); 
            //operation class => add class
            myOp.performOperations(num1, num2, myDelegate2);
            //operation class => sub class
            myOp.performOperations(num1, num2, myDelegate3);
            //operation class => NO MULTIPLY class == Anonym Func


            //multicast delegate
            Console.WriteLine("------Multicast Delgates------");
            MyDelegate myDelegate4 = new MyDelegate(myAdd.Add);
            myDelegate4 += mySub.Sub;
            myDelegate4 += myDiv.Div;

            myOp.performOperations(num1, num2, myDelegate4);

            Console.ReadLine();


            #region WITHOUT DELEGATE
            Console.WriteLine("------- Without delegates ------");
            myAdd.Add(num1, num2);
            mySub.Sub(num1, num2);

            Console.ReadLine();
            #endregion




        }
    }
}
