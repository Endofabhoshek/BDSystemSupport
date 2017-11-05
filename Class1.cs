using System;

namespace ConsoleTest
{
    public class A
    {
        public string Test()
        {
            return "A";
        }
    }

    public class B : A
    {
        public string Test()
        {
            return "B";
        }
    }

    public class C : A
    {
        public string Test()
        {
            return "C";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            Console.WriteLine("----------Below is a with new B");
            Console.WriteLine(a.Test());
            C a = new B();

            Console.WriteLine(a.Test());
            Console.WriteLine(b.Test());
            Console.WriteLine(c.Test());
            Console.WriteLine(a.Test());
            b.Test();
            Console.Read();
        }
    }
}