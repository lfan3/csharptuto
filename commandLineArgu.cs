using System;

namespace learning
{
    class Literal{
        public static void Main(string[] args)
        {
            if(args.Length>0){
                Console.WriteLine("The Args are : ");
                foreach(Object obj in args)
                {
                    Console.WriteLine(obj);
                    Console.WriteLine(obj.GetType());
                }
            }
        }
    }
}