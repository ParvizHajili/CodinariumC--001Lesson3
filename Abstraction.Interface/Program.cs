namespace Abstraction.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nəzəri
            /*
             Encapsulation
             Inheritance
             Polymorphism
             Abstraction           
             */

            //C#-da multiple inheritance dəstəklənmir.
            //Yəni 1 classdan yalnız 1 class miras ala bilər.
            //Amma 1 class və ya interfeys 1-dən çox
            //interfeysdən implement edə bilər.

            Console.WriteLine("Hello, World!");

            //CRUD

            /*
             C - Create
             R - Read
             U - Update
             D - Delete
             */

            //accessmodifier 

            //ProductCard card = new ProductCard();
            //card.

            //Teacher teacher = new Teacher();
            //Singleton design patterns

            //Human human = new Human();

            //Human teacher = new Teacher();
            //teacher.

            //Product card = new ProductCard();
            //card.GetType();
            #endregion

            //implicitly
            //explicitly
            //manual
            /*
             
             */
            //Lada lada = new Lada();

            //ISunRoof mercedes = new Mercedes();
            //mercedes.SunRoofClose();

            IMainOperation product = new Product();
            product.Test();

            IProductOperation product1 = new Product();
            product1.Test();
           
        }
    }

    public interface IProductOperation
    {
        void Test();
    }

    public interface IMainOperation
    {
        void Test();
    }

    public class Product : IProductOperation, IMainOperation
    {
        void IProductOperation.Test()
        {
            Console.WriteLine("IProductOperation test method");
        }

        void IMainOperation.Test()
        {
            Console.WriteLine("IMainOperation test method");
        }
    }


    //public interface ICar
    //{
    //    void Start();
    //    void Stop();
    //}

    //public interface IAirCondition
    //{
    //    void AirCondition();
    //}

    //public interface ISunRoof
    //{
    //    void SunRoofOpen();
    //    void SunRoofClose();
    //}

    //public abstract class BaseCar
    //{
    //    public string Model { get; set; }
    //    public string Color { get; set; }
    //    public byte DoorCount { get; set; }
    //    public DateTime CreatedYear { get; set; }
    //    public string FuelType { get; set; }
    //}


    //public class Bmw : BaseCar, ICar, IAirCondition, ISunRoof
    //{
    //    public void AirCondition()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void SunRoofClose()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void SunRoofOpen()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }
    //}

    //public class Mercedes : BaseCar, ICar,IAirCondition,ISunRoof
    //{
    //    public void AirCondition()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void SunRoofClose()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void SunRoofOpen()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }
    //}

    //public class Lada : BaseCar, ICar
    //{
    //    public void Start()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }
    //}

    //public class Hyundai : BaseCar, ICar, IAirCondition
    //{
    //    public void AirCondition()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("İşləyir");
    //    }
    //}
    #region Nəzəri
    //public interface ICategory
    //{
    //    void Add();
    //    void Update();
    //    void Delete();
    //}

    //public interface ITest
    //{

    //}

    //public interface ITest2
    //{

    //}

    //public class Category :BaseClass, ICategory, ITest, ITest2
    //{
    //    public void Add()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public class BaseClass
    //{
    //    public string Name { get; set; }
    //}

    //public class Test
    //{

    //}

    //public abstract class Product
    //{
    //    public void Create()
    //    {
    //        Console.WriteLine("Product Added");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Product Updated");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("Product Deleted");
    //    }

    //    public List<Product> GetAll()
    //    {
    //        return new List<Product>();
    //    }

    //    public abstract void Test();
    //}

    //class ProductCard : Product
    //{
    //    public void AddProductToCard()
    //    {

    //    }

    //    public void UpdateCard()
    //    {

    //    }

    //    public void DeleteCard()
    //    {

    //    }

    //    public override void Test()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public abstract class Human
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }

    //    public void Talking()
    //    {

    //    }

    //    public abstract void Walking();

    //}

    //public class Teacher : Human
    //{

    //    public double TeacherSalary()
    //    {
    //        return 5.5;
    //    }


    //    public override void Walking()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion
}
