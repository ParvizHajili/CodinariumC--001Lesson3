using System.Text;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1

            // İstifadəçi bir ədəd daxil edəcək 
            // əgər ədəd cütdürsə ekrana yazılacaqki 
            // Ədəd cüt ədəddir. Əks halda cüt ədəd deyil.
            //Console.WriteLine("Ədəd daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Ədəd cütdür");
            //}
            //else
            //{
            //    Console.WriteLine("Ədəd təkdir");
            //}

            #endregion

            #region Task2
            // İstifadəçi bir ədəd daxil edəcək 
            // əgər ədəd 3-ə bölünürsə ekrana yazılacaqki 
            // Ədəd 3-ə bölünür. Əks halda 3-ə bölünmür.

            //int num = int.Parse(Console.ReadLine());

            //if(num %3 == 0)
            //{
            //    Console.WriteLine("Ədəd 3-ə bölünür");
            //}
            //else
            //{
            //    Console.WriteLine("Ədəd 3-ə bölünmür");
            //}
            #endregion

            #region Task3
            // İstifadəçi bir ədəd daxil edəcək 
            // əgər ədəd 3-ə həm də 5-ə bölünürsə ekrana yazılacaqki 
            // Ədəd 3-ə həm də 5-ə bölünür.
            // Əks halda 3-ə həm də 5-ə bölünmür.

            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            #endregion

            #region Task4
            //string text = "Codinarium";
            ///*
            // * İstifadəçi daxil etdiyi mətn Codinarium 
            // * olsa. Ekrana düzgün cavab yazılsın
            // * Əks halda Yanlış cavab
            // */
            //string userInput = Console.ReadLine();
            //if (text == userInput)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            #endregion

            #region Task5
            /*
             İstifadəçidən 3 ədəd alacaqsız.
            Bu 3 ədəd ən azı 1-i 5dirsə.
            Daxil edilmiş ədədlər içində 5 ədədi var.
            Daxil edilmiş ədədlər içində 5 ədədi yoxdur.
             
             */
            //Console.WriteLine("Birinci Ədəd daxil edin");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci Ədəd daxil edin");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Üçüncü  Ədəd daxil edin");
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 == 5 || num2 == 5 || num3 == 5)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            #region Task6
            //Mini kalkulyator
            //Console.WriteLine("1-ci eded daxil edin ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2-ci eded daxil edin ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Operator daxil edin: +,-,/,*");
            //char operand = Convert.ToChar(Console.ReadLine());

            //switch (operand)
            //{
            //    case '+':
            //        Console.WriteLine(num + num2);
            //        break;
            //    case '-':
            //        Console.WriteLine(num - num2);
            //        break;
            //    case '*':
            //        Console.WriteLine(num * num2);
            //        break;
            //    case '/':
            //        {
            //            if (num2 == 0)
            //                Console.WriteLine("0-a bolmek olmaz");
            //            else
            //                Console.WriteLine(num / num2);
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("duzgun operand daxil edin");
            //        break;
            //}
            #endregion


        }
    }
}
