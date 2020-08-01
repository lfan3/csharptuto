using System;

namespace Delegates
{
    class Program
    {
        public delegate void Del(string message);

        public static void Method(string message)
        {
            Console.WriteLine(message);
        }
        public static int myMethod(int a, int b)
        {
            return a * b;
        }

        static void Main()
        {
            //Del is a type
            Del handler = Method;
            handler("delegate");
            Method("method");

            //short way to create a delegate function
            Func<int, int, int> multiple = myMethod;
            int result = multiple(2,5);
            Console.WriteLine(result);

            //Func with anonyme function
            Func<int, int, int> val = delegate(int x, int y)
            {
                return x + y;
            };
            int res = val(2,5);
            Console.WriteLine(res);
        }
    
    }
}