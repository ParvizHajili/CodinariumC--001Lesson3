using System.Text;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Oprators


            //+
            //int a = 10;
            //int b = 20;

            //var c = a + b;

            //float f1 = 4.5F;
            //float f2 = 5.6F;

            //var f3 = f1+ f2;

            //float a = 10;
            //double b = 20;

            //var res = a + b;

            //byte a = 250;
            //byte b = 250;

            //var result = a + b;

            //int a = 10;
            //int b = 8;

            //int result = a - b;

            //byte a = 10;
            //byte b = 30;

            //var res = a * b;

            //int a = 20;
            //int b = 6;

            //var result = a / b;
            //Console.WriteLine(result);

            //int a = 10;
            //int b = 0;

            //Console.WriteLine(a/b);
            // value++ bu zaman birinci olaraq 
            //dəyəri mənimsədir daha sonra artırır

            // ++value bu zaman birinci olaraq dəyəri
            // artırır daha sonra mənimsədir
            // ++ --

            //int a = 10;
            //Console.WriteLine(a);
            //int b = a++;
            //Console.WriteLine(b);
            //Console.WriteLine(a);
            ////int c = b++;

            //int a = 20;
            //Console.WriteLine(a);
            //int b = ++a;
            //Console.WriteLine(b);
            //int c = a++;
            //Console.WriteLine(c);
            //Console.WriteLine(a);

            //int a = 10;
            //int b = --a;
            //Console.WriteLine(b);
            //int c = a++;
            //Console.WriteLine(c);

            //bool value1 = false;
            //bool value2 = false;

            //Console.WriteLine(value1 != value2);

            //&&, || , ^,!



            //bool value1 = true;
            //bool value2 = true;

            //Console.WriteLine(!(value1 && value2));

            //nullable
            //string message = "Salam";
            //string message = null;


            ////possible null reference
            //int? a = null;

            #endregion

            #region Conditional Statements
            #region If else


            //int value1 = 70;
            //int value2 = 10;

            //if (value2 > value1)
            //{
            //    Console.WriteLine("Value1 Value2-dən böyükdür");
            //}
            //else
            //{
            //    Console.WriteLine("Value1 Value2-dən kiçikdir");
            //}


            //byte month = 6;
            //Console.WriteLine("1-12 aralığında bir ədəd daxil edin");
            //int month = Convert.ToInt32(Console.ReadLine());


            //if (month == 1)
            //{
            //    Console.WriteLine("Yanvar");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Fevral");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Mart");
            //}
            //else if (month == 4)
            //{
            //    Console.WriteLine("Aprel");
            //}
            //else if (month == 5)
            //{
            //    Console.WriteLine("May");
            //}
            //else
            //{
            //    Console.WriteLine("Düzgün rəqəm daxil edin");
            //}

            //int a = 5;

            //if(a == 5)
            //{
            //    Console.WriteLine("5");
            //    Console.WriteLine("Salam");
            //}

            //else
            //    Console.WriteLine("5 deyil");
            #endregion

            #region Switch Case
            //Console.WriteLine("1-12 aralığında bir ədəd daxil edin");

            //int month = Convert.ToInt32(Console.ReadLine());


            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun deyer daxil edin");
            //        break;
            //}


            //string text = Console.ReadLine();
            //bool value = true;
            //switch (text)
            //{
            //    case "Codinarium" when value == true:
            //        Console.WriteLine("Daxil edilen metn Codinariumdur");
            //        break;
            //    case "Technest":
            //    case "Teqaud":
            //        Console.WriteLine("Daxil edilen metn Technestdir");
            //        break;
            //    case "Salam":
            //        Console.WriteLine("Daxil edilen metn Salamdir");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun daxil edin");
            //        break;
            //}
            //C# 8.0
            //discard
            int month = 4;

            var value = month switch
            {
                1 => "Yanvar",
                2 => "Fevral",
                3 => "Mart",
                _ => "Duzgun daxil edin"
            };

            Console.WriteLine(value);
            #endregion


            #endregion



        }
    }
}
