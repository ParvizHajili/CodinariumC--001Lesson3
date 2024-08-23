using System.Text;

namespace Codinarium.OOP.Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //OOP 

            /*
             1) Abstraction
             2) Polymorphism
             3) Encapsulation
             4) Inheritance

             */

            /*
             
             obyekt => Noutbuk
             properties =>
            {
            Name: MSI
            SSD :512 gb
            Ram :32 gb

            }
             */
            // . access member operator

            //classlar referance typedir

            //field

            //fieldlər həmişə acces modifier olaraq
            //private olmalıdır.

            //Encapsulation => 
            //Dataların xaricə idarəli şəkildə
            //açılmağı və dataların kənardan
            //idarəli bir şəkildə qəbul edilməyidir.

            //Student student = new Student();

            //student.FirstName = "Nurlan";

            //Console.WriteLine(student.FirstName);

            //Pocket pocket = new Pocket();

            //pocket.Money = 50;

            //Console.WriteLine(pocket.Money);

            //Pocket pocket = new Pocket();
            //pocket.Money = 100;

            //Console.WriteLine(pocket.Money);



            //Student student = new Student();
            //student.FirstName = "Elçin";
            //student.Age = 22;
            //student.IsMarried = true;
            //student.EyeColor = "Mavi";
            //Console.WriteLine(student.EyeColor);
            //Console.WriteLine(student.CreatedDate);

            //student.Talking();



            Car car = new Car()
            {
                Marka ="Bmw",
                Model = "520",
                Color = "Black",
                Year = 2015,
                IsAirCondition = true,
            };

            Car car1 = new Car()
            {
                Marka = "Hyundai",
                Model = "Elantra",
                Color = "White",
                Year = 2015,
                IsAirCondition = true,
            };

            Console.WriteLine($"{car.Marka}, {car.Model}, {car.Color},{car.Year},{car.IsAirCondition}");
            Console.WriteLine($"{car1.Marka}, {car1.Model}, {car1.Color},{car1.Year},{car1.IsAirCondition}");
        }
    }

    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public bool IsAirCondition { get; set; }

    }


    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public byte Age { get; set; }
    //    public bool IsMarried { get; set; }
    //    public string EyeColor { get; set; } = "Qəhvəyi";
    //    public DateTime CreatedDate { get; set; } = DateTime.Now;


    //    public void Laughing()
    //    {
    //        Console.WriteLine("Student is laughing");
    //    }

    //    public void Talking()
    //    {
    //        Console.WriteLine("Student is talking");
    //    }
    //}

    //public class Pocket
    //{
    //    //backingfield

    //    //full property
    //    //private int money;
    //    //public int Money
    //    //{
    //    //    get
    //    //    {
    //    //        if (money > 100)
    //    //            return money / 10;
    //    //        else
    //    //            return money / 2;
    //    //    }
    //    //    set
    //    //    {
    //    //        money = value * 5;
    //    //    }
    //    //}


    //    //public int Money { get; set; }

    //    //public string FirstName { get; set; }

    //}


    //public class Student
    //{
    //    private string firstName;

    //    public string FirstName
    //    {
    //        get 
    //        {
    //            return firstName;
    //        }
    //        set 
    //        {
    //            firstName = value;
    //        }
    //    }

    //}
}
