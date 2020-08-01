using System;
using System.Collections;
using System.Collections.Generic;

namespace ListSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList can contain all kinds of types
            //slow and create a mess vs List
            ArrayList list = new ArrayList();
            list.Add(6);
            list.Add("he");
            foreach(var a in list)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(6);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }


        }
    }
}