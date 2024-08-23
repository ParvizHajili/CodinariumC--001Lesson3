using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //type safety
            //type [] myArr = new type [10];
            //int[] myFirstArr = new int[3];
            //int[] mySecondArr = { 5, 8, 4};

            //Console.WriteLine(mySecondArr[6]);

            //value type => deep copy  
            //referans type => shallow copy

            //int a = 10;
            //int b = a;
            //a = 15;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] ints = new int[] { 3, 7, 1, 6 };

            //int[] newArr = ints;

            //ints[3] = 98;

            //Console.WriteLine(ints[3]);
            //Console.WriteLine(newArr[3]);

            //string[] myCitiesArr = { "Bakı", "Sumqayıt", "Lənkəran", "Qəbələ" };
            //string[] studentNames = { "Elvin", "Məhəmməd", "Elçin" };

            //for (int i = 0; i < myCitiesArr.Length; i++)
            //{
            //    Console.WriteLine(myCitiesArr[i]);
            //}

            //Console.WriteLine(myCitiesArr[2]);

            //int[] myArr = new int[10];

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]);
            //}
            //Console.WriteLine("test1");
            //string[] myArr2 = new string[10];
            //for (int i = 0; i < myArr2.Length; i++)
            //{
            //    Console.WriteLine(myArr2[i]);
            //}
            //Console.WriteLine("test");
            //int[] myArr = new int[10];

            //myArr[3] = 5;
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]);
            //}

            //int[] myArr = new int[5] { 4, 7, 8, 9, 2 };

            //int a = myArr[3];
            //Console.WriteLine(a);

            //Array myArray = new int[5] { 5, 9, 0, 1, 3 };

            //int b = (int)myArray.GetValue(2);
            //Console.WriteLine(b);

            //int[] myArr = new int[5] { 4, 7, 8, 9, 2 };

            //bool[] myArr2 = new bool[5];

            //foreach (int i in myArr)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Clear(myArr2);
            //Console.WriteLine("After clear method");

            //foreach (var i in myArr2)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] myArr = new int[5] { 4, 7, 8, 9, 2 };

            //Array.Reverse(myArr);

            //foreach (int i in myArr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] myArr = new int[8] { 4, 1, 7, 8, 6, 9, 2, 3 };

            //Array.Sort(myArr);

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]);
            //}

            //int[] myArr = { 4, 1, 7, 8, 6, 9, 2, 3 };
            //int[] myArr2 = new int[myArr.Length];

            //Array.Copy(myArr,myArr2,myArr.Length);

            //foreach(var i in myArr2)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] myArray = new string[8];
            //Array.CreateInstance(typeof(string), 8);


            //bool[] boolArray = new bool[100];
            //Array.CreateInstance(typeof(bool), 100);

            //Index ındex = 5;
            //int[] myArr = { 4, 1, 7, 8, 6, 9, 2, 3 };

            //Console.WriteLine(myArr[ındex]);
            //int[] myArr = { 4, 1, 7, 8, 6, 9, 2, 3 };

            //Range range = 2..4;

            //int[] newArr = myArr[range];

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}

            //int[] myArr = { 4, 1, 7, 8, 6, 9, 2, 3 };

            //Range range = 4..7;

            //int[] newArr = myArr[range];

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}


            //int[] myArr = { 4, 1, 7, 8, 6, 9, 2, 3 };

            ////Range range = 3..^2;
            //Range range = 4..^2;

            //int[] newArr = myArr[range];

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}


        }
    }
}
