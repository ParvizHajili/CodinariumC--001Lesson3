using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Nezeri


            /*
             - Parametr almayan ve geri deyer dondermeyen
             - Parametr almayan ve geriye deyer donderen
             - Parametr alan ve geriye deyer dondermeyen
             - Parametr alan ve geriye deyer donderen
             */
            //accessmodifiers : public /private

            //int,string,bool
            /*
             accesmodifier returnvalue / void MethodName()
            {
              return;
            }
             
             */

            //SumTwoNumbers(3,8);

            #region Task2 Description
            /*Mən info@codinairum.edu.az mail adresindən mail aldım.*/

            //string text = "Mən info@codinairum.edu.az mail adresindən mail aldım.";

            //Console.WriteLine("Zəhmət olmasa mətni daxil edin:");
            //string text = Console.ReadLine();

            //var emailAdress = GetEmailAdress(text);

            //if(emailAdress is  null)
            //{
            //    Console.WriteLine("Mətndə email adresi tapılmadı");
            //}
            //else
            //{
            //    Console.WriteLine($"Mətndə olan mail adresi {emailAdress}");
            //}


            #endregion

            //var result = Sum(35,20,5);

            //Console.WriteLine(result);
            #endregion

            #region Params
            //SumTwoNumbers(1, 5);
            //SumFourNumbers(3, 4, 6, 7);
            //var result = Sum(2, 4, 5, 10, 30, 34, 56, 21, 32, 14, 54, 67, 65, 4334, 3, 23, 32, 2);
            //Console.WriteLine(result);
            #endregion

            #region Named Arguments
            //Test(name: "Salam", number: 5, isSuccessfully: false);
            #endregion

            #region Overloading
            //statik polimorfizm
            //overloading ve overriding
            //Sum(5,4.5F);

            //Sum(1, 4, 6, 7);

            #endregion
        }
        #region Nezeri


        //public static int Sum(int b, int c, int a = 10)
        //{
        //    return a + b +c;
        //}

        //public static string GetEmailAdress(string text)
        //{
        //    string[] words = text.Split(' ');

        //    foreach (var word in words)
        //    {
        //        if (word.Contains("@"))
        //            return word;
        //    }

        //    return null;
        //}


        //public static int SumTwoNumbers(int a,int b)
        //{
        //    return a + b;
        //}
        //public void ParametrLessAndNonReturnValue()
        //{

        //}

        //public string ParametrLessAndReturnValue()
        //{
        //    return "Codinarium";
        //}

        //public void ParametrsAndNonReturnValue(int a, int b, string c, bool value)
        //{
        //    Console.WriteLine("Bu metod parametr alir ve geri deyer qaytamir");
        //}

        //public bool ParametsAndReturnValue(int a, int b)
        //{
        //    if (a == b)
        //        return true;
        //    else
        //        return false;
        //}

        //public void Test()
        //{
        //    string Test5(int a)
        //    {
        //        return "A";
        //    }
        //}
        #endregion

        #region Params
        //public static int Sum(params int[] ints)
        //{
        //    int sum = 0;

        //    foreach (var item in ints)
        //    {
        //        sum += item;
        //    }

        //    return sum;
        //}

        //public static int SumTwoNumbers(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int SumThreeNumbers(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static int SumFourNumbers(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}
        #endregion

        #region Named Arguments
        //public static void Test(int number, string name, bool isSuccessfully)
        //{
        //    Console.WriteLine($"{number} {name} {isSuccessfully}");
        //}
        #endregion

        #region Overloading
        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public static decimal Sum(decimal a, decimal b)
        //{
        //    return a + b;
        //}

        //public static float Sum(float a, float b)
        //{
        //    return a + b;
        //}

        //public static int Sum(byte a, int b)
        //{
        //    return a + b;
        //}

        //public static int Sum(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

        //public static decimal Sum(int a, int d, byte f, sbyte b, short r)
        //{
        //    return a + d + f + b + r;
        //}
        #endregion
    }
}
