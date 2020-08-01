using System;

namespace TupleSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int> myTuple = new Tuple<string, int>("name", 5);
            var myTuple2 = new Tuple<double, int>(2.3, 2);
            var myTuple3 = Tuple.Create<string,int>("hello", 3);
            var myTuple4 = Tuple.Create("baby", 3.14);
            var myTupleR = Tuple.Create(1,2,3,4,5,6,7, Tuple.Create(8,9,10));

            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple2.Item1);
            Console.WriteLine(myTuple3.Item1);
            Console.WriteLine(myTuple4.Item1);
            Console.WriteLine(myTupleR.Rest.Item1.Item1);
        }
    }
}