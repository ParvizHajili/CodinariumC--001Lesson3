namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*down casting
              up casting

             Association
             Aggregation 
             Composition
            */

            /*
             1. Encapsulation
             2. Inheritance
             3. Polymorphism
             4. Abstraction
             */

            //Polymorphism 2 novu movcuddur
            //1. Statik (overload)
            //2. Dinamik (override)

            //overload => compile time 
            //override => runtime


            //Polymorphism bir obyektin fərqli 
            //referanslarla işarələnməyidir.

            //hər bir tələbə bir insandır 
            //hər bir insan tələbə deyil
            //Human student = new Student();

            //Human teacher = new Teacher();

            //Sum(10, 40);

            /*
             is a
             has a 
             can do
             */

            /*
             sealed keywördü classın varislik
            xususiyyətini ləğv edir.
            Əgər bir class sealed keywördü ilə işarələnibsə o class
            miras verə bilmir. Ancaq ki miras ala bilir.
             */

            //Car bmw = new Bmw();
            //Car kia = new Kia();
            //Car hyundai = new Hyundai();
        }

        //sealed class B :A
        //{

        //}

        //class A 
        //{

        //}

        //public interface IStudent
        //{
        //    void GiveExam();
        //}

        //public interface ITeacher
        //{
        //    void CheckExam();
        //}

        //public interface IHuman
        //{
        //    void Talking();
        //    void Laughing();
        //    void Crying();
        //}

        //public interface ICar
        //{
        //    void Start();
        //    void Stop();
        //}

        //public class Notebook
        //{
        //    public string Name { get; set; }
        //}

        //public class Teacher
        //{
        //    public Notebook Notebook { get; set; }
        //}

        //class Driver
        //{
        //    public string FirstName { get; set; }
        //}

        //class Car
        //{
        //    public string Marka { get; set; }
        //    public string Model { get; set; }
        //    public string Color { get; set; }
        //    public string Fueltype { get; set; }
        //    public byte DoorCount { get; set; }

        //    //navigation property
        //    public Driver Driver { get; set; }
        //}


        //class Bmw : Car
        //{

        //}

        //class Hyundai : Car
        //{

        //}

        //class Kia : Car
        //{

        //}

        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}



        //class Human
        //{
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }

        //    public virtual void Talking()
        //    {
        //        Console.WriteLine("Talk");
        //    }
        //}

        //class Student : Human
        //{
        //    public override void Talking()
        //    {
        //        //some code
        //    }
        //}

        //class Teacher : Human
        //{

        //}
    }
}
