using System;

namespace StaticClassSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.staticMethod();
        }
    }

    //static class
    static class StaticClass
    {
        //static data member
        //statt class does not contain instance constructor
        //static method
        //can not inherit

        public static string staticDataMember = "staticdatamember";

        //static methods contains only static data members, can not access non-static data
        public static void staticMethod()
        {
            //static code
            Console.WriteLine(staticDataMember);
        }

    }
    
}