using System;
using System.Collections;

namespace ArrayListSpace
{
    class Program
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("three");
            list.Insert(1, 2);
            foreach(var ele in list)
            {
                Console.WriteLine(ele);
            }
        }

    }
}