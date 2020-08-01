using System;
//extention class to a existing class/struct
//extention method should be static with the binding parameter
//static class and static method
namespace ExtentionSpace
{
    static class NewMethods
    {
        public static void M4(this Existing e)  
        { 
            Console.WriteLine("Method Name: M4"); 
        } 
        
        public static void M5(this Existing e, string info) 
        { 
            Console.WriteLine("Method Name: M5 " + info); 
        } 
    }

    class Program
    {
        static void Main()
        {
            Existing ex = new Existing();
            ex.M1();
            ex.M4();
            ex.M5("this is the info M5");
        }
    }

}