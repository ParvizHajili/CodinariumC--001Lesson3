namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref and Out


            //ref & out
            //int a = 10;
            //int b = a;

            //a = 40;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] arr = { 2, 5, 7, 8, 9, 10, 11 };
            //int[] arr2 = arr;

            //arr[3] = 19;

            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr2[3]);


            //int a = 40;

            //ref int b = ref a;

            //a = 50;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a = 50;

            //Test(ref a);
            //Console.WriteLine(a);
            //int res;
            //TestOutMethod(5, 6,out res);

            //Console.WriteLine(res);

            //Console.WriteLine("Bir ədəd daxil edin");
            //int num = int.Parse(Console.ReadLine());

            //CheckMethod(num, out string message);

            //Console.WriteLine(message);

            #endregion

            #region Math
            //var result = Math.Sqrt(16);
            //var result = Math.Pow(3, 3);
            //var result = Math.Abs(-8.4);
            //var result = Math.Ceiling(5.8);
            //var result = Math.Floor(5.4);
            //var result = Math.Round(5.8);
            //var result = Math.PI;
            //Console.WriteLine(result);
            #endregion

            #region Datetime
            //var result = DateTime.Now;
            //var result2 = DateTime.UtcNow;


            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            //var result = DateTime.Now.Year;

            //Console.WriteLine(result);

            //var result = DateTime.UtcNow.ToString("dd ddd MMMM yyy");
            //Console.WriteLine(result);

            //var data = DateTime.Now - DateTime.Now;
            #endregion




        }

        //public static void Test(ref int a)
        //{
        //    a = 180;
        //}

        //public static void TestOutMethod(int x, int y, out int result)
        //{
        //    result = x + y;
        //}

        //public static void CheckMethod(int x, out string message)
        //{
        //    if (x == 5)
        //        message = "Cavab Doğrudur!";
        //    else
        //        message = "Cavab Yanlışdır!";
        //}
    }
}
