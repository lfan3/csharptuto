using System;

namespace TypeCast
{
    class program
    {
        public static void Main(string[] args)
        {
            int i= 57;
            long l = i;
            float f = l;
            Console.WriteLine(i.GetType());
            Console.WriteLine(l.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);

            double d = 52.3;
            int a = (int)d;
            Console.WriteLine(a);

            int c = 2;
            bool b = Convert.ToBoolean(c);
            Console.WriteLine(b);
        
        }
    }
    
}