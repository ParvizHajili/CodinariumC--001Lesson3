using System.Collections;

namespace OOP.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Genericlərdə value type constraint yazmaq istədiyimiz zaman
             struct keywordündən istifadə edirik. 
             Referans type constraint yaratmaq üçün isə class keywordündən istifadə 
             edirik 
             */
            //constraint => məhdudlaşdırıcılar

            //int[] myIntArr = new int[3];

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("Salam");
            //arrayList.Add(true);

            //List<string> stringList = new List<string>();
            //stringList.Add("Salam");
            //stringList.Add("Codinarium");

            //List<int> intList = new List<int>();
            //intList.Add(10);
            //intList.Add(true);

            //DRY 
            Kia kia = new Kia();
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            int a = 10;
            byte b = 20;
            double d = 30;

            //CarSellOperation carSellOperation = new CarSellOperation();

            //CarSellOperation<Kia> kiaCarselOperation = new CarSellOperation<Kia>();
            //kiaCarselOperation.Add(kia);

            //CarSellOperation<Mercedes> mercedesCarSellOperation = new CarSellOperation<Mercedes>();
            //mercedesCarSellOperation.Add(mercedes);

            //CarSellOperation<Product> carSellOperation = new CarSellOperation<Product>();

            //MyCustomSumClass<int> myCustomSumClass = new MyCustomSumClass<int>();
            //myCustomSumClass.Sum(10, 20, 30);

            //MyCustomSumClass<Kia> myCustomSumClass = new MyCustomSumClass<Kia>();
            //myCustomSumClass.Sum(kia, kia, kia);

            //MyCustomSumClass<int> myCustomSumClass = new();

            CarSellOperation<Bmw> carSellOperation1 = new ();
        }

        public class Product
        {

        }

        public class CarSellOperation<T> where T : class, ICar, new()
        {
            private T[] myCars = new T[100];
            public int count = 0;

            public void Add(T car)
            {
                myCars[count++] = car;
            }
        }

        public interface ICar
        {
            void Drive();
        }

        public class Bmw : ICar
        {
            //public Bmw(int a)
            //{
                
            //}
            public void Drive()
            {
                throw new NotImplementedException();
            }
        }

        public class Mercedes : ICar
        {
            public void Drive()
            {
                throw new NotImplementedException();
            }
        }

        public class Kia : ICar
        {
            public void Drive()
            {
                throw new NotImplementedException();
            }
        }


        public class MyCustomSumClass<T> where T : struct
        {
            public void Sum<T>(T a, T b, T c)
            {
                Console.WriteLine("Sum");
            }
        }
    }
}
