using System;

namespace Structure {
    public struct Person
    {
        public string Name;
        public int Age;
    }  
    /**
        struct: value, constructor, method, value type
        */
    struct Rectangle
    {
        public double length;
        public double width;
        //constructor
        public Rectangle(double l = 1, double w = 1)
        {
            length = l;
            width = w;
        }
        //method
        public double Area()
        {
            return length * width;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Person P;
            P.Name = "jahon";
            P.Age = 25;
            Console.WriteLine(P.Name+" has "+P.Age+"years old.");
            
        //Rectangle struct
            Rectangle react1;
            react1.length = 200;
            react1.width = 50;

            Console.WriteLine("Area: {0}", react1.Area());

            Rectangle react2 = new Rectangle(200,40);
            Console.WriteLine("Area: {0}", react2.Area());

            //copie the value not the reference
            react2 = react1;
            react1.length = 600;
            Console.WriteLine("react2.length: {0}; react2.width: {1}",
            react2.length, react2.width);
            Console.WriteLine("Area: {0}", react1.Area());
            Console.WriteLine("Area: {0}", react2.Area());
        }
    }
}