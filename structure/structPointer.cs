using System;

namespace structPtrSpace
{
    struct Student
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }
    };
    struct Professor
    {
        public int reference;
        public double mark;
        public char Letter{get; set;}
        public Professor(int r, double m, char c)
        {
            reference = r;
            mark = m;
            Letter = c;
        }
    };
    class Program
    {
        static void Main()
        {
            unsafe
            {
                Professor prof1 = new Professor(12, 1.5, 'a');
                Professor* prof_ptr1 = &prof1;
                Console.WriteLine(prof_ptr1->mark);
                Console.WriteLine(prof1.mark);
                Console.WriteLine((*prof_ptr1).mark);
                Console.WriteLine(prof_ptr1->Letter);


                //! ERROR, a pointer is not permitted to poit to a reference
                //! Or struc that contains reference and the referent type.
                //Student st1 = new Student(1, "Sam");
                //Student st2 = new Student(2, "Tim");
                //! Student contains String, can not use pointer
                //Student* ptr1 = &st1;
                //Student* ptr2 = &st2;
               
            }

        }
    }
}