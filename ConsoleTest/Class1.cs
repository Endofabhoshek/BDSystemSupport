using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public delegate int BinaryOp(int x, int y);
    class Class1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example!!!!!!!");
            BinaryOp b = new BinaryOp(SimpleMath.Sub);
            b += SimpleMath.Add;

            Console.WriteLine("10+10 = {0}", b(10,10));
            b.GetInvocationList();
            foreach (Delegate d in b.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type name: {0}",d.Target);
            }

            Console.Read();
        }
    }
    class SimpleMath
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
