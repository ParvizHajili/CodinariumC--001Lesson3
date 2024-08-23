using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP
            /*
             1.Encapsulation
             2.Inheritance
             3.Polimorphism
             4.Abstraction        
             */

            //miras veren sinif => base class
            //miras alan sinifler => derived class
            // : 
            //C#-da 1 classdan yalnizca 1 class miras 
            //ala biler.

            //inheritance chain 
            //name hiding


            //Human human = new Human();
            //human.Talking();

            //Student student = new Student();
            //student.FirstName = "Xalid";
            //student.GPA = 100;
            //student.Talking();

            //Teacher teacher = new Teacher();
            //teacher.Salary = 100;

            //var d = new D();
            //d.Test();

            //A a = new A();


            // class


            //overload ve override
            //virtual override 

            //this
            //base
            //Student student = new Student();
            //student.Talking();

            Teacher teacher = new Teacher();
            teacher.Talking();
        }
    }
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual void Talking()
        {
            Console.WriteLine("Human Talking");
            //some code
            //some code
            //some code
            //some code
            //some code
        }
    }

    public class Student : Human
    {
        public double GPA { get; set; }

        public override void Talking()
        {
            //base.Talking();

            Console.WriteLine("Student Talking");
        }
    }

    public class Mentor : Human
    {
        public byte GroupCount { get; set; }

        public override void Talking()
        {
            
            Console.WriteLine("Mentor Talking");
        }

    }

    public class Teacher : Human
    {
        public double Salary { get; set; }

        public override void Talking()
        {
            Console.WriteLine("Teacher Talking");
        }
    }
    //class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}

    //class B : A
    //{
    //    public B()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}

    //class C : B
    //{
    //    public C()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}

    //class D : C
    //{
    //    public D()
    //    {
    //        Console.WriteLine("D");
    //    }
    //}
}
