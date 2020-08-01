using System;

namespace MethodParameter
{
    class Program
    {
     
        public static void addstr(string s1, string s2, string s3)
        {
            string r = s1 + s2 + s3;
            Console.WriteLine(r);
        }

        public static void addNum(ref int a)
        {
            a += a;
        }

        public static void divid(out int a)
        {
            a = 20;
            a /= 2;
        }
        public static void dyna(dynamic val)
        {
            Console.WriteLine(val);
        }
        public static void para(params object[] paramArray)
        {
            foreach(var i in paramArray)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void Main(string[] args)
        {
            //Name parameter
            Console.WriteLine("Name parameter: ");
            addstr(s1:"Today", s2:"is", s3:"good");
            addstr(s2:"is", s3:"good",s1:"Today");
           
            //ref parameter
            Console.WriteLine("Ref parameter: ");

            int a = 20;
            addNum(ref a);
            Console.WriteLine(a);

            //out parameter
            //ref vs out, initialisation of the variable.(int a = 20 or int a;)
            Console.WriteLine("out parameter: ");

            int b;
            divid(out b);
            Console.WriteLine(b);

            //default or optional param, at the end of the parameters
            
            //dynamic parameters
            Console.WriteLine("dynamic parameter: ");

            dyna(10);
            dyna(2.5);
            dyna("abc");

            //params parameters
            Console.WriteLine("Params parameter: ");

            object[] obj = {1, "nice", 2.6};
            para(obj);
        }
    }
}