using System;

namespace Params
{
    class program
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach(int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }

        public static string AddStr(params string[] ListString)
        {
            string full = "";
            foreach(string s in ListString)
            {
                full += s;
            }
            return full;
        }
        static void Main(string[] args)
        {
            int y = Add(1,2,3,4,5);
            string st = AddStr("ab", "cd", "ef");
            Console.WriteLine(y);
            Console.WriteLine(st);
        }
    }

}