using System;

namespace Inheritance_example
{
    public class StudentAndTeacherTest
    {
        public static void Main(string[] args)
        {
            Person myPerson = new Person(); //kreiranje novog objekta1
            myPerson.Greet();

            Student myStudent = new Student(); //kreiranje novog objekta2
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.Study();

            Teacher myTeacher = new Teacher(); //kreiranje novog objekta3
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

        }
    }

    public class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int n) //parametri su u zagradi 
        {
            age = n;
        }
    }

    public class Student : Person //nasledjivanje osobina klase
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void showAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }

    public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}