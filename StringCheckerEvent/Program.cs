using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckerEvent
{
    /// <summary>
    /// 4 .Write a C# program to create a function to input a string 
    /// and count number of words are present  in the string , 
    /// then  print them separately in an event.
    /// </summary>
    public delegate void stringCounting(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your sentence:");
            string input = Console.ReadLine();

            StringHelper myWord = new StringHelper();

            myWord.counterEvent += MyWord_counterEvent1;
            myWord.Count(input);

            Console.ReadLine();
        }

        private static void MyWord_counterEvent1(int num)
        {
            int answ = num;
            Console.WriteLine("The total num of words in the sentence are: " + answ);
        }
    }
}
