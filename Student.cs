using System;

namespace HelloWorld{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        public static int studentsNumb = 45;
        //constuctor should has the samename with
        public Student(string aname, string amajor, double agpa)
        {
            name = aname;
            major = amajor;
            gpa = agpa;
            studentsNumb++;
        }
        public static void sayHi()
        {
            Console.WriteLine("Hello");
        }

        public bool hasHoner()
        {
            if(gpa > 3.5)
                return true;
            return false;
        }
    }
}