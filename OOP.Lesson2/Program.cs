using System.Text.Json.Serialization.Metadata;

namespace OOP.Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static constructor
            //tuple
            /*
             1.Encapsulation
             2.Abstraction
             3.Polymorphism
             4.Inheritance
             */

            //this
            //parametrless constructor
            //Console.WriteLine("Hello, World!");

            //Student student = new Student(10,"Pərviz");

            //Car car = new Car(5, 10, 15);
            //Console.WriteLine("Ad daxil edin");
            //string name = Console.ReadLine();

            //MyClass myClass = Test(25, "Xalid", true);

            //Console.WriteLine(myClass.Name);
            //Console.WriteLine(myClass.Age);
            //Console.WriteLine(myClass.IsStudent);

            //Deconstructor
            //(int a, int b) = new TestClass(10, 20);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Car car = new Car();
        }
        //dead zone
        //public static MyClass Test(byte age, string name, bool isStudent)
        //{
        //    MyClass myClass = new MyClass()
        //    {
        //        Name = name,
        //        Age = age,
        //        IsStudent = isStudent
        //    };

        //    return myClass;
        //}

        //public class MyClass
        //{
        //    public string Name { get; set; }
        //    public byte Age { get; set; }
        //    public bool IsStudent { get; set; }
        //}
    }
    //public class Car
    //{
    //    private Car()
    //    {

    //    }
    //}
    //public class MyClass
    //{
    //    //design pattern
    //    //Singleton (private)
    //    //birinci static constructor ise dusur. daha sonra 
    //    //ise diger constructorlar ise dusur.
    //    //static MyClass()
    //    //{

    //    //}


    //    //public MyClass()
    //    //{

    //    //}

    //    //public MyClass(int a)
    //    //{

    //    //}

    //    //public MyClass(string a)
    //    //{

    //    //}

    //    //public MyClass(bool b, int c)
    //    //{

    //    //}
    //}
    //ref ve out
    //public class TestClass
    //{
    //    public TestClass(int a, int b)
    //    {

    //    }

    //    public void Deconstruct(out int a, out int b)
    //    {
    //        a = 50;
    //        b = 100;
    //    }
    //}
    //public class Car
    //{
    //    //private string model;
    //    //public void Test(string model)
    //    //{
    //    //    this.model = model; 
    //    //}

    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }

    //    public Car(int x)
    //    {
    //        Console.WriteLine("X parametr alan constructor");
    //        X = x;
    //    }

    //    public Car(int x, int y) : this(x)
    //    {
    //        Console.WriteLine("X ve y parametr alan constructor");
    //        Y = y;
    //    }

    //    public Car(int x, int y, int z) : this(x, y)
    //    {
    //        Console.WriteLine("x y ve z paramtr alan constructor");
    //        Z = z;
    //    }
    //    //Garbage collector

    //    ~Car()
    //    {

    //    }
    //}

    //public class Student
    //{
    //    //public Student()
    //    //{

    //    //}

    //    public Student(string name)
    //    {
    //        Console.WriteLine("Ad qebul eden constructor");
    //    }

    //    public Student(int age,string name)
    //    {
    //        Console.WriteLine("Ad ve yas qebul eden constructor");
    //    }

    //    public Student (int age,string name,bool isStudent) 
    //    { 
    //    }
    //}
}
