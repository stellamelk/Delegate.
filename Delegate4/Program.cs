using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    class Program
    {
        delegate void Message();
        delegate int Operatino(int x, int y);
        static void Main(string[] args)
        {
            Message mes = Hello;
            //mes();
            mes.Invoke();
            Operatino op = Add;
            //op(3,4);
            mes.Invoke();
            Operatino op1 = Subtract;
            op1 += Multiply;
            op1 += Add;
            Console.WriteLine(op1(7,2));//Add(7,2) = 9
        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Subtract(int x, int y)
        {
            return x - y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
