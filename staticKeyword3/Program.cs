using System;

namespace staticKeyword3
{
    class Test
    {
        public void display1()
        {
            Console.WriteLine("Non static method");
        }
        public static void display2()
        {
            Console.WriteLine("Static method");
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Test t1 = new Test();
            t1.display1();
            Test.display2();
            Console.ReadLine();
        }
    }
}
