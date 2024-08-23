namespace Lesson3
{
    internal class Program
    {
        readonly int d = 10;
        public Program()
        {
            d = 11;
        }
        static void Main(string[] args)
        {
            #region Const and readonly
            //const int a = 15;
            //a = 20;


            //const float pi = 5;

            //pi = 10;
            //pi = 5;// constla yaradilan dəyişkənin
            //       // dəyərini sonradan dəyişmək olmaz

            //const string message = "Əməliyyat uğurla yerinə yetirildi";

            // readonly ile yaradilan dəyişkənin
            /*
             dəyərini sonradan dəyişmək olar yalnızca 
            classın constructoru daxilində
             */

            #endregion

            #region Object  Boxing and Unboxing
            //object
            //byte age = 25;
            //string name = "Tunar";
            //bool isStudent = false;
            //int salary = 10000;

            //object objAge = 25;
            //object objName = "Tunar";
            //object objIsStudent = false;
            //object objSalary = 100;

            ////boxing
            //int a = 10;
            //int b = 20;
            //int c = a + b;


            //object e = 20;
            //object d = 50;
            //object g = (int)e + (int)d;
            //Console.WriteLine(g);

            //object msg = "Salam";

            //string s = (string)msg;


            //unboxing
            //unboxing əməliyyatını yerinə yetirmək 
            //üçün cast operatorundan istifadə edilir ()
            #endregion

            #region Var and Dynamic keyword
            //var a = 10;
            //var message = "Codinarium";
            //var d = 'F';

            //a = 20;
            //a = 30;
            //a = "Salam";

            //var isMarried = false;

            //isMarried = true;
            //isMarried = "Evli";
            //isMarried = 10;
            //int n = 10;
            //var a = 10; //keyword
            //object a1 = 20;//data tipi
            //var h = 10;

            //var value1 = 20;
            //var value2 = "salam";

            //var result = value1 * value2;

            //dynamic value1 = 20;
            //dynamic value2 = "salam";

            //dynamic result = value1 * value2;

            //Console.WriteLine(result);



            //Console.WriteLine(vb.GetType());
            /*
             var compile time zamani verilmis tipə bürünür
            dynamic runtime zamanı verilmiş tipə bürünür
             */
            #endregion


            #region Type Conversion
            //implicit type conversion
            //explicit type conversion 
            // bilinçli bilinçsiz


            //implicit type conversion
            //byte value = 10;
            //int x = value;

            //Console.WriteLine(x);


            //unchecked
            //{
            //    int value1 =256;
            //    byte a = (byte)value1;
            // Console.WriteLine(a);
            //}

            #endregion

        }
    }
}
