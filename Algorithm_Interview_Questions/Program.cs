using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fibonacci
            //Fibonacci fb = new Fibonacci();

            //Console.WriteLine(fb.Recurrence(4)); // should give us 3
            //Console.WriteLine(fb.Recurrence(7)); // should give us 13

            //Console.WriteLine(fb.ReverseUsingRecurrenceMethod(13)); // should give us 7
            //Console.WriteLine(fb.ReverseUsingRecurrenceMethod(3)); // should give us 4
            #endregion

            #region Using Strings
            UsingStrings us = new UsingStrings();

            //Console.WriteLine(us.PalidromeUsingRecurrence("level")); // should give us TRUE
            //Console.WriteLine(us.PalidromeUsingRecurrence("rever")); // should give us TRUE
            //Console.WriteLine(us.PalidromeUsingRecurrence("true")); // should give us FALSE

            Console.WriteLine(us.PalindromeWithoutRecurrence("level")); // should give us TRUE
            Console.WriteLine(us.PalindromeWithoutRecurrence("rever")); // should give us TRUE
            Console.WriteLine(us.PalindromeWithoutRecurrence("true")); // should give us FALSE
            #endregion

            Console.Read();
        }
    }
}
