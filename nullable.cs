using System;

//Nullable is a type
namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null;
            //print nothing
            Console.WriteLine(n);
            //0
            Console.WriteLine(n.GetValueOrDefault());


            int ? name = null;
            Console.WriteLine(name);
            Console.WriteLine(name.GetValueOrDefault());
                   

            int ? num = 42;
            Console.WriteLine(num);
            Console.WriteLine(num.GetValueOrDefault());

            Nullable<int> b = null;
            Nullable<int> c = 7;
            Console.WriteLine(b.HasValue);
            Console.WriteLine(c.HasValue);

            int ? d = null;
            int k = d ?? 3;
            Console.WriteLine(k);

        }
    }
}