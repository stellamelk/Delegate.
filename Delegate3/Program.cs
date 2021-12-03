using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            Message mes1 = Hello;
            Message mes2 = WhatAreYouDoing;
            Message mes3 = mes1 + mes2;// combine delegates
            mes1 += HowAreYou; //mes1 points to two methods
            mes1(); // both methods are called
            mes1 -= HowAreYou; // delate HowAreYou method
            mes1(); //only Hello method is called
            
        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        private static void WhatAreYouDoing()
        {
            Console.WriteLine("What are you doing");
        }
    }
}
