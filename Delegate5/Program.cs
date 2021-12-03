using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate5
{
    class Program
    {
        delegate void GetMessage();
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Show_Message(GoodMorning);
            }
            else
            {
                Show_Message(GoodEvening);
            }
        }
        private static void Show_Message(GetMessage _del)// delegates as parametres of method
        {
            _del?.Invoke();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
