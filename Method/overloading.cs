using System;

namespace MethodOverloading
{
    /** polymorphism: 
    * method overloading can be done by changing:
    * The number of parameters in two methods.
    * The data types of the parameters.
    * The Order of the parameters of methods.
    */
    //resumer: nombre, type, order
    class Program
    {
        public int sum(int a, int b)
        {
            return a+b;
        }
        public int sum(int a, int b, int c)
        {
            return a+b+c;
        }
        public double sum(double a, double b)
        {
            return a+b;
        }
        public void indentity(int id, string name)
        {
            Console.WriteLine($"{id} is {name}");
        }
        public void indentity(string name, int id)
        {
            Console.WriteLine($"{name} is {id}");
        }
        public static int Main(string[] args)
        {
            Program exe = new Program();
            //! error: can not convert string "1.2" directly ToInt32, convert to double then from double to int
            double d = Convert.ToDouble(args[0]);
            double e = Convert.ToDouble(args[1]);
            int a = Convert.ToInt32(d);
            int b = Convert.ToInt32(e);
            exe.indentity(1, "first");
            exe.indentity("second", 2);
            
            if(args.Length == 3)
            {
                int c = Convert.ToInt32(args[2]);
                Console.WriteLine(exe.sum(a,b,c));
                Console.WriteLine(args.Length);
                return 1;
            }
            Console.WriteLine(exe.sum(a,b));
            Console.WriteLine(exe.sum(e,d));
            
            return 1;
            
                
        }
    }
}