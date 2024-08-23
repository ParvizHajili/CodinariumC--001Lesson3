namespace OOP.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student student = new()
            //{
            //    Name="Xalid",
            //    Surname ="Sədizadə",
            //    Gpa =50
            //};

            //MyCustomValidation.StudentAdd(student);



            ////clientSide
            ////serverSide

            ////Delegate
            ////Handler

            //MyTestDelegate myTestDelegate = new MyTestDelegate(ConsoleHelloWorld);

            ////myTestDelegate.Invoke();
            ////myTestDelegate();

            //myTestDelegate += () =>
            //{
            //    MyTestMethod();
            //    MyTestMethod2();
            //};

            ////myTestDelegate += () =>
            ////{
            ////    Console.WriteLine("Codinarium");
            ////};

            ////myTestDelegate += MyTestMethod3;

            ////myTestDelegate.Invoke();

            ////myTestDelegate -= MyTestMethod3;

            ////Console.WriteLine("==================");
            ////myTestDelegate.Invoke();


            //var word = CustomToUpper("Codinarium",myTestDelegate);

            //Console.WriteLine(word);
        }

        public delegate void MyTestDelegate();

        public static void ConsoleHelloWorld()
        {
            Console.WriteLine("Hello world From delegate");
        }

        public static void MyTestMethod()
        {
            Console.WriteLine("MyTestmethod1");
        }

        public static void MyTestMethod2()
        {
            Console.WriteLine("MyTestMethod2");
        }

        public static void MyTestMethod3()
        {
            Console.WriteLine("MyTestMethod3");
        }

        public static string CustomToUpper(string text, MyTestDelegate myTestDelegate)
        {
            myTestDelegate.Invoke();
            return text.ToUpper();
        }
    }
}
