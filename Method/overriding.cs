using System;
/**
keyword: 
new
virtual + override
base: call method or constructor of baseclass, can not be used within a static method
*/

namespace OverridingSpace
{
    //Method overriding without using virtual and override modifiers
    class baseClass
    {
        public void show()
        {
            Console.WriteLine("base class");
        }
    }
    class derived: baseClass
    {
        //new keyword
        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }
    //Method overridding with virtual and override modifiers
    class parent
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class");
        }
    }
    class child : parent
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("+");
            Console.WriteLine("Child class");
        }
    }
    //base works with constructor of base class
    public class classA
    {
        int i, j;
        //default constructor
        public classA()
        {
            Console.WriteLine("Default constructor of classA");
        }
        //parameterized constructor
        public classA(int i, int j)
        {
            this.i = i;
            this.j = j;
            Console.WriteLine($"the params of constructor {i} and {j}");
        }
    }
    public class deriveClassA : classA
    {
        public deriveClassA() : base(){}
        public deriveClassA(int i, int j): base(i, j){}
    }
    class Program
    {
        static void Main()
        {
            //without virtual and override
            baseClass bc = new baseClass();
            //base
            bc.show();

            derived dc = new derived();
            //derive
            dc.show();

            bc = new derived();
            //base -- not good
            bc.show();
            Console.WriteLine();

            /**************************
            with virtual and override
            **************************/
            parent pc = new parent();
            pc.show();
            
            child cc = new child();
            cc.show();

            pc = new child();
            pc.show();
            Console.WriteLine();

            /**************************
            base + baseclass constructor
            **************************/

            deriveClassA dcc = new deriveClassA();
            deriveClassA dcc1 = new deriveClassA(1, 2);
        }
    }
}