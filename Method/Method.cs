using System;

namespace MethodSpace
{
    class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }
        public int multiply(int a, int b)
        {
            return a*b;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            //From static method: access to public method vs static method 
            Program pro = new Program();
            Console.WriteLine(pro.multiply(a,b));
            Console.WriteLine(sum(a,b));
        }

    }
}