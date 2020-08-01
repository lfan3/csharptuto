using System;

namespace Enum
{
    enum month
    {
        jan,
        feb,
        mar,
        apr
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)month.jan == 0);
            Console.WriteLine((int)month.feb == 1);
        }
    }
}